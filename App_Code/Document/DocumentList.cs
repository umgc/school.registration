using System;
using System.Collections;
using System.Collections.Generic;

namespace EDUnited.Documents
{
    /// <summary>
    /// Summary description for DocumentList
    /// </summary>
    [Serializable()]
    public class DocumentList : List<Document>
    {
        #region Members

        private ArrayList alDocuments = null;

        #endregion

        #region Constructors

        public DocumentList()
        {
            alDocuments = new ArrayList();
        }

        #endregion

        #region Methods

        public Document FindByFileName(string sFileName)
        {
            foreach (Document oDoc in this)
            {
                if (oDoc.Filename == sFileName)
                {
                    return oDoc;
                }
            }

            return null;
        }

        public void RemoveByFileName(string sFileName)
        {
            foreach (Document oDoc in this)
            {
                if (oDoc.Filename == sFileName)
                {
                    //Remove them from this list.
                    Remove(oDoc);
                    break;
                }
            }
        }

        public Document FindByFilenameWithSessionID(string sFilenameWithSessionID)
        {
            foreach (Document oDoc in this)
            {
                if (oDoc.FilenameWithSessionID == sFilenameWithSessionID)
                {
                    return oDoc;
                }
            }

            return null;
        }

        public void RemoveByFilenameWithSessionID(string sFilenameWithSessionID)
        {
            foreach (Document oDoc in this)
            {
                if (oDoc.FilenameWithSessionID == sFilenameWithSessionID)
                {
                    //Remove them from this list.
                    Remove(oDoc);
                    break;
                }
            }
        }

        #endregion

        #region Properties

        public ArrayList Documents
        {
            get { return alDocuments; }
        }

        #endregion
    }
}
