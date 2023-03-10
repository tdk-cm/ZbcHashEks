using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbcHashEks.ClientServerKeys.Models
{
    public class ClientMessage
    {
        public int EncryptedWithClientID { get; set; }
        public string Message64String { get; set; }
        public bool Encrypted { get; set; }
    }
}
