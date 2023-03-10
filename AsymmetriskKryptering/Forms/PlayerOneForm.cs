using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZbcHashEks.AsymmetriskKryptering.Crypto;

namespace ZbcHashEks.AsymmetriskKryptering.Forms
{
    public partial class PlayerOneForm : Form
    {
        ReceiverAsymmetriskCryptoProcessor _receiverCryptoProcessor;
        SenderAsymmetriskCryptoProcessor _senderCryptoProcessor;

        public PlayerOneForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _receiverCryptoProcessor = new ReceiverAsymmetriskCryptoProcessor();
            _receiverCryptoProcessor.Initialize();
            RSAParameters keyParameters = _receiverCryptoProcessor.GetRSAParameters();
            tBox_Exponent.Text = BitConverter.ToString(keyParameters.Exponent);
            tBox_Modulus.Text = BitConverter.ToString(keyParameters.Modulus);

            tBox_Priv_D.Text = BitConverter.ToString(keyParameters.D);
            tBox_Priv_DP.Text = BitConverter.ToString(keyParameters.DP);
            tBox_Priv_DQ.Text = BitConverter.ToString(keyParameters.DQ);
            tBox_Priv_InvQ.Text = BitConverter.ToString(keyParameters.InverseQ);
            tBox_Priv_P.Text = BitConverter.ToString(keyParameters.P);
            tBox_Priv_Q.Text = BitConverter.ToString(keyParameters.Q);

            _senderCryptoProcessor = new SenderAsymmetriskCryptoProcessor();
            _senderCryptoProcessor.Initialize();
        }

        private byte[] HexToByteArray(string hexString)
        {
            hexString = hexString.Replace("-", "");
            byte[] byteArray = new byte[hexString.Length / 2];

            for (int index = 0; index < byteArray.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                byteArray[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return byteArray;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSAParameters p = new RSAParameters();
            p.Modulus = HexToByteArray(tBox_sender_Modulus.Text);
            p.Exponent = HexToByteArray(tBox_sender_Exponent.Text);
            _senderCryptoProcessor.InsertParameters(p);

            string encrypted = _senderCryptoProcessor.EncryptString(tBox_sender_Plaintext.Text);
            tBox_sender_cipherbytes.Text = Convert.ToHexString(Convert.FromBase64String(encrypted));
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string decrypted = _receiverCryptoProcessor.Decrypt(HexToByteArray(tBox_Cipherbytes.Text));
            tBox_Decrypted.Text = decrypted;
        }
    }
}
