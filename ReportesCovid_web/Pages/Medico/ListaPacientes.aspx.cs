using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Medico
{
    public partial class ListaPacientes : System.Web.UI.Page
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
            CargarEstadosPaciente();
            CargarPacientes();
        }

        private void CargarEstadosPaciente()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios
                {
                    TipoAtributo = "IN_EstadoPaciente",
                    EntidadTabla = "Paciente"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    ddlEstadoPaciente.DataTextField = "Descripcion";
                    ddlEstadoPaciente.DataValueField = "Valor";
                    ddlEstadoPaciente.DataSource = list;
                    ddlEstadoPaciente.DataBind();
                    ddlEstadoPaciente.Items.Insert(0, new ListItem("Todos", "0"));
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar Estados del Paciente." + "', 'error');", true);
            }
        }

        private void CargarPacientes()
        {
            try
            {
                List<DtoPaciente> ListPacientes = new List<DtoPaciente>();
                ClassResultV cr = new CtrPaciente().Usp_Paciente_Select(new DtoPaciente
                {
                    IB_Estado = true,
                    IN_EstadoPaciente = Convert.ToInt32(ddlEstadoPaciente.SelectedValue),
                    Criterio = txtBuscar.Text.Trim()
                }
                );
                if (!cr.HuboError)
                {
                    ListPacientes.AddRange(cr.List.Cast<DtoPaciente>());
                    gvPacientes.DataSource = ListPacientes;
                }
                gvPacientes.DataBind();
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los Pacientes." + "', 'error');", true);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        protected void gvPacientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string idPaciente = (gvPacientes.Rows[rowIndex].Cells[0].FindControl("lblIdPaciente") as Label).Text;
            switch (e.CommandName)
            {
                case "Generar":
                    Response.Redirect("/medico/paciente/GenerarReporte?idPaciente=" + idPaciente);
                    break;
                case "VerReportes":
                    Response.Redirect("/medico/reporte/lista?idPaciente=" + idPaciente);
                    break;
            }
        }

        protected void gvPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.PageIndex = e.NewPageIndex;
            CargarPacientes();
        }
    }
}