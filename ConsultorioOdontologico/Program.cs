using ConsultorioOdontologico.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioOdontologico
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
            //Application.Run(new Login());

            Login login = new Login();
            login.FormClosed += Login_Closed; // agrega esto aquí
            login.Show();
            Application.Run();

        }

        private static void Login_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Login_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += Login_Closed;
            }
        }
    }
}
