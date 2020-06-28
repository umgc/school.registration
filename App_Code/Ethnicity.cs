using EDUnited.Attributes;
using System;

namespace EDUnited
{
    /// <summary>
    /// Summary description for Ethnicity
    /// </summary>
    [Serializable()]
    public class Ethnicity
    {
        #region Members

        private string sRace = String.Empty;
        private bool bIsHispanic = false;

        #endregion

        #region Constructors

        public Ethnicity() { }

        public Ethnicity(string sRace, bool bIsHispanic) 
        {
            Race = sRace;
            IsHispanic = bIsHispanic;
        }

        #endregion

        #region Properties

        [Description("Race")]
        public string Race
        {
            get { return sRace; }
            set { sRace = value; }
        }

        [Description("Is Hispanic")]
        public bool IsHispanic
        {
            get { return bIsHispanic; }
            set { bIsHispanic = value; }
        }        

        #endregion
    }
}