using MimeKit;
using MailKit.Net.Smtp;

namespace ReportesCovid_web.Helpers
{
    public class HelpE
    {

        #region Mailing Methods
        public static void SendMail_Gmail(string to, string asunto, string body)
        {
            //otro modo
            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("Reportes Covid", "20171937@aloe.ulima.edu.pe"));

            mailMessage.To.Add(new MailboxAddress("", to));
            mailMessage.Subject = asunto;
            mailMessage.Body = new TextPart("html") { Text = body };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 465, true);
                //Ingresar Contrasena
                smtpClient.Authenticate("20171937@aloe.ulima.edu.pe", "");
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }

        }
        #endregion

        public static string mensajeConfirmacion(string titulo, string mensaje, string tipo)
        {
            string script = @"Swal.fire({title: '" + titulo + "',text: '" + mensaje + "', icon: '" + tipo + "', button: 'OK'})";
            return script;
        }

        public static string mensajeConfirmacionRedirect(string titulo, string mensaje, string tipo, string url)
        {
            string script = @"Swal.fire({title: '" + titulo + "',text: '" + mensaje + "', icon: '" + tipo + "', button: 'OK'}).then(function() { window.location = '" + url + "'; });";
            return script;
        }

        public static string mensajeConfirmacionHtml(string titulo, string html, string tipo)
        {
            string script = @"Swal.fire({title: '" + titulo + "',html: '" + html + "', icon: '" + tipo + "', button: 'OK',})";
            return script;
        }
    }
}