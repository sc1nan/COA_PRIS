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
        public static readonly string get_acc = "SELECT COUNT(*) FROM user_cred_table WHERE user_name = '{0}'";
        public static readonly string check_acc_status = "SELECT state FROM user_info_table WHERE user_name = '{0}'";

        public static readonly string deact_acc = "UPDATE user_info_table SET state = 0 WHERE user_name = '{0}'";
        public static readonly string get_pass = "SELECT password FROM user_cred_table WHERE user_name = '{0}'";

        public static string last_query;

        #region Activity Logging
        public static readonly string logged_in = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP)";
        public static readonly string display_logs = "SELECT user_name, activity, activity_datetime FROM log_table";
        public static readonly string display_three_logs = "SELECT user_name, activity, activity_datetime FROM log_table LIMIT {0}, 10";
        public static readonly string display_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%'";
        public static readonly string display_ten_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%' LIMIT {2}, 10";
        public static readonly string count_logs = "SELECT COUNT(*) FROM log_table";
        //public static readonly string login_attempt = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', 'Attempted to login', CURRENT_TIMESTAMP)";

        #endregion


        public static readonly string get_top_employee_rec = "SELECT employee_no FROM emp_info_table ORDER BY employee_no DESC LIMIT 1";


        #region Maintenance GET Queries

        public static readonly string get_all_agency_records = "SELECT  agency_table.code, agency_table.title, agency_table.description, cluster_table.title\r" +
                                                                "FROM agency_table LEFT JOIN cluster_table ON agency_table.cluster_code = cluster_table.code\r" +
                                                                "WHERE agency_table.status = 1;";
        
        public static readonly string get_all_cluster_records = "SELECT cluster_table.code, cluster_table.title, cluster_table.description, sector_table.title \r" +
                                                                "FROM cluster_table LEFT JOIN sector_table ON cluster_table.sector_code = sector_table.code\r" +
                                                                "WHERE cluster_table.status = 1;";

        public static readonly string get_all_contractor_records = "SELECT contractor_table.code, contractor_table.title, contractor_table.description FROM contractor_table \r" +
                                                                    "WHERE contractor_table.status = 1;";

        public static readonly string get_all_division_records = "SELECT division_table.code, division_table.title, division_table.description, office_table.title \r" +
                                                                    "FROM division_table LEFT JOIN office_table ON division_table.office_code = office_table.code\r" +
                                                                    "WHERE division_table.status = 1;";

        public static readonly string get_all_nature_records = "SELECT nature_table.code, nature_table.title, nature_table.description FROM nature_table\r" +
                                                                    "WHERE nature_table.status = 1;";


        public static readonly string get_all_office_records = "SELECT office_table.code, office_table.title, office_table.description, sector_table.title \r" +
                                                                "FROM office_table LEFT JOIN sector_table ON office_table.sector_code = sector_table.code\r" +
                                                                "WHERE office_table.status = 1;";

        public static readonly string get_all_position_records = "SELECT position_table.code, position_table.title, position_table.description FROM position_table\r" +
                                                                "WHERE position_table.status = 1;";

        public static readonly string get_all_section_records = "SELECT section_table.code, section_table.title, section_table.description, division_table.title\r" +
                                                                "FROM section_table LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                                "WHERE section_table.status = 1;";

        public static readonly string get_all_sector_records = "SELECT sector_table.code, sector_table.title, sector_table.description FROM sector_table\r" +
                                                                "WHERE sector_table.status= 1;";


        #endregion









        public static readonly string get_recent_code = "SELECT code FROM {0} ORDER BY code DESC LIMIT 1";

        public static readonly string get_code_info = "SELECT code, num_length, initial_num FROM code_table WHERE code_table.table = '{0}'";


        public static readonly string get_cluster_options = "SELECT cluster_table.code, cluster_table.title FROM cluster_table";

        public static readonly string get_office_options = "SELECT office_table.code, office_table.title FROM office_table WHERE office_table.status = 1 ;";

        public static readonly string get_sector_options = "SELECT sector_table.code,sector_table.title FROM sector_table WHERE sector_table.status = 1";

        public static readonly string get_division_options = "SELECT division_table.code,division_table.title FROM division_table WHERE division_table.status = 1";
            
        public static readonly string set_new_agency = "INSERT INTO agency_table (code, title, description, cluster_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        public static readonly string set_new_cluster = "INSERT INTO cluster_table (code, title, description, sector_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_contractor = "INSERT INTO contractor_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_nature = "INSERT INTO nature_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_position = "INSERT INTO position_table (code, title, description, status, created_by, created_date)\r" +
                                                         "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_sector = "INSERT INTO sector_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_section = "INSERT INTO section_table (code, title, description, division_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        public static readonly string set_new_office = "INSERT INTO office_table (code, title, description, sector_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";
        public static readonly string set_new_division = "INSERT INTO division_table (code, title, description, office_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";


        #region EMPLOYEE
        #endregion
        
        public static readonly string set_new_employee = "INSERT INTO emp_info_table(code,full_name,email,contact_no,section_code,position_code,status,created_by,created_date)\r" +
                                                         "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', 1,'{6}', CURRENT_TIMESTAMP())";
    }
}
