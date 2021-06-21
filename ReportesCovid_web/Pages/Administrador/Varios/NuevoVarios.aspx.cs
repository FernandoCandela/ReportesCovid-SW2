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
            CargarAtributo();
            CargarEntidad();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                /*PREGUNTAR A FERNANDO*/
                DtoTablaVarios dto = (DtoTablaVarios)new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios
                {
                    Valor = txtValor.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    IB_Estado = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue)),
                });
                if (dto.HuboError)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error", dto.ErrorMsj, "error"), true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacionRedirect("Usuario Registrado", "Se registro correctamente", "success", "/administrador/varios/lista"), true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron guardar los datos." + "', 'error');", true);
            }
        }

        private void CargarAtributo()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios());
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    ddlTipoAtributo.DataSource = list;
                    ddlTipoAtributo.DataBind();
                    ListItem firstLista = new ListItem("Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlTipoAtributo.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar TipoAtributo." + "', 'error');", true);
            }

        }

        private void CargarEntidad()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios());
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> list = cr.List.Cast<DtoTablaVarios>().ToList();
                    ddlEntidadTabla.DataSource = list;
                    ddlEntidadTabla.DataBind();
                    ListItem firstLista = new ListItem("Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlEntidadTabla.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar EntidadTabla." + "', 'error');", true);
            }

        }


    }

}


/*
 REVISAR TODO
 */