using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COA_PRIS.Utilities
{
    internal class Activity_Manager
    {
        private Database_Manager db_Manager;


        /*public void AnonymousLoginAttempt(string username)
        {
            db_Manager = new Database_Manager();

            using(db_Manager )
            {
                //db_Manager.ExecuteScalar(string.Format(Database_Query.login_attempt));
                Console.WriteLine("a");
                db_Manager.ExecuteNonQuery(Database_Query.login_attempt);
            }
        }

        public void SuccessfulLogin(string username)
        {
            db_Manager = new Database_Manager();

            using (db_Manager)
            {
                db_Manager.ExecuteNonQuery(string.Format(Database_Query.logged_in, username));
            }
        }*/

        public void Log_Activity(string username, string message) 
        {
            db_Manager = new Database_Manager();
            int ret = 0;
            using (db_Manager) 
            { 
                ret = Convert.ToInt32(db_Manager.ExecuteNonQuery(string.Format(Database_Query.logged_in, username, message)));
            }
            
        }
    }
}
