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
        private string sDOB = String.Empty;
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
        public Student(string sFirstName, string sMiddleName, string sLastName, string sGender, string sBirthPlace, string sGrade, string sDOB,
            Ethnicity oEthnicity, PrimaryLanguage oPrimaryLanguage, Address oPhysicalAddress, Address oMailingAddress, Guardian oGuardian1, Guardian oGuardian2,
            EmergencyContact oEmergencyContact1, EmergencyContact oEmergencyContact2, AdditionalInformation oAdditionalInfo) : base(sFirstName, sMiddleName, sLastName)
        {
            Gender = sGender;
            BirthPlace = sBirthPlace;
            Grade = sGrade;
            DOB = sDOB;
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

        [Description("DOB")]
        public string DOB
        {
            get { return sDOB; }
            set { sDOB = value; }
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

        /// <summary>
        /// Turn the student object and it's other objects into a CSV file
        /// </summary>
        /// <returns>String that contains the CSV format of the student object</returns>
        public string ReturnCSVFormat() 
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("First Name,Middle Name,Last Name,Gender,Birthplace,DOB,Race,IsHispanic,SpokenInHome,SpokenByStudent,PhysicalAddrStreet,PhysicalAddrCity,PhysicalAddrState,PhysicalAddrZip,MailingAddrStreet,MailingAddrCity,MailingAddrState,MailingAddrZip,Guardian1FirstName,Guardian1MiddleName,Guardian1LastName,Guardian1CellPhone,Guardian1Employer,Guardian1WorkPhone,Guardian1Email,Guardian1Relationship,Guardian2FirstName,Guardian2MiddleName,Guardian2LastName,Guardian2CellPhone,Guardian2Employer,Guardian2WorkPhone,Guardian2Email,Guardian2Relationship,Emergency1FirstName,Emergency1MiddleName,Emergency1LastName,Emergency1Phone,Emergency1Relationship,Emergency2FirstName,Emergency2MiddleName,Emergency2LastName,Emergency2Phone,Emergency2Relationship,Diagnosed Health Condition,Description,IEP,504,Allergies");
            sb.Append(Environment.NewLine);
            sb.Append(this.FirstName);
            sb.Append(",");
            sb.Append(this.MiddleName);
            sb.Append(",");
            sb.Append(this.LastName);
            sb.Append(",");
            sb.Append(this.Gender);
            sb.Append(",");
            sb.Append(this.BirthPlace);
            sb.Append(",");
            sb.Append(this.DOB);
            sb.Append(",");
            sb.Append(this.Ethnicity.Race);
            sb.Append(",");
            sb.Append(this.Ethnicity.IsHispanic);
            sb.Append(",");
            sb.Append(this.PrimaryLanguage.SpokenInHome);
            sb.Append(",");
            sb.Append(this.PrimaryLanguage.SpokenByChild);
            sb.Append(",");
            sb.Append(this.PhysicalAddress.Street);
            sb.Append(",");
            sb.Append(this.PhysicalAddress.City);
            sb.Append(",");
            sb.Append(this.PhysicalAddress.State);
            sb.Append(",");
            sb.Append(this.PhysicalAddress.Zipcode);
            sb.Append(",");
            sb.Append(this.MailingAddress.Street);
            sb.Append(",");
            sb.Append(this.MailingAddress.City);
            sb.Append(",");
            sb.Append(this.MailingAddress.State);
            sb.Append(",");
            sb.Append(this.MailingAddress.Zipcode);
            sb.Append(",");
            sb.Append(this.Guardian1.FirstName);
            sb.Append(",");
            sb.Append(this.Guardian1.MiddleName);
            sb.Append(",");
            sb.Append(this.Guardian1.LastName);
            sb.Append(",");
            sb.Append(this.Guardian1.CellPhone);
            sb.Append(",");
            sb.Append(this.Guardian1.Employer);
            sb.Append(",");
            sb.Append(this.Guardian1.WorkPhone);
            sb.Append(",");
            sb.Append(this.Guardian1.Email);
            sb.Append(",");
            sb.Append(this.Guardian1.Relationship);
            sb.Append(",");
            sb.Append(this.Guardian2.FirstName);
            sb.Append(",");
            sb.Append(this.Guardian2.MiddleName);
            sb.Append(",");
            sb.Append(this.Guardian2.LastName);
            sb.Append(",");
            sb.Append(this.Guardian2.CellPhone);
            sb.Append(",");
            sb.Append(this.Guardian2.Employer);
            sb.Append(",");
            sb.Append(this.Guardian2.WorkPhone);
            sb.Append(",");
            sb.Append(this.Guardian2.Email);
            sb.Append(",");
            sb.Append(this.Guardian2.Relationship);
            sb.Append(",");
            sb.Append(this.EmergencyContact1.FirstName);
            sb.Append(",");
            sb.Append(this.EmergencyContact1.MiddleName);
            sb.Append(",");
            sb.Append(this.EmergencyContact1.LastName);
            sb.Append(",");
            sb.Append(this.EmergencyContact1.Phone);
            sb.Append(",");
            sb.Append(this.EmergencyContact1.Relationship);
            sb.Append(",");
            sb.Append(this.EmergencyContact2.FirstName);
            sb.Append(",");
            sb.Append(this.EmergencyContact2.MiddleName);
            sb.Append(",");
            sb.Append(this.EmergencyContact2.LastName);
            sb.Append(",");
            sb.Append(this.EmergencyContact2.Phone);
            sb.Append(",");
            sb.Append(this.EmergencyContact2.Relationship);
            sb.Append(",");
            sb.Append(this.AdditionalInformation.HaveDiagnosedHealthCondition);
            sb.Append(",");
            sb.Append(this.AdditionalInformation.DiagnosedHealthConditionDescription);
            sb.Append(",");
            sb.Append(this.AdditionalInformation.HaveAnIEP);
            sb.Append(",");
            sb.Append(this.AdditionalInformation.HaveA504);
            sb.Append(",");
            sb.Append(this.AdditionalInformation.HaveAllergies);

            return sb.ToString();
        }

        #endregion
    }
}