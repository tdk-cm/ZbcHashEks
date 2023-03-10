namespace ZbcHashEks.ClientServerKeys.Forms
{
    partial class NewMessageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CreatedBy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_UsingKeyFrom = new System.Windows.Forms.ComboBox();
            this.tBox_Message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created by: ";
            // 
            // lbl_CreatedBy
            // 
            this.lbl_CreatedBy.AutoSize = true;
            this.lbl_CreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CreatedBy.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_CreatedBy.Location = new System.Drawing.Point(153, 15);
            this.lbl_CreatedBy.Name = "lbl_CreatedBy";
            this.lbl_CreatedBy.Size = new System.Drawing.Size(68, 21);
            this.lbl_CreatedBy.TabIndex = 1;
            this.lbl_CreatedBy.Text = "Client 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Using key from:";
            // 
            // combo_UsingKeyFrom
            // 
            this.combo_UsingKeyFrom.ForeColor = System.Drawing.Color.CadetBlue;
            this.combo_UsingKeyFrom.FormattingEnabled = true;
            this.combo_UsingKeyFrom.Location = new System.Drawing.Point(137, 59);
            this.combo_UsingKeyFrom.Name = "combo_UsingKeyFrom";
            this.combo_UsingKeyFrom.Size = new System.Drawing.Size(121, 23);
            this.combo_UsingKeyFrom.TabIndex = 2;
            // 
            // tBox_Message
            // 
            this.tBox_Message.Location = new System.Drawing.Point(138, 129);
            this.tBox_Message.Name = "tBox_Message";
            this.tBox_Message.Size = new System.Drawing.Size(367, 23);
            this.tBox_Message.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Message:";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(185, 235);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(145, 63);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "Create Message";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(559, 356);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tBox_Message);
            this.Controls.Add(this.combo_UsingKeyFrom);
            this.Controls.Add(this.lbl_CreatedBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NewMessageForm";
            this.Text = "NewMessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_CreatedBy;
        private Label label3;
        private ComboBox combo_UsingKeyFrom;
        private TextBox tBox_Message;
        private Label label4;
        private Button btn_Create;
    }
}