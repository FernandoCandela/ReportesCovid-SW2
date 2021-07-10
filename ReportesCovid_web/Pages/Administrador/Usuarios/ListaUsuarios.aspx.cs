using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Administrador.Usuarios
{
    public partial class ListaUsuarios : System.Web.UI.Page
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
            CargarRoles();
            CargarUsuarios();
        }
        private void CargarRoles()
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
                    ddlRol.DataTextField = "Descripcion";
                    ddlRol.DataValueField = "Valor";
                    ddlRol.DataSource = list;
                    ddlRol.DataBind();
                    ListItem firstLista = new ListItem("Todos", "0");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlRol.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los Roles." + "', 'error');", true);
            }
        }
        private void CargarUsuarios()
        {
            try
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                List<DtoUsuario> ListUsuarios = new List<DtoUsuario>();

                ClassResultV cr = new CtrUsuario().Usp_Usuario_SelectAll(new DtoUsuario
                {
                    IB_Estado = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue)),
                    IN_Rol = Convert.ToInt32(ddlRol.SelectedValue),
                    Criterio = txtBuscar.Text.Trim(),
                    OrganizacionId = user.OrganizacionId
                }
                );
                if (!cr.HuboError)
                {
                    ListUsuarios.AddRange(cr.List.Cast<DtoUsuario>());
                    gvUsuarios.DataSource = ListUsuarios;
                }
                gvUsuarios.DataBind();
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los Usuarios." + "', 'error');", true);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        protected void gvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            switch (e.CommandName)
            {
                case "Editar":
                    rowIndex = int.Parse(e.CommandArgument.ToString());
                    string idUsuario = (gvUsuarios.Rows[rowIndex].Cells[0].FindControl("lblIdUsuario") as Label).Text;
                    Response.Redirect("/administrador/usuario/editar?idusuario=" + idUsuario);
                    break;
            }
        }

        protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.PageIndex = e.NewPageIndex;
            CargarUsuarios();
        }

        protected void gvUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    var dto = (DtoUsuario)e.Row.DataItem;
                    string msj = "<span class='badge " + (dto.IB_Estado == true ? "bg-success" : "bg-warning") + "'>" + (dto.IB_Estado == true ? "Activo" : "Desactivado") + "</span>";
                    (e.Row.Cells[7].FindControl("ltlEstados") as Literal).Text = msj;
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}