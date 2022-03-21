using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyApplication.Core
{
    public class Cryptography
    {
        private readonly byte[] sal;

        public Cryptography()
        {
            sal = new byte[] { 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x5, 0x4, 0x3, 0x2, 0x1, 0x0 };
        }

        public string Encrypt(string key, string text)
        {
            try
            {
                if (IsParametersValid(key, text))
                {
                    var innerKey = new Rfc2898DeriveBytes(key, sal);

                    var algorithm = new RijndaelManaged();

                    algorithm.Key = innerKey.GetBytes(16);
                    algorithm.IV = innerKey.GetBytes(16);

                    var textBytes = new UnicodeEncoding().GetBytes(text);

                    var sourceStream = new MemoryStream(textBytes);
                    var targetStream = new MemoryStream();

                    var crypto = new CryptoStream(sourceStream, algorithm.CreateEncryptor(), CryptoStreamMode.Read);

                    #region Move bytes
                    byte[] bytes = new byte[2049];
                    var counter = crypto.Read(bytes, 0, bytes.Length - 1);

                    while (0 != counter)
                    {
                        targetStream.Write(bytes, 0, counter);
                        counter = crypto.Read(bytes, 0, bytes.Length - 1);
                    }
                    #endregion

                    var encryptedText = targetStream.ToArray();

                    return Convert.ToBase64String(encryptedText);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw new Exception("ENCRYPT ERROR");
            }
        }

        public string Decrypt(string key, string text)
        {
            try
            {
                if (IsParametersValid(key, text))
                {
                    var innerKey = new Rfc2898DeriveBytes(key, sal);
                    var algorithm = new RijndaelManaged();

                    algorithm.Key = innerKey.GetBytes(16);
                    algorithm.IV = innerKey.GetBytes(16);

                    var textBytes = Convert.FromBase64String(text);
                    var sourceStream = new MemoryStream(textBytes);

                    var targetStream = new MemoryStream();

                    var crypto = new CryptoStream(sourceStream, algorithm.CreateDecryptor(), CryptoStreamMode.Read);

                    #region Move bytes
                    byte[] bytes = new byte[2049];
                    var counter = crypto.Read(bytes, 0, bytes.Length - 1);

                    while (0 != counter)
                    {
                        targetStream.Write(bytes, 0, counter);
                        counter = crypto.Read(bytes, 0, bytes.Length - 1);
                    }
                    #endregion

                    byte[] decryptedBytes = targetStream.ToArray();

                    var decryptedText = new UnicodeEncoding().GetString(decryptedBytes);

                    return decryptedText;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw new Exception("DECRYPT ERROR");
            }
        }

        private bool IsParametersValid(string key, string text)
        {
            bool isKeyInvalid = string.IsNullOrEmpty(key);
            bool isTextInvalid = string.IsNullOrEmpty(text);

            if (isKeyInvalid || isTextInvalid)
            {
                return false;
            }

            return true;
        }
    }
}
