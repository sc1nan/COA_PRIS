using COA_PRIS.Screens;
using COA_PRIS.Utilities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);







            Application.Run(new Login());
            //Activity_Manager.CurrentUser = "TSO_Dev";
            //Application.Run(new Dashboard());
        }
       

        
    }
}
