using DTO;
using System;
using System.Text;

namespace ReportesCovid_web.MasterPages
{
    public partial class Web_Usuarios : System.Web.UI.MasterPage
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
                    Response.Redirect("/logOut");
                }
            }
        }
        public void FirsLoad()
        {
            DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];

            lbUserName.Text = user.PrimerNombre + " " + user.ApellidoPaterno;
            lbUserRole.Text = user.NombreRol;

        StringBuilder content = new StringBuilder();
            switch (user.IN_Rol)
            {
                case 1:
                    //Administrador
                    hplMenu.NavigateUrl = "/administrador/menu";

                    content.Append(@"<li class='navigation-header text-truncate'><span data-i18n='Maestros'>Maestros</span></li>");
                    content.Append("<li class='nav-item'><a href='/administrador/usuario/lista'><i class='menu-livicon' data-icon='users'></i><span class='menu-title text-truncate' data-i18n='Usuarios'>Usuarios</span></a>");
                    content.Append("<ul class='menu-content'>");
                    content.Append("<li><a class='d-flex align-items-center' href='/administrador/usuario/lista'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Lista'>Lista</span></a></li>");
                    content.Append("<li><a class='d-flex align-items-center' href='/administrador/usuario/nuevo'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Nuevo'>Nuevo</span></a></li>");
                    content.Append("</ul>");
                    content.Append("</li>");

                    content.Append("<li class='nav-item'><a href='/administrador/mensaje/lista'><i class='menu-livicon' data-icon='envelope-put'></i><span class='menu-title text-truncate' data-i18n='Mensajes'>Mensajes</span></a>");
                    content.Append("<ul class='menu-content'>");
                    content.Append("<li><a class='d-flex align-items-center' href='/administrador/mensaje/lista'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Lista'>Lista</span></a></li>");
                    content.Append("<li><a class='d-flex align-items-center' href='/administrador/mensaje/nuevo'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Nuevo'>Nuevo</span></a></li>");
                    content.Append("</ul>");
                    content.Append("</li>");

                    content.Append("<li class='nav-item'><a href='/administrador/varios/lista'><i class='menu-livicon' data-icon='gears'></i><span class='menu-title text-truncate' data-i18n='Varios'>Varios</span></a>");
                    content.Append("<ul class='menu-content'>");
                    content.Append("<li><a class='d-flex align-items-center' href='/administrador/varios/lista'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Lista'>Lista</span></a></li>");
                    content.Append("<li><a class='d-flex align-items-center' href='/administrador/varios/nuevo'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Nuevo'>Nuevo</span></a></li>");
                    content.Append("</ul>");
                    content.Append("</li>");

                    ListaMenu.Text = content.ToString();

                    break;
                case 2:
                    //Enfermera
                    hplMenu.NavigateUrl = "/enfermera/menu";
                    content.Append(@"<li class='navigation-header text-truncate'><span data-i18n='Gestionar'>Gestionar</span></li>");
                    content.Append("<li class='nav-item'><a href='/enfermera/paciente/lista'><i class='menu-livicon' data-icon='users'></i><span class='menu-title text-truncate' data-i18n='Pacientes'>Pacientes</span></a>");
                    content.Append("<ul class='menu-content'>");
                    content.Append("<li><a class='d-flex align-items-center' href='/enfermera/paciente/lista'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Lista'>Lista</span></a></li>");
                    content.Append("<li><a class='d-flex align-items-center' href='/enfermera/paciente/nuevo'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Nuevo'>Nuevo</span></a></li>");
                    content.Append("</ul>");
                    content.Append("</li>");
                    ListaMenu.Text = content.ToString();
                    break;
                case 3:
                    hplMenu.NavigateUrl = "/medico/menu";
                    content.Append(@"<li class='navigation-header text-truncate'><span data-i18n='Gestionar'>Gestionar</span></li>");
                    content.Append("<li class='nav-item'><a href='/medico/paciente/lista'><i class='menu-livicon' data-icon='users'></i><span class='menu-title text-truncate' data-i18n='Pacientes'>Pacientes</span></a>");
                    content.Append("<ul class='menu-content'>");
                    content.Append("<li><a class='d-flex align-items-center' href='/medico/paciente/lista'><i class='bx bx-right-arrow-alt'></i><span class='menu-item text-truncate' data-i18n='Lista'>Lista</span></a></li>");
                    content.Append("</ul>");
                    content.Append("</li>");
                    ListaMenu.Text = content.ToString();
                    break;
            }


        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("logOut");
        }
    }
}