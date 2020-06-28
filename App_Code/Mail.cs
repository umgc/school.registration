using EDUnited.Documents;
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
        private void AddAttachments(DocumentList lAttachments) 
        {
            foreach (Document oDoc in lAttachments)
            {
                this.Attachments.Add(new Attachment(oDoc.CompletePath));
            }
        }        

        #endregion
    }
}