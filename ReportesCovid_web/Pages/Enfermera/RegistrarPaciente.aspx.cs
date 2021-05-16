using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using ReportesCovid_web.Helpers;
using System.Web.Security;

namespace ReportesCovid_web.Pages.Enfermera
{
    public partial class RegistrarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                if (user != null && user.IN_Rol == 2)
                {
                    FirstLoad();
                }
                else
                {
                    Session.RemoveAll();
                    Response.Redirect("logIn");
                }
            }
        }
        public void FirstLoad()
        {
            CargarTipoDocumento();
            CargarTipoSeguro();
            CargarEstadosPaciente();
        }
        private void CargarTipoDocumento()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios
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
                    //Contacto
                    ddlTipoDocContacto.DataTextField = "Descripcion";
                    ddlTipoDocContacto.DataValueField = "Valor";
                    ddlTipoDocContacto.DataSource = list;
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
        private void CargarTipoSeguro()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios
                {
                    TipoAtributo = "IN_TipoSeguro",
                    EntidadTabla = "Paciente"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    ddlTipoSeguro.DataTextField = "Descripcion";
                    ddlTipoSeguro.DataValueField = "Valor";
                    ddlTipoSeguro.DataSource = list;
                    ddlTipoSeguro.DataBind();
                    //"<asp:ListItem Selected="True" disabled Value="" Text="Choose..."></asp:ListItem>"
                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlTipoSeguro.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar TipoSeguro." + "', 'error');", true);
            }
        }
        private void CargarEstadosPaciente()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios
                {
                    TipoAtributo = "IN_EstadoPaciente",
                    EntidadTabla = "Paciente"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    ddlEstadoPaciente.DataTextField = "Descripcion";
                    ddlEstadoPaciente.DataValueField = "Valor";
                    ddlEstadoPaciente.DataSource = list;
                    ddlEstadoPaciente.DataBind();
                    //"<asp:ListItem Selected="True" disabled Value="" Text="Choose..."></asp:ListItem>"
                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlEstadoPaciente.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar TipoSeguro." + "', 'error');", true);
            }
        }
        protected void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];

                var guid = Guid.NewGuid().ToString().Replace("-", "");


                DtoPaciente dtoPa = new CtrPaciente().Usp_Paciente_Insert(new DtoPaciente
                {
                    Nombres = txtNombres.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    IN_Tipodoc = Convert.ToInt32(ddlTipoDocumento.SelectedValue),
                    Numdoc = txtNumdoc.Text.Trim(),
                    IN_TipoSeguro = Convert.ToInt32(ddlTipoSeguro.SelectedValue),
                    IN_EstadoPaciente = Convert.ToInt32(ddlEstadoPaciente.SelectedValue),
                    UsuarioCreacionId = user.IdUsuario,
                    Credencial = guid

                });
                if (dtoPa.HuboError)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dtoPa.ErrorMsj, "error"), true);
                }
                else
                {
                    //registrarContacto
                    DtoContacto dtoContacto = new CtrContacto().Usp_Contacto_Insert(new DtoContacto
                    {
                        NombreCompleto = txtNombreApellidoContacto.Text.Trim(),
                        IN_Tipodoc = Convert.ToInt32(ddlTipoDocContacto.SelectedValue),
                        Numdoc = txtNumDocContacto.Text.Trim(),
                        Email = txtCorreoContacto.Text.Trim(),
                        Telefono = txtTelefonoContacto.Text.Trim(),
                        UsuarioCreacionId = user.IdUsuario,
                        PacienteId = dtoPa.IdPaciente

                    });
                    if (dtoContacto.HuboError)
                        ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dtoContacto.ErrorMsj, "error"), true);
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Paciente Registrado", "Se registro correctamente el Paciente", "success", "/TablaModificarPaciente"), true);
                    }


                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo Registrar el Paciente." + "', 'error');", true);
            }
        }
    }
}