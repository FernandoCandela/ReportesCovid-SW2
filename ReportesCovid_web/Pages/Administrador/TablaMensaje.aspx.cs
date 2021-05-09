using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Administrador
{
    public partial class TablaMensaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                if (user != null && user.IN_Rol == 1)
                {
                    FirstLoad();
                }
                else
                {
                    Session.RemoveAll();
                    Response.Redirect("logIn");
                }
            }
        }

        public void FirstLoad()
        {
            CargarMensajes();
        }


        private void CargarMensajes()
        {
            try
            {
                List<DtoPaciente> ListPacientes = new List<DtoPaciente>();
                ClassResultV cr = new CtrPaciente().Usp_Paciente_Select(new DtoPaciente
                {
                    IB_Estado = true,
                    IN_EstadoPaciente = 1,
                    Criterio = txtBuscar.Text.Trim()
                }
                );
                //lblResultados.Text = "Resultados encontrados: " + cr.List.Count;
                if (!cr.HuboError)
                {
                    ListPacientes.AddRange(cr.List.Cast<DtoPaciente>());
                    gvMensaje.DataSource = ListPacientes;
                }
                gvMensaje.DataBind();
            }
            catch (Exception ex)
            {

                //ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "script", "fail('" + ex.Message + "');", true);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarMensajes();
        }

        protected void gvPacientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            switch (e.CommandName)
            {
                case "Responder":
                    rowIndex = int.Parse(e.CommandArgument.ToString());
                    string idPaciente = (gvMensaje.Rows[rowIndex].Cells[0].FindControl("lblIdPaciente") as Label).Text;
                    Response.Redirect("/ResponderMensaje?idPaciente=" + idPaciente);
                    break;
            }
        }
    }
}