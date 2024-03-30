using Org.BouncyCastle.Asn1.X9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS
{
    internal class Database_Query
    {
        public static string get_acc = "SELECT COUNT(*) FROM user_cred_table WHERE user_name = '{0}'";
        public static string check_acc_status = "SELECT state FROM user_info_table WHERE user_name = '{0}'";

        public static string deact_acc = "UPDATE user_info_table SET state = 0 WHERE user_name = '{0}'";
        public static string get_pass = "SELECT password FROM user_cred_table WHERE user_name = '{0}'";

        #region Activity Logging
        public static string logged_in = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP)";
        public static string display_logs = "SELECT user_name, activity, activity_datetime FROM log_table";
        public static string display_three_logs = "SELECT user_name, activity, activity_datetime FROM log_table LIMIT {0}, 10";
        public static string display_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%'";
        public static string display_ten_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%' LIMIT {2}, 10";
        public static string count_logs = "SELECT COUNT(*) FROM log_table";
        //public static string login_attempt = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', 'Attempted to login', CURRENT_TIMESTAMP)";

        #endregion


        public static string get_top_employee_rec = "SELECT employee_no FROM emp_info_table ORDER BY employee_no DESC LIMIT 1";
        public static string get_all_agency_records = "SELECT agency_id, agency_title, cluster_title FROM agency_table NATURAL JOIN cluster_table";
        public static string get_all_cluster_records = "SELECT cluster_id, cluster_title, sector_title FROM cluster_table NATURAL JOIN sector_table";


    }
}
