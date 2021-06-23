using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Medico
{
    public partial class ListaReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                if (user != null && user.IN_Rol == 3)
                {
                    FirstLoad();
                }
                else
                {
                    Response.Redirect("/logOut");
                }
            }
        }
        public void FirstLoad()
        {
            CargarReportes();
        }
        private void CargarReportes()
        {
            try
            {
                List<DtoPacienteHistorial> listaReporte = new List<DtoPacienteHistorial>();
                DateTime fistdate = new DateTime();
                DateTime lastdate = new DateTime();
                for (int i = 0; i < calendario.SelectedDates.Count; i++)
                {
                    if (i == 0)
                    {
                        fistdate = calendario.SelectedDates[i];
                    }
                    else if (i == calendario.SelectedDates.Count - 1)
                    {
                        lastdate = calendario.SelectedDates[i];
                    }
                }
                if (fistdate == lastdate)
                {
                    lastdate = Convert.ToDateTime("01/01/0001");
                }

                ClassResultV cr = new CtrPacienteHistoria().Usp_PacienteHistorial_SelectAll_Usuario(new DtoPacienteHistorial
                {
                    PacienteId = Convert.ToInt32(Request.QueryString["idPaciente"]),
                    FechaInicio = fistdate,
                    FechaFin = lastdate
                });
                if (!cr.HuboError)
                {
                    listaReporte.AddRange(cr.List.Cast<DtoPacienteHistorial>());
                    gvReportes.DataSource = listaReporte;
                }
                gvReportes.DataBind();
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los Reportes." + "', 'error');", true);
            }
        }

        protected void gvReportes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string idHistoria = (gvReportes.Rows[rowIndex].Cells[0].FindControl("lblIdHistoria") as Label).Text;
            switch (e.CommandName)
            {
                case "VerReporte":
                    Response.Redirect("/medico/reporte/verreporte?idHistoria=" + idHistoria);
                    break;
            }
        }

        protected void gvReportes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.PageIndex = e.NewPageIndex;
            CargarReportes();
        }
        protected void calendario_SelectionChanged(object sender, EventArgs e)
        {
            CargarReportes();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            calendario.SelectedDates.Clear();
            CargarReportes();
        }
        protected void gvReportes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    var dto = (DtoPacienteHistorial)e.Row.DataItem;
                    string msj = "<span class='badge " + (dto.IB_Traslado == true ? "bg-danger" : "bg-success") + "'>" + (dto.IB_Traslado == true ? "SI" : "NO") + "</span>";
                    (e.Row.Cells[3].FindControl("ltlTraslado") as Literal).Text = msj;
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}