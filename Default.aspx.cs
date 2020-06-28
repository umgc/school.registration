using EDUnited.Documents;
using System;
using System.Collections.Generic;
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

            #endregion

            #region Mailing Address

            Address mAddress = new Address();
            mAddress.Street = tbxMailingAddressStreet.Text;
            mAddress.City = tbxMailingAddressCity.Text;

            //It should never be null but check just in case//
            mAddress.State = ddlMailingAddressState.SelectedValue == null ? string.Empty : ddlMailingAddressState.SelectedValue;
            mAddress.Zipcode = tbxMailingAddressZipcode.Text;

            #endregion

            #region Guardian #1

            Guardian guardian1 = new Guardian();
            guardian1.FirstName = tbxGuard1FirstName.Text;
            guardian1.MiddleName = tbxGuard1MiddleName.Text;
            guardian1.LastName = tbxGuard1LastName.Text;
            guardian1.CellPhone = tbxGuard1CellNum.Text;
            guardian1.Employer = tbxGuard1Employer.Text;
            guardian1.Email = tbxGuard1Email.Text;
            guardian1.WorkPhone = tbxGuard1WorkNum.Text;

            #endregion

            #region Guardian #2

            Guardian guardian2 = new Guardian();
            guardian2.FirstName = tbxGuard2FirstName.Text;
            guardian2.MiddleName = tbxGuard2MiddleName.Text;
            guardian2.LastName = tbxGuard2LastName.Text;
            guardian2.CellPhone = tbxGuard2CellNum.Text;
            guardian2.Employer = tbxGuard2Employer.Text;
            guardian2.Email = tbxGuard2Email.Text;
            guardian2.WorkPhone = tbxGuard2WorkNum.Text;

            #endregion

            #region Emergency Contact #1

            EmergencyContact emergencyContact1 = new EmergencyContact();
            emergencyContact1.FirstName = tbxEmergencyContact1FirstName.Text;
            emergencyContact1.MiddleName = tbxEmergencyContact1MiddleName.Text;
            emergencyContact1.LastName = tbxEmergencyContact1LastName.Text;
            emergencyContact1.Phone = tbxEmergencyContact1PhoneNum.Text;
            emergencyContact1.Relationship = tbxEmergencyContact1Relationship.Text;

            #endregion

            #region Emergency Contact #2

            EmergencyContact emergencyContact2 = new EmergencyContact();
            emergencyContact2.FirstName = tbxEmergencyContact2FirstName.Text;
            emergencyContact2.MiddleName = tbxEmergencyContact2MiddleName.Text;
            emergencyContact2.LastName = tbxEmergencyContact2LastName.Text;
            emergencyContact2.Phone = tbxEmergencyContact2PhoneNum.Text;
            emergencyContact2.Relationship = tbxEmergencyContact2Relationship.Text;

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

            #region Mail

            //TODO: Finish mailing class
            Mail mail = new Mail();


            #endregion

        }

        #endregion

    }
}