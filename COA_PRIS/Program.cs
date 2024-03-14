using COA_PRIS.Screens;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //Test();
            Application.Run(new Dashboard());
        }

        static void Test()
        {
            var dbCon = DBConnection.Instance();

            if (dbCon.IsConnect()) 
            {
                var cmd = new MySqlCommand("SELECT * FROM user_credential", dbCon.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                { 
                    Console.WriteLine(String.Format("{0}", reader[1]));
                }
                reader.Close();
                dbCon.Close();
            }
            


        }
    }
}
