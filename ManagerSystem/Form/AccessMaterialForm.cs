using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ManagerSystem.Module;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace ManagerSystem
{
    public partial class AccessMaterialForm : Form
    {
        private static MySqlDataReader data;
        private static int number = 0;
        private MainForm form;

        public AccessMaterialForm()
        {
            InitializeComponent();
        }

        public AccessMaterialForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
            this.FormClosing += new FormClosingEventHandler(form.Form_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String sql = "SELECT ProductNumber FROM level";
            MySQLT.cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());
            data = MySQLT.cmd.ExecuteReader();

            while (data.Read())
            {
                comboBox1.Items.Add(data[0]);
            }
            comboBox1.SelectedIndex = 0;
            data.Close();
        }

        private void button1_Click(object sender, EventArgs e) //重置按鈕
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox combox = ((ComboBox)sender);
                String sql = "SELECT * FROM inventory where ProductNumber='" + combox.SelectedItem.ToString() + "'";
                MySQLT.cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());

                data = MySQLT.cmd.ExecuteReader();
                while (data.Read())
                {
                    number = Convert.ToInt32(data[2].ToString());
                    label6.Text = data[2].ToString();
                }
                data.Close();
            }
            catch (MySqlException ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text.ToString(), @"^\+?[1-9][0-9]*$") && textBox2.Text != "")
            {
                try
                {
                    String sql = @"SELECT * FROM userinformation WHERE UserNumber=" + textBox2.Text + "";
                    MySQLT.cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());
                    data = MySQLT.cmd.ExecuteReader();

                    if (data.HasRows == true)
                    {
                        if (data.Read() == true)
                        {
                            int getNumber = Convert.ToInt32(textBox1.Text.ToString());

                            //員工編號
                            int staffNumber = Convert.ToInt16(data[0].ToString());

                            //使用者名稱
                            String user = data[1].ToString();
                            data.Close();
                            if (getNumber <= number)
                            {
                                number -= getNumber;
                                sql = "UPDATE inventory SET InventoryCount='" + number + "' WHERE ProductNumber='" + comboBox1.SelectedItem.ToString() + "'";

                                MySQLT.cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());

                                if (MySQLT.cmd.ExecuteNonQuery() == 1)
                                {
                                    sql = "Insert Into record (UserNumber,KeepTime,ProductNumber,InventoryCount,Count)VALUES (?UserNumber,?KeepTime,?ProductNumber,?InventoryCount,?Count)";
                                    MySqlCommand cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());
                                    MySqlParameter[] pars = new MySqlParameter[5];
                                    pars[0] = new MySqlParameter("?UserNumber", MySqlDbType.Int16, 5);
                                    pars[0].Value = staffNumber;
                                    pars[1] = new MySqlParameter("?KeepTime", MySqlDbType.DateTime);
                                    pars[1].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    pars[2] = new MySqlParameter("?ProductNumber", MySqlDbType.VarChar, 40);
                                    pars[2].Value = comboBox1.SelectedItem.ToString();
                                    pars[3] = new MySqlParameter("?InventoryCount", MySqlDbType.Int16, 10);
                                    pars[3].Value = number;
                                    pars[4] = new MySqlParameter("?Count", MySqlDbType.Int16, 5);
                                    pars[4].Value = getNumber;
                                    cmd.Parameters.AddRange(pars);
                                    if (cmd.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("謝謝" + user + "先生/小姐領取");
                                        label6.Text = number + "";
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("領取數量過多，請重新輸入");
                                textBox1.Focus();
                                textBox1.Text = "";
                            }
                        }
                    }
                    else
                    {
                        data.Close();
                        MessageBox.Show("你並不是該公司的員工");
                    }
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("你領取的數量過大");
                }
                catch (MySqlException ex) { }
            }
            else
            {
                MessageBox.Show("請輸入正確員工編號或是領取數量");
            }
        }

        public static DateTime FROM_UNIXTIME(long timeStamp)
        {
            return DateTime.Parse("1970-01-01 00:00:00").AddSeconds(timeStamp);
        }

        public static long UNIX_TIMESTAMP(DateTime dateTime)
        {
            return (dateTime.Ticks - DateTime.Parse("1970-01-01 00:00:00").Ticks) / 10000000;
        }
    }
}