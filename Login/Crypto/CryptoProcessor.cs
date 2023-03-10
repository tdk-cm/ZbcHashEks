using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZbcHashEks.Login.Crypto
{
    internal class CryptoProcessor
    {
        private int iterations = 20000;
        private int hashSize = 128;
        public byte[] GenerateSalt()
        {
            RandomNumberGenerator service = RandomNumberGenerator.Create();
            byte[] salt = new byte[64];
            service.GetBytes(salt);

            return salt;
        }

        public string HashPassword(string password, byte[] salt)
        {

            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(hashSize));
            }
        }
    }
}
