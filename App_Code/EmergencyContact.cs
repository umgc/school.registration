using EDUnited.App_Code.Attributes;
using EDUnited.App_Code.Base_Classes;
using System;

namespace EDUnited.App_Code
{
    /// <summary>
    /// Summary description for EmergencyContact
    /// </summary>
    [Serializable()]
    public class EmergencyContact : People
    {
        #region Members

        private string sPhone = String.Empty;
        private string sRelationship = String.Empty;

        #endregion

        #region Constructors

        public EmergencyContact() : base() { }

        public EmergencyContact(string sFirstName, string sMiddleName, string sLastName) : base(sFirstName, sMiddleName, sLastName) {  }
        public EmergencyContact(string sFirstName, string sMiddleName, string sLastName, string sPhone, string sRelationship) : base(sFirstName, sMiddleName, sLastName)
        {
            Phone = sPhone;
            Relationship = sRelationship;
        }

        #endregion

        #region Properties

        [Description("Phone")]
        public string Phone
        {
            get { return sPhone; }
            set { sPhone = value; }
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