﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using ReportesCovid_web.Helpers;
using System.Web.Security;

namespace ReportesCovid_web.Pages.Medico
{
    public partial class GenerarReporte : System.Web.UI.Page
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
                    Session.RemoveAll();
                    Response.Redirect("logIn");
                }
            }
        }

        public void FirstLoad()
        {
            CargarTipoTraslado();
            cbTraslado.Attributes.Add("OnChange", "changeTraslado('" + cbTraslado.ClientID + "','" + txtFechaTraslado.ClientID + "','" + ddlTipoTraslado.ClientID + "','" + txtComentario.ClientID + "');");
        }
        private void CargarTipoTraslado()
        {
            try
            {
                ClassResultV cr = new CtrTablaVarios().Usp_TablaVarios_Select(new DtoTablaVarios
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

    }
}