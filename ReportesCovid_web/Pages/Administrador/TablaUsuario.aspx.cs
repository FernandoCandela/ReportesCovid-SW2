using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Administrador
{
    public partial class TablaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DtoUsuario user = (DtoUsuario)Session["UsuarioLogin"];
                if (user.IN_Rol == 1)
                {
                    FirstLoad();
                }
                else
                {
                    Session.Remove("UsuarioLogin");
                    Response.Redirect("logIn");
                }
            }
        }

        public void FirstLoad()
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                List<DtoUsuario> ListUsuarios = new List<DtoUsuario>();

                ClassResultV cr = new CtrUsuario().Usp_Usuario_Login(new DtoUsuario
                {
                    IB_Estado = true,
                    Criterio = txtBuscar.Text.Trim()
                }
                );
                //lblResultados.Text = "Resultados encontrados: " + cr.List.Count;
                if (!cr.HuboError)
                {
                    ListUsuarios.AddRange(cr.List.Cast<DtoUsuario>());
                    gvUsuarios.DataSource = ListUsuarios;
                }
                gvUsuarios.DataBind();
            }
            catch (Exception ex)
            {

                //ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "script", "fail('" + ex.Message + "');", true);
            }
        }
    }
}