using AddApplication.Src.AllForms;
using System;
using System.Windows.Forms;

namespace AddApplication
{

    // NOTE: the code will never be perfect + it is a learning project 
    // so feel free to change the code and commit push it to github.

    // thanks, Niek Tuytel

    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
