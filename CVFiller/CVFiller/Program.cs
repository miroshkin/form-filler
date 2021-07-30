using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFiller
{
    static class Program
    {
        //Mutex for single app instance mode
        private static Mutex mutex = null;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            mutex = new Mutex(true, Application.ProductName, out createdNew);

            if (!createdNew)
            {
                //App is already running! Exiting the application  
                MessageBox.Show("FormFiller is already running\nPress Alt + ~ to activate it","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Added as a solution for blurry fonts problem 
            //Makes fonts sharp and clear
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            if (ProcessChecker.IsOnlyProcess(Application.ProductName))
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SearchForm());
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
