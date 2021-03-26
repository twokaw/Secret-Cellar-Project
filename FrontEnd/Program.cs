using System;
using System.Windows.Forms;

namespace SecretCellar
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
            new DataAccess(Properties.Settings.Default.URL);
            Application.Run(new frmTransaction());
        }
    }
}
