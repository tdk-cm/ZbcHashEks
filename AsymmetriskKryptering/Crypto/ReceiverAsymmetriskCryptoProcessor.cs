using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZbcHashEks.AsymmetriskKryptering.Crypto
{
    internal class ReceiverAsymmetriskCryptoProcessor
    {
        private RSACryptoServiceProvider mainRsa;
   
        public void Initialize()
        {
            mainRsa = new RSACryptoServiceProvider();
        }

        public RSAParameters GetRSAParameters()
        {
            return mainRsa.ExportParameters(true);
        }

        public string Decrypt(byte[] data)
        {
            try
            {
                return System.Text.Encoding.Default.GetString(mainRsa.Decrypt(data, true));
            }
            catch (Exception ex)
            {
                return "Decoding failed.";
            }
           
        }
    }
}
