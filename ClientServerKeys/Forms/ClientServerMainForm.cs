using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZbcHashEks.AsymmetriskKryptering.Forms;
using ZbcHashEks.ClientServerKeys.Models;
using ZbcHashEks.ClientServerKeys.Server;

namespace ZbcHashEks.ClientServerKeys.Forms
{
    public partial class ClientServerMainForm : Form
    {
        private EncryptorServer _server;
        private int selectedClientId = 0;

        private bool SelectingMessageToDecrypt = false;
        List<Panel> MessagePanels = new List<Panel>();
        List<Panel> ClientPanels = new List<Panel>();
        

        public ClientServerMainForm()
        {
            InitializeComponent();

            _server = EncryptorServer.Instance;
            HookEvents();
            panel_MessagePreview.Visible = false;
            panel_ClientActions.Visible = false;
            InitializeClients();
            LoadMessages();
        }

        private void HookEvents()
        {
            // Using the same event for a new message, and a general change in messages.
            // too lazy to rename it
            _server.NewMessageEvent += (sender, args) =>
            {
                LoadMessages();
            };
        }

        /// <summary>
        /// Reloads all the messages
        /// </summary>
        public void LoadMessages()
        {
            flow_Messages.Controls.Clear();
            MessagePanels.Clear();
            List<ClientMessage> messages = _server.GetMessages();

            foreach(ClientMessage msg in messages)
            {
                flow_Messages.Controls.Add(CreateMessageObject(msg));
            }
        }

        public void InitializeClients()
        {
            List<int> clientIDs = _server.GetActiveClientsIDs();
            ClientPanels.Clear();
            flow_Clients.Controls.Clear();
            foreach(int i in clientIDs)
            {
                flow_Clients.Controls.Add(CreateClientObject(i));
            }
        }

        private Panel CreateClientObject(int clientID)
        {
            Panel mainPanel = new Panel();
            mainPanel.Size = new Size(90, 90);
            mainPanel.BorderStyle = BorderStyle.Fixed3D;
            mainPanel.BackColor = Color.WhiteSmoke;

            Label lbl_Client = new Label();
            lbl_Client.Text = "Client";
            lbl_Client.Size = new Size(65, 20);
            lbl_Client.Font = new Font("arial", 14, FontStyle.Bold);
            lbl_Client.Location = new Point(mainPanel.Width / 2 - lbl_Client.Size.Width / 2, 4);

            Label lbl_ClientID = new Label();
            lbl_ClientID.Text = clientID.ToString();
            lbl_ClientID.Size = new Size(15, 30);
            lbl_ClientID.Font = new Font("arial", 14, FontStyle.Bold);
            lbl_ClientID.Location = new Point(mainPanel.Width / 2 - lbl_ClientID.Size.Width / 2, 35);

            // Create the transparent panel for clicking
            TransparentPanel clickPanel = new TransparentPanel();
            clickPanel.Size = mainPanel.Size;
         
            clickPanel.Click += (sender, args) =>
            {
                selectedClientId = clientID;
                lbl_Test_ClientId.Text = selectedClientId.ToString();
                lbl_ClientActions_ClientId.Text = clientID.ToString();
                panel_ClientActions.Visible = true;

                foreach(Panel p in ClientPanels)
                {
                    p.BackColor = Color.WhiteSmoke;
                    p.Invalidate();
                }

                mainPanel.BackColor = Color.LightGreen;
                mainPanel.Invalidate();
            };
            clickPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            
            mainPanel.Controls.Add(clickPanel);
            mainPanel.Controls.Add(lbl_Client);
            mainPanel.Controls.Add(lbl_ClientID);
            ClientPanels.Add(mainPanel);
            return mainPanel;


        }

        private Panel CreateMessageObject(ClientMessage message)
        {
            BorderPanel mainPanel = new BorderPanel();
            mainPanel.Size = new Size(90, 90);
            mainPanel.BorderStyle = BorderStyle.Fixed3D;
            mainPanel.BackColor = Color.WhiteSmoke;

            Label lbl_StatusText = new Label();
            lbl_StatusText.Text = message.Encrypted? "Encrypted" : "Decrypted";
            lbl_StatusText.Size = new Size(65, 30);
            lbl_StatusText.Font = new Font("arial", 9, FontStyle.Bold);
            lbl_StatusText.ForeColor = message.Encrypted ? Color.Red : Color.Black;
            lbl_StatusText.Location = new Point(mainPanel.Width / 2 - lbl_StatusText.Width / 2, 4);

            Label lbl_withId = new Label();
            lbl_withId.Text = "With Client " + message.EncryptedWithClientID;
            lbl_withId.Size = new Size(70, 30);
            lbl_withId.Location = new Point(mainPanel.Width / 2 - lbl_withId.Width / 2, 40);

            TransparentPanel clickPanel = new TransparentPanel();
            clickPanel.Size = mainPanel.Size;
            clickPanel.Click += (sender, args) =>
            {
                if (SelectingMessageToDecrypt)
                {
                    _server.DecryptMessage(selectedClientId, message);
                    button2.ForeColor = Color.Black;
                    SelectingMessageToDecrypt = false;                   
                }

                foreach (BorderPanel panel in MessagePanels)
                {
                    panel.BorderShowing = false;
                    panel.BackColor = Color.WhiteSmoke;
                    panel.Invalidate();
                }

                mainPanel.BackColor = Color.LightGreen;
                mainPanel.Invalidate();

                ShowMessageInfo(message);

            };
            clickPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            
            mainPanel.Controls.Add(clickPanel);

            mainPanel.Controls.Add(lbl_withId);
            mainPanel.Controls.Add(lbl_StatusText);
            MessagePanels.Add(mainPanel);

            return mainPanel;


        }

        private void ShowMessageInfo(ClientMessage message)
        {
            panel_MessagePreview.Visible = true;
            lbl_MsgEncryptedby.Text = message.EncryptedWithClientID.ToString();
            tBox_MessageText.Text = message.Message64String;
        }

        private void ClearMessageInfo()
        {
            panel_MessagePreview.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var msgForm = new NewMessageForm(this.selectedClientId);
            msgForm.Show();
        }

        // Decrypt
        private void button2_Click(object sender, EventArgs e)
        {
            SelectingMessageToDecrypt = true;
            ClearMessageInfo();

            foreach(BorderPanel panel in MessagePanels)
            {
                panel.BorderShowing = true;
                panel.BackColor = Color.WhiteSmoke;
                panel.BorderColor = Color.DarkOrange;
                panel.Invalidate();
            }
            button2.ForeColor = Color.Green;
        }
    }
}
