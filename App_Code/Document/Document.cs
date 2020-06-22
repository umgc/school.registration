using EDUnited.App_Code.Attributes;
using System;

namespace EDUnited.App_Code.Documents
{
    /// <summary>
    /// Summary description for Document
    /// </summary>
    [Serializable()]
    public class Document
    {
        #region Members

        private string sSessionFilename = String.Empty;
        private string sFilename = String.Empty;

        #endregion

        #region Constructors

        public Document() { }

        public Document(string sSessionFilename, string sFilename)  
        {
            FilenameWithSessionID = sSessionFilename;
            Filename = sFilename;
        }

        #endregion

        #region Properties       

        [Description("Filename")]
        public string Filename
        {
            get { return sFilename; }
            set { sFilename = value; }
        }

        [Description("Filename with Session ID")]
        public string FilenameWithSessionID
        {
            get { return sSessionFilename; }
            set { sSessionFilename = value; }
        }

        #endregion

    }
}
