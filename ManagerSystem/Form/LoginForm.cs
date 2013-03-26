using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManagerSystem
{
    public partial class LoginForm : Form
    {
        Boolean isLogin = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_system_btn_login_Click(object sender, EventArgs e)
        {
            // String[] str_account = new String[] { "q", "w" };
            // String[] str_password = new String[] { "1", "2" };
           
            String account = "test";
            String password = "test";

            if (this.Login_textBox_Account.Text.Equals("") || this.Login_textBox_Password.Text.Equals(""))
            {
                MessageBox.Show("請正確輸入!", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.Login_textBox_Account.Text.Equals(account))
            {
                if (this.Login_textBox_Password.Text.Equals(password))
                {
                    isLogin = true;
                    this.Hide();
                   // new MainForm().ShowDialog();
                }
            }

            if (!isLogin)
            {
                MessageBox.Show("帳號或是密碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            //
        }

        public bool IsLogin
        {
            get { return this.isLogin; }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}