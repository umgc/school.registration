using EDUnited.App_Code.Attributes;
using EDUnited.App_Code.Base_Classes;
using System;

namespace EDUnited.App_Code
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
        private Ethnicity oEthnicity;
        private PrimaryLanguage oPrimaryLanguage;

        #endregion

        #region Constructors

        public Student() : base() { }

        public Student(string sFirstName, string sMiddleName, string sLastName) : base(sFirstName, sMiddleName, sLastName) 
        {
            oEthnicity = new Ethnicity();
            oPrimaryLanguage = new PrimaryLanguage();
        }
        public Student(string sFirstName, string sMiddleName, string sLastName, string sGender, string sBirthPlace, Ethnicity oEthnicity, PrimaryLanguage oPrimaryLanguage) : base(sFirstName, sMiddleName, sLastName)
        {
            Gender = sGender;
            BirthPlace = sBirthPlace;
            Ethnicity = oEthnicity;
            PrimaryLanguage = oPrimaryLanguage;
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

        #endregion
    }
}