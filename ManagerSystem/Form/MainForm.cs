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

            for (int i = 3; i <= 9; i++)
            {
                Button btn = (Button)this.Controls["button" + i];
                btn.Enabled = false;
            }
        }

        private void MainForm_button_Material_Click(object sender, EventArgs e)
        {
            // this.Hide();

            new AccessMaterialForm().ShowDialog();
        }

        private void MainForm_button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_button_Login_Click(object sender, EventArgs e)
        {
            using (LoginForm lf = new LoginForm())
            {
                lf.ShowDialog();
                if (lf.IsLogin == true)
                {
                    Boolean bn = true;
                    if (bn)
                    {
                        for (int i = 3; i <= 9; i++)
                        {
                            Button bt = (Button)this.Controls["button" + i];
                            bt.Enabled = true;
                        }
                        MainForm_button_Login.Hide();
                    }
                }
            }
        }

        private void MainForm_button_Edit_Click(object sender, EventArgs e)
        {
            EditImageForm Ed = new EditImageForm();
            Ed.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}