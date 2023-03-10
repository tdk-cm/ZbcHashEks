using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZbcHashEks.ClientServerKeys.Models;
using ZbcHashEks.ClientServerKeys.Server;

namespace ZbcHashEks.ClientServerKeys.Forms
{
    public partial class NewMessageForm : Form
    {
        private int fromClientId;
        private int usingClientId;
        private EncryptorServer _server;

        public NewMessageForm(int clientId)
        {
            InitializeComponent();
            _server = EncryptorServer.Instance;
            this.fromClientId = clientId;
            InitializeUI();
        }

        private void InitializeUI()
        {
            lbl_CreatedBy.Text = "Client " + this.fromClientId.ToString();

            List<int> clients = _server.GetActiveClientsIDs();

            for(int i = 0; i < clients.Count; i++)
            {
                combo_UsingKeyFrom.Items.Add(clients[i]);
            }

            combo_UsingKeyFrom.SelectedIndex = 0;
            usingClientId = Convert.ToInt32(combo_UsingKeyFrom.Text);


            combo_UsingKeyFrom.SelectedIndexChanged += (sender, args) =>
            {
                usingClientId = Convert.ToInt32(combo_UsingKeyFrom.Text);    
            };

      
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            _server.AddMessage(fromClientId, usingClientId, tBox_Message.Text);
            this.Close();
        }
    }
}
