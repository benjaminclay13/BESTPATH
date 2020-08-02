using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.IO;
using System.Web.Security;
using System.Net;
using System.Data.SqlClient;
using System.Net.Security;
using System.Data;
using System.Collections;
using System.Security.Cryptography;

namespace BESTPATH
{
    public class Encryption
    {
        private string errorMessage;

        private string MasterKey = "masked for privacy";

        private string MasterIV = "masked for privacy";

        public string getErrorMessage()
        {
            return this.errorMessage;

        }//end property

        public void setErrorMessage(string ErrorMessage)
        {
            this.errorMessage = ErrorMessage;

        }//end property

        public string getMasterKey()
        {
            return this.MasterKey;

        }//end property

        public string getMasterIV()
        {
            return this.MasterIV;

        }//end property

        public Encryption()
        {
            this.errorMessage = null;

        }//end constructor

        public static byte[] GetMasterIV()
        {
            Encryption encryptionObject = new Encryption();

            string AesIVString = encryptionObject.getMasterIV();

            byte[] AesIV = Convert.FromBase64String(AesIVString);

            return AesIV;

        }//end method

        public static byte[] GetMasterKey()
        {
            Encryption encryptionObject = new Encryption();

            string AesKeyString = encryptionObject.getMasterKey();

            byte[] AesKey = Convert.FromBase64String(AesKeyString);

            return AesKey;

        }//end method

        public static byte[] Encrypt_AES(string plainText, byte[] Key, byte[] IV)
        {
                if (plainText == null || plainText.Length <= 0)
                    throw new ArgumentNullException("plainText");

                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");

                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("Key");

                byte[] encrypted;

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);

                            }//end using

                            encrypted = msEncrypt.ToArray();

                        }//end using

                    }//end using

                }//end using

                return encrypted;

        }//end method

        public static string Decrypt_AES(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");

            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");

            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();

                        }//end using

                    }//end using

                }//end using

            }//end using

            return plaintext;

        }//end method

    }//end class

}//end namespace