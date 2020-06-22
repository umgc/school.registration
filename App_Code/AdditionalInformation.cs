using EDUnited.App_Code.Attributes;
using System;

namespace EDUnited.App_Code
{
    /// <summary>
    /// Summary description for AdditionalInformation 
    /// </summary>
    [Serializable()]
    public class AdditionalInformation
    {
        #region Members

        private bool bHaveDiagnosedHealthCondition = false;
        private string sDiagnosedHealthConditionDescription = String.Empty;
        private bool bHaveAnIEP = false;
        private bool bHaveA504 = false;
        private bool bHaveAllergies = false;

        #endregion

        #region Constructors

        public AdditionalInformation() { }

        public AdditionalInformation(bool bHaveDiagnosedHealthCondition, string sDiagnosedHealthConditionDescription, bool bHaveAnIEP, bool bHaveA504, bool bHaveAllergies) 
        {
            HaveDiagnosedHealthCondition = bHaveDiagnosedHealthCondition;
            DiagnosedHealthConditionDescription = sDiagnosedHealthConditionDescription;
            HaveAnIEP = bHaveAnIEP;
            HaveA504 = bHaveA504;
            HaveAllergies = bHaveAllergies;
        }

        #endregion

        #region Properties

        [Description("Have Diagnosed Health Condition")]
        public bool HaveDiagnosedHealthCondition
        {
            get { return bHaveDiagnosedHealthCondition; }
            set { bHaveDiagnosedHealthCondition = value; }
        }

        [Description("Diagnosed Health Condition Description")]
        public string DiagnosedHealthConditionDescription
        {
            get { return sDiagnosedHealthConditionDescription; }
            set { sDiagnosedHealthConditionDescription = value; }
        }

        [Description("Have An IEP")]
        public bool HaveAnIEP
        {
            get { return bHaveAnIEP; }
            set { bHaveAnIEP = value; }
        }

        [Description("Have A 504")]
        public bool HaveA504
        {
            get { return bHaveA504; }
            set { bHaveA504 = value; }
        }

        [Description("Have Allergies")]
        public bool HaveAllergies
        {
            get { return bHaveAllergies; }
            set { bHaveAllergies = value; }
        }

        #endregion
    }
}