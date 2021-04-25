using System;
using System.Configuration;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI.WebControls;
using System.Web;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace ReportesCovid_web.Helpers
{
    public class HelpE
    {

        #region Mailing Methods
        public static void SendMail_Gmail(string to, string asunto, string body)
        {
            SendMail_SendGrid(to, asunto, body);
        }

        private static void SendMail_SendGrid(string mailTo, string Asunto, string emailBody)
        {
            //var client = new SendGridClient(ConfigurationManager.AppSettings["SendGridApiKey"]);
            //var msg = MailHelper.CreateSingleEmail(new EmailAddress(ConfigurationManager.AppSettings["Correo"], "ReportesCovid"), new EmailAddress(mailTo), Asunto, HttpUtility.HtmlEncode(emailBody), emailBody);
            //var sendEmailAsync = client.SendEmailAsync(msg);
        }
        #endregion

        public static string mensajeConfirmacion(string titulo, string mensaje, string tipo)
        {
            string script = @"Swal.fire({title: '" + titulo + "',text: '" + mensaje + "', icon: '" + tipo + "', button: 'OK'})";
            //script += ".then((willDelete) => { if (willDelete) { window.location = 'GestionarPedido.aspx'; } else { window.location = 'GestionarPedido.aspx'; }});";
            return script;
        }

        public static string mensajeConfirmacionRedirect(string titulo, string mensaje, string tipo, string url)
        {
            string script = @"Swal.fire({title: '" + titulo + "',text: '" + mensaje + "', icon: '" + tipo + "', button: 'OK'}).then(function() { window.location = '" + url + "'; });";
            //script += ".then((willDelete) => { if (willDelete) { window.location = 'GestionarPedido.aspx'; } else { window.location = 'GestionarPedido.aspx'; }});";
            return script;
        }

        public static string mensajeConfirmacionHtml(string titulo, string html, string tipo)
        {
            string script = @"Swal.fire({title: '" + titulo + "',html: '" + html + "', icon: '" + tipo + "', button: 'OK',})";
            return script;
        }
    }
}