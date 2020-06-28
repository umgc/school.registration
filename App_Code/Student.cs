using EDUnited.Attributes;
using EDUnited.Base_Classes;
using System;
using System.Text;

namespace EDUnited
{
    /// <summary>
    /// Summary description for Student
    /// </summary>
    [Serializable()]
    public class Student : People
    {
        #region Members

        private string sGender = String.Empty;
        private string sBirthPlace = String.Empty;
        private string sGrade = String.Empty;
        private Ethnicity oEthnicity;
        private PrimaryLanguage oPrimaryLanguage;
        private Address oPhysicalAddress;
        private Address oMailingAddress;
        private Guardian oGuardian1;
        private Guardian oGuardian2;
        private EmergencyContact oEmergencyContact1;
        private EmergencyContact oEmergencyContact2;
        private AdditionalInformation oAdditionalInfo;

        #endregion

        #region Constructors

        public Student() : base() { }

        public Student(string sFirstName, string sMiddleName, string sLastName) : base(sFirstName, sMiddleName, sLastName) 
        {
            oEthnicity = new Ethnicity();
            oPrimaryLanguage = new PrimaryLanguage();
            oPhysicalAddress = new Address();
            oMailingAddress = new Address();
            oGuardian1 = new Guardian();
            oGuardian2 = new Guardian();
            oEmergencyContact1 = new EmergencyContact();
            oEmergencyContact2 = new EmergencyContact();
            oAdditionalInfo = new AdditionalInformation();
        }
        public Student(string sFirstName, string sMiddleName, string sLastName, string sGender, string sBirthPlace, string sGrade,
            Ethnicity oEthnicity, PrimaryLanguage oPrimaryLanguage, Address oPhysicalAddress, Address oMailingAddress, Guardian oGuardian1, Guardian oGuardian2,
            EmergencyContact oEmergencyContact1, EmergencyContact oEmergencyContact2, AdditionalInformation oAdditionalInfo) : base(sFirstName, sMiddleName, sLastName)
        {
            Gender = sGender;
            BirthPlace = sBirthPlace;
            Grade = sGrade;
            Ethnicity = oEthnicity;
            PrimaryLanguage = oPrimaryLanguage;
            PhysicalAddress = oPhysicalAddress;
            MailingAddress = oMailingAddress;
            Guardian1 = oGuardian1;
            Guardian2 = oGuardian2;
            EmergencyContact1 = oEmergencyContact1;
            EmergencyContact2 = oEmergencyContact2;
            AdditionalInformation = oAdditionalInfo;
        }

        #endregion

        #region Properties

        [Description("Gender")]
        public string Gender
        {
            get { return sGender; }
            set { sGender = value; }
        }

        [Description("Birth Place")]
        public string BirthPlace
        {
            get { return sBirthPlace; }
            set { sBirthPlace = value; }
        }

        [Description("Grade")]
        public string Grade
        {
            get { return sGrade; }
            set { sGrade = value; }
        }

        [Description("Ethnicity")]
        public Ethnicity Ethnicity
        {
            get { return oEthnicity; }
            set { oEthnicity = value; }
        }

        [Description("Primary Language")]
        public PrimaryLanguage PrimaryLanguage
        {
            get { return oPrimaryLanguage; }
            set { oPrimaryLanguage = value; }
        }

        [Description("Physical Address")]
        public Address PhysicalAddress
        {
            get { return oPhysicalAddress; }
            set { oPhysicalAddress = value; }
        }

        [Description("Mailing Address")]
        public Address MailingAddress
        {
            get { return oMailingAddress; }
            set { oMailingAddress = value; }
        }

        [Description("Guardian 1")]
        public Guardian Guardian1
        {
            get { return oGuardian1; }
            set { oGuardian1 = value; }
        }

        [Description("Guardian 2")]
        public Guardian Guardian2
        {
            get { return oGuardian2; }
            set { oGuardian2 = value; }
        }

        [Description("Emergency Contact 1")]
        public EmergencyContact EmergencyContact1
        {
            get { return oEmergencyContact1; }
            set { oEmergencyContact1 = value; }
        }

        [Description("Emergency Contact 2")]
        public EmergencyContact EmergencyContact2
        {
            get { return oEmergencyContact2; }
            set { oEmergencyContact2 = value; }
        }

        [Description("Additional Info")]
        public AdditionalInformation AdditionalInformation
        {
            get { return oAdditionalInfo; }
            set { oAdditionalInfo = value; }
        }

        #endregion

        #region Methods

        public StringBuilder ReturnCSVFormat() 
        {
            StringBuilder sb = new StringBuilder();

            return sb;
        }

        #endregion
    }
}