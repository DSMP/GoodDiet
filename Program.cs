using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobraDietaApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new LoginForm());
            }
            catch (System.Data.NoNullAllowedException e)
            {
                MessageBox.Show("Fill all required fields like: " + e.Message);
            }
        }
    }
}
