using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS
{
    public class Database_Query
    {
        public static string login_query = "SELECT COUNT(*) FROM user_credential WHERE user_name = '{0}' AND password = '{1}'";
        public static string check_acc_status = "SELECT user_info.status FROM user_info WHERE user_info.user_name = '{0}'";
    }
}
