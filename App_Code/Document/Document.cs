using EDUnited.Attributes;
using System;

namespace EDUnited.Documents
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
        private string sCompletePath = String.Empty;

        #endregion

        #region Constructors

        public Document() { }

        public Document(string sSessionFilename, string sFilename, string sCompletePath)  
        {
            FilenameWithSessionID = sSessionFilename;
            Filename = sFilename;
            CompletePath = sCompletePath;
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

        [Description("Complete Path")]
        public string CompletePath
        {
            get { return sCompletePath; }
            set { sCompletePath = value; }
        }

        #endregion

    }
}
