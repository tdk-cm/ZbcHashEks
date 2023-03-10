using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZbcHashEks.Vigenere.Processing;

namespace ZbcHashEks.Vigenere.Forms
{
    public partial class VigenereForm : Form
    {
        private VigenereProcessor _processor;
        public VigenereForm()
        {
            _processor = new VigenereProcessor();
            _processor.CreateArray();

            InitializeComponent();

            tBox_Encrypt_CodeKey.KeyPress += (sender, args) =>
            {
                KeyPressEventArgs arg = args as KeyPressEventArgs;
                if (Convert.ToInt32(arg.KeyChar) == 13) // enter
                {
                    string result = _processor.EncryptMessage(tBox_Encrypt_Input.Text.ToUpper(), tBox_Encrypt_CodeKey.Text.ToUpper());
                    tBox_Encrypt_Answer.Text = result.ToUpper();
                };
            };

            tBox_Decrypt_CodeKey.KeyPress += (sender, args) =>
            {
                KeyPressEventArgs arg = args as KeyPressEventArgs;
                if (Convert.ToInt32(arg.KeyChar) == 13) // enter
                {
                    string result = _processor.DecryptMessage(tBox_Decrypt_Input.Text.ToUpper(), tBox_Decrypt_CodeKey.Text.ToUpper());
                    tBox_Decrypt_Answer.Text = result.ToUpper();
                };
            };
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string result = _processor.EncryptMessage(tBox_Encrypt_Input.Text.ToUpper(), tBox_Encrypt_CodeKey.Text.ToUpper());
            tBox_Encrypt_Answer.Text = result.ToUpper();
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string result = _processor.DecryptMessage(tBox_Decrypt_Input.Text.ToUpper(), tBox_Decrypt_CodeKey.Text.ToUpper());
            tBox_Decrypt_Answer.Text = result.ToUpper();
        }
    }
}
