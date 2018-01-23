using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace StegoVideo.Controller
{
    public class DES
    {
        private string originalText;
        private string encryptedText;

        public DES()
        {

        }
        /* cek key size
         ks = des.LegalKeySizes;
            foreach (KeySizes k in ks)
            {
                Console.WriteLine("\tLegal min key size = " + k.MinSize);
                Console.WriteLine("\tLegal max key size = " + k.MaxSize);
            }
        */
        
        /// Returns the encryption key
        private static byte[] rgbKey(string password)
        {
            return ASCIIEncoding.ASCII.GetBytes((password + System.Math.PI.ToString()).Substring(0, 8));
        }
        
        /// Returns the encryption IV
        private static byte[] rgbIV(string password)
        {
            return ASCIIEncoding.ASCII.GetBytes((password + System.Math.Sqrt(2.0).ToString()).Substring(0, 8));
        }
        
        /// &lt;returns>The encrypted string.&lt;/returns>
        /// &lt;exception cref="ArgumentNullException">This exception will be thrown when the original string or password is null or empty.&lt;/exception>
        public string Encrypt(string originalString, string password)
        {
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(rgbKey(password), rgbIV(password)), CryptoStreamMode.Write);

            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();

            encryptedText = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);

            return encryptedText;
        }

        /// &lt;returns>The decrypted string.&lt;/returns>
        /// &lt;exception cref="ArgumentNullException">This exception will be thrown when the crypted string or password is null or empty.&lt;/exception>
        public string Decrypt(string cryptedString, string password)
        {
            if (cryptedString.Length == 0)
                return cryptedString;

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(rgbKey(password), rgbIV(password)), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);

            originalText = reader.ReadToEnd();

            return originalText;
        }
    }
}
