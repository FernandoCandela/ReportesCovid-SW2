using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Contacto
{
    public partial class ListaMensajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FirstLoad()
        {
            CargarMensajes();
        }

        private void CargarMensajes()
        {
            try
            {
                List<DtoMensajes> ListaMensajes = new List<DtoMensajes>();

                ClassResultV cr = new CtrMensajes().Usp_Mensajes_SelectAll(new DtoMensajes
                {
                    IB_Respondido = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue)),
                    Criterio = txtBuscar.Text.Trim(),
                });
                if (!cr.HuboError)
                {
                    ListaMensajes.AddRange(cr.List.Cast<DtoMensajes>());
                    gvMensajes.DataSource = ListaMensajes;
                }
                gvMensajes.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los mensajes." + "', 'error');", true);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarMensajes();
        }

        protected void gvMensajes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.PageIndex = e.NewPageIndex;
            CargarMensajes();
        }

        protected void gvMensajes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    var dto = (DtoMensajes)e.Row.DataItem;
                    string msj = "<span class='badge " + (dto.IB_Respondido == true ? "bg-success" : "bg-warning") + "'>" + (dto.IB_Respondido == true ? "Respondido" : "No Respondido") + "</span>";
                    (e.Row.Cells[5].FindControl("ltlEstados") as Literal).Text = msj;
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}