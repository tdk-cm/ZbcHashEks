using System.Security.Cryptography;
using ZbcHashEks.AsymmetriskKryptering.Forms;
using ZbcHashEks.ClientServerKeys.Forms;
using ZbcHashEks.SymmetriskKryptering.Forms;
using ZbcHashEks.Vigenere.Forms;

namespace ZbcHashEks
{
    public partial class Form1 : Form
    {
        private string AlgorithmSelected = "";
        private HMAC selectedMac;
        private ComboBox cBox_MacSelection;
        private Button btn_LoginSystem;
        private Button btn_hashPage;
        private Button btn_Symmetrik;
        private Button btn_Asymmetrisk;
        private Button btn_Vigenere;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int third = this.Width / 3;
            int height_OneThird = this.Height / 3;
            int height_TwoThirds = (this.Height / 3) * 2;

            btn_hashPage = new Button();
            btn_hashPage.Size = new Size(200, 100);
            btn_hashPage.Location = new Point(third - btn_hashPage.Size.Width / 2, (this.Height / 3) - btn_hashPage.Size.Height);
            btn_hashPage.Text = "Go to Server/Client System";
            btn_hashPage.Click += (sender, args) =>
            {
                var csForm = new ClientServerMainForm();
                csForm.Show();
            };

            this.Controls.Add(btn_hashPage);

            btn_LoginSystem = new Button();
            btn_LoginSystem.Size = new Size(200, 100);
            btn_LoginSystem.Location = new Point(third * 2 - btn_LoginSystem.Size.Width / 2, (this.Height / 3) - btn_LoginSystem.Size.Height);
            btn_LoginSystem.Text = "Go to Login system";
            btn_LoginSystem.Click += (sender, args) =>
            {
                var loginForm = new LoginSystemForm();
                loginForm.Show();
            };
            this.Controls.Add(btn_LoginSystem);

            btn_Symmetrik = new Button();
            btn_Symmetrik.Size = new Size(200, 100);
            btn_Symmetrik.Location = new Point(third - btn_Symmetrik.Size.Width / 2, height_TwoThirds - btn_Symmetrik.Size.Height);
            btn_Symmetrik.Text = "Go to Symmetrik Encrypting";
            btn_Symmetrik.Click += (sender, args) =>
            {
                var symForm = new SymmetricMainForm();
                symForm.Show();
            };
            this.Controls.Add(btn_Symmetrik);

            btn_Asymmetrisk = new Button();
            btn_Asymmetrisk.Size = new Size(200, 100);
            btn_Asymmetrisk.Location = new Point(third * 2 - btn_Asymmetrisk.Size.Width / 2, height_TwoThirds - btn_Asymmetrisk.Size.Height);
            btn_Asymmetrisk.Text = "Go to Asymmetrisk Encrypting";
            btn_Asymmetrisk.Click += (sender, args) =>
            {
                var p1Form = new PlayerOneForm();
                p1Form.Show();
            };
            this.Controls.Add(btn_Asymmetrisk);

            btn_Vigenere = new Button();
            btn_Vigenere.Size = new Size(200, 70);
            btn_Vigenere.Location = new Point(this.Size.Width / 2 - btn_Vigenere.Width / 2, this.Size.Height - 120);
            btn_Vigenere.Text = "Go to Vigenere Encrypting";
            btn_Vigenere.Click += (sender, args) =>
            {
                var vigForm = new VigenereForm();
                vigForm.Show();
            };
            this.Controls.Add(btn_Vigenere);

            //cBox_MacSelection = new ComboBox();
            //cBox_MacSelection.Location = new Point(5, 5);
            //cBox_MacSelection.Size = new Size(100, 50);

            //cBox_MacSelection.Items.Add("SHA1");
            //cBox_MacSelection.Items.Add("MD5");
            //cBox_MacSelection.Items.Add("RIPEMD");
            //cBox_MacSelection.Items.Add("SHA256");
            //cBox_MacSelection.Items.Add("SHA384");
            //cBox_MacSelection.Items.Add("SHA512");
            //cBox_MacSelection.SelectedIndex = 0;

            //this.AlgorithmSelected = cBox_MacSelection.Text;

            //TextBox tBox = new TextBox();
            //tBox.Location = new Point(5, 100);
            //tBox.Size = new Size(100, 50);

            //tBox.Text = this.AlgorithmSelected;

            //cBox_MacSelection.SelectedIndex = 0;


            //cBox_MacSelection.SelectedIndexChanged += (sender, args) =>
            //{
            //    UpdateSelectedMac(cBox_MacSelection.Text);
            //    tBox.Text = this.AlgorithmSelected;
            //};

            //this.Controls.Add(cBox_MacSelection);



            //this.Controls.Add(tBox);

        }

        private void UpdateSelectedMac(string newChoice)
        {
            this.AlgorithmSelected = cBox_MacSelection.Text;

            switch (newChoice)
            {
                case "SHA1":
                    this.selectedMac = new HMACSHA1();
                    break;

                case "MD5":
                    this.selectedMac = new HMACMD5();
                    break;

                //case "RIPEMD":
                //    this.selectedMac = new HMACRIPEMD160();
                //    break;

                case "SHA256":
                    this.selectedMac = new HMACSHA256();
                    break;

                case "SHA384":
                    this.selectedMac = new HMACSHA384();
                    break;

                case "SHA512":
                    this.selectedMac = new HMACSHA512();
                    break;

            }
        }
    }
}