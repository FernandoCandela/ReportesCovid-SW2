using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Web.UI;


namespace ReportesCovid_web.Pages.Inicial
{
    public partial class InicioSesion : System.Web.UI.Page
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
        public void LoguearUsuario(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario dto = new DtoUsuario
                {
                    Usuario = username.Text.Trim(),
                    Contrasena = password.Text.Trim()
                };
                DtoUsuario dtoR = new CtrUsuario().Usp_Usuario_Login(dto);
                if (!dtoR.HuboError)
                {
                    Session["UsuarioLogin"] = dtoR;
                    switch (dtoR.IN_Rol)
                    {
                        case 1:
                            Response.Redirect("MenuAdmin");
                            break;
                        case 2:
                            Response.Redirect("MenuEnfermera");
                            break;
                        case 3:
                            Response.Redirect("BuscarPaciente");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop",HelpE.mensajeConfirmacion("Error!", dtoR.ErrorMsj, "error"), true);
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error!", "Oops, algo salió mal :(", "error"), true);
            }
        }
    }
}