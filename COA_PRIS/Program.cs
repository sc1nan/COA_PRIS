using COA_PRIS.Screens;
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







            //Application.Run(new Login());
            //Application.Run(new Splash_Screen());
            Application.Run(new Dashboard());
        }

        
    }
}
