using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZbcHashEks.ClientServerKeys.Models;

namespace ZbcHashEks.ClientServerKeys.Clients
{
    public interface IEncryptorClient
    {
        public int ClientID { get; set; }
        public ClientData GetClientData();
        public string EncryptMessage(string message, RSAParameters _parameters);
        public bool DecryptMessage(string message, out string result);
    }
}
