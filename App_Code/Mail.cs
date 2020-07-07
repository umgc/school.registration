using EDUnited.Documents;
using EDUnited.Attributes;
using System;
using System.Net.Mail;

namespace EDUnited
{
    /// <summary>
    /// Summary description for Mail
    /// </summary>
    [Serializable()]
    public class Mail : MailMessage
    {
        #region Members

        private string sCertificatePath = String.Empty;
        private string sCertificatePassword = String.Empty;

        #endregion

        #region Constructors

        public Mail() : base() { }

        public Mail(string sFrom, string sTo, string sSubject, string sBody, DocumentList lAttachments) : base(sFrom, sTo, sSubject, sBody) 
        {
            AddAttachments(lAttachments);
        }

        public Mail(string sFrom, string sTo, string sSubject, DocumentList lAttachments) : base(sFrom, sTo)
        {
            base.Subject = sSubject;
            AddAttachments(lAttachments);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Takes a document list of attachemtns in and adds them as attachments to the mail object
        /// </summary>
        /// <param name="lAttachments">List of document attachments</param>
        public void AddAttachments(DocumentList lAttachments) 
        {
            foreach (Document oDoc in lAttachments)
            {
                this.Attachments.Add(new Attachment(oDoc.CompletePath));
            }
        }

        #endregion

        #region Properties

        [Description("Certificate Path")]
        public string CertificatePath
        {
            get { return sCertificatePath; }
            set { sCertificatePath = value; }
        }

        [Description("Certificate Password")]
        public string CertificatePassword
        {
            get { return sCertificatePassword; }
            set { sCertificatePassword = value; }
        }

        #endregion
    }
}