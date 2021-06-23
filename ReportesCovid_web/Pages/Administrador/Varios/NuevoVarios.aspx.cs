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
    public partial class NuevoVarios : System.Web.UI.Page
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

        private void FirstLoad()
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
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
                DtoTablaVarios dto = new CtrTablaVarios().Usp_TablaVarios_Insert(new DtoTablaVarios
                {
                    Descripcion = txtDescripcion.Text.Trim(),
                    TipoAtributo = ddlTiposVarios.SelectedValue,
                    EntidadTabla = entidad,
                    UsuarioCreacionId = user.IdUsuario,
                    IB_Estado = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue)),
                });
                if (dto.HuboError)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dto.ErrorMsj, "error"), true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Atributo Registrado", "Se registro correctamente el Atributo", "success", "/administrador/varios/lista"), true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo Registrar el Atributo." + "', 'error');", true);
            }
        }
    }

}
