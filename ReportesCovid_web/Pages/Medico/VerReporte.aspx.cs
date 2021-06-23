using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Medico
{
    public partial class VerReporte : System.Web.UI.Page
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
                    Response.Redirect("/logOut");
                }
            }
        }
        public void FirstLoad()
        {
            CargarTipoTraslado();
            CargarReporteMedico();
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

                    ListItem firstLista = new ListItem(" ", "");
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
        private void CargarDatosPaciente(int idPaciente)
        {
            try
            {
                DtoPaciente userPaciente = new CtrPaciente().Usp_Paciente_SelectOne(new DtoPaciente
                {
                    IdPaciente = idPaciente
                });

                txtNombres.Text = userPaciente.Nombres;
                txtApellidos.Text = userPaciente.Apellidos;
                txtNumdoc.Text = userPaciente.NombreTipodoc + "-" + userPaciente.Numdoc.ToString();
                txtEstadoPaciente.Text = userPaciente.NombreEstadoPaciente;
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar datos del paciente." + "', 'error');", true);
            }

        }
        private void CargarReporteMedico()
        {
            try
            {
                DtoPacienteHistorial dtoPH = new CtrPacienteHistoria().Usp_PacienteHistorial_SelectOne(new DtoPacienteHistorial
                {
                    IdHistorial = Convert.ToInt32(Request.QueryString["idHistoria"])
                });
                if (!dtoPH.HuboError)
                {
                    txtFechaCreacion.Text = dtoPH.FechaCreacion.ToString();
                    txtTemperatura.Text = dtoPH.Temperatura;
                    txtFrecuencia.Text = dtoPH.FrecuenciaCardiaca;
                    txtPresion.Text = dtoPH.PresionArterial;
                    txtSaturacion.Text = dtoPH.Saturacion;
                    txtPronostico.Text = dtoPH.Pronostico;
                    txtRequerimiento.Text = dtoPH.Requerimiento;
                    txtEvolucion.Text = dtoPH.Evolucion;

                    cbTraslado.Checked = dtoPH.IB_Traslado;
                    if (dtoPH.IB_Traslado)
                    {
                        lblTraslado.CssClass = "badge rounded-pill bg-danger";
                        lblTraslado.Text = "Requiere Traslado!";

                        txtFechaTraslado.Text = dtoPH.FechaSolicitudTraslado.ToString("dd/MM/yyyy");
                        ddlTipoTraslado.SelectedValue = dtoPH.IN_TipoTraslado.ToString();
                        txtComentario.Text = dtoPH.DescTraslado;
                    }
                    hdnIdPaciente.Value = dtoPH.PacienteId.ToString();
                    CargarDatosPaciente(dtoPH.PacienteId);
                    DtoUsuario dtoUser = new CtrUsuario().Usp_Usuario_SelectOne(new DtoUsuario
                    {
                        IdUsuario = dtoPH.UsuarioCreacionId
                    });
                    if (!dtoUser.HuboError)
                    {
                        txtMedico.Text = dtoUser.PrimerNombre + " " + dtoUser.SegundoNombre + " " + dtoUser.ApellidoPaterno + " " + dtoUser.ApellidoMaterno;
                    }
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo cargar el reporte." + "', 'error');", true);
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/medico/reporte/lista?idPaciente="+hdnIdPaciente.Value.ToString());
        }
    }
}