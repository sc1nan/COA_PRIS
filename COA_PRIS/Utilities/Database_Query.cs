using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS
{
    internal class Database_Query
    {
        public static string login_query = "SELECT COUNT(*) FROM user_cred_table WHERE user_name = '{0}'";
        public static string check_acc_status = "SELECT state FROM user_info_table WHERE user_name = '{0}'";

        public static string deact_acc = "UPDATE user_info_table SET state = 0 WHERE user_name = '{0}'";
        public static string get_pass = "SELECT password FROM user_cred_table WHERE user_name = '{0}'";



    }
}
