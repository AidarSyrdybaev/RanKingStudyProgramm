using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RankingAppProject
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
            AuthorizationForm form = new AuthorizationForm();
            Application.Run(form);
            if (form.LoginCheck)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
