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
    public partial class AccessMaterialForm : Form
    {
        public AccessMaterialForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //員工證號
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //領取數量
        {
        }

        private void button1_Click(object sender, EventArgs e) //重置按鈕
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType().ToString().Contains("TextBox"))//取得多個textbox判斷
                {
                    ((TextBox)c).Text = ""; //清除textbox內文字
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //確認按鈕
        {
        }
    }
}