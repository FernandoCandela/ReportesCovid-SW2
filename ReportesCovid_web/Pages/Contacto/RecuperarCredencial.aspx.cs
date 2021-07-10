using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.Pages.Contacto
{
    public partial class RestaurarCredencial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FirstLoad();
        }

        public void FirstLoad()
        {
            CargarTipoDocumento();
        }

        private void CargarTipoDocumento()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_SelectAll(new DtoTablaVarios
                {
                    TipoAtributo = "IN_Tipodoc",
                    EntidadTabla = "Paciente"
                });
                if (!cr.HuboError)
                {
                    List<DtoTablaVarios> lista = cr.List.Cast<DtoTablaVarios>().ToList();
                    //Paciente
                    ddlTipoDocumento.DataTextField = "Descripcion";
                    ddlTipoDocumento.DataValueField = "Valor";
                    ddlTipoDocumento.DataSource = lista;
                    ddlTipoDocumento.DataBind();
                    //Contacto
                    ddlTipoDocContacto.DataTextField = "Descripcion";
                    ddlTipoDocContacto.DataValueField = "Valor";
                    ddlTipoDocContacto.DataSource = lista;
                    ddlTipoDocContacto.DataBind();

                    //"<asp:ListItem Selected="True" disabled Value="" Text="Choose..."></asp:ListItem>"
                    ListItem firstLista = new ListItem("[Seleccionar]", "");
                    firstLista.Attributes.Add("disabled", "disabled");
                    firstLista.Attributes.Add("Selected", "True");
                    ddlTipoDocumento.Items.Insert(0, firstLista);
                    ddlTipoDocContacto.Items.Insert(0, firstLista);
                }
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Pop", @"Swal.fire('Error!', '" + "No se pudieron cargar TipoDocumento." + "', 'error');", true);
            }
        }
    }
}