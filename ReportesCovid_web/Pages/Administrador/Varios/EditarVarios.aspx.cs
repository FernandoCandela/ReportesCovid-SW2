using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Administrador.Varios
{
    public partial class EditarVarios : System.Web.UI.Page
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
            LlenarDetalle();
        }

        private void LlenarDetalle()
        {
            try
            {
                DtoTablaVarios dto = (DtoTablaVarios)new CtrTablaVarios().Usp_TablaVarios_SelectOne(new DtoTablaVarios
                {
                    IdTabVarios = Convert.ToInt32(Request.QueryString["IdTabVarios"])
                });
                if (!dto.HuboError)
                {
                    txtDescripcion.Text = dto.Descripcion;
                    ddlTiposVarios.Text = dto.TipoAtributo;
                    ddlEstado.SelectedValue = dto.IB_Estado == true ? "1" : "0";
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los datos." + "', 'error');", true);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];

                var entidad = "";
                switch (ddlTiposVarios.SelectedValue)
                {
                    case "IN_EstadoPaciente":
                        entidad = "Paciente";
                        break;
                    case "IN_Rol":
                        entidad = "Usuario";
                        break;
                    case "IN_Tipodoc":
                        entidad = "Paciente";
                        break;
                    case "IN_TipoMensaje":
                        entidad = "Mensajes";
                        break;
                    case "IN_Cargo":
                        entidad = "Usuario";
                        break;
                    case "IN_TipoSeguro":
                        entidad = "Paciente";
                        break;
                    case "IN_TipoTraslado":
                        entidad = "PacienteHistorial";
                        break;
                }
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_Update(new DtoTablaVarios
                {
                    IdTabVarios = Convert.ToInt32(Request.QueryString["IdTabVarios"]),
                    Descripcion = txtDescripcion.Text,
                    TipoAtributo = ddlTiposVarios.SelectedValue,
                    EntidadTabla = entidad,
                    UsuarioModificacionId = user.IdUsuario,
                    IB_Estado = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue))
                });
                if (cr.HuboError)
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", cr.ErrorMsj, "error"), true);
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Atributo Actualizado", "Se actualizo correctamente el atributo", "success", "/administrador/varios/lista"), true);

                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo Actualizar el Atributo." + "', 'error');", true);
            }
        }
    }
}