using System;
using System.IO;
using System.Web;
using System.Web.UI;

namespace EDUnited
{
    public partial class Decryption : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Events       

        /// <summary>
        /// This event handles the clicking of the decryption button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cmdDecryptFiles_Click(object sender, EventArgs e)
        {
            string sPassphrase = System.Configuration.ConfigurationManager.AppSettings["DecryptionPassphrase"];
            string sEnteredPassphrase = tbxPassphrase.Text;

            if (sPassphrase == sEnteredPassphrase && fuSupportingDocs.HasFiles)
            {
                foreach (HttpPostedFile uploadedFile in fuSupportingDocs.PostedFiles)
                {
                    //Even though the regex validator checked this, double-check to ensure that it's what we expect
                    if (uploadedFile.FileName.EndsWith("_enc.zip"))
                    {
                        //Grab the filename
                        string sPath = System.IO.Path.Combine(Server.MapPath("~/DecryptionDocs/"), uploadedFile.FileName);

                        //Grab the decrypted filename
                        string sDecryptedPath = System.IO.Path.Combine(Server.MapPath("~/DecryptionDocs/"), uploadedFile.FileName.Replace("_enc", string.Empty));

                        //Save the file so we can decrypt it
                        uploadedFile.SaveAs(System.IO.Path.Combine(Server.MapPath("~/DecryptionDocs/"), uploadedFile.FileName));

                        //Decrypt the zip file 
                        CryptoManager.DecryptFile(sPath, sDecryptedPath);

                        //Clean up the original encrypted file
                        File.Delete(sPath);

                        //Send the decrypted file to the user so they can decide where to save it to
                        System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
                        response.ClearContent();
                        response.Clear();
                        response.ContentType = "text/plain";
                        response.AddHeader("Content-Disposition", "attachment; filename=" + uploadedFile.FileName.Replace("_enc", string.Empty) + ";");
                        response.TransmitFile(sDecryptedPath);
                        response.Flush();

                        //Clean up the decrypted file
                        File.Delete(sDecryptedPath);

                        response.End();
                    }
                }
            }
        }

        #endregion      

    }
}