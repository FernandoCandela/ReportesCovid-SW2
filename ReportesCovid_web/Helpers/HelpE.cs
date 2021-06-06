using MimeKit;
using MailKit.Net.Smtp;

namespace ReportesCovid_web.Helpers
{
    public class HelpE
    {

        #region Mailing Methods
        public static void SendMail_Gmail(string to, string asunto, string body)
        {
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.Credentials = new NetworkCredential("20171937@aloe.ulima.edu.pe", "EPEJXX103");
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.EnableSsl = true;
            //smtp.UseDefaultCredentials = false;

            //MailMessage mail = new MailMessage();
            //mail.From = new MailAddress("20171937@aloe.ulima.edu.pe", "Reportes Covid");
            //mail.To.Add(new MailAddress(to));
            //mail.Subject = asunto;
            //mail.IsBodyHtml = true;

            //mail.Body = body;

            //smtp.Send(mail);

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

            //SendMail_SendGrid(to, asunto, body);
        }

        //private static void SendMail_SendGrid(string mailTo, string Asunto, string emailBody)
        //{
        //    var client = new SendGridClient(ConfigurationManager.AppSettings["SendGridApiKey"]);
        //    var msg = MailHelper.CreateSingleEmail(new EmailAddress(ConfigurationManager.AppSettings["Correo"], "ReportesCovid"), new EmailAddress(mailTo), Asunto, HttpUtility.HtmlEncode(emailBody), emailBody);
        //    var sendEmailAsync = client.SendEmailAsync(msg);
        //}
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