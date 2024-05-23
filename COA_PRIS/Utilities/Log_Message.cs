using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS.Utilities
{
    internal class Log_Message
    {
        public static string login_message = "Logged In";
        public static string logout_message = "Logged Out";
        public static string login_attempt = "Attempted to Login";

        public static readonly string set_docu_message = "{0} - {1} : Created by {2}";
        public static readonly string update_docu_message = "{0} - {1} : Updated by {2}"; 
    }
}
