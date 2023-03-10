namespace ZbcHashEks.AsymmetriskKryptering.Forms
{
    partial class PlayerOneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBox_Modulus = new System.Windows.Forms.TextBox();
            this.tBox_Exponent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBox_Priv_Q = new System.Windows.Forms.TextBox();
            this.tBox_Priv_P = new System.Windows.Forms.TextBox();
            this.tBox_Priv_InvQ = new System.Windows.Forms.TextBox();
            this.tBox_Priv_DQ = new System.Windows.Forms.TextBox();
            this.tBox_Priv_DP = new System.Windows.Forms.TextBox();
            this.tBox_Priv_D = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBox_Cipherbytes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tBox_Decrypted = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tBox_sender_cipherbytes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tBox_sender_Plaintext = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tBox_sender_Modulus = new System.Windows.Forms.TextBox();
            this.tBox_sender_Exponent = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tBox_Modulus);
            this.panel1.Controls.Add(this.tBox_Exponent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 91);
            this.panel1.TabIndex = 0;
            // 
            // tBox_Modulus
            // 
            this.tBox_Modulus.Location = new System.Drawing.Point(89, 50);
            this.tBox_Modulus.Name = "tBox_Modulus";
            this.tBox_Modulus.Size = new System.Drawing.Size(278, 23);
            this.tBox_Modulus.TabIndex = 2;
            // 
            // tBox_Exponent
            // 
            this.tBox_Exponent.Location = new System.Drawing.Point(89, 8);
            this.tBox_Exponent.Name = "tBox_Exponent";
            this.tBox_Exponent.Size = new System.Drawing.Size(278, 23);
            this.tBox_Exponent.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Modulus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Exponent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, -15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Public Data";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tBox_Priv_Q);
            this.panel2.Controls.Add(this.tBox_Priv_P);
            this.panel2.Controls.Add(this.tBox_Priv_InvQ);
            this.panel2.Controls.Add(this.tBox_Priv_DQ);
            this.panel2.Controls.Add(this.tBox_Priv_DP);
            this.panel2.Controls.Add(this.tBox_Priv_D);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(14, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 254);
            this.panel2.TabIndex = 1;
            // 
            // tBox_Priv_Q
            // 
            this.tBox_Priv_Q.Location = new System.Drawing.Point(89, 213);
            this.tBox_Priv_Q.Name = "tBox_Priv_Q";
            this.tBox_Priv_Q.Size = new System.Drawing.Size(278, 23);
            this.tBox_Priv_Q.TabIndex = 2;
            // 
            // tBox_Priv_P
            // 
            this.tBox_Priv_P.Location = new System.Drawing.Point(89, 175);
            this.tBox_Priv_P.Name = "tBox_Priv_P";
            this.tBox_Priv_P.Size = new System.Drawing.Size(278, 23);
            this.tBox_Priv_P.TabIndex = 2;
            // 
            // tBox_Priv_InvQ
            // 
            this.tBox_Priv_InvQ.Location = new System.Drawing.Point(89, 134);
            this.tBox_Priv_InvQ.Name = "tBox_Priv_InvQ";
            this.tBox_Priv_InvQ.Size = new System.Drawing.Size(278, 23);
            this.tBox_Priv_InvQ.TabIndex = 2;
            // 
            // tBox_Priv_DQ
            // 
            this.tBox_Priv_DQ.Location = new System.Drawing.Point(89, 98);
            this.tBox_Priv_DQ.Name = "tBox_Priv_DQ";
            this.tBox_Priv_DQ.Size = new System.Drawing.Size(278, 23);
            this.tBox_Priv_DQ.TabIndex = 2;
            // 
            // tBox_Priv_DP
            // 
            this.tBox_Priv_DP.Location = new System.Drawing.Point(89, 56);
            this.tBox_Priv_DP.Name = "tBox_Priv_DP";
            this.tBox_Priv_DP.Size = new System.Drawing.Size(278, 23);
            this.tBox_Priv_DP.TabIndex = 2;
            // 
            // tBox_Priv_D
            // 
            this.tBox_Priv_D.Location = new System.Drawing.Point(89, 13);
            this.tBox_Priv_D.Name = "tBox_Priv_D";
            this.tBox_Priv_D.Size = new System.Drawing.Size(278, 23);
            this.tBox_Priv_D.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Q:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "P:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Inverse Q:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "DQ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "DP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "D:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Private Data";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cipherbytes:";
            // 
            // tBox_Cipherbytes
            // 
            this.tBox_Cipherbytes.Location = new System.Drawing.Point(105, 415);
            this.tBox_Cipherbytes.Name = "tBox_Cipherbytes";
            this.tBox_Cipherbytes.Size = new System.Drawing.Size(278, 23);
            this.tBox_Cipherbytes.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 487);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Decrypted:";
            // 
            // tBox_Decrypted
            // 
            this.tBox_Decrypted.Location = new System.Drawing.Point(105, 484);
            this.tBox_Decrypted.Name = "tBox_Decrypted";
            this.tBox_Decrypted.Size = new System.Drawing.Size(278, 23);
            this.tBox_Decrypted.TabIndex = 2;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Decrypt.Location = new System.Drawing.Point(143, 444);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(130, 30);
            this.btn_Decrypt.TabIndex = 3;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = false;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_Decrypt);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tBox_Decrypted);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tBox_Cipherbytes);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 518);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.tBox_sender_cipherbytes);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.tBox_sender_Plaintext);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(486, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 518);
            this.panel4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(143, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Plaintext:";
            // 
            // tBox_sender_cipherbytes
            // 
            this.tBox_sender_cipherbytes.Location = new System.Drawing.Point(105, 223);
            this.tBox_sender_cipherbytes.Name = "tBox_sender_cipherbytes";
            this.tBox_sender_cipherbytes.Size = new System.Drawing.Size(278, 23);
            this.tBox_sender_cipherbytes.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Public Data";
            // 
            // tBox_sender_Plaintext
            // 
            this.tBox_sender_Plaintext.Location = new System.Drawing.Point(105, 154);
            this.tBox_sender_Plaintext.Name = "tBox_sender_Plaintext";
            this.tBox_sender_Plaintext.Size = new System.Drawing.Size(278, 23);
            this.tBox_sender_Plaintext.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Cipherbytes:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tBox_sender_Modulus);
            this.panel5.Controls.Add(this.tBox_sender_Exponent);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Location = new System.Drawing.Point(14, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 91);
            this.panel5.TabIndex = 0;
            // 
            // tBox_sender_Modulus
            // 
            this.tBox_sender_Modulus.Location = new System.Drawing.Point(89, 50);
            this.tBox_sender_Modulus.Name = "tBox_sender_Modulus";
            this.tBox_sender_Modulus.Size = new System.Drawing.Size(278, 23);
            this.tBox_sender_Modulus.TabIndex = 2;
            // 
            // tBox_sender_Exponent
            // 
            this.tBox_sender_Exponent.Location = new System.Drawing.Point(89, 8);
            this.tBox_sender_Exponent.Name = "tBox_sender_Exponent";
            this.tBox_sender_Exponent.Size = new System.Drawing.Size(278, 23);
            this.tBox_sender_Exponent.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "Modulus:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "Exponent:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, -15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Public Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(135, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 32);
            this.label14.TabIndex = 6;
            this.label14.Text = "Receiver";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(657, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 32);
            this.label21.TabIndex = 7;
            this.label21.Text = "Sender";
            // 
            // PlayerOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(920, 584);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "PlayerOneForm";
            this.Text = "PlayerOneForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tBox_Modulus;
        private TextBox tBox_Exponent;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private TextBox tBox_Priv_Q;
        private TextBox tBox_Priv_P;
        private TextBox tBox_Priv_InvQ;
        private TextBox tBox_Priv_DQ;
        private TextBox tBox_Priv_DP;
        private TextBox tBox_Priv_D;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label12;
        private TextBox tBox_Cipherbytes;
        private Label label13;
        private TextBox tBox_Decrypted;
        private Button btn_Decrypt;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Label label15;
        private TextBox tBox_sender_cipherbytes;
        private Label label16;
        private TextBox tBox_sender_Plaintext;
        private Label label17;
        private Panel panel5;
        private TextBox tBox_sender_Modulus;
        private TextBox tBox_sender_Exponent;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label14;
        private Label label21;
    }
}