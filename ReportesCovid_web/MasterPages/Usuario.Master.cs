using CTR;
using DTO;
using ReportesCovid_web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.MasterPages
{
    public partial class Usuario : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Para ver que menu mostrar a cada usuario //
            //DtoUsuario dto = new DtoUsuario();
            //DtoUsuario dtoR = new CtrUsuario().Usp_Usuario_Login(dto);
            //if (!dtoR.HuboError)
            //{
            //    Session["UsuarioLogin"] = dtoR;

            //    if (dtoR.IN_Rol == 1)
            //    {
            //            admin1.Attributes.Add("style", "visibility: visible;");
            //            admin2.Attributes.Add("style", "visibility: visible;");
            //            admin3.Attributes.Add("style", "visibility: visible;");
            //    }

            //    else if (dtoR.IN_Rol == 2)
            //    {
            //            enfermera1.Attributes.Add("style", "visibility: visible;");
            //            enfermera2.Attributes.Add("style", "visibility: visible;");
            //            enfermera3.Attributes.Add("style", "visibility: visible;");
            //    }

            //    else if (dtoR.IN_Rol == 3)
            //    {
            //            medico.Attributes.Add("style", "visibility: visible;");
            //    }
            //}

            //else
            //    {
            //        ScriptManager.RegisterStartupScript(this, GetType(), "Pop", HelpE.mensajeConfirmacion("Error!", dtoR.ErrorMsj, "error"), true);
            //    }

        }
    }
}