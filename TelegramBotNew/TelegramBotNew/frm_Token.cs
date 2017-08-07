using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBotNew
{
    public partial class frm_Token : Form
    {
        public frm_Token()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_Token.Text == "")
            {
                MessageBox.Show("Please Insert Token");
            }
            else
            {
                Telegram.bot.Token_Status = txt_Token.Text;
                string JSON_string = Telegram.bot.Token_Status.ToString();
                MessageBox.Show(JSON_string);
                if (JSON_string.ToLower() == "false")
                {
                    MessageBox.Show("Token is invalid!!!");
                }
                else
                {
                    lbl_Bot_ID.Text = Telegram.JSON.Read.get_JSONRead(JSON_string, "result", "id");
                    lbl_Bot_name.Text = Telegram.JSON.Read.get_JSONRead(JSON_string, "result", "first_name");
                    lbl_bot_user.Text = Telegram.JSON.Read.get_JSONRead(JSON_string, "result", "username");
                    Properties.Settings.Default.Token = txt_Token.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void frm_Token_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Token != "")
            {
                txt_Token.Text = Properties.Settings.Default.Token;
            }
        }
    }
}
