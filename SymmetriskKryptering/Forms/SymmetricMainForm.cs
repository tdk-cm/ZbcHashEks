using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZbcHashEks.SymmetriskKryptering.Processing;

namespace ZbcHashEks.SymmetriskKryptering.Forms
{
    public partial class SymmetricMainForm : Form
    {
        private Panel mainPanel;
        private ComboBox tBox_ChooseAlgorithm;
        private string AlgorithmSelected;
        private SymmetricCryptoProcessor _cryptoProcessor;

        private TextBox tBox_Key;
        private TextBox tBox_IV;
        private TextBox tBox_PlainText_Ascii;
        private TextBox tBox_PlainText_Hex;
        private TextBox tBox_CypherText_Ascii;
        private TextBox tBox_CypherText_Hex;
        private Label lbl_EncryptionTime;
        private Label lbl_DescryptionTime;
        private Label lbl_time;
        string encryptedInput;

        private string gen_Key = "";
        private string gen_IV = "";

        public SymmetricMainForm()
        {
            InitializeComponent();
            _cryptoProcessor = new SymmetricCryptoProcessor();
            CreateMainGUI();
        }
        
        public void CreateMainGUI()
        {
            mainPanel = new Panel();
            mainPanel.Size = this.Size;

            int col1_X = 15;
            int col2_X = this.Width / 2;

            tBox_ChooseAlgorithm = new ComboBox();
            tBox_ChooseAlgorithm.Location = new Point(col1_X, 20);
            tBox_ChooseAlgorithm.Size = new Size(160, 50);

            tBox_ChooseAlgorithm.Items.Add("DES");
            tBox_ChooseAlgorithm.Items.Add("3DES");
            tBox_ChooseAlgorithm.Items.Add("AES");
            tBox_ChooseAlgorithm.SelectedIndex = 0;

           

            tBox_ChooseAlgorithm.SelectedIndexChanged += (sender, args) =>
            {
                UpdateSelectedAlgorithm(tBox_ChooseAlgorithm.Text);
            };

            mainPanel.Controls.Add(tBox_ChooseAlgorithm);

            // Key display
            tBox_Key = new TextBox();
            tBox_Key.Location = new Point(col2_X, 20);
            tBox_Key.Size = new Size(250, 50);
            tBox_Key.ReadOnly = true;
            tBox_Key.BackColor = Color.White;
            tBox_Key.Text = gen_Key;

            mainPanel.Controls.Add(tBox_Key);

            Label lbl_Key = new Label();
            lbl_Key.Location = GetLabelTboxPosition(tBox_Key.Location);
            lbl_Key.Text = "Key";

            mainPanel.Controls.Add(lbl_Key);


            // IV Display
            tBox_IV = new TextBox();
            tBox_IV.Location = new Point(col2_X, 70);
            tBox_IV.Size = new Size(250, 50);
            tBox_IV.ReadOnly = true;
            tBox_IV.BackColor = Color.White;
            tBox_IV.Text = gen_IV;

            mainPanel.Controls.Add(tBox_IV);

            Label lbl_Iv = new Label();
            lbl_Iv.Location = GetLabelTboxPosition(tBox_IV.Location);
            lbl_Iv.Text = "IV";

            mainPanel.Controls.Add(lbl_Iv);


            Button btn_GenerateKeys = new Button();
            btn_GenerateKeys.Location = new Point(col1_X, 70);
            btn_GenerateKeys.Size = new Size(180, 50);
            btn_GenerateKeys.Text = "Generate Key and IV";
            btn_GenerateKeys.Click += (sender, args) =>
            {
                string key = _cryptoProcessor.GenerateKey();
                tBox_Key.Text = key;
                string iv = _cryptoProcessor.GenerateIV();
                tBox_IV.Text = iv;
            };

            mainPanel.Controls.Add(btn_GenerateKeys);

            Button btn_Encrypt = new Button();
            btn_Encrypt.Location = new Point(col1_X, 170);
            btn_Encrypt.Size = new Size(180, 50);
            btn_Encrypt.Text = "Encrypt";
            btn_Encrypt.Click += (sender, args) =>
            {
                Stopwatch encryptWatch = Stopwatch.StartNew();
                string encrypted = Convert.ToBase64String(_cryptoProcessor.Encrypt(tBox_PlainText_Ascii.Text));
                encryptedInput = encrypted;
                tBox_CypherText_Ascii.Text = encryptedInput;
                tBox_CypherText_Hex.Text = Convert.ToHexString(Encoding.UTF8.GetBytes(encryptedInput));
                tBox_PlainText_Ascii.Text = "";
                tBox_PlainText_Hex.Text = "";

                encryptWatch.Stop();
                lbl_time.Text = $"Encrypting took {encryptWatch.ElapsedTicks} ticks";

            };

            mainPanel.Controls.Add(btn_Encrypt);

            Button btn_Decrypt = new Button();
            btn_Decrypt.Location = new Point(col1_X, 270);
            btn_Decrypt.Size = new Size(180, 50);
            btn_Decrypt.Text = "Decrypt";
            btn_Decrypt.Click += (sender, args) =>
            {
                Stopwatch decryptWatch = Stopwatch.StartNew();
                byte[] decryptedBytes = _cryptoProcessor.Decrypt(Convert.FromBase64String(encryptedInput));
                tBox_PlainText_Ascii.Text = System.Text.Encoding.Default.GetString(decryptedBytes);
                tBox_CypherText_Ascii.Text = "";
                tBox_CypherText_Hex.Text = "";

                decryptWatch.Stop();
                lbl_time.Text = $"Encrypting took {decryptWatch.ElapsedTicks} ticks";
            };

            mainPanel.Controls.Add(btn_Decrypt);

            //
            //  Cypher
            //
           
            //     ascii
            tBox_PlainText_Ascii = new TextBox();
            tBox_PlainText_Ascii.Location = new Point(col2_X, 170);
            tBox_PlainText_Ascii.Size = new Size(250, 50);
            tBox_PlainText_Ascii.ReadOnly = false;
            tBox_PlainText_Ascii.BackColor = Color.White;
            tBox_PlainText_Ascii.Text = gen_IV;
            tBox_PlainText_Ascii.TextChanged += (sender, args) =>
            {
                tBox_PlainText_Hex.Text = Convert.ToHexString(Encoding.UTF8.GetBytes(tBox_PlainText_Ascii.Text));
            };

            mainPanel.Controls.Add(tBox_PlainText_Ascii);

            Label lbl_PlainText = new Label();
            lbl_PlainText.Location = GetLabelTboxPosition(tBox_PlainText_Ascii.Location);
            lbl_PlainText.Text = "Plain Text";

            mainPanel.Controls.Add(lbl_PlainText);           
            mainPanel.Controls.Add(GenerateLeftLabel("ASCII", tBox_PlainText_Ascii));

            //         hex
            tBox_PlainText_Hex = new TextBox();
            tBox_PlainText_Hex.Location = new Point(col2_X, 210);
            tBox_PlainText_Hex.Size = new Size(250, 50);
            tBox_PlainText_Hex.ReadOnly = true;
            tBox_PlainText_Hex.BackColor = Color.White;
            tBox_PlainText_Hex.Text = gen_IV;

            mainPanel.Controls.Add(tBox_PlainText_Hex);

            mainPanel.Controls.Add(GenerateLeftLabel("HEX", tBox_PlainText_Hex));


            // 
            //  Cypher
            //
            //     ascii
            tBox_CypherText_Ascii = new TextBox();
            tBox_CypherText_Ascii.Location = new Point(col2_X, 280);
            tBox_CypherText_Ascii.Size = new Size(250, 50);
            tBox_CypherText_Ascii.ReadOnly = true;
            tBox_CypherText_Ascii.BackColor = Color.White;
            tBox_CypherText_Ascii.Text = gen_IV;

            mainPanel.Controls.Add(tBox_CypherText_Ascii);

            Label lbl_CypherText = new Label();
            lbl_CypherText.Location = GetLabelTboxPosition(tBox_CypherText_Ascii.Location);
            lbl_CypherText.Text = "Cypher Text";

            mainPanel.Controls.Add(lbl_CypherText);
            mainPanel.Controls.Add(GenerateLeftLabel("ASCII", tBox_CypherText_Ascii));

            //         hex
            tBox_CypherText_Hex = new TextBox();
            tBox_CypherText_Hex.Location = new Point(col2_X, 330);
            tBox_CypherText_Hex.Size = new Size(250, 50);
            tBox_CypherText_Hex.ReadOnly = true;
            tBox_CypherText_Hex.BackColor = Color.White;
            tBox_CypherText_Hex.Text = gen_IV;

            mainPanel.Controls.Add(tBox_CypherText_Hex);

            mainPanel.Controls.Add(GenerateLeftLabel("HEX", tBox_CypherText_Hex));

            // Encrypt time
            lbl_time = new Label();
            lbl_time.Size = new Size(250, 50);
            lbl_time.Location = new Point(col2_X, tBox_CypherText_Hex.Location.Y + 50);
            mainPanel.Controls.Add(lbl_time);


            //this.Controls.Add(cBox_MacSelection);


            UpdateSelectedAlgorithm(tBox_ChooseAlgorithm.Text);
            this.Controls.Add(mainPanel);
        }

        private Point GetLabelTboxPosition(Point textBoxPosition)
        {
            return new Point(textBoxPosition.X, textBoxPosition.Y - 20);
        }

        private Label GenerateLeftLabel(string text, Control control)
        {
            Label nL = new Label();
            nL.Location = new Point(control.Location.X - 35, control.Location.Y + 3);
            nL.Text = text;

            return nL;
        }

        private void UpdateSelectedAlgorithm(string algorithmName)
        {
            this.AlgorithmSelected = algorithmName;
            _cryptoProcessor.SelectAlgorithm(algorithmName);
        }
    }
}
