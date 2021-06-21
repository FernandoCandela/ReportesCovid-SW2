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
                /*PREGUNTAR A FERNANDO*/
                DtoTablaVarios dto = (DtoTablaVarios)new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios
                { 
                    IdTabVarios = Convert.ToInt32(Request.QueryString["IdTabVarios"])
                });
                if (!dto.HuboError)
                {
                    txtValor.Text = dto.Valor;
                    txtDescripcion.Text = dto.Descripcion;
                    txtAtributo.Text = dto.TipoAtributo;
                    txtEntidad.Text = dto.EntidadTabla;
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
                /*PREGUNTAR A FERNANDO*/
                DtoTablaVarios varios = (DtoTablaVarios)Session["UsuarioLogin"];
                ClassResultV cr = (DtoTablaVarios)new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios
                {
                    IdTabVarios = Convert.ToInt32(Request.QueryString["IdTabVarios"]),
                    Valor = txtValor.Text,
                    Descripcion = txtDescripcion.Text,
                    TipoAtributo = txtAtributo.Text,
                    EntidadTabla = txtEntidad.Text,
                    IB_Estado = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue))
                });
                if(cr.HuboError)
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", cr.ErrorMsj, "error"), true);
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Usuario Actualizado", "Se actualizo correctamente el usuario", "success", "/administrador/varios/lista"), true);

                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudo Actualizar el Usuario." + "', 'error');", true);
            }
        }
    }
}