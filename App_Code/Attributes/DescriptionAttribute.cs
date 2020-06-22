using System;

namespace EDUnited.App_Code.Attributes
{
    /// <summary>
    /// Summary description for DescriptionAttribute.
    /// </summary>
    public class DescriptionAttribute : Attribute
    {
        #region Fields

        private string msDescription = String.Empty;

        #endregion

        #region Constructors

        public DescriptionAttribute(string sDescription)
        {
            msDescription = sDescription;
        }

        #endregion

        #region Properties

        public string Description
        {
            get { return msDescription; }
            set { msDescription = value; }
        }

        #endregion
    }
}