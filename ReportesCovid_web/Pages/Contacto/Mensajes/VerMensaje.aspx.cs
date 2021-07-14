using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Contacto.Mensajes
{
    public partial class VerMensaje : System.Web.UI.Page
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
                    IdMensaje = Convert.ToInt32(Session["idMensaje"])
                });
                if (!dto.HuboError)
                {
                    txtAsunto.Text = dto.Asunto;
                    ddlTipoMensaje.SelectedValue = dto.IN_TipoMensaje.ToString();
                    txtMensaje.Text = dto.Mensaje;
                    
                    if (dto.IB_Respondido)
                    {
                        tabRespuesta.Attributes.Remove("style");
                        txtRespuesta.Text = dto.Respuesta;
                    }
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo cargar el mensaje." + "', 'error');", true);
            }
        }
    }
}