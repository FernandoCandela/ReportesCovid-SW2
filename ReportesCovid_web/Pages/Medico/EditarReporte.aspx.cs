using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Medico
{
    public partial class EditarReporte : System.Web.UI.Page
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


            cbTraslado.Attributes.Add("OnChange", "changeTraslado('" + cbTraslado.ClientID + "','" + txtFechaTraslado.ClientID + "','" + ddlTipoTraslado.ClientID + "','" + txtComentario.ClientID + "');");
            btnActualizar.Attributes.Add("OnClick", "return validarTraslado('" + cbTraslado.ClientID + "','" + txtFechaTraslado.ClientID + "','" + ddlTipoTraslado.ClientID + "','" + txtComentario.ClientID + "');");
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
                    txtFechaCreacion.Text = dtoPH.UsuarioModificacionId == 0 ? dtoPH.FechaCreacion.ToString() : dtoPH.FechaModificacion.ToString();
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
                        txtFechaTraslado.Attributes.Remove("disabled");
                        ddlTipoTraslado.Attributes.Remove("disabled");
                        txtComentario.Attributes.Remove("disabled");
                        txtFechaTraslado.Text = dtoPH.FechaSolicitudTraslado.ToString("yyyy-MM-dd");
                        ddlTipoTraslado.SelectedValue = dtoPH.IN_TipoTraslado.ToString();
                        txtComentario.Text = dtoPH.DescTraslado;
                    }
                    hdnIdPaciente.Value = dtoPH.PacienteId.ToString();
                    CargarDatosPaciente(dtoPH.PacienteId);
                    DtoUsuario dtoUser = new CtrUsuario().Usp_Usuario_SelectOne(new DtoUsuario
                    {
                        IdUsuario = dtoPH.UsuarioModificacionId == 0 ? dtoPH.UsuarioCreacionId : dtoPH.UsuarioModificacionId
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
            Response.Redirect("/medico/reporte/lista?idPaciente=" + hdnIdPaciente.Value.ToString());
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];

                DtoPacienteHistorial dtoPH = new DtoPacienteHistorial
                {
                    IdHistorial = Convert.ToInt32(Request.QueryString["idHistoria"]),
                    Temperatura = txtTemperatura.Text.Trim(),
                    FrecuenciaCardiaca = txtFrecuencia.Text.Trim(),
                    PresionArterial = txtPresion.Text.Trim(),
                    Saturacion = txtSaturacion.Text.Trim(),
                    Pronostico = txtPronostico.Text.Trim(),
                    Requerimiento = txtRequerimiento.Text.Trim(),
                    Evolucion = txtEvolucion.Text.Trim(),
                    IB_Traslado = cbTraslado.Checked,
                    UsuarioModificacionId = user.IdUsuario
                };
                if (cbTraslado.Checked)
                {
                    dtoPH.IN_TipoTraslado = Convert.ToInt32(ddlTipoTraslado.SelectedValue);
                    dtoPH.Evolucion = txtEvolucion.Text.Trim();
                    dtoPH.DescTraslado = txtComentario.Text.Trim();
                    dtoPH.FechaSolicitudTraslado = Convert.ToDateTime(txtFechaTraslado.Text);
                }

                DtoPacienteHistorial dtoPa = new CtrPacienteHistoria().Usp_PacienteHistorial_Update_ByIdHistorial(dtoPH);

                if (!dtoPa.HuboError)
                {
                    DtoContacto dtoC = new CtrContacto().Usp_Contacto_SelectOne(new DtoContacto
                    {
                        PacienteId = Convert.ToInt32(hdnIdPaciente.Value)
                    });

                    String HTML = Resource1.Reporte_Actualizado;
                    HTML = HTML.Replace("{fecha}", DateTime.Now.ToString());
                    HTML = HTML.Replace("{nomPaciente}", txtNombres.Text + " " + txtApellidos.Text);

                    string to = dtoC.Email;
                    HelpE.SendMail_Gmail(to, "Essalud - Reporte Actualizado", HTML);

                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Reporte Acatualizado", "Se actualizo correctamente el reporte", "success", "/medico/reporte/lista?idPaciente=" + hdnIdPaciente.Value.ToString()), true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dtoPa.ErrorMsj, "error"), true);
                }


            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo actualizar el Reporte." + "', 'error');", true);
            }
        }
    }
}