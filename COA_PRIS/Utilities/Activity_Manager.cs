using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable Display_Logs_Table()
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(Database_Query.display_logs);
            }
            Console.WriteLine(dt);
            return dt;
        }

        public DataTable Display_Specific_Logs_Table(string searchwords, string sortby)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            Console.WriteLine("asdasd");
            Console.WriteLine(string.Format(Database_Query.display_specific_logs, sortby, searchwords));
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_specific_logs, sortby, searchwords));
            }
            Console.WriteLine(dt);
            return dt;
        }
    }
}
