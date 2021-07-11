using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages
{
    public partial class RestaurarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FirstLoad();

        }

        public void FirstLoad()
        {
            ddlTipoDocumento.Attributes.Add("OnChange", "return changeTipoDoc('" + ddlTipoDocumento.ClientID + "','" + hdnTipoDoc.ClientID + "')");
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
                    //Usuario
                    ddlTipoDocumento.DataTextField = "Descripcion";
                    ddlTipoDocumento.DataValueField = "Valor";
                    ddlTipoDocumento.DataSource = lista;
                    ddlTipoDocumento.DataBind();

                    //"<asp:ListItem Selected="True" disabled Value="" Text="Choose..."></asp:ListItem>"
                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlTipoDocumento.Items.Insert(0, firstLista);
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

                DtoUsuario dto = new DtoUsuario
                {
                    Usuario = txtUsuario.Text.Trim(),
                    IN_Tipodoc = Convert.ToInt32(hdnTipoDoc.Value),
                    Numdoc = txtNumDoc.Text.Trim(),
                    Email = txtCorreo.Text.Trim(),
                    Contrasena = Membership.GeneratePassword(12, 2),
                };
                ClassResultV cr = new CtrUsuario().Usp_Usuario_ForgotPassword(dto);
                if (!cr.HuboError)
                {

                    String HTML = Resource1.htmlUsuario;
                    HTML = HTML.Replace("{titulo}", "Contraseña Restaurada");
                    HTML = HTML.Replace("{usuario}", dto.Usuario);
                    HTML = HTML.Replace("{clave}", dto.Contrasena);

                    string to = txtCorreo.Text;
                    HelpE.SendMail_Gmail(to, "Essalud - Usuario", HTML);


                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Contraseña Actualizada", "Se envio un correo con sus nuevos datos de acceso", "success", "/logIn"), true);
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