﻿using System;
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
            return dt;
        }

        public DataTable Display_Specific_Logs_Table(string searchwords, string sortby)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_specific_logs, sortby, searchwords));
            }
            return dt;
        }
        public DataTable Display_Ten_Specific_Logs_Table(string searchwords, string sortby, int minimium)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_ten_specific_logs, sortby, searchwords, minimium));
            }
            return dt;
        }

        public DataTable Display_Three_Logs_Table(int minimium)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_three_logs, minimium));
            }
            return dt;
        }

        public int Count_Logs()
        {
            db_Manager = new Database_Manager();
            int count;
            using (db_Manager)
            {
                count = Convert.ToInt32(db_Manager.ExecuteScalar(Database_Query.count_logs));
            }
            return count;
        }
    }
}
