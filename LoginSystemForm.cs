using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZbcHashEks.Login.Crypto;
using ZbcHashEks.Login.Data;
using ZbcHashEks.Login.Models;

namespace ZbcHashEks
{
    public partial class LoginSystemForm : Form
    {
        private Panel mainPanel;
        private Label lbl_ErrorMessage;
        private Dictionary<string, int> loginAttempts = new Dictionary<string, int>();

        public LoginSystemForm()
        {
            InitializeComponent();
            //TestCrypto();
            //TestPw();
                       


            LoadLoginScreen();
        }

        private void LoadRegisterScreen()
        {
            this.Controls.Clear();
            mainPanel = new Panel();
            mainPanel.Size = this.Size;

            Label lbl_Overhead = new Label();
            lbl_Overhead.Size = new Size(300, 20);
            lbl_Overhead.Text = "Register new User";
            lbl_Overhead.Location = new Point(mainPanel.Width / 2 - lbl_Overhead.Width / 2, 30);
            mainPanel.Controls.Add(lbl_Overhead);

            TextBox tBox_userName = new TextBox();
            tBox_userName.BorderStyle = BorderStyle.Fixed3D;
            tBox_userName.Size = new Size(250, 80);
            tBox_userName.Location = new Point(mainPanel.Width / 2 - tBox_userName.Width / 2, 90);
            tBox_userName.TextChanged += (sender, args) => {
            };
            mainPanel.Controls.Add(tBox_userName);

            Label lbl_userName = new Label();
            lbl_userName.Size = new Size(100, 50);
            lbl_userName.Text = "Username";
            lbl_userName.Location = new Point(tBox_userName.Location.X, tBox_userName.Location.Y - 20);
            mainPanel.Controls.Add(lbl_userName);


            TextBox tBox_password = new TextBox();
            tBox_password.Size = new Size(250, 80);
            tBox_password.BorderStyle = BorderStyle.Fixed3D;
            tBox_password.Location = new Point(mainPanel.Width / 2 - tBox_password.Width / 2, tBox_userName.Location.Y + 70);
            mainPanel.Controls.Add(tBox_password);

            Label lbl_password = new Label();
            lbl_password.Size = new Size(100, 50);
            lbl_password.Text = "Password";
            lbl_password.Location = new Point(tBox_password.Location.X, tBox_password.Location.Y - 20);
            mainPanel.Controls.Add(lbl_password);

            Button btn_register = new Button();
            btn_register.Size = new Size(150, 30);
            btn_register.Text = "Register";
            btn_register.Location = new Point(mainPanel.Width / 2 - btn_register.Size.Width / 2, tBox_password.Location.Y + 50);
            btn_register.MouseClick += (sender, args) =>
            {
                RegisterUser(tBox_userName.Text, tBox_password.Text);
            };

            mainPanel.Controls.Add(btn_register);

            this.Controls.Add(mainPanel);
        }

        private void RegisterUser(string user, string password)
        {
            CryptoProcessor crypto = new CryptoProcessor();

            UserModel model = new UserModel();
            model.UserName = user;
            byte[] salt = crypto.GenerateSalt();
            string pw = crypto.HashPassword(password, salt);
            model.PasswordSalt = Convert.ToBase64String(salt);
            model.PasswordHash = pw;
            model.IsLocked = false;
            model.UserEmail = "tempEmail";

            DatabaseProcessor db = new DatabaseProcessor();
            db.AddToUsers(model);

            LoadLoginScreen();

        }

