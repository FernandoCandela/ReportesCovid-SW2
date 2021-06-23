using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Administrador.Varios
{
    public partial class ListaVarios : System.Web.UI.Page
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
            CargarTablas();
        }

        private void CargarTablas()
        {
            try
            {
                List<DtoTablaVarios> ListVarios = new List<DtoTablaVarios>();
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_SelectAll_Admin(new DtoTablaVarios
                {
                    IB_Estado = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue)),
                    Criterio = txtBuscar.Text.Trim(),
                    TipoAtributo = ddlTiposVarios.SelectedValue
                });
                if (!cr.HuboError)
                {
                    ListVarios.AddRange(cr.List.Cast<DtoTablaVarios>());
                    gvVarios.DataSource = ListVarios;
                }
                gvVarios.DataBind();
            }
            catch(Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los datos." + "', 'error');", true);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarTablas();
        }

        protected void gvVarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            switch (e.CommandName)
            {
                case "Editar":
                    rowIndex = int.Parse(e.CommandArgument.ToString());
                    string idTab = (gvVarios.Rows[rowIndex].Cells[0].FindControl("lblIdTab") as Label).Text;
                    Response.Redirect("/administrador/varios/editar?IdTabVarios=" + idTab);
                    break;
            }
        }

        protected void gvVarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.PageIndex = e.NewPageIndex;
            CargarTablas();
        }

        protected void gvVarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    var dto = (DtoTablaVarios)e.Row.DataItem;
                    string msj = "<span class='badge " + (dto.IB_Estado == true ? "bg-success" : "bg-warning") + "'>" + (dto.IB_Estado == true ? "Activo" : "Desactivado") + "</span>";
                    (e.Row.Cells[6].FindControl("ltlEstados") as Literal).Text = msj;
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}