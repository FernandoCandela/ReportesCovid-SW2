using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Administrador.Usuarios
{
    public partial class NuevoUsuario : System.Web.UI.Page
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
            CargarTipoDocumento();
            CargarRol();
            CargarCargos();
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

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];

                DtoUsuario dtoPa = new CtrUsuario().Usp_Usuario_Insert(new DtoUsuario
                {
                    Usuario = tUsuario.Text.Trim(),
                    Contrasena = tContrasena.Text.Trim(),
                    IN_Tipodoc = Convert.ToInt32(ddlTipoDocumento.SelectedValue),
                    Numdoc = txtNumdoc.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    IN_Rol = Convert.ToInt32(ddlRol.SelectedValue),
                    IN_Cargo = Convert.ToInt32(ddlCargo.SelectedValue),
                    OrganizacionId = 1,
                    UsuarioCreacionId = user.IdUsuario,
                    IB_Estado = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue)),
                    PrimerNombre = txtPrimerNombre.Text.Trim(),
                    SegundoNombre = txtSegundoNombre.Text.Trim(),
                    ApellidoPaterno = txtApellidoPaterno.Text.Trim(),
                    ApellidoMaterno = txtApellidoMaterno.Text.Trim(),
                    Email = txtCorreo.Text.Trim()

                });
                if (dtoPa.HuboError)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dtoPa.ErrorMsj, "error"), true);
                }
                else
                {

                    String HTML = Resource1.htmlUsuario;
                    HTML = HTML.Replace("{usuario}", dtoPa.Usuario);
                    HTML = HTML.Replace("{clave}", dtoPa.Contrasena);

                    string to = dtoPa.Email;
                    HelpE.SendMail_Gmail(to, "Essalud - Usuario", HTML);

                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Usuario Registrado", "Se registro correctamente el Usuario", "success", "/administrador/usuario/lista"), true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo Registrar el Usuario." + "', 'error');", true);
            }
        }
    }
}
