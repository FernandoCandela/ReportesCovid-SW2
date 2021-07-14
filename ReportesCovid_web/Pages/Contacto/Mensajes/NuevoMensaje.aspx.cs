using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Contacto.Mensajes
{
    public partial class NuevoMensaje : System.Web.UI.Page
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
            CargarTiposMensajes();
            //CargarMensajes();
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
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoContacto userContacto = (DtoContacto)Session["ContactoSession"];
                DtoPaciente userPaciente = (DtoPaciente)Session["PacienteContacto"];
                DtoMensajes dtoPa = new CtrMensajes().Usp_Mensajes_Insert(new DtoMensajes
                {
                    ContactoId = userContacto.IdContacto,
                    Asunto = txtAsunto.Text.Trim(),
                    Mensaje = txtMensaje.Text.Trim(),
                    IN_TipoMensaje = Convert.ToInt32(ddlTipoMensaje.SelectedValue),
                    OrganizacionId = userPaciente.OrganizacionId

                });
                if (dtoPa.HuboError)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dtoPa.ErrorMsj, "error"), true);
                }
                else
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Mensaje Enviado Correctamente", "Se envio correctamente el mensaje", "success", "/contacto/mensaje/lista"), true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo enviar el mensaje." + "', 'error');", true);
            }


        }
    }
}