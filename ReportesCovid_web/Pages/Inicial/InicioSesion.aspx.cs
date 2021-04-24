using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                    Correo = tCorreoLogin.Text.Trim(),
                    //Password = Helpers.HelpE.EncryptText(tContraseña.Text.Trim()),
                    Password = tContraseniaLogin.Text.Trim()
                };
                CmUsuarioLogin dtoR = new CtrUsuario().Usp_Usuario_Login(dto);
                if (!dtoR.HuboError)
                {
                    Session["UsuarioLogin"] = dtoR;
                    Response.Redirect("home/default");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", mensajeConfirmacion("Error!", dtoR.ErrorMsj, "error"), true);
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", mensajeConfirmacion("Error!", "Oops, algo salió mal :(", "error"), true);
            }
        }
    }
}