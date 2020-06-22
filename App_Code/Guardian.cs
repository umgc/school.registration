using EDUnited.App_Code.Attributes;
using EDUnited.App_Code.Base_Classes;
using System;

namespace EDUnited.App_Code
{
    /// <summary>
    /// Summary description for Guardian
    /// </summary>
    [Serializable()]
    public class Guardian : People
    {
        #region Members

        private string sCellPhone = String.Empty;
        private string sEmployer = String.Empty;
        private string sWorkPhone = String.Empty;
        private string sEmail = String.Empty;
        private string sRelationship = String.Empty;

        #endregion

        #region Constructors

        public Guardian() : base() { }

        public Guardian(string sFirstName, string sMiddleName, string sLastName) : base(sFirstName, sMiddleName, sLastName) {  }
        public Guardian(string sFirstName, string sMiddleName, string sLastName, string sCellPhone, string sEmployer, string sWorkPhone, string sEmail, string sRelationship) : base(sFirstName, sMiddleName, sLastName)
        {
            CellPhone = sCellPhone;
            Employer = sEmployer;
            WorkPhone = sWorkPhone;
            Email = sEmail;
            Relationship = sRelationship;
        }

        #endregion

        #region Properties

        [Description("Cell Phone")]
        public string CellPhone
        {
            get { return sCellPhone; }
            set { sCellPhone = value; }
        }

        [Description("Employer")]
        public string Employer
        {
            get { return sEmployer; }
            set { sEmployer = value; }
        }

        [Description("WorkPhone")]
        public string WorkPhone
        {
            get { return sWorkPhone; }
            set { sWorkPhone = value; }
        }

        [Description("Email")]
        public string Email
        {
            get { return sEmail; }
            set { sEmail = value; }
        }

        [Description("Relationship")]
        public string Relationship
        {
            get { return sRelationship; }
            set { sRelationship = value; }
        }

        #endregion
    }
}