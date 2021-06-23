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

namespace ReportesCovid_web.Pages.Medico
{
    public partial class GenerarReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                if (user != null && user.IN_Rol == 3)
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
            CargarDatosPaciente();
            CargarDatosMedico();

            CargarTipoTraslado();
            cbTraslado.Attributes.Add("OnChange", "changeTraslado('" + cbTraslado.ClientID + "','" + txtFechaTraslado.ClientID + "','" + ddlTipoTraslado.ClientID + "','" + txtComentario.ClientID + "');");
            btnRegistrar.Attributes.Add("OnClick", "return validarTraslado('" + cbTraslado.ClientID + "','" + txtFechaTraslado.ClientID + "','" + ddlTipoTraslado.ClientID + "','" + txtComentario.ClientID + "');");
        }
        private void CargarTipoTraslado()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_SelectAll(new DtoTablaVarios
                {
                    TipoAtributo = "IN_TipoTraslado",
                    EntidadTabla = "PacienteHistorial"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    ddlTipoTraslado.DataTextField = "Descripcion";
                    ddlTipoTraslado.DataValueField = "Valor";
                    ddlTipoTraslado.DataSource = list;
                    ddlTipoTraslado.DataBind();

                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlTipoTraslado.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar Tipo Traslado." + "', 'error');", true);
            }
        }

        private void CargarDatosPaciente()
        {
            try
            {
                DtoPaciente dtop = new CtrPaciente().Usp_Paciente_SelectOne(new DtoPaciente
                {
                    IdPaciente = Convert.ToInt32(Request.QueryString["idPaciente"])
                });
                if (!dtop.HuboError)
                {
                    txtNombres.Text = dtop.Nombres;
                    txtApellidos.Text = dtop.Apellidos;
                    txtNumdoc.Text = (dtop.IN_Tipodoc.ToString() == "1" ? "DNI" : "Pasaporte") + "-" + dtop.Numdoc.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CargarDatosMedico()
        {
            DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
            txtMedico.Text = user.PrimerNombre + " " + user.SegundoNombre + " " + user.ApellidoPaterno + " " + user.ApellidoMaterno;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];

                DtoPacienteHistorial dtoPH = new DtoPacienteHistorial
                {
                    PacienteId = Convert.ToInt32(Request.QueryString["idPaciente"]),
                    Temperatura = txtTemperatura.Text.Trim(),
                    FrecuenciaCardiaca = txtFrecuencia.Text.Trim(),
                    PresionArterial = txtPresion.Text.Trim(),
                    Saturacion = txtSaturacion.Text.Trim(),
                    Pronostico = txtPronostico.Text.Trim(),
                    Requerimiento = txtRequerimiento.Text.Trim(),
                    Evolucion = txtEvolucion.Text.Trim(),
                    IB_Traslado = cbTraslado.Checked,
                    OrganizacionId = user.OrganizacionId,
                    UsuarioCreacionId = user.IdUsuario
                };
                if (cbTraslado.Checked)
                {
                    dtoPH.IN_TipoTraslado = Convert.ToInt32(ddlTipoTraslado.SelectedValue);
                    dtoPH.Evolucion = txtEvolucion.Text.Trim();
                    dtoPH.DescTraslado = txtComentario.Text.Trim();
                    dtoPH.FechaSolicitudTraslado = Convert.ToDateTime(txtFechaTraslado.Text);
                }

                DtoPacienteHistorial dtoPa = new CtrPacienteHistoria().Usp_PacienteHistorial_Insert(dtoPH);

                if (dtoPa.HuboError)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dtoPa.ErrorMsj, "error"), true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Reporte Registrado", "Se registro correctamente el reporte", "success", "/BuscarPaciente"), true);
                }


            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo Registrar el Reporte." + "', 'error');", true);
            }
        }
    }
}