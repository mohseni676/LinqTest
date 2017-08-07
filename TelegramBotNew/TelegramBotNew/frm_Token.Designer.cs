namespace TelegramBotNew
{
    partial class frm_Token
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
            this.txt_Token = new System.Windows.Forms.TextBox();
            this.lbl_token = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Bot_name = new System.Windows.Forms.Label();
            this.lbl_Bot_ID = new System.Windows.Forms.Label();
            this.lbl_bot_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Token
            // 
            this.txt_Token.Location = new System.Drawing.Point(95, 12);
            this.txt_Token.Name = "txt_Token";
            this.txt_Token.Size = new System.Drawing.Size(672, 20);
            this.txt_Token.TabIndex = 0;
            // 
            // lbl_token
            // 
            this.lbl_token.AutoSize = true;
            this.lbl_token.Location = new System.Drawing.Point(32, 15);
            this.lbl_token.Name = "lbl_token";
            this.lbl_token.Size = new System.Drawing.Size(57, 13);
            this.lbl_token.TabIndex = 1;
            this.lbl_token.Text = "Bot Token";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(95, 38);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(672, 32);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bot ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bot Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bot Token";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Robot ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bot User";
            // 
            // lbl_Bot_name
            // 
            this.lbl_Bot_name.AutoSize = true;
            this.lbl_Bot_name.Location = new System.Drawing.Point(104, 103);
            this.lbl_Bot_name.Name = "lbl_Bot_name";
            this.lbl_Bot_name.Size = new System.Drawing.Size(19, 13);
            this.lbl_Bot_name.TabIndex = 1;
            this.lbl_Bot_name.Text = "----";
            // 
            // lbl_Bot_ID
            // 
            this.lbl_Bot_ID.AutoSize = true;
            this.lbl_Bot_ID.Location = new System.Drawing.Point(104, 77);
            this.lbl_Bot_ID.Name = "lbl_Bot_ID";
            this.lbl_Bot_ID.Size = new System.Drawing.Size(19, 13);
            this.lbl_Bot_ID.TabIndex = 1;
            this.lbl_Bot_ID.Text = "----";
            // 
            // lbl_bot_user
            // 
            this.lbl_bot_user.AutoSize = true;
            this.lbl_bot_user.Location = new System.Drawing.Point(104, 129);
            this.lbl_bot_user.Name = "lbl_bot_user";
            this.lbl_bot_user.Size = new System.Drawing.Size(19, 13);
            this.lbl_bot_user.TabIndex = 1;
            this.lbl_bot_user.Text = "----";
            // 
            // frm_Token
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 169);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_bot_user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Bot_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Bot_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_token);
            this.Controls.Add(this.txt_Token);
            this.Name = "frm_Token";
            this.Text = "frm_Token";
            this.Load += new System.EventHandler(this.frm_Token_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Token;
        private System.Windows.Forms.Label lbl_token;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Bot_name;
        private System.Windows.Forms.Label lbl_Bot_ID;
        private System.Windows.Forms.Label lbl_bot_user;
    }
}