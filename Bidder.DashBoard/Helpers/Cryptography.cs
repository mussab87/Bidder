using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bidder.DashBoard.Helpers
{
    public class Cryptography
    {
        public static string EncryptPassword(string stringToEncrypt, string key)
        {
            if (string.IsNullOrEmpty(key) || key.Length == 0)
            {
                if (string.IsNullOrEmpty(key))
                    key = "Bidder_Full";
                key = key.ToUpper().Replace("Bidder_", "");
            }

            //SSTCryptographer SSTCryptographer = new SSTCryptographer();
            return SSTCryptographer.Encrypt(stringToEncrypt, key);
        }

        public static string DecryptPassword(string stringToDecrypt, string key)
        {
            if (string.IsNullOrEmpty(key) || key.Length == 0)
            {
                // key = MS.General.Parse(ConnectionString, "Database");
                if (key == "")
                    key = "Bidder_Full";
                key = key.ToUpper().Replace("Bidder_", "");
            }

            var sstCryptographer = new SSTCryptographer();
            return SSTCryptographer.Decrypt(stringToDecrypt, key);
        }
    }


    internal class SSTCryptographer
    {
        private static string _key;

        public static string Key
        {
            set => _key = value;
        }

        //' <summary>
        //' Encrypt the given string using the default key.
        //' </summary>
        //' <param name="strToEncrypt">The string to be encrypted.</param>
        //' <returns>The encrypted string.</returns>
        public static string Encrypt(string strToEncrypt)
        {
            try
            {
                return Encrypt(strToEncrypt, _key);
            }
            catch (Exception ex)
            {
                return "Wrong Input. " + ex.Message;
            }
        }

        /// <summary>
        ///     Decrypt the given string using the default key.
        /// </summary>
        /// <param name="strEncrypted">The string to be decrypted.</param>
        /// <returns>The decrypted string.</returns>
        public static string Decrypt(string strEncrypted)
        {
            try
            {
                return Decrypt(strEncrypted, _key);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        ///     Encrypt the given string using the specified key.
        /// </summary>
        /// <param name="strToEncrypt">The string to be encrypted.</param>
        /// <param name="strKey">The encryption key.</param>
        /// <returns>The encrypted string.</returns>
        public static string Encrypt(string strToEncrypt, string strKey)
        {
            try
            {
                var objDesCrypto = new TripleDESCryptoServiceProvider();
                var objHashMd5 = new MD5CryptoServiceProvider();

                byte[] byteHash = null;
                byte[] byteBuff = null;
                var strTempKey = strKey;

                byteHash = objHashMd5.ComputeHash(Encoding.ASCII.GetBytes(strTempKey));
                objHashMd5 = null;
                objDesCrypto.Key = byteHash;
                objDesCrypto.Mode = CipherMode.ECB;
                //CBC, CFB
                byteBuff = Encoding.ASCII.GetBytes(strToEncrypt);
                return Convert.ToBase64String(objDesCrypto.CreateEncryptor()
                    .TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        /// <summary>
        ///     Decrypt the given string using the specified key.
        /// </summary>
        /// <param name="strEncrypted">The string to be decrypted.</param>
        /// <param name="strKey">The decryption key.</param>
        /// <returns>The decrypted string.</returns>
        public static string Decrypt123(string strEncrypted, string strKey)
        {
            try
            {
                var objDesCrypto = new TripleDESCryptoServiceProvider();
                var objHashMd5 = new MD5CryptoServiceProvider();

                byte[] byteHash = null;
                byte[] byteBuff = null;
                var strTempKey = strKey;

                byteHash = objHashMd5.ComputeHash(Encoding.ASCII.GetBytes(strTempKey));
                objHashMd5 = null;
                objDesCrypto.Key = byteHash;
                objDesCrypto.Mode = CipherMode.ECB;
                //CBC, CFB

                byteBuff = Encoding.ASCII.GetBytes(strEncrypted);

                var encoding = new ASCIIEncoding();
                byteBuff = encoding.GetBytes(strEncrypted);


                var strDecrypted = Encoding.ASCII.GetString(objDesCrypto.CreateDecryptor()
                    .TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                objDesCrypto = null;

                return strDecrypted;
            }
            catch (Exception ex)
            {
                return "Wrong Input. " + ex.Message;
            }
        }

        public static string Decrypt(string toDecrypt, string key)
        {
            byte[] keyArray = null;
            var toEncryptArray = Convert.FromBase64String(toDecrypt);

            var md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            keyArray = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(key));

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            var cTransform = tdes.CreateDecryptor();
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }
    }
}
