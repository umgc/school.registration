using EDUnited.Documents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;
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
            primaryLanguage.SpokenByChild = ddlLanguageSpokenByChild.SelectedValue == null ? string.Empty : ddlLanguageSpokenByChild.SelectedValue;

            //It should never be null but check just in case//
            primaryLanguage.SpokenInHome = ddlLanguageSpokenInHome.SelectedValue == null ? string.Empty : ddlLanguageSpokenInHome.SelectedValue;

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

            //TODO: Finish mailing class
            Mail mail = new Mail();

            mail.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["SendRegistrationFrom"]);
            mail.To.Add(new MailAddress(System.Configuration.ConfigurationManager.AppSettings["SendRegistrationTo"]));
            mail.Subject = String.Format("New registration form has been received for student: {0} {1}", student.FirstName, student.LastName);

            StringBuilder sbText = new StringBuilder();
            sbText.Append(String.Format("{0} {1} as been submitted as a new registered student for grade {2}", student.FirstName, student.LastName, student.Grade));
            sbText.Append(Environment.NewLine);
            sbText.Append(Environment.NewLine);
            sbText.Append("The attached CSV file contains all the information submitted on the registration form.");
            sbText.Append(String.Format("There are a total of {0} documents attached.", documents.Count));

            mail.Body = sbText.ToString();

            mail.AddAttachments(documents);

            EmailManager.SendEmail(mail, System.Configuration.ConfigurationManager.AppSettings["MailServer"]);


            #endregion

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