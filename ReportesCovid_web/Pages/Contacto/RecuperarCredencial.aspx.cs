using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Contacto
{
    public partial class RestaurarCredencial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FirstLoad();
        }

        public void FirstLoad()
        {
            ddlTipoDocContacto.Attributes.Add("OnChange", "return changeTipoDoc('" + ddlTipoDocContacto.ClientID + "','" + hdnTipoDoc.ClientID + "')");
            ddlTipoDocumento.Attributes.Add("OnChange", "return changeTipoDoc('" + ddlTipoDocumento.ClientID + "','" + hdnTipoDoc_Paciente.ClientID + "')");
            CargarTipoDocumento();
        }

        private void CargarTipoDocumento()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_SelectAll(new DtoTablaVarios
                {
                    TipoAtributo = "IN_Tipodoc",
                    EntidadTabla = "Paciente"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> lista = cr.List.Cast<DtoTablaVarios>().ToList();
                    //Paciente
                    ddlTipoDocumento.DataTextField = "Descripcion";
                    ddlTipoDocumento.DataValueField = "Valor";
                    ddlTipoDocumento.DataSource = lista;
                    ddlTipoDocumento.DataBind();
                    //Contacto
                    ddlTipoDocContacto.DataTextField = "Descripcion";
                    ddlTipoDocContacto.DataValueField = "Valor";
                    ddlTipoDocContacto.DataSource = lista;
                    ddlTipoDocContacto.DataBind();

                    //"<asp:ListItem Selected="True" disabled Value="" Text="Choose..."></asp:ListItem>"
                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlTipoDocumento.Items.Insert(0, firstLista);
                    ddlTipoDocContacto.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar TipoDocumento." + "', 'error');", true);
            }
        }

        protected void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                var guid = Guid.NewGuid().ToString().Replace("-", "");
                DtoContacto dto = new DtoContacto
                {
                    IN_Tipodoc = Convert.ToInt32(hdnTipoDoc.Value),
                    Numdoc = txtNumDocContacto.Text.Trim(),
                    Email = txtCorreoContacto.Text.Trim(),
                    NuevaCredencial = guid,
                    Numdoc_Paciente = txtNumdoc.Text.Trim(),
                    IN_Tipodoc_Paciente = Convert.ToInt32(hdnTipoDoc_Paciente.Value),

                };
                ClassResultV cr = new CtrContacto().Usp_Contacto_ForgotCredential(dto);
                if (!cr.HuboError)
                {

                    String HTML = Resource1.htmlCredencial;
                    HTML = HTML.Replace("{titulo}", "Credencial Actualizada");
                    HTML = HTML.Replace("{credencial}", dto.NuevaCredencial);
                    string to = dto.Email;
                    HelpE.SendMail_Gmail(to.Trim(), "Essalud - Crendencial", HTML);

                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Credencial Actualizada", "Se envio un correo con la nueva credencial de acceso", "success", "/IngresarCredencial"), true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error!", cr.ErrorMsj, "error"), true);
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error!", "Oops, algo salió mal :(", "error"), true);
            }
        }
    }
}