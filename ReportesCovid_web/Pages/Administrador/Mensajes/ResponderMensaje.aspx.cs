using CTR;
using DTO;
using ReportesCovid_web.Helpers;
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
            CargarTiposMensajes();
            CargarDealles();
        }
        private void CargarTiposMensajes()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_SelectAll(new DtoTablaVarios
                {
                    TipoAtributo = "IN_TipoMensaje",
                    EntidadTabla = "Mensajes"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    ddlTipoMensaje.DataTextField = "Descripcion";
                    ddlTipoMensaje.DataValueField = "Valor";
                    ddlTipoMensaje.DataSource = list;
                    ddlTipoMensaje.DataBind();
                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlTipoMensaje.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los tipos de mensajes." + "', 'error');", true);
            }
        }
        private void CargarDealles()
        {
            try
            {
                DtoMensajes dto = new CtrMensajes().Usp_Mensajes_SelectOne(new DtoMensajes
                {
                    IdMensaje = Convert.ToInt32(Request.QueryString["idMensaje"])
                });
                if (!dto.HuboError)
                {
                    txtAsunto.Text = dto.Asunto;
                    ddlTipoMensaje.SelectedValue = dto.IN_TipoMensaje.ToString();
                    txtMensaje.Text = dto.Mensaje;

                    if (dto.IB_Respondido)
                    {
                        btnEnviarRespuesta.Attributes.Add("style", "display:none");
                        txtRespuesta.ReadOnly = true;
                        txtRespuesta.Text = dto.Respuesta;
                    }
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo cargar el mensaje." + "', 'error');", true);
            }
        }

        protected void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                ClassResultV dtoPa = new CtrMensajes().Usp_Mensajes_Update_Respuesta(new DtoMensajes
                {
                    IdMensaje = Convert.ToInt32(Request.QueryString["idMensaje"]),
                    Respuesta = txtRespuesta.Text.Trim(),
                    UsuarioCreacionId = user.IdUsuario,


                });
                if (dtoPa.HuboError)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dtoPa.ErrorMsj, "error"), true);
                }
                else
                {

                    //String HTML = Resource1.htmlUsuario;
                    //HTML = HTML.Replace("{titulo}", "¡Bienvenido!");
                    //HTML = HTML.Replace("{usuario}", dtoPa.Usuario);
                    //HTML = HTML.Replace("{clave}", dtoPa.Contrasena);

                    //string to = dtoPa.Email;
                    //HelpE.SendMail_Gmail(to, "Essalud - Usuario", HTML);

                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Respuesta Enviada", "Se envio la respuesta correctamente", "success", "/administrador/mensaje/lista"), true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo enviar la respuesta." + "', 'error');", true);
            }



        }
    }
}