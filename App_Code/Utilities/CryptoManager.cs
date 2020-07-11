using System.IO;
using System.Security.Cryptography;

namespace EDUnited
{
    /// <summary>
    /// Summary description for CryptoManager.
    /// </summary>
    public class CryptoManager
    {
        #region Static Fields

        private static RijndaelManaged oCrypt;

        private static byte[] byteIv = new byte[] {0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 
										  0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08};
        private static byte[] byteKey = new byte[] {0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 
										   0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 
										   0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 
										   0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08};

        #endregion

        #region Constructors

        static CryptoManager()
        {
            oCrypt = new RijndaelManaged();
            oCrypt.IV = byteIv;
            oCrypt.Key = byteKey;
        }

        #endregion

        #region Methods

        public static void EncryptFile(string inputFile, string outputFile)
        {
            using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
            {
                using (ICryptoTransform encryptor = oCrypt.CreateEncryptor())
                {
                    using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                        {
                            int data;
                            while ((data = fsIn.ReadByte()) != -1)
                            {
                                cs.WriteByte((byte)data);
                            }
                        }
                    }
                }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile)
        {
            using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
            {
                using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                {
                    using (ICryptoTransform decryptor = oCrypt.CreateDecryptor())
                    {
                        using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                        {
                            int data;
                            while ((data = cs.ReadByte()) != -1)
                            {
                                fsOut.WriteByte((byte)data);
                            }
                        }
                    }
                }
            }

        }

        #endregion

    }
}

