using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ManagerSystem.Module;
using MySql.Data.MySqlClient;

namespace ManagerSystem
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void textBox1_ControlRemoved(object sender, ControlEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals("") && !textBox4.Text.Equals(""))
            {
                String sql = "INSERT INTO account(UserNumber) VALUES('" + textBox4.Text + "')";
                MySQLT.cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());
                if (MySQLT.cmd.ExecuteNonQuery() == 1)
                {
                    sql = "INSERT INTO userinformation(UserNumber,Name,Account,Password) VALUES(?UserNumber,?Name,?Account,?Password)";
                    MySQLT.cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());
                    MySqlParameter[] pars = new MySqlParameter[4];
                    pars[0] = new MySqlParameter("?UserNumber", MySqlDbType.Int16, 5);
                    pars[0].Value = textBox4.Text.ToString();
                    pars[1] = new MySqlParameter("?Name", MySqlDbType.VarChar, 30);
                    pars[1].Value = textBox3.Text.ToString();
                    pars[2] = new MySqlParameter("?Account", MySqlDbType.VarChar, 30);
                    pars[2].Value = textBox1.Text.ToString();
                    pars[3] = new MySqlParameter("?Password", MySqlDbType.VarChar, 30);
                    pars[3].Value = textBox2.Text.ToString();
                    MySQLT.cmd.Parameters.AddRange(pars);
                    if (MySQLT.cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("建立成功");
                        this.Close();
                    }
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!((TextBox)sender).Text.Equals(""))
            {
                String sql = "SELECT * FROM userinformation WHERE Account='" + textBox1.Text + "'";
                MySQLT.cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, MySQLT.getMySqlConnection());
                MySqlDataReader data = MySQLT.cmd.ExecuteReader();
                if (data.HasRows == true)
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "帳號已有人使用";
                    textBox1.Focus();
                }
                else
                {
                    label5.ForeColor = Color.Green;
                    label5.Text = "帳號可以使用";
                }
                data.Close();
            }
            else
            {
                MessageBox.Show("請輸入帳號");
            }
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int length = ((TextBox)sender).Text.Length;
            if (length > 30)
            {
                MessageBox.Show("帳號不得超過30個字");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int length = ((TextBox)sender).Text.Length;
            if (length > 30)
            {
                MessageBox.Show("密碼不得超過30個字");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int length = ((TextBox)sender).Text.Length;
            if (length > 30)
            {
                MessageBox.Show("姓名不得超過30個字");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            String userNumber = ((TextBox)sender).Text;
            Regex regex = new Regex("^[0-9]*[1-9][0-9]*$");
            if (!userNumber.Equals("") && regex.IsMatch(userNumber))
            {
                String sql = "SELECT * FROM account WHERE UserNumber='" + textBox4.Text + "'";
                MySQLT.cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, MySQLT.getMySqlConnection());
                MySqlDataReader data = MySQLT.cmd.ExecuteReader();
                if (data.HasRows == true)
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "該員工帳號以建立";
                    textBox1.Focus();
                }
                else
                {
                    label5.ForeColor = Color.Green;
                    label5.Text = "該員工帳號尚未建立";
                }
                data.Close();
            }
            else
            {
                MessageBox.Show("請輸入員工編號，並且要是數字");
                this.textBox4.Focus();
            }
        }
    }
}