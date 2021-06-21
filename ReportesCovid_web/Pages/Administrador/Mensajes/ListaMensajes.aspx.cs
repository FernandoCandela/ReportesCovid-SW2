using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Administrador.Mensajes
{
    public partial class ListaMensajes : System.Web.UI.Page
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
            CargarMensajes();
        }
        private void CargarMensajes()
        {
            try
            {
                List<DtoMensajes> ListMensajes = new List<DtoMensajes>();

                ClassResultV cr = new CtrMensajes().Usp_Mensajes_SelectAll(new DtoMensajes
                {
                    IB_Respondido = Convert.ToBoolean(Convert.ToInt32(ddlEstado.SelectedValue)),
                    Criterio = txtBuscar.Text.Trim()
                }
                );
                if (!cr.HuboError)
                {
                    ListMensajes.AddRange(cr.List.Cast<DtoMensajes>());
                    gvMensajes.DataSource = ListMensajes;
                }
                gvMensajes.DataBind();
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar los mensajes." + "', 'error');", true);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarMensajes();
        }

        protected void gvMensajes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            switch (e.CommandName)
            {
                case "Editar":
                    rowIndex = int.Parse(e.CommandArgument.ToString());
                    string idMensaje = (gvMensajes.Rows[rowIndex].Cells[0].FindControl("lblIdMensaje") as Label).Text;
                    Response.Redirect("/administrador/mensaje/respondermensaje?IdMensaje=" + idMensaje);
                    break;
            }
        }

        protected void gvMensajes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.PageIndex = e.NewPageIndex;
            CargarMensajes();
        }

        protected void gvMensajes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    var dto = (DtoMensajes)e.Row.DataItem;
                    string msj = "<span class='badge " + (dto.IB_Respondido == true ? "bg-success" : "bg-warning") + "'>" + (dto.IB_Respondido == true ? 1 : 0) + "</span>";
                    (e.Row.Cells[7].FindControl("ltlEstados") as Literal).Text = msj;
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}

/*
 REVISAR TODO DE NUEVO, ALGO FALLA (CREO)
 */