using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManagerSystem.Module;
using MySql.Data.MySqlClient;

namespace ManagerSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_system_btn_login_Click(object sender, EventArgs e)
        {
            if (Login_textBox_Account.Text.Equals("") || Login_textBox_Password.Text.Equals(""))
            {
                MessageBox.Show("請正確輸入!", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String account = Login_textBox_Account.Text;
                String password = Login_textBox_Password.Text;
                String sql = "SELECT * From userinformation WHERE Account='" + account + "' AND Password='" + password + "'";

                MySQLT.cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());
                try
                {
                    MySqlDataReader data = MySQLT.cmd.ExecuteReader();
                    if (data.HasRows == true)
                    {
                        new MainForm().Show(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("帳號或是密碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    data.Close();
                }
                catch (MySqlException ex)
                {
                }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MySQLT.setDataBase("127.0.0.1", "managersystem", "123456789");
            MySQLT.Open();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CreateAccountForm().ShowDialog();
        }
    }
}