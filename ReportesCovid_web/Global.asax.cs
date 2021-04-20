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
            //routes.MapPageRoute("", "", "~/Pages/Web/Home.aspx", true);

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
}