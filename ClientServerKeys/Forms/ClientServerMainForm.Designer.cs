namespace ZbcHashEks.ClientServerKeys.Forms
{
    partial class ClientServerMainForm
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
            this.flow_Clients = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_Messages = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_MessageParent = new System.Windows.Forms.Panel();
            this.panel_MessagePreview = new System.Windows.Forms.Panel();
            this.lbl_MsgEncryptedby = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBox_MessageText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_ClientActionsParent = new System.Windows.Forms.Panel();
            this.panel_ClientActions = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_ClientActions_ClientId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Test_ClientId = new System.Windows.Forms.Label();
            this.panel_MessageParent.SuspendLayout();
            this.panel_MessagePreview.SuspendLayout();
            this.panel_ClientActionsParent.SuspendLayout();
            this.panel_ClientActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // flow_Clients
            // 
            this.flow_Clients.AutoScroll = true;
            this.flow_Clients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flow_Clients.Location = new System.Drawing.Point(37, 205);
            this.flow_Clients.Name = "flow_Clients";
            this.flow_Clients.Size = new System.Drawing.Size(900, 114);
            this.flow_Clients.TabIndex = 1;
            // 
            // flow_Messages
            // 
            this.flow_Messages.AutoScroll = true;
            this.flow_Messages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flow_Messages.Location = new System.Drawing.Point(37, 41);
            this.flow_Messages.Name = "flow_Messages";
            this.flow_Messages.Size = new System.Drawing.Size(900, 114);
            this.flow_Messages.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(653, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message Preview";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "CLIENTS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel_MessageParent
            // 
            this.panel_MessageParent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_MessageParent.Controls.Add(this.panel_MessagePreview);
            this.panel_MessageParent.Location = new System.Drawing.Point(509, 359);
            this.panel_MessageParent.Name = "panel_MessageParent";
            this.panel_MessageParent.Size = new System.Drawing.Size(428, 113);
            this.panel_MessageParent.TabIndex = 3;
            // 
            // panel_MessagePreview
            // 
            this.panel_MessagePreview.Controls.Add(this.lbl_MsgEncryptedby);
            this.panel_MessagePreview.Controls.Add(this.label5);
            this.panel_MessagePreview.Controls.Add(this.label6);
            this.panel_MessagePreview.Controls.Add(this.tBox_MessageText);
            this.panel_MessagePreview.Location = new System.Drawing.Point(-2, -2);
            this.panel_MessagePreview.Name = "panel_MessagePreview";
            this.panel_MessagePreview.Size = new System.Drawing.Size(428, 113);
            this.panel_MessagePreview.TabIndex = 0;
            // 
            // lbl_MsgEncryptedby
            // 
            this.lbl_MsgEncryptedby.AutoSize = true;
            this.lbl_MsgEncryptedby.Location = new System.Drawing.Point(222, 11);
            this.lbl_MsgEncryptedby.Name = "lbl_MsgEncryptedby";
            this.lbl_MsgEncryptedby.Size = new System.Drawing.Size(47, 15);
            this.lbl_MsgEncryptedby.TabIndex = 2;
            this.lbl_MsgEncryptedby.Text = "Client 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Encrypted with:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Message:";
            // 
            // tBox_MessageText
            // 
            this.tBox_MessageText.Location = new System.Drawing.Point(74, 49);
            this.tBox_MessageText.Name = "tBox_MessageText";
            this.tBox_MessageText.Size = new System.Drawing.Size(325, 23);
            this.tBox_MessageText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "MESSAGES";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel_ClientActionsParent
            // 
            this.panel_ClientActionsParent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ClientActionsParent.Controls.Add(this.panel_ClientActions);
            this.panel_ClientActionsParent.Location = new System.Drawing.Point(37, 359);
            this.panel_ClientActionsParent.Name = "panel_ClientActionsParent";
            this.panel_ClientActionsParent.Size = new System.Drawing.Size(408, 113);
            this.panel_ClientActionsParent.TabIndex = 4;
            // 
            // panel_ClientActions
            // 
            this.panel_ClientActions.Controls.Add(this.button2);
            this.panel_ClientActions.Controls.Add(this.label8);
            this.panel_ClientActions.Controls.Add(this.lbl_ClientActions_ClientId);
            this.panel_ClientActions.Controls.Add(this.button1);
            this.panel_ClientActions.Location = new System.Drawing.Point(-1, 0);
            this.panel_ClientActions.Name = "panel_ClientActions";
            this.panel_ClientActions.Size = new System.Drawing.Size(407, 111);
            this.panel_ClientActions.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Decrypt Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Client ID: ";
            // 
            // lbl_ClientActions_ClientId
            // 
            this.lbl_ClientActions_ClientId.AutoSize = true;
            this.lbl_ClientActions_ClientId.Location = new System.Drawing.Point(217, 9);
            this.lbl_ClientActions_ClientId.Name = "lbl_ClientActions_ClientId";
            this.lbl_ClientActions_ClientId.Size = new System.Drawing.Size(13, 15);
            this.lbl_ClientActions_ClientId.TabIndex = 1;
            this.lbl_ClientActions_ClientId.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create new Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(179, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Client Actions";
            // 
            // lbl_Test_ClientId
            // 
            this.lbl_Test_ClientId.AutoSize = true;
            this.lbl_Test_ClientId.Location = new System.Drawing.Point(468, 517);
            this.lbl_Test_ClientId.Name = "lbl_Test_ClientId";
            this.lbl_Test_ClientId.Size = new System.Drawing.Size(38, 15);
            this.lbl_Test_ClientId.TabIndex = 5;
            this.lbl_Test_ClientId.Text = "label4";
            // 
            // ClientServerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(990, 771);
            this.Controls.Add(this.lbl_Test_ClientId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel_ClientActionsParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_MessageParent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flow_Messages);
            this.Controls.Add(this.flow_Clients);
            this.Name = "ClientServerMainForm";
            this.Text = "ClientServerMainForm";
            this.panel_MessageParent.ResumeLayout(false);
            this.panel_MessagePreview.ResumeLayout(false);
            this.panel_MessagePreview.PerformLayout();
            this.panel_ClientActionsParent.ResumeLayout(false);
            this.panel_ClientActions.ResumeLayout(false);
            this.panel_ClientActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlowLayoutPanel flow_Clients;
        private FlowLayoutPanel flow_Messages;
        private Label label1;
        private Label label3;
        private Panel panel_MessageParent;
        private Label lbl_MsgEncryptedby;
        private TextBox tBox_MessageText;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel_ClientActionsParent;
        private Label label7;
        private Panel panel_MessagePreview;
        private Label label8;
        private Label lbl_ClientActions_ClientId;
        private Button button1;
        private Button button2;
        private Panel panel_ClientActions;
        private Label lbl_Test_ClientId;
    }
}