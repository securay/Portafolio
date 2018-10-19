using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Util
{
    public static class MailUtil
    {
        public static void SendMail(String To, String Subject, String Body)
        {
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                String from = "securay.dev@gmail.com";
                String from_pass = "Securay.DEV";
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(from);
                mail.To.Add(To);
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(from, from_pass);
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (ArgumentException ex)
            {
                Logger.Log(ex, Logger.ERROR);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SmtpFailedRecipientException ex)
            {
                Logger.Log(ex, Logger.ERROR);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(SmtpException ex)
            {
                Logger.Log(ex, Logger.ERROR);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
