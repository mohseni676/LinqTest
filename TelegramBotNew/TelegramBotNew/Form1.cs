using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telegram;
namespace TelegramBotNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bot.token = Properties.Settings.Default.Token;
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                bot.update = "true";
                txt_status.Text = bot.update.ToString();
                if (bot.message_id!="")
                {

                }//if message id
            }//while
        }

        private void btn_token_insert_Click(object sender, EventArgs e)
        {
            frm_Token frm_token = new frm_Token();
            frm_token.ShowDialog();
        }
    }
}
