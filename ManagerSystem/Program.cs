using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManagerSystem
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new LoginForm());
        }
    }
}