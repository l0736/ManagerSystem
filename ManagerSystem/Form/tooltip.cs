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
    public partial class tooltip : Form
    {
        private static MySqlConnection conn;
        private static MySqlCommand cmd;

        public tooltip()
        {
            InitializeComponent();
        }

        public tooltip(String text)
        {
            String sql = "SELECT a.*,b.* FROM inventory as a, level as b where a.Index=b.Index";

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader data = cmd.ExecuteReader();

            try
            {
                while (data.Read())
                {
                    MessageBox.Show(data.GetOrdinal(text) + "");
                    textBox1.Text = data[0].ToString();
                    textBox2.Text = data[1].ToString();
                }
            }
            catch (MySqlException ex)
            {
            }
        }

        private void tooltip_Load(object sender, EventArgs e)
        {
            MySQLT.setDataBase("127.0.0.1", "managersystem", "123456789", "root", 3306);
            conn = MySQLT.getMySqlConnection();
        }

        private void tooltip_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}