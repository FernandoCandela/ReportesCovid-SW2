using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ReportesCovid_web
{
    public class Global : System.Web.HttpApplication
    {

        #region Eventos
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }
        protected void Application_Error(object sender, EventArgs e)
        {

        }
        protected void Session_End(object sender, EventArgs e)
        {

        }
        protected void Application_End(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos
        public static void RegisterRoutes(RouteCollection routes)
        {
            #region Web Routes
            //rout para la pagina inical
            routes.MapPageRoute("", "", "~/Pages/Inicial/Paginainicial.aspx", true);
            routes.MapPageRoute("logIn", "logIn", "~/Pages/Inicial/Iniciosesion.aspx", true);
            routes.MapPageRoute("logOut", "logOut", "~/Pages/Inicial/CerrarSesion.aspx", true);
            routes.MapPageRoute("logOutContacto", "logOutContacto", "~/Pages/Inicial/CerrarSesionContacto.aspx", true);
            routes.MapPageRoute("IngresarCredencial", "IngresarCredencial", "~/Pages/Inicial/Ingresarcredencial.aspx", true);

            //recuperar
            routes.MapPageRoute("RecuperarCredencial", "RecuperarCredencial", "~/Pages/contacto/Recuperarcredencial.aspx", true);
            routes.MapPageRoute("RecuperarContraseña", "RecuperarContraseña", "~/Pages/RecuperarContraseña.aspx", true);

            //Enfermera
            routes.MapPageRoute("enfermera/menu", "enfermera/menu", "~/Pages/Enfermera/MenuenfermeraV2.aspx", true);
            routes.MapPageRoute("enfermera/paciente/editar", "enfermera/paciente/editar", "~/Pages/Enfermera/ModificarpacienteV2.aspx", true);
            routes.MapPageRoute("enfermera/paciente/nuevo", "enfermera/paciente/nuevo", "~/Pages/Enfermera/RegistrarpacienteV2.aspx", true);
            routes.MapPageRoute("enfermera/paciente/lista", "enfermera/paciente/lista", "~/Pages/Enfermera/ListaPacientes.aspx", true);

            //Administrador
            routes.MapPageRoute("administrador/menu", "administrador/menu", "~/Pages/Administrador/MenuAdmin.aspx", true);

            routes.MapPageRoute("administrador/usuario/lista", "administrador/usuario/lista", "~/Pages/Administrador/Usuarios/ListaUsuarios.aspx", true);
            routes.MapPageRoute("administrador/usuario/nuevo", "administrador/usuario/nuevo", "~/Pages/Administrador/Usuarios/NuevoUsuario.aspx", true);
            routes.MapPageRoute("administrador/usuario/editar", "administrador/usuario/editar", "~/Pages/Administrador/Usuarios/EditarUsuario.aspx", true);

            routes.MapPageRoute("administrador/mensaje/respondermensaje", "administrador/mensaje/respondermensaje", "~/Pages/Administrador/Mensajes/ResponderMensaje.aspx", true);
            routes.MapPageRoute("administrador/mensaje/lista", "administrador/mensaje/lista", "~/Pages/Administrador/Mensajes/ListaMensajes.aspx", true);

            routes.MapPageRoute("administrador/varios/lista", "administrador/varios/lista", "~/Pages/Administrador/Varios/ListaVarios.aspx", true);
            routes.MapPageRoute("administrador/varios/nuevo", "administrador/varios/nuevo", "~/Pages/Administrador/Varios/NuevoVarios.aspx", true);
            routes.MapPageRoute("administrador/varios/editar", "administrador/varios/editar", "~/Pages/Administrador/Varios/EditarVarios.aspx", true);

            //Contacto
            //routes.MapPageRoute("EnviarMensaje", "EnviarMensaje", "~/Pages/Contacto/Enviarmensaje.aspx", true);

            //routes.MapPageRoute("RecuperarCredencial", "RecuperarCredencial", "~/Pages/Contacto/Recuperarcredencial.aspx", true);
            //routes.MapPageRoute("VisualizarCredencial", "VisualizarCredencial", "~/Pages/Contacto/Visualizarcredencial.aspx", true);

            routes.MapPageRoute("contacto/menu", "contacto/menu", "~/Pages/Contacto/MenuContacto.aspx", true);

            routes.MapPageRoute("contacto/reporte/lista", "contacto/reporte/lista", "~/Pages/Contacto/Reportes/ListaReportes.aspx", true);
            routes.MapPageRoute("contacto/reporte/verreporte", "contacto/reporte/verreporte", "~/Pages/Contacto/Reportes/VerReporte.aspx", true);

            routes.MapPageRoute("contacto/mensaje/lista", "contacto/mensaje/lista", "~/Pages/Contacto/Mensajes/ListaMensajes.aspx", true);

            //Medico

            routes.MapPageRoute("medico/menu", "medico/menu", "~/Pages/Medico/MenuMedico.aspx", true);
            routes.MapPageRoute("medico/paciente/lista", "medico/paciente/lista", "~/Pages/Medico/ListaPacientes.aspx", true);
            routes.MapPageRoute("medico/paciente/GenerarReporte", "medico/paciente/GenerarReporte", "~/Pages/Medico/GenerarReporte.aspx", true);

            routes.MapPageRoute("medico/reporte/lista", "medico/reporte/lista", "~/Pages/Medico/ListaReportes.aspx", true);
            routes.MapPageRoute("medico/reporte/verreporte", "medico/reporte/verreporte", "~/Pages/Medico/VerReporte.aspx", true);
            routes.MapPageRoute("medico/reporte/editar", "medico/reporte/editar", "~/Pages/Medico/EditarReporte.aspx", true);
            #endregion

        }
        #endregion

    }

}