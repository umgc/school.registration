using EDUnited.Attributes;
using System;

namespace EDUnited.Base_Classes
{
    /// <summary>
    /// Summary description for People
    /// </summary>
    [Serializable()]
    public class People
    {
        #region Members

        private string sFirstName = String.Empty;
        private string sMiddleName = String.Empty;
        private string sLastName = String.Empty;

        #endregion

        #region Constructors

        public People() { }
        public People(string sFirstName, string sMiddleName, string sLastName)
        {
            FirstName = sFirstName;
            MiddleName = sMiddleName;
            LastName = sLastName;
        }

        #endregion

        #region Properties

        [Description("First Name")]
        public string FirstName
        {
            get { return sFirstName; }
            set { sFirstName = value; }
        }

        [Description("Middle Name")]
        public string MiddleName
        {
            get { return sMiddleName; }
            set { sMiddleName = value; }
        }

        [Description("Last Name")]
        public string LastName
        {
            get { return sLastName; }
            set { sLastName = value; }
        }

        #endregion
    }
}