using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZbcHashEks.AsymmetriskKryptering.Crypto
{
    internal class SenderAsymmetriskCryptoProcessor
    {
        RSACryptoServiceProvider rsa;

        public void Initialize()
        {
            rsa = new RSACryptoServiceProvider(2048);
        }

        public void InsertParameters(RSAParameters parameters)
        {         
            rsa.ImportParameters(parameters);
        }

        public string EncryptString(string input)
        {
            return Convert.ToBase64String(rsa.Encrypt(Encoding.UTF8.GetBytes(input), true));
        }
    }
}
