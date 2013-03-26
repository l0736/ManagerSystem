using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManagerSystem
{
    public partial class AccessMaterialForm : Form
    {
        private static MySqlDataReader data;
        private static MySqlCommand cmd;
        private static MySqlConnection conn;
        private static int number = 0;

        public AccessMaterialForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagerSystem.Module.MySQLT.setDataBase("127.0.0.1", "managersystem", "123456789", "root", 3306);
            conn = ManagerSystem.Module.MySQLT.getMySqlConnection();
            conn.Open();
            String sql = "SELECT ProductNumber FROM level";
            cmd = new MySqlCommand(sql, conn);
            data = cmd.ExecuteReader();

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
                cmd = new MySqlCommand(sql, conn);

                data = cmd.ExecuteReader();
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
                    String sql = @"SELECT * FROM account WHERE UserNumber=" + textBox2.Text + "";
                    cmd = new MySqlCommand(sql, conn);
                    data = cmd.ExecuteReader();

                    if (data.HasRows == true)
                    {
                        if (data.Read() == true)
                        {
                            String user = data[1].ToString();
                            data.Close();
                            int getNumber = Convert.ToInt32(textBox1.Text.ToString());
                            if (getNumber <= number)
                            {
                                number -= getNumber;
                                sql = "UPDATE inventory SET InventoryCount='" + number + "' WHERE ProductNumber='" + comboBox1.SelectedItem.ToString() + "'";

                                cmd = new MySqlCommand(sql, conn);
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("謝謝" + user + "先生/小姐領取");
                                    label6.Text = number + "";
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

        private void AccessMaterialForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}