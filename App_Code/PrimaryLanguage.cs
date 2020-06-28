using EDUnited.Attributes;
using System;

namespace EDUnited
{
    /// <summary>
    /// Summary description for PrimaryLanguage
    /// </summary>
    [Serializable()]
    public class PrimaryLanguage
    {
        #region Members

        private string sSpokenInHome = String.Empty;
        private string sSpokenByChild = String.Empty;

        #endregion

        #region Constructors

        public PrimaryLanguage() { }

        public PrimaryLanguage(string sSpokenInHome, string sSpokenByChild) 
        {
            SpokenInHome = sSpokenInHome;
            SpokenByChild = sSpokenByChild;
        }

        #endregion

        #region Properties

        [Description("SpokenInHome")]
        public string SpokenInHome
        {
            get { return sSpokenInHome; }
            set { sSpokenInHome = value; }
        }

        [Description("SpokenByChild")]
        public string SpokenByChild
        {
            get { return sSpokenByChild; }
            set { sSpokenByChild = value; }
        }        

        #endregion
    }
}