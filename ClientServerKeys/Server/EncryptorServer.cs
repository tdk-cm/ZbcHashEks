using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ZbcHashEks.ClientServerKeys.Clients;
using ZbcHashEks.ClientServerKeys.Models;

namespace ZbcHashEks.ClientServerKeys.Server
{
    public class EncryptorServer
    {
        private List<IEncryptorClient> activeClients;
        private List<ClientMessage> activeMessages;

        // Singleton
        private static readonly object singletonLock = new object();
        private static EncryptorServer instance = null;

        // Events
        public event EventHandler<EventArgs> NewMessageEvent;


        public static EncryptorServer Instance
        {
            get
            {
                lock (singletonLock)
                {
                    if (instance == null)
                    {
                        instance = new EncryptorServer();
                    }
                    return instance;
                }
            }
        }

        private EncryptorServer()
        {
            activeClients = new List<IEncryptorClient>();

            AddClient(new EncryptorClient(this, 1));
            AddClient(new EncryptorClient(this, 2));
            AddClient(new EncryptorClient(this, 3));

            activeMessages = new List<ClientMessage>();
           
        }

        public List<ClientMessage> GetMessages()
        {
            return activeMessages;
        }

        public bool DecryptMessage(int clientId, ClientMessage message)
        {
            try
            {
                IEncryptorClient client = activeClients.Find(x => x.ClientID == clientId);
                string result;

                bool decrypted = client.DecryptMessage(message.Message64String, out result);

                if (decrypted)
                {
                    message.Encrypted = false;
                    message.Message64String = result;
                    NewMessageEvent?.Invoke(null, new EventArgs());
                }

                return decrypted;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public ClientData GetClientData(int clientId)
        {
            // Gonna throw an error if it's null, but it shouldn't be. And if it is, i deserve to crash the program.
            return activeClients.Find(x => x.ClientID == clientId).GetClientData();
        }

        public void AddClient(IEncryptorClient client)
        {
            activeClients.Add(client);
        }

        public void AddMessage(int fromClientID, int withClientID, string msg)
        {
            IEncryptorClient fromClient = activeClients.Find(x => x.ClientID == fromClientID);
            IEncryptorClient withClient = activeClients.Find(x => x.ClientID == withClientID);
            ClientData withClientData = withClient.GetClientData();
            string encoded64 = fromClient.EncryptMessage(msg, withClientData.GetPublicParameters());

            activeMessages.Add(new ClientMessage()
            {
                EncryptedWithClientID = withClientID,
                Encrypted = true,
                Message64String = encoded64
            });


            NewMessageEvent?.Invoke(null, new EventArgs());
        }

        public List<int> GetActiveClientsIDs()
        {
            return activeClients.Select(x => x.ClientID).ToList();
        }

        public List<ClientData> GetClientsData()
        {
            List<ClientData> returnList = new List<ClientData>();

            foreach(IEncryptorClient client in activeClients)
            {
                returnList.Add(client.GetClientData());
            }

            return returnList;
        }
    }
}