        private void LoadLoginScreen()
        {
            this.Controls.Clear();
            mainPanel = new Panel();
            mainPanel.Size = this.Size;

            lbl_ErrorMessage = new Label();
            lbl_ErrorMessage.Text = "Invalid Username or Password";
            lbl_ErrorMessage.Size = new Size(300, 50);
            lbl_ErrorMessage.Location = new Point(400, 100);
            lbl_ErrorMessage.ForeColor = Color.Red;
            lbl_ErrorMessage.Visible = false;
            mainPanel.Controls.Add(lbl_ErrorMessage);
            
            TextBox tBox_userName = new TextBox();
            tBox_userName.BorderStyle = BorderStyle.Fixed3D;
            tBox_userName.Size = new Size(250, 80);
            tBox_userName.Location = new Point(this.Width / 2 - tBox_userName.Width / 2, 150);
            tBox_userName.TextChanged += (sender, args) => {
                lbl_ErrorMessage.Visible = false;
            };
            mainPanel.Controls.Add(tBox_userName);

            Label lbl_userName = new Label();
            lbl_userName.Size = new Size(100, 50);
            lbl_userName.Text = "Username";
            lbl_userName.Location = new Point(tBox_userName.Location.X, tBox_userName.Location.Y - 20);
            mainPanel.Controls.Add(lbl_userName);


            TextBox tBox_password = new TextBox();
            tBox_password.Size = new Size(250, 80);
            tBox_password.BorderStyle = BorderStyle.Fixed3D;
            tBox_password.Location = new Point(this.Width / 2 - tBox_password.Width / 2, 230);
            tBox_password.TextChanged += (sender, args) => {
                lbl_ErrorMessage.Visible = false;
            };
            tBox_password.KeyPress += (sender, args) =>
            {
                KeyPressEventArgs arg = args as KeyPressEventArgs;
                if(Convert.ToInt32(arg.KeyChar) == 13) // enter
                {
                    PerformLogin(tBox_userName.Text, tBox_password.Text);
                };
            };
            mainPanel.Controls.Add(tBox_password);

            Label lbl_password = new Label();
            lbl_password.Size = new Size(100, 50);
            lbl_password.Text = "Password";
            lbl_password.Location = new Point(tBox_password.Location.X, tBox_password.Location.Y - 20);
            mainPanel.Controls.Add(lbl_password);

            Button btn_Login = new Button();
            btn_Login.Size = new Size(150, 50);
            btn_Login.Text = "Login";
            btn_Login.Font = new Font("ariel", 20);
            btn_Login.Location = new Point(mainPanel.Width / 2 - btn_Login.Size.Width / 2, tBox_password.Location.Y + 50);
            btn_Login.MouseClick += (sender, args) =>
            {
                PerformLogin(tBox_userName.Text, tBox_password.Text);
            };

            mainPanel.Controls.Add(btn_Login);

            Button btn_register = new Button();
            btn_register.Size = new Size(150, 30);
            btn_register.Text = "Register new User";
            btn_register.Location = new Point(mainPanel.Width / 2 - btn_register.Size.Width / 2, btn_Login.Location.Y + 50);
            btn_register.MouseClick += (sender, args) =>
            {
                LoadRegisterScreen();
            };

            mainPanel.Controls.Add(btn_register);

            this.Controls.Add(mainPanel);

        }

        private void PerformLogin(string userName, string password)
        {
            CryptoProcessor cryptoProcessor = new CryptoProcessor();

            DatabaseProcessor databaseProcessor = new DatabaseProcessor();

            UserModel model = databaseProcessor.GetUserData(userName);

            if(model is null)
            {
                DisplayErrorMessage("Wrong Username or Password ");
                return;
            }

            string pwFromDatabase = cryptoProcessor.HashPassword(password, Convert.FromBase64String(model.PasswordSalt));

            if (!pwFromDatabase.Equals(model.PasswordHash))
            {
                DisplayErrorMessage("Wrong Username or Password ");
                if (loginAttempts.ContainsKey(model.UserName))
                {
                    int attempts = loginAttempts[model.UserName];
                    attempts++;
                    loginAttempts[model.UserName] = attempts;

                    if (attempts > 5) 
                    {
                        model.IsLocked = true;
                        DisplayErrorMessage("Too many attempts. Account locked");
                    }
                } else
                {
                    loginAttempts.Add(model.UserName, 1);
                }

                
                return;
            }
            else
            {
                LoadUserProfile(model.UserName);
            }
            
        }

        private void DisplayErrorMessage(string message)
        {
            lbl_ErrorMessage.Visible = true;
            lbl_ErrorMessage.Text = message;
        }

        private void LoadUserProfile(string userName)
        {
            this.Controls.Clear();
            mainPanel = new Panel();
            mainPanel.Size = this.Size;
            Label lbl_name = new Label();
            lbl_name.Size = new Size(400, 300);
            lbl_name.Text = $"Welcome, {userName}";
            lbl_name.Font = new Font("arel", 35);
            lbl_name.Location = new Point(mainPanel.Size.Width / 2 - lbl_name.Size.Width / 2, 100);

            Button btn_backToLogin = new Button();
            btn_backToLogin.Size = new Size(250, 50);
            btn_backToLogin.Text = "Back to Login";
            btn_backToLogin.Font = new Font("ariel", 20);
            btn_backToLogin.Location = new Point(mainPanel.Width / 2 - btn_backToLogin.Size.Width / 2, lbl_name.Location.Y + 80);
            btn_backToLogin.MouseClick += (sender, args) =>
            {
                LoadLoginScreen();
            };

            mainPanel.Controls.Add(btn_backToLogin);



            mainPanel.Controls.Add(lbl_name);

            this.Controls.Add(mainPanel);
        }

        private void TestPw()
        {
            DatabaseProcessor db = new DatabaseProcessor();
            CryptoProcessor crypto = new CryptoProcessor();
            UserModel model = db.GetUserData("carlo");
            string result = crypto.HashPassword("12345", Convert.FromBase64String(model.PasswordSalt));

            if(result == model.PasswordHash)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }

        private void TestCrypto()
        {
            CryptoProcessor crypto = new CryptoProcessor();

            byte[] s = crypto.GenerateSalt();

            string b64Salt = Convert.ToBase64String(s);

            string hashedPw = crypto.HashPassword("12345", s);

            UserModel user = new UserModel();
            user.UserName = "carlo";
            user.UserEmail = "whatever";
            user.PasswordHash = hashedPw;
            user.PasswordSalt = b64Salt;

            DatabaseProcessor db = new DatabaseProcessor();

            db.AddToUsers(user);


        }
    }
}
