using EDUnited.Documents;
using System;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MimeKit;
using MailKit.Net.Smtp;
using System.IO.Compression;


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
                    //Using the SessionID as a way to ensure we are keeping the documents that below to the session together in case there are duplicate names//
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

        /// <summary>
        /// This event handles the clicking of the registration submission button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cmdSubmitReg_Click(object sender, EventArgs e)
        {
            // validate the Captcha to check we're not dealing with a bot
            bool bIsHuman = ExampleCaptcha.Validate(tbxCaptchaCodeTextBox.Text);

            // clear previous user input
            tbxCaptchaCodeTextBox.Text = null;

            if (bIsHuman)
            {

                #region Student
                //Create new student object//
                Student student = new Student();

                student.FirstName = tbxStudentFirstName.Text;
                student.MiddleName = tbxStudentMiddleName.Text;
                student.LastName = tbxStudentLastName.Text;
                student.Gender = rblGender.SelectedValue;
                student.BirthPlace = tbxBirthplace.Text;
                student.DOB = tbxDOB.Text;

                //It should never be null but check just in case//            
                student.Grade = ddlEnrollingGrade.SelectedValue == null ? string.Empty : ddlEnrollingGrade.SelectedValue;

                #endregion

                #region Ethnicity

                bool bIsHispanic;

                //Create new ethnicity object///
                Ethnicity ethnicity = new Ethnicity();

                //It should never be null but check just in case//            
                ethnicity.Race = ddlRace.SelectedValue == null ? string.Empty : ddlRace.SelectedValue;

                //Validating we are returning a boolean answer//
                bool.TryParse(rblHispanicLatinoQuestion.SelectedValue, out bIsHispanic);
                ethnicity.IsHispanic = bIsHispanic;

                //Assign ethnicity object to student//
                student.Ethnicity = ethnicity;

                #endregion

                #region Primary Language

                //Create new primary language object
                PrimaryLanguage primaryLanguage = new PrimaryLanguage();

                //It should never be null but check just in case//
                primaryLanguage.SpokenByChild = tbxLanguageSpokenByChild.Text;

                //It should never be null but check just in case//
                primaryLanguage.SpokenInHome = tbxLanguageSpokenInHome.Text;

                //Assign primary language object to student//
                student.PrimaryLanguage = primaryLanguage;

                #endregion

                #region Physical Address

                Address pAddress = new Address();
                pAddress.Street = tbxPhysicalAddressStreet.Text;
                pAddress.City = tbxPhysicalAddressCity.Text;

                //It should never be null but check just in case//
                pAddress.State = ddlPhysicalAddressState.SelectedValue == null ? string.Empty : ddlPhysicalAddressState.SelectedValue;
                pAddress.Zipcode = tbxPhysicalAddressZipcode.Text;
                pAddress.IsMailingAddress = false;

                //Assign physical address object to student//
                student.PhysicalAddress = pAddress;

                #endregion

                #region Mailing Address

                Address mAddress = new Address();
                mAddress.Street = tbxMailingAddressStreet.Text;
                mAddress.City = tbxMailingAddressCity.Text;

                //It should never be null but check just in case//
                mAddress.State = ddlMailingAddressState.SelectedValue == null ? string.Empty : ddlMailingAddressState.SelectedValue;
                mAddress.Zipcode = tbxMailingAddressZipcode.Text;
                mAddress.IsMailingAddress = true;

                //Assign mailing address object to student//
                student.MailingAddress = mAddress;

                #endregion

                #region Guardian #1

                Guardian guardian1 = new Guardian();
                guardian1.FirstName = tbxGuard1FirstName.Text;
                guardian1.MiddleName = tbxGuard1MiddleName.Text;
                guardian1.LastName = tbxGuard1LastName.Text;
                guardian1.Relationship = tbxGuard1Relationship.Text;
                guardian1.CellPhone = tbxGuard1CellNum.Text;
                guardian1.Employer = tbxGuard1Employer.Text;
                guardian1.Email = tbxGuard1Email.Text;
                guardian1.WorkPhone = tbxGuard1WorkNum.Text;

                //Assign guardian 1 object to student//
                student.Guardian1 = guardian1;

                #endregion

                #region Guardian #2

                Guardian guardian2 = new Guardian();
                guardian2.FirstName = tbxGuard2FirstName.Text;
                guardian2.MiddleName = tbxGuard2MiddleName.Text;
                guardian2.LastName = tbxGuard2LastName.Text;
                guardian2.Relationship = tbxGuard2Relationship.Text;
                guardian2.CellPhone = tbxGuard2CellNum.Text;
                guardian2.Employer = tbxGuard2Employer.Text;
                guardian2.Email = tbxGuard2Email.Text;
                guardian2.WorkPhone = tbxGuard2WorkNum.Text;

                //Assign guardian 2 object to student//
                student.Guardian2 = guardian2;

                #endregion

                #region Emergency Contact #1

                EmergencyContact emergencyContact1 = new EmergencyContact();
                emergencyContact1.FirstName = tbxEmergencyContact1FirstName.Text;
                emergencyContact1.MiddleName = tbxEmergencyContact1MiddleName.Text;
                emergencyContact1.LastName = tbxEmergencyContact1LastName.Text;
                emergencyContact1.Phone = tbxEmergencyContact1PhoneNum.Text;
                emergencyContact1.Relationship = tbxEmergencyContact1Relationship.Text;

                //Assign emergency contact 1 object to student//
                student.EmergencyContact1 = emergencyContact1;

                #endregion

                #region Emergency Contact #2

                EmergencyContact emergencyContact2 = new EmergencyContact();
                emergencyContact2.FirstName = tbxEmergencyContact2FirstName.Text;
                emergencyContact2.MiddleName = tbxEmergencyContact2MiddleName.Text;
                emergencyContact2.LastName = tbxEmergencyContact2LastName.Text;
                emergencyContact2.Phone = tbxEmergencyContact2PhoneNum.Text;
                emergencyContact2.Relationship = tbxEmergencyContact2Relationship.Text;

                //Assign emergency contact 2 object to student//
                student.EmergencyContact2 = emergencyContact2;

                #endregion

                #region Additional Information

                bool bHasDiagHealth;
                bool bHasIEP;
                bool bHas504;
                bool bHasAllergies;

                AdditionalInformation additionalInformation = new AdditionalInformation();

                //Validating we are returning a boolean answer//
                bool.TryParse(rblDiagHealth.SelectedValue, out bHasDiagHealth);
                additionalInformation.HaveDiagnosedHealthCondition = bHasDiagHealth;

                //Validating we are returning a boolean answer//
                bool.TryParse(rblIEP.SelectedValue, out bHasIEP);
                additionalInformation.HaveAnIEP = bHasIEP;

                //Validating we are returning a boolean answer//
                bool.TryParse(rbl504.SelectedValue, out bHas504);
                additionalInformation.HaveA504 = bHas504;

                //Validating we are returning a boolean answer//
                bool.TryParse(rblAllergies.SelectedValue, out bHasAllergies);
                additionalInformation.HaveAllergies = bHasAllergies;

                //Assign additional information object to student//
                student.AdditionalInformation = additionalInformation;


                #endregion

                #region Supporting Documents

                DocumentList documents = new DocumentList();

                if (lbLoadedDocs.Items != null && lbLoadedDocs.Items.Count > 0)
                {
                    foreach (ListItem item in lbLoadedDocs.Items)
                    {
                        Document document = new Document();
                        document.Filename = item.Text;
                        document.FilenameWithSessionID = HttpContext.Current.Session.SessionID + "_" + item.Text;
                        document.CompletePath = System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), document.FilenameWithSessionID);
                        documents.Add(document);
                    }
                }

                #endregion

                #region Create and Save CSV

                //Establish the filename and path
                string sCSVFilename = HttpContext.Current.Session.SessionID + ".csv";
                string sCSVFilePath = System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), sCSVFilename);

                //Writing the CSV file to the folder so it can be attached to the mail object
                WriteCSVToPath(sCSVFilePath, student.ReturnCSVFormat());

                //Add it as a document
                Document csvdocument = new Document(sCSVFilename, sCSVFilename, sCSVFilePath);
                documents.Add(csvdocument);

                #endregion

                #region Mail

                //Read the configuration parameters from the web.config
                string sSendEmailFrom = System.Configuration.ConfigurationManager.AppSettings["SendRegistrationFrom"];
                string sSendEmailTo = System.Configuration.ConfigurationManager.AppSettings["SendRegistrationTo"];
                string sSMTPServer = System.Configuration.ConfigurationManager.AppSettings["MailServer"];
                string sSMTPUsername = System.Configuration.ConfigurationManager.AppSettings["Username"];
                string sSMTPPassword = System.Configuration.ConfigurationManager.AppSettings["Password"];

                bool bEnableSSL = false;
                bool.TryParse(System.Configuration.ConfigurationManager.AppSettings["MailEnableSSL"], out bEnableSSL);

                int iPort = 25;
                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["MailPort"], out iPort);

                //Create new mail message
                MimeMessage mail = new MimeMessage();

                //Add the parts of who the email is sent from and sent to
                mail.From.Add(new MailboxAddress(sSendEmailFrom));
                mail.To.Add(new MailboxAddress(sSendEmailTo));

                //Add the subject
                mail.Subject = String.Format("New registration form has been received for student: {0} {1}", student.FirstName, student.LastName);

                //Use the bodybuilder class to build the body
                BodyBuilder bodyBuilder = new BodyBuilder();

                //Build the text of the body
                StringBuilder sbText = new StringBuilder();
                sbText.Append(String.Format("{0} {1} as been submitted as a new registered student for grade {2}", student.FirstName, student.LastName, student.Grade));
                sbText.Append(Environment.NewLine);
                sbText.Append(Environment.NewLine);
                sbText.Append("The attached CSV file contains all the information submitted on the registration form.");
                sbText.Append(String.Format("There are a total of {0} documents attached.", documents.Count));

                //Assign the body text
                bodyBuilder.TextBody = sbText.ToString();

                //Create the zip file that will house all the documents
                ZipArchive zip = ZipFile.Open(System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), HttpContext.Current.Session.SessionID + ".zip"), ZipArchiveMode.Create);

                //Loop through each document that was loaded
                foreach (Document oDoc in documents)
                {
                    //Add it to the zip file
                    zip.CreateEntryFromFile(oDoc.CompletePath, oDoc.Filename, CompressionLevel.Optimal);
                }

                //Free up the zip file for use later
                zip.Dispose();

                //Encrypt the zip file and add the "_enc" so we know it's encypted
                CryptoManager.EncryptFile(System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), HttpContext.Current.Session.SessionID + ".zip"), System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), HttpContext.Current.Session.SessionID + "_enc.zip"));

                //Attach it to the email
                bodyBuilder.Attachments.Add(System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), HttpContext.Current.Session.SessionID + "_enc.zip"));

                //Add the BodyBuilder parts to the body
                mail.Body = bodyBuilder.ToMessageBody();

                //Send the email using the values specified in the web.config file
                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect(sSMTPServer, iPort, bEnableSSL);
                    smtpClient.Authenticate(sSMTPUsername, sSMTPPassword);
                    smtpClient.Send(mail);
                    smtpClient.Disconnect(true);
                }

                //Loop through each document that was loaded and remove it
                foreach (Document oDoc in documents)
                {
                    File.Delete(oDoc.CompletePath);
                }

                //Clean up the zip file
                File.Delete(System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), HttpContext.Current.Session.SessionID + ".zip"));

                //Clean up the encrypted file
                File.Delete(System.IO.Path.Combine(Server.MapPath("~/UploadedDocs/"), HttpContext.Current.Session.SessionID + "_enc.zip"));

                #endregion

                Response.Redirect("Submission.aspx");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// This method is used to write the CSV file locally so it can be attached to the email
        /// </summary>
        /// <param name="sPath"></param>
        /// <param name="sContent"></param>
        private void WriteCSVToPath(string sPath, string sContent)
        {
            //Check if a file already exists
            if (File.Exists(sPath))
            {
                //If it does, remove it so we can start clean
                File.Delete(sPath);
            }

            using (StreamWriter sw = File.CreateText(sPath))
            {
                sw.Write(sContent);
            }
        }

        #endregion

    }
}