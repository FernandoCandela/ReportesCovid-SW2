using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.MasterPages
{
    public partial class Usuario : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack)
                {
                    if (Session["UsuarioLogin"] != null)
                    {
                    FirsLoad();

                    }
                    else
                    {
                        Response.Redirect("logIn");
                    }
                }
        }


        public void FirsLoad()
        {
            DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];

            switch (user.IN_Rol)
            {
                case 1:
                    menu5.Text = "Menu Administrador";
                    menu5.NavigateUrl = "/MenuAdmin";

                    menu6.Text = "Registrar Usuario";
                    menu6.NavigateUrl = "/CrearUsuario";

                    menu7.Text = "Lista de usuarios";
                    menu7.NavigateUrl = "/TablaUsuario";

                    menu8.Text = "Lista de mensajes";
                    menu8.NavigateUrl = "/TablaMensaje";
                    break;
                case 2:
                    menu1.Text = "Menu Enfermera";
                    menu1.NavigateUrl = "/MenuEnfermera";

                    menu2.Text = "Registrar Paciente";
                    menu2.NavigateUrl = "/RegistrarPaciente";

                    menu3.Text = "Lista Paciente";
                    menu3.NavigateUrl = "/TablaModificarPaciente";
                    break;
                case 3:
                    menu4.Text = "Lista de Pacientes";
                    menu4.NavigateUrl = "/BuscarPaciente";
                    break;
            }


        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["UsuarioLogin"] = null;
            Response.Redirect("logIn");
        }
    }
}