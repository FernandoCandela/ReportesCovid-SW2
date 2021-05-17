using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Web.UI;


namespace ReportesCovid_web.Pages.Contacto
{
    public partial class IngresarCredencial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FirstLoad();
            }
        }
        public void FirstLoad()
        {
            // Validaciones para el usuario
        }
        public void LoguearContacto(object sender, EventArgs e)
        {
            try
            {
                DtoPaciente dto = new DtoPaciente
                {
                    Credencial = txtCredencial.Text.Trim()
                };
                DtoPaciente dtoP = new CtrContacto().Usp_Contacto_Login(dto);
                if (!dtoP.HuboError)
                {
                    Session["PacienteContacto"] = dtoP;

                    Response.Redirect("VisualizarCredencial");

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error!", dtoP.ErrorMsj, "error"), true);
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error!", "Oops, algo salió mal :(", "error"), true);
            }
        }
    }

}