using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ZbcHashEks.SymmetriskKryptering.Processing
{
    internal class SymmetricCryptoProcessor
    {
        private SymmetricAlgorithm algorithm;

        public string GenerateKey()
        {
            algorithm.GenerateKey();
            return Convert.ToBase64String(algorithm.Key);
        }

        public string GenerateIV()
        {
            algorithm.GenerateIV();
            return Convert.ToBase64String(algorithm.IV);
        }

        public void SelectAlgorithm(string name)
        {
            switch (name)
            {
                case "DES":
                    algorithm = DES.Create();
                    break;
                case "3DES":
                    algorithm = TripleDES.Create();
                    break;
                case "AES":
                    algorithm = Aes.Create();
                    break;
            }
        }

        public byte[] Encrypt(string input)
        {
            byte[] encryptedBytes;
            
            using(MemoryStream encryptedStream = new MemoryStream())
            {
                //string key = Convert.ToBase64String(algorithm.Key);
                //string iv = Convert.ToBase64String(algorithm.IV);
                using(CryptoStream cryptoStream = new CryptoStream(encryptedStream, algorithm.CreateEncryptor(algorithm.Key, algorithm.IV), CryptoStreamMode.Write))
                {
                    using(StreamWriter sw = new StreamWriter(cryptoStream))
                    {
                        sw.Write(input);
                    }

                    encryptedBytes = encryptedStream.ToArray();
                }
            }

            return encryptedBytes;
        }

        public byte[] Decrypt(byte[] input)
        {
            try
            {
                byte[] returnbytes = new byte[input.Length];
                //string iis = Convert.ToBase64String(input);
                //string key = Convert.ToBase64String(algorithm.Key);
                //string iv = Convert.ToBase64String(algorithm.IV);
                using (MemoryStream encryptedStream = new MemoryStream(input))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(encryptedStream, algorithm.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cryptoStream.Read(returnbytes, 0, input.Length);
                        cryptoStream.Close();
                    }
                }

                return returnbytes;
            }
            catch (Exception ex)
            {
                return System.Text.Encoding.Default.GetBytes("Invalid key/iv");
            }
          
        }
    }
}
