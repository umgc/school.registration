using System;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDUnited
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Events
        protected void cmdUploadDocs_Click(object sender, EventArgs e)
        {
            if (fuSupportingDocs.HasFiles)
            {
                foreach (HttpPostedFile uploadedFile in fuSupportingDocs.PostedFiles)
                {
                    // the session
                    uploadedFile.SaveAs(System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), HttpContext.Current.Session.SessionID + "_" + uploadedFile.FileName));
                    lbLoadedDocs.Items.Add(new ListItem(uploadedFile.FileName));
                }
            }
        }

        protected void cmdRemove_Click(object sender, EventArgs e)
        {
            if (lbLoadedDocs.SelectedItem != null) 
            {
                File.Delete(System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), HttpContext.Current.Session.SessionID + "_" + lbLoadedDocs.SelectedItem.Text));
                lbLoadedDocs.Items.RemoveAt(lbLoadedDocs.SelectedIndex);
            }
        }

        #endregion

    }
}