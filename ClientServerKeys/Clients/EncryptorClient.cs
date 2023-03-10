using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZbcHashEks.ClientServerKeys.Models;
using ZbcHashEks.ClientServerKeys.Server;

namespace ZbcHashEks.ClientServerKeys.Clients
{
    internal class EncryptorClient : IEncryptorClient
    {
        public int ClientID { get; set; }
        private readonly EncryptorServer _server;
        private RSACryptoServiceProvider mainRsa;
        private RSAParameters ownParameters;
        private RSAParameters targetParameters;

        public EncryptorClient(EncryptorServer server, int clientID)
        {
            this._server = server;
            this.ClientID = clientID;
            // Generate a new key
            mainRsa = new RSACryptoServiceProvider();

            // export own parameters (including private keys) to save them
            ownParameters = mainRsa.ExportParameters(true);
        }       

        public ClientData GetClientData()
        {
            // Get the parameters WITHOUT the public fields
            RSAParameters pms = mainRsa.ExportParameters(false);

            return new ClientData()
            {
                ClientID = this.ClientID,
                ClientExponent = pms.Exponent,
                ClientModulus = pms.Modulus
            };
        }

        public string EncryptMessage(string message, RSAParameters _parameters)
        {            
            mainRsa.ImportParameters(_parameters);
            return Convert.ToBase64String(mainRsa.Encrypt(Encoding.UTF8.GetBytes(message), true));
        }

        public bool DecryptMessage(string message, out string result)
        {
            try
            {
                mainRsa.ImportParameters(ownParameters);
                byte[] messageBytes = Convert.FromBase64String(message);
                byte[] decryptedBytes = mainRsa.Decrypt(messageBytes, true);
                result = Encoding.Default.GetString(decryptedBytes);
                return true;
            }
            catch (Exception ex)
            {
                result = "Decoding failed.";
                return false;
            }

        }
    }
}
