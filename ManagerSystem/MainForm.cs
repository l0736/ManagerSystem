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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            for (int i = 2; i <= 9; i++)
            {
                Button btn = (Button)this.Controls["button" + i];
            }
        }

        private void MainForm_button_Material_Click(object sender, EventArgs e)
        {
            this.Hide();

            new AccessMaterialForm().ShowDialog();
        }

        private void MainForm_button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}