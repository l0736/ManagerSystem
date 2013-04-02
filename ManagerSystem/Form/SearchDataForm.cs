using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ManagerSystem.Module;
using MySql.Data.MySqlClient;

namespace ManagerSystem
{
    public partial class SearchDataForm : Form
    {
        private MainForm form;

        public SearchDataForm()
        {
            InitializeComponent();
        }

        public SearchDataForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
            this.FormClosing += new FormClosingEventHandler(form.Form_FormClosing);
            this.dataGridView.ReadOnly = true;
        }

        public SearchDataForm(String text)
        {
            InitializeComponent();
            this.textBoxProductName.Text = text;
            setGridView(MyDataType.LabelProductName);
        }

        private enum MyDataType : int
        {
            Time = 1,
            StaffName = 2,
            ProductName = 3,
            All = 4,
            LabelProductName = 5
        };

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (radioButtonTime.Checked == true)
            {
                setGridView(getSqlString(MyDataType.Time));
            }
            else if (radioButtonStaffName.Checked == true)
            {
                if (getSqlString(MyDataType.StaffName) != null)
                {
                    try
                    {
                        MySQLT.cmd = new MySqlCommand(getSqlString(MyDataType.StaffName), MySQLT.getMySqlConnection());
                        MySqlDataReader data = MySQLT.cmd.ExecuteReader();
                        if (data.HasRows == true)
                        {
                            int staffNumber = 0;
                            while (data.Read())
                            {
                                staffNumber = Convert.ToInt16(data[0].ToString());
                            }
                            data.Close();
                            String sql = "SELECT * From record where UserNumber='" + staffNumber + "'";
                            setGridView(sql);
                        }
                        else
                        {
                            data.Close();
                        }
                    }
                    catch (MySqlException ex)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("請輸入使用者姓名");
                }
            }
            else if (radioButtonProuctName.Checked == true)
            {
                if (getSqlString(MyDataType.ProductName) != null)
                {
                    try
                    {
                        MySQLT.cmd = new MySqlCommand(getSqlString(MyDataType.ProductName), MySQLT.getMySqlConnection());
                        MySqlDataReader data = MySQLT.cmd.ExecuteReader();
                        if (data.HasRows == true)
                        {
                            String prouctName = "";
                            while (data.Read())
                            {
                                prouctName = data[2].ToString();
                            }
                            data.Close();
                            String sql = "SELECT * From record where ProductNumber='" + prouctName + "'";
                            setGridView(sql);
                        }
                        else
                        {
                            data.Close();
                        }
                    }
                    catch (MySqlException ex)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("請輸入產品名稱");
                }
            }
            else if (radioButtonAll.Checked == true)
            {
            }
            else
            {
                MessageBox.Show("至少選一個吧？");
            }
            try
            {
                this.dataGridView.Columns[0].HeaderText = "員工編號";
                this.dataGridView.Columns[1].HeaderText = "拿取時間";
                this.dataGridView.Columns[2].HeaderText = "產品編號";
                this.dataGridView.Columns[3].HeaderText = "倉庫庫存";
                this.dataGridView.Columns[4].HeaderText = "拿取數量";

                //遞增排序
                this.dataGridView.Sort(dataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            catch (ArgumentOutOfRangeException ex)
            {
            }
        }

        private String getSqlString(MyDataType type)
        {
            if (type == MyDataType.Time)
            {
                // String startTime = dateTimePicker1.Value.ToShortDateString().Replace('/', '-');
                // String endTime = dateTimePicker2.Value.ToShortDateString().Replace('/', '-');
                String startTime = dateTimePicker1.Text;
                String endTime = dateTimePicker2.Text;
                return "SELECT * From record where KeepTime BETWEEN '" + startTime + "' AND '" + endTime + "'";
            }
            else if (type == MyDataType.StaffName)
            {
                if (!this.textBoxStaffNmae.Text.Equals(""))
                {
                    return "SELECT * From userinformation where Name='" + this.textBoxStaffNmae.Text + "'";
                }
                else
                {
                    return null;
                }
            }
            else if (type == MyDataType.ProductName)
            {
                if (!this.textBoxProductName.Text.Equals(""))
                {
                    return "SELECT * From level where ProductNumber='" + this.textBoxProductName.Text + "'";
                }
                else
                {
                    return null;
                }
            }
            else if (type == MyDataType.All)
            {
                return "";
            }
            else if (type == MyDataType.LabelProductName)
            {
                if (!this.textBoxProductName.Text.Equals(""))
                {
                    return "SELECT level.*, inventory.InventoryCount FROM LEVEL AS level  LEFT JOIN INVENTORY AS inventory ON level.ProductNumber=inventory.ProductNumber WHERE inventory.ProductNumber='" + this.textBoxProductName.Text + "'";
                }
            }

            return null;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.MinDate.AddDays(1);
        }

        private void SearchDataForm_Load(object sender, EventArgs e)
        {
            this.dataGridView.ReadOnly = true;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/M/d H:m";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.CustomFormat = "yyyy/M/d H:m";
            dateTimePicker2.ShowUpDown = true;
        }

        private void setGridView(String sql)
        {
            DataSet myds = new DataSet();
            MySqlDataAdapter adapeter = new MySqlDataAdapter(sql, MySQLT.getMySqlConnection());
            adapeter.Fill(myds, "Table1");
            this.bindingSource.DataSource = myds.Tables["Table1"];
            this.dataGridView.DataSource = bindingSource;
        }

        private void setGridView(MyDataType type)
        {
            MySQLT.cmd = new MySqlCommand(getSqlString(type), MySQLT.getMySqlConnection());
            MySqlDataReader data = MySQLT.cmd.ExecuteReader();

            if (data.HasRows == true)
            {
                data.Close();
                this.radioButtonProuctName.Checked = true;
                setGridView(MySQLT.cmd.CommandText);
                this.dataGridView.Columns[0].HeaderText = "順序";
                this.dataGridView.Columns[1].HeaderText = "階度";
                this.dataGridView.Columns[2].HeaderText = "產品編號";
                this.dataGridView.Columns[3].HeaderText = "品名規格";
                this.dataGridView.Columns[4].HeaderText = "數量";
            }
            else
            {
                MessageBox.Show("該資料庫沒有該筆資料");
                data.Close();
                this.Close();
            }
            data.Close();
        }
    }
}