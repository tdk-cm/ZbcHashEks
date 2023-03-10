using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZbcHashEks.ClientServerKeys.Models
{
    public class ClientData
    {
        public int ClientID { get; set; }
        public byte[] ClientExponent { get; set; }
        public byte[] ClientModulus { get; set; }

        public RSAParameters GetPublicParameters()
        {
            return new RSAParameters()
            {
                Modulus = ClientModulus,
                Exponent = ClientExponent
            };
        }
    }
}
