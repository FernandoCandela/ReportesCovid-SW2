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

            //Enfermera
            routes.MapPageRoute("MenuEnfermera", "MenuEnfermera", "~/Pages/Enfermera/Menuenfermera.aspx", true);
            routes.MapPageRoute("ModificarPaciente", "ModificarPaciente", "~/Pages/Enfermera/Modificarpaciente.aspx", true);
            routes.MapPageRoute("RegistrarPaciente", "RegistrarPaciente", "~/Pages/Enfermera/Registrarpaciente.aspx", true);
            routes.MapPageRoute("TablaModificarPaciente", "TablaModificarPaciente", "~/Pages/Enfermera/TablaModificarpaciente.aspx", true);

            //Administrador
            routes.MapPageRoute("CrearUsuario", "CrearUsuario", "~/Pages/Administrador/Crearusuario.aspx", true);
            routes.MapPageRoute("MenuAdmin", "MenuAdmin", "~/Pages/Administrador/Menuadmin.aspx", true);
            routes.MapPageRoute("ModificarUsuario", "ModificarUsuario", "~/Pages/Administrador/Modificarusuario.aspx", true);
            routes.MapPageRoute("ResponderMensaje", "ResponderMensaje", "~/Pages/Administrador/Respondermensaje.aspx", true);
            routes.MapPageRoute("TablaMensaje", "TablaMensaje", "~/Pages/Administrador/Tablamensaje.aspx", true);
            routes.MapPageRoute("TablaUsuario", "TablaUsuario", "~/Pages/Administrador/Tablausuario.aspx", true);

            //Contacto
            routes.MapPageRoute("EnviarMensaje", "EnviarMensaje", "~/Pages/Contacto/Enviarmensaje.aspx", true);
            
            routes.MapPageRoute("RecuperarCredencial", "RecuperarCredencial", "~/Pages/Contacto/Recuperarcredencial.aspx", true);
            routes.MapPageRoute("VisualizarCredencial", "VisualizarCredencial", "~/Pages/Contacto/Visualizarcredencial.aspx", true);

            //Medico
            routes.MapPageRoute("BuscarPaciente", "BuscarPaciente", "~/Pages/Medico/BuscarPaciente.aspx", true);
            routes.MapPageRoute("GenerarReporte", "GenerarReporte", "~/Pages/Medico/GenerarReporte.aspx", true);

            //Ejemplos
            //routes.MapPageRoute("Activacion", "Activacion", "~/Pages/Web/Activacion.aspx", true);


            //routes.MapPageRoute("login", "login", "~/Pages/Web/Login.aspx", true);
            //routes.MapPageRoute("registrate", "registrate", "~/Pages/Web/Registrate.aspx", true);

            //routes.MapPageRoute("principal", "principal", "~/Pages/Cuentas/Principal.aspx", true);
            //routes.MapPageRoute("micuenta/perfil", "micuenta/perfil", "~/Pages/Cuentas/Perfil.aspx", true);
            //routes.MapPageRoute("micuenta/direccion", "micuenta/direccion", "~/Pages/Cuentas/Direccion.aspx", true);
            //routes.MapPageRoute("micuenta/seguridad", "micuenta/seguridad", "~/Pages/Cuentas/Seguridad.aspx", true);
            //routes.MapPageRoute("micuenta/direcciones", "micuenta/direcciones", "~/Pages/Cuentas/DireccionesGeneral.aspx", true);

            #endregion

        }
        #endregion

    }

}