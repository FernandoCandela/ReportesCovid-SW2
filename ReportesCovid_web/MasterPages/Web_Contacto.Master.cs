using CTR;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportesCovid_web.MasterPages
{
    public partial class Web_Contacto : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DtoPaciente userPaciente = (DtoPaciente)Session["PacienteContacto"];
            //if (userPaciente != null)
            //{
            //    FirstLoad();
            //}
            //else
            //{
            //    Response.Redirect("/logOutContacto");
            //}
        }
        public void FirstLoad()
        {
            DtoPaciente userPaciente = (DtoPaciente)Session["PacienteContacto"];

            DtoContacto dtoC = new CtrContacto().Usp_Contacto_SelectOne(new DtoContacto
            {
                PacienteId = userPaciente.IdPaciente
            });
            if (!dtoC.HuboError)
            {
                lbUserName.Text = dtoC.NombreCompleto;
                title.Text = "Essalud - " + userPaciente.Nombres + " " + userPaciente.Apellidos;
                titulo.InnerText="Paciente - " + userPaciente.Nombres + " " + userPaciente.Apellidos;
            }
        }
    }
}