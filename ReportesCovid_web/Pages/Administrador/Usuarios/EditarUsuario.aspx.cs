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

namespace ReportesCovid_web.Pages.Administrador.Usuarios
{
    public partial class EditarUsuario : System.Web.UI.Page
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
            btnGenerarUsuario.Attributes.Add("OnClick", "return GenerarUsuario('" + txtPrimerNombre.ClientID + "','" + txtSegundoNombre.ClientID + "','" + txtApellidoPaterno.ClientID + "','" + txtApellidoMaterno.ClientID + "','" + tUsuario.ClientID + "')");
            CargarTipoDocumento();
            CargarRol();
            CargarCargos();
            LlenarDetalle();
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
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    //Paciente
                    ddlTipoDocumento.DataTextField = "Descripcion";
                    ddlTipoDocumento.DataValueField = "Valor";
                    ddlTipoDocumento.DataSource = list;
                    ddlTipoDocumento.DataBind();
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
        private void CargarRol()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_SelectAll(new DtoTablaVarios
                {
                    TipoAtributo = "IN_Rol",
                    EntidadTabla = "Usuario"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    //Paciente
                    ddlRol.DataTextField = "Descripcion";
                    ddlRol.DataValueField = "Valor";
                    ddlRol.DataSource = list;
                    ddlRol.DataBind();
                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlRol.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar Roles." + "', 'error');", true);
            }
        }
        private void CargarCargos()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_SelectAll(new DtoTablaVarios
                {
                    TipoAtributo = "IN_Cargo",
                    EntidadTabla = "Usuario"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    //Paciente
                    ddlCargo.DataTextField = "Descripcion";
                    ddlCargo.DataValueField = "Valor";
                    ddlCargo.DataSource = list;
                    ddlCargo.DataBind();
                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlCargo.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar Cargos." + "', 'error');", true);
            }
        }
        private void LlenarDetalle()
        {
            try
            {
                DtoUsuario dto = new CtrUsuario().Usp_Usuario_SelectOne(new DtoUsuario
                {
                    IdUsuario = Convert.ToInt32(Request.QueryString["idusuario"])
                });
                if (!dto.HuboError)
                {
                    txtPrimerNombre.Text = dto.PrimerNombre;
                    txtSegundoNombre.Text = dto.SegundoNombre;
                    txtApellidoPaterno.Text = dto.ApellidoPaterno;
                    txtApellidoMaterno.Text = dto.ApellidoMaterno;
                    tUsuario.Text = dto.Usuario;
                    ddlTipoDocumento.SelectedValue = dto.IN_Tipodoc.ToString();
                    txtNumdoc.Text = dto.Numdoc;
                    txtTelefono.Text = dto.Telefono;
                    ddlRol.SelectedValue = dto.IN_Rol.ToString();
                    ddlCargo.SelectedValue = dto.IN_Cargo.ToString();
                    ddlEstado.SelectedValue = dto.IB_Estado == true ? "1" : "0";
                    txtCorreo.Text = dto.Email;
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo cargar el Usuario." + "', 'error');", true);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                ClassResultV cr = new CtrUsuario().Usp_Usuario_Update(new DtoUsuario
                {
                    IdUsuario = Convert.ToInt32(Request.QueryString["idusuario"]),
                    Usuario = tUsuario.Text,
                    Numdoc = txtNumdoc.Text,
                    IN_Tipodoc = Convert.ToInt32(ddlTipoDocumento.SelectedValue),
                    Telefono = txtTelefono.Text,
                    IN_Rol = Convert.ToInt32(ddlRol.SelectedValue),
                    IN_Cargo = Convert.ToInt32(ddlCargo.SelectedValue),
                    UsuarioModificacionId = user.IdUsuario,
                    IB_Estado = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue)),
                    PrimerNombre = txtPrimerNombre.Text,
                    SegundoNombre = txtSegundoNombre.Text,
                    ApellidoPaterno = txtApellidoPaterno.Text,
                    ApellidoMaterno = txtApellidoMaterno.Text,
                    Email = txtCorreo.Text

                });
                if (cr.HuboError)
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", cr.ErrorMsj, "error"), true);
                else
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Usuario Actualizado", "Se actualizo correctamente el usuario", "success", "/administrador/usuario/lista"), true);
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo Actualizar el Usuario." + "', 'error');", true);
            }
        }

        protected void btnNuevaContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                var newpassword = Membership.GeneratePassword(12, 2);
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                ClassResultV cr = new CtrUsuario().Usp_Usuario_ResetPassword_Admin(new DtoUsuario
                {
                    IdUsuario = Convert.ToInt32(Request.QueryString["idusuario"]),
                    Contrasena = newpassword,
                    UsuarioModificacionId = user.IdUsuario


                });
                if (cr.HuboError)
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", cr.ErrorMsj, "error"), true);
                else
                {
                    String HTML = Resource1.htmlUsuario;
                    HTML = HTML.Replace("{titulo}", "Contraseña Actualizada");
                    HTML = HTML.Replace("{usuario}", tUsuario.Text);
                    HTML = HTML.Replace("{clave}", newpassword);

                    string to = txtCorreo.Text;
                    HelpE.SendMail_Gmail(to, "Essalud - Usuario", HTML);

                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Contraseña Actualizada", "Se actualizo correctamente la contraseña", "success", "/administrador/usuario/lista"), true);
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo Actualizar la Contraseña ." + "', 'error');", true);
            }
        }
    }
}