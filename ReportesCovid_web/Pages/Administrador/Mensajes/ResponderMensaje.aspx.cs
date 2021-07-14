using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Administrador.Mensajes
{
    public partial class ResponderMensaje : System.Web.UI.Page
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
                    Response.Redirect("/logOut");
                }
            }
        }

        public void FirstLoad()
        {
            LlenarDetalle();
        }

        private void LlenarDetalle()
        {
            //try
            //{
            //    DtoMensajes dto = new CtrMensajes().Usp_Mensajes_SelectOne(new DtoMensajes
            //    {
            //        IdMensaje = Convert.ToInt32(Request.QueryString["IdMensaje"])
            //    });
            //    if (!dto.HuboError)
            //    {
            //        nombre.Text = dto.NombreCompleto;
            //        correo.Text = dto.Email;
            //        asunto.Text = dto.Asunto;
            //        mensaje.Text = dto.Mensaje;
            //    }
            //}
            //catch (Exception)
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo cargar los datos." + "', 'error');", true);
            //}
        }

        /*
         * NO SE SI SE RELLENARAN LOS TEXTBOX, NO PUEDO PROBARLOS, NO TENGO CONEXION A LA BD
         * 
         * FALTA AÑADIR FUNCIONALIDAD AL BOTÓN DE ENVIAR
         */
    }
}