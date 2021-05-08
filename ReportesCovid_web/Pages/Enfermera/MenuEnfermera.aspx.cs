using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using System.Web.Security;

namespace ReportesCovid_web.Pages.Enfermera
{
    public partial class MenuEnfermera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                if (user.IN_Rol == 2)
                {
                    FirstLoad();
                }
                else
                {
                    Session.Remove("UsuarioLogin");
                    Response.Redirect("logIn");
                }
            }
        }

        public void FirstLoad()
        {

        }
    }
}