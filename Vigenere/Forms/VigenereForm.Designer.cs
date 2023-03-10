namespace ZbcHashEks.Vigenere.Forms
{
    partial class VigenereForm
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
            this.tBox_Encrypt_Input = new System.Windows.Forms.TextBox();
            this.tBox_Encrypt_CodeKey = new System.Windows.Forms.TextBox();
            this.tBox_Encrypt_Answer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBox_Decrypt_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_Decrypt_CodeKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_Decrypt_Answer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBox_Encrypt_Input
            // 
            this.tBox_Encrypt_Input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBox_Encrypt_Input.Location = new System.Drawing.Point(142, 32);
            this.tBox_Encrypt_Input.Name = "tBox_Encrypt_Input";
            this.tBox_Encrypt_Input.Size = new System.Drawing.Size(408, 23);
            this.tBox_Encrypt_Input.TabIndex = 0;
            // 
            // tBox_Encrypt_CodeKey
            // 
            this.tBox_Encrypt_CodeKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBox_Encrypt_CodeKey.Location = new System.Drawing.Point(142, 88);
            this.tBox_Encrypt_CodeKey.Name = "tBox_Encrypt_CodeKey";
            this.tBox_Encrypt_CodeKey.Size = new System.Drawing.Size(408, 23);
            this.tBox_Encrypt_CodeKey.TabIndex = 0;
            // 
            // tBox_Encrypt_Answer
            // 
            this.tBox_Encrypt_Answer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBox_Encrypt_Answer.Location = new System.Drawing.Point(142, 146);
            this.tBox_Encrypt_Answer.Name = "tBox_Encrypt_Answer";
            this.tBox_Encrypt_Answer.Size = new System.Drawing.Size(408, 23);
            this.tBox_Encrypt_Answer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Encrypted Message:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tBox_Encrypt_Input);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tBox_Encrypt_CodeKey);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBox_Encrypt_Answer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 216);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tBox_Decrypt_Input);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tBox_Decrypt_CodeKey);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tBox_Decrypt_Answer);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(32, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 216);
            this.panel2.TabIndex = 2;
            // 
            // tBox_Decrypt_Input
            // 
            this.tBox_Decrypt_Input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBox_Decrypt_Input.Location = new System.Drawing.Point(142, 32);
            this.tBox_Decrypt_Input.Name = "tBox_Decrypt_Input";
            this.tBox_Decrypt_Input.Size = new System.Drawing.Size(408, 23);
            this.tBox_Decrypt_Input.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Encrypted Message:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tBox_Decrypt_CodeKey
            // 
            this.tBox_Decrypt_CodeKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBox_Decrypt_CodeKey.Location = new System.Drawing.Point(142, 88);
            this.tBox_Decrypt_CodeKey.Name = "tBox_Decrypt_CodeKey";
            this.tBox_Decrypt_CodeKey.Size = new System.Drawing.Size(408, 23);
            this.tBox_Decrypt_CodeKey.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Code key:";
            // 
            // tBox_Decrypt_Answer
            // 
            this.tBox_Decrypt_Answer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBox_Decrypt_Answer.Location = new System.Drawing.Point(142, 146);
            this.tBox_Decrypt_Answer.Name = "tBox_Decrypt_Answer";
            this.tBox_Decrypt_Answer.Size = new System.Drawing.Size(408, 23);
            this.tBox_Decrypt_Answer.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Original Message:";
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Encrypt.Location = new System.Drawing.Point(669, 104);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(119, 56);
            this.btn_Encrypt.TabIndex = 3;
            this.btn_Encrypt.Text = "ENCRYPT";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Decrypt.Location = new System.Drawing.Point(669, 349);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(119, 56);
            this.btn_Decrypt.TabIndex = 3;
            this.btn_Decrypt.Text = "DECRYPT";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // VigenereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VigenereForm";
            this.Text = "VigenereForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tBox_Encrypt_Input;
        private TextBox tBox_Encrypt_CodeKey;
        private TextBox tBox_Encrypt_Answer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private TextBox tBox_Decrypt_Input;
        private Label label4;
        private TextBox tBox_Decrypt_CodeKey;
        private Label label5;
        private TextBox tBox_Decrypt_Answer;
        private Label label6;
        private Button btn_Encrypt;
        private Button btn_Decrypt;
    }
}