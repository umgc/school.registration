using System.Net.Mail;
using System.Net;

namespace EDUnited.App_Code.Utilities
{
    /// <summary>
    /// Summary description for EmailManager.
    /// </summary>
    public class EmailManager
    {
        #region Constructors

        private EmailManager() {  }

        #endregion

        #region Methods       

        public static void SendEmail(MailMessage msg, string SmtpServer)
        {
            SmtpClient oClient = new SmtpClient(SmtpServer);
            oClient.EnableSsl = true;
            oClient.Send(msg);
            oClient.Dispose();
        }

        public static void SendEmail(MailMessage msg, string SmtpServer, string sUsername, string sPassword)
        {
            SmtpClient oClient = new SmtpClient(SmtpServer);
            oClient.EnableSsl = true;
            oClient.UseDefaultCredentials = false;
            oClient.Credentials = new NetworkCredential(sUsername, sPassword);
            oClient.Send(msg);
            oClient.Dispose();
        }

        #endregion
    }
}
