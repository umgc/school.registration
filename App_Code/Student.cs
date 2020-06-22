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
        private string sEthnicity = String.Empty;
        private string sPrimaryLanguage = String.Empty;

        #endregion

        #region Constructors

        public Student() : base() { }

        public Student(string sFirstName, string sMiddleName, string sLastName) : base(sFirstName, sMiddleName, sLastName) {  }
        public Student(string sFirstName, string sMiddleName, string sLastName, string sGender, string sBirthPlace, string sEthnicity, string sPrimaryLanguage) : base(sFirstName, sMiddleName, sLastName)
        {
            Gender = sGender;
            BirthPlace = sBirthPlace;
            Ethnicity = sEthnicity;
            PrimaryLanguage = sPrimaryLanguage;
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
        public string Ethnicity
        {
            get { return sEthnicity; }
            set { sEthnicity = value; }
        }

        [Description("Primary Language")]
        public string PrimaryLanguage
        {
            get { return sPrimaryLanguage; }
            set { sPrimaryLanguage = value; }
        }

        #endregion
    }
}