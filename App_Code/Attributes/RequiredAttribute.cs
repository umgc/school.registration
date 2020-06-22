using System;

namespace EDUnited.App_Code.Attributes
{
    /// <summary>
    /// Summary description for RequiredAttribute.
    /// </summary>
    public class RequiredAttribute : Attribute
    {
        #region Fields

        private bool mbRequired = false;

        #endregion

        #region Constructors

        public RequiredAttribute(bool bRequired)
        {
            mbRequired = bRequired;
        }

        #endregion

        #region Properties

        public bool Required
        {
            get { return mbRequired; }
            set { mbRequired = value; }
        }

        #endregion
    }
}