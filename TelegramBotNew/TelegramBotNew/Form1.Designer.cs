namespace TelegramBotNew
{
    partial class Form1
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
            this.txt_status = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_token_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(12, 12);
            this.txt_status.Multiline = true;
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(703, 230);
            this.txt_status.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btn_token_insert
            // 
            this.btn_token_insert.Location = new System.Drawing.Point(12, 248);
            this.btn_token_insert.Name = "btn_token_insert";
            this.btn_token_insert.Size = new System.Drawing.Size(158, 38);
            this.btn_token_insert.TabIndex = 1;
            this.btn_token_insert.Text = "Insert Token";
            this.btn_token_insert.UseVisualStyleBackColor = true;
            this.btn_token_insert.Click += new System.EventHandler(this.btn_token_insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 356);
            this.Controls.Add(this.btn_token_insert);
            this.Controls.Add(this.txt_status);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_token_insert;
    }
}

