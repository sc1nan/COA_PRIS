using COA_PRIS.Utilities;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS
{
    internal class Database_Query
    {
        public static readonly string get_acc = "SELECT COUNT(*) FROM user_cred_table WHERE user_name = '{0}'";
        public static readonly string check_acc_status = "SELECT status FROM user_info_table WHERE user_name = '{0}'";

        public static readonly string deact_acc = "UPDATE user_info_table SET status = 0 WHERE user_name = '{0}'";
        public static readonly string get_pass = "SELECT password FROM user_cred_table WHERE user_name = '{0}'";

        public static readonly string get_code = "SELECT code FROM code_table WHERE code_table.table = '{0}';";
        public static readonly string get_length = "SELECT num_length FROM code_table WHERE code_table.table = '{0}';";

        public static string last_query;

        #region Activity Logging
        public static readonly string display_logs = "SELECT user_name, activity, activity_datetime FROM log_table";
        public static readonly string count_account_logs = "SELECT COUNT(*) FROM log_table WHERE activity_type = 1";
        public static readonly string count_account_logs_by_date = "SELECT COUNT(*) FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND activity_type = 1";
        public static readonly string count_activity_logs = "SELECT COUNT(*) FROM log_table WHERE activity_type = 2";
        public static readonly string count_activity_logs_by_date = "SELECT COUNT(*) FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND activity_type = 2";
        //deprecated
        public static readonly string count_logs = "SELECT COUNT(*) FROM log_table";
        #region Accounts Logs
        public static readonly string logged_in = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP, 1)";
        public static readonly string logged_out = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP, 1)";
        public static readonly string display_account_logs_by_date = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND activity_type = 1 LIMIT {2}, 15";
        public static readonly string display_specified_account_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND {4} LIKE '%{3}%' AND activity_type = 1 LIMIT {2}, 15";
        public static readonly string display_account_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_type = 1";
        #endregion
        #region Activity Logs
        public static readonly string log_maintenance_activity_add = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP, 2)";
        public static readonly string log_maintenance_activity_delete = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', 'Deleted Record: {1} {2}', CURRENT_TIMESTAMP, 2)";
        public static readonly string log_maintenance_activity_edit = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP, 2)";
        public static readonly string display_activity_logs_by_date = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND activity_type = 2 LIMIT {2}, 15";
        public static readonly string display_specified_activity_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND {4} LIKE '%{3}%' AND activity_type = 2 LIMIT {2}, 15";
        public static readonly string display_activity_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_type = 2";
        public static readonly string return_module_name = "SELECT module FROM code_table WHERE `table` like '{0}'";
        #endregion
        #region Deprecated Logs Query
        public static readonly string display_three_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_type = 1 LIMIT {0}, 15";
        public static readonly string display_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%'";
        public static readonly string display_ten_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%' LIMIT {2}, 15";

        #endregion
        //public static readonly string login_attempt = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', 'Attempted to login', CURRENT_TIMESTAMP)";
        
        #endregion


        public static readonly string get_top_employee_rec = "SELECT employee_no FROM emp_info_table ORDER BY employee_no DESC LIMIT 1";

        public static readonly string get_recent_code = "SELECT code FROM {0} ORDER BY code DESC LIMIT 1";

        public static readonly string get_code_info = "SELECT code, num_length, initial_num FROM code_table WHERE code_table.table = '{0}'";

        public static readonly string delete_record_by_id = "UPDATE {0} SET status = 0 WHERE code = '{1}';";

        public static readonly string delete_user_record_by_id = "UPDATE {0} SET status = 0 WHERE employee_code = '{1}';";

        public static readonly string get_record_code = "SELECT code FROM {0} WHERE title = '{1}';";

        #region Project Requests

        //public static readonly string get_all_project_records = "SELECT * FROM docu_info_table";

        //public static readonly string get_general_project_records_by_date = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}'";
        public static readonly string get_general_project_records_by_date = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\n\r\nFROM docu_info_table \r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\n\r\nORDER BY receiving_date DESC";

        
        //public static readonly string get_specific_project_records_by_date = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND {3} LIKE '%{4}%'";

        public static readonly string get_specific_project_records_by_date = "SELECT docu_info_table.code, docu_info_table.document_no, CONCAT(\"₱ \", FORMAT(docu_info_table.amount,2)) AS amount, DATE_FORMAT(docu_info_table.period, \"%M %Y\") AS period, docu_info_table.subject FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND '{3}' IN \r" +
                                                                                "(document_id, document_code, document_no, amount, title, subject)";

        public static readonly string get_specific_project_records_by_date2 = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\nFROM docu_info_table \r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\nAND\r\n(\r\n    docu_info_table.document_no LIKE '%{3}%' OR\r\n    docu_info_table.title LIKE '%{3}%' OR\r\n    docu_info_table.amount LIKE '%{3}%' \r\n)\r\nORDER BY receiving_date DESC";
        #endregion

        public static readonly string get_office_options_by_id = "SELECT office_table.code, office_table.title, office_table.description FROM office_table \r" +
                                                                    "WHERE office_table.sector_code = '{0}' AND (office_table.status != 0 AND office_table.status != -2);";

        public static readonly string get_division_options_by_id = "SELECT division_table.code, division_table.title, division_table.description FROM division_table \r" +
                                                                    "WHERE division_table.office_code = '{0}' AND (division_table.status != 0 AND division_table.status != -2);";

        public static readonly string get_section_options_by_id = "SELECT section_table.code, section_table.title, section_table.description FROM section_table \r" +
                                                                    "WHERE section_table.division_code = '{0}' AND (section_table.status != 0 AND section_table.status != -2);";

        public static readonly string get_position_options = "SELECT position_table.code, position_table.title, position_table.description FROM position_table \r" +
                                                             "WHERE (position_table.status != 0 AND position_table.status != -2 );";

        public static readonly string get_section_option = "SELECT section_table.code, section_table.title, section_table.description FROM section_table \r" +
                                                            "WHERE (section_table.status != 0 AND section_table.status != -2);";

        public static readonly string get_employee_record_by_id = "SELECT emp_info_table.full_name, emp_info_table.email, emp_info_table.contact_no, sector_table.title, office_table.title, division_table.title, section_table.title, position_table.title\r" +
                                                                    "FROM emp_info_table \r" +
                                                                    "LEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r" +
                                                                    "LEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r" +
                                                                    "LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                                    "LEFT JOIN office_table ON division_table.office_code = office_table.code\r" +
                                                                    "LEFT JOIN sector_table ON office_table.sector_code = sector_table.code\r" +
                                                                    "WHERE emp_info_table.code = '{0}'";


        public static readonly string update_employee_record_by_id = "UPDATE emp_info_table SET \r\nemp_info_table.full_name = '{0}',\r\nemp_info_table.email = '{1}',\r\nemp_info_table.contact_no = '{2}',\r\nemp_info_table.section_code = '{3}',\r\nemp_info_table.position_code = '{4}',\r\nemp_info_table.updated_by = '{5}',\r\nemp_info_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE emp_info_table.code = '{6}' AND emp_info_table.status = 1;";



        public static readonly string get_audit_trail_by_id = "SELECT created_by, created_date, updated_by, updated_date FROM {0} WHERE code = '{1}';";

        #region Maintenance GET Table Queries

        public static readonly string get_all_agency_records = "SELECT  agency_table.code, agency_table.title, agency_table.description, cluster_table.title\r" +
                                                                "FROM agency_table LEFT JOIN cluster_table ON agency_table.cluster_code = cluster_table.code\r" +
                                                                "WHERE agency_table.status != 0 AND agency_table.status != -2;";
        
        public static readonly string get_all_cluster_records = "SELECT cluster_table.code, cluster_table.title, cluster_table.description, sector_table.title \r" +
                                                                "FROM cluster_table LEFT JOIN sector_table ON cluster_table.sector_code = sector_table.code\r" +
                                                                "WHERE cluster_table.status != 0 AND cluster_table.status != -2;";

        public static readonly string get_all_contractor_records = "SELECT contractor_table.code, contractor_table.title, contractor_table.description FROM contractor_table \r" +
                                                                    "WHERE contractor_table.status != 0 AND contractor_table.status != -2 ;";

        public static readonly string get_all_division_records = "SELECT division_table.code, division_table.title, division_table.description, office_table.title \r" +
                                                                    "FROM division_table LEFT JOIN office_table ON division_table.office_code = office_table.code\r" +
                                                                    "WHERE division_table.status != 0 AND division_table.status != -2;";

        public static readonly string get_all_nature_records = "SELECT nature_table.code, nature_table.title, nature_table.description FROM nature_table\r" +
                                                                    "WHERE nature_table.status != 0 AND nature_table.status != -2 ;";


        public static readonly string get_all_office_records = "SELECT office_table.code, office_table.title, office_table.description, sector_table.title \r" +
                                                                "FROM office_table LEFT JOIN sector_table ON office_table.sector_code = sector_table.code\r" +
                                                                "WHERE office_table.status != 0 AND office_table.status != -2 ;";

        public static readonly string get_all_position_records = "SELECT position_table.code, position_table.title, position_table.description FROM position_table\r" +
                                                                "WHERE position_table.status != 0 AND position_table.status != -2;";

        public static readonly string get_all_section_records = "SELECT section_table.code, section_table.title, section_table.description, division_table.title\r" +
                                                                "FROM section_table LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                                "WHERE section_table.status != 0 AND section_table.status != -2;";

        public static readonly string get_all_sector_records = "SELECT sector_table.code, sector_table.title, sector_table.description FROM sector_table\r" +
                                                                "WHERE sector_table.status != 0 AND sector_table.status != -2;";

        public static readonly string get_all_status_records = "SELECT status_table.code, status_table.title, status_table.description FROM status_table\r" +
                                                                "WHERE status_table.status != 0 AND status_table.status != -2 ;";


        public static readonly string get_cluster_options = "SELECT cluster_table.code, cluster_table.title, cluster_table.description FROM cluster_table WHERE cluster_table.status != 0 AND cluster_table.status != -2;";
        public static readonly string get_office_options = "SELECT office_table.code, office_table.title, office_table.description FROM office_table WHERE office_table.status != 0 AND office_table.status != -2;";
        public static readonly string get_sector_options = "SELECT sector_table.code,sector_table.title, sector_table.description FROM sector_table WHERE sector_table.status != 0 AND sector_table.status != -2";
        public static readonly string get_division_options = "SELECT division_table.code, division_table.title, division_table.description FROM division_table WHERE division_table.status!= 0 AND division_table.status!= -2";
        public static readonly string get_agency_options = "SELECT agency_table.code, agency_table.title, agency_table.description FROM agency_table WHERE agency_table.status != 0 AND agency_table.status != -2;";
        public static readonly string get_contractor_options = "SELECT contractor_table.code, contractor_table.title, contractor_table.description FROM contractor_table WHERE contractor_table.status != 0 AND contractor_table.status != -2";
        public static readonly string get_nature_options = "SELECT nature_table.code, nature_table.title, nature_table.description FROM nature_table WHERE nature_table.status != 0 AND nature_table.status != -2";
        public static readonly string get_employee_options = "SELECT emp_info_table.code, emp_info_table.full_name, emp_info_table.email FROM emp_info_table WHERE emp_info_table.status NOT IN (0, -2)";

        public static readonly string get_employee_options_by_office = "SELECT emp_info_table.code, emp_info_table.full_name, emp_info_table.email \r\nFROM emp_info_table \r\nINNER JOIN section_table ON emp_info_table.section_code =  section_table.code\r\nINNER JOIN division_table ON section_table.division_code = division_table.code\r\nINNER JOIN office_table ON division_table.office_code = office_table.code\r\nWHERE \r\noffice_table.code = '{0}'\r\nAND\r\nemp_info_table.status NOT IN (0, -2)";
        public static readonly string get_free_employee_account_options = "SELECT emp_info_table.code, emp_info_table.full_name, emp_info_table.email \r\nFROM emp_info_table \r\nWHERE \r\nNOT (SELECT COUNT(*) FROM user_info_table WHERE user_info_table.employee_code = emp_info_table.code) AND \r\n(emp_info_table.status != 0 AND emp_info_table.status != -2);";

        public static readonly string get_cluster_options_by_id = "SELECT cluster_table.code, cluster_table.title, cluster_table.description FROM cluster_table \r\nWHERE cluster_table.sector_code = '{0}' AND cluster_table.status != 0 AND cluster_table.status != -2;";
        public static readonly string get_agency_options_by_id = "SELECT agency_table.code, agency_table.title, agency_table.description FROM agency_table \r\nWHERE agency_table.cluster_code = '{0}' AND agency_table.status != 0 AND agency_table.status != -2;";
        #endregion

        #region Maintenance SET Record Queries

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

        public static readonly string set_new_status = "INSERT INTO status_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_section = "INSERT INTO section_table (code, title, description, division_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        public static readonly string set_new_office = "INSERT INTO office_table (code, title, description, sector_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";
        public static readonly string set_new_division = "INSERT INTO division_table (code, title, description, office_code, status, created_by, created_date)\r" +
                                                     "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        #endregion

        #region EMPLOYEE


        public static readonly string get_employee_records = "SELECT emp_info_table.code, emp_info_table.full_name, office_table.title, position_table.title,\r" +
                                                                "CASE \r" +
                                                                "WHEN emp_info_table.status = 1 THEN 'Active'\r" +
                                                                "WHEN emp_info_table.status = 0 THEN 'Inactive'\r" +
                                                                "ELSE 'TERMINATED'\r\nEND\r\nAS status\r" +
                                                            "FROM emp_info_table \r" +
                                                            "LEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r" +
                                                            "LEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r" +
                                                            "LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                            "LEFT JOIN office_table ON division_table.office_code = office_table.code\r\n" +
                                                            "WHERE emp_info_table.status != -2 AND emp_info_table.status != -1";



        public static readonly string set_new_employee = "INSERT INTO emp_info_table(code,full_name,email,contact_no,section_code,position_code,status,created_by,created_date)\r" +
                                                         "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', 1,'{6}', CURRENT_TIMESTAMP())";
        #endregion



        #region GET Record Queries
        public static readonly string get_agency_record_by_id = "SELECT agency_table.title, agency_table.description, cluster_table.title FROM agency_table \r" +
                                                                "INNER JOIN cluster_table ON agency_table.cluster_code = cluster_table.code\r" +
                                                                "WHERE agency_table.code = '{0}';";

        public static readonly string get_cluster_record_by_id = "SELECT  cluster_table.title, cluster_table.description, sector_table.title  FROM cluster_table\r" +
                                                                    "INNER JOIN sector_table ON cluster_table.sector_code = sector_table.code\r" +
                                                                    "WHERE cluster_table.code = '{0}'";

        public static readonly string get_contractor_record_by_id = "SELECT contractor_table.title, contractor_table.description FROM contractor_table\r" +
                                                                    "WHERE contractor_table.code = '{0}';";

        public static readonly string get_division_record_by_id = "SELECT division_table.title, division_table.description, office_table.title FROM division_table\r\nINNER JOIN office_table ON division_table.office_code = office_table.code\r\nWHERE division_table.code = '{0}';";

        public static readonly string get_nature_record_by_id = "SELECT nature_table.title, nature_table.description FROM nature_table\r\nWHERE nature_table.code = '{0}';";

        public static readonly string get_office_record_by_id = "SELECT office_table.title, office_table.description, sector_table.title FROM office_table\r\nINNER JOIN sector_table ON office_table.sector_code = sector_table.code\r\nWHERE office_table.code = '{0}'";

        public static readonly string get_position_record_by_id = "SELECT position_table.title, position_table.description FROM position_table\r\nWHERE position_table.code = '{0}';";

        public static readonly string get_section_record_by_id = "SELECT section_table.title, section_table.description, division_table.title FROM section_table\r\nINNER JOIN division_table ON section_table.division_code = division_table.code\r\nWHERE section_table.code = '{0}';";

        public static readonly string get_sector_record_by_id = "SELECT sector_table.title, sector_table.description FROM sector_table\r\nWHERE sector_table.code = '{0}';";
        
        public static readonly string get_status_record_by_id = "SELECT status_table.title, status_table.description FROM status_table\r\nWHERE status_table.code = '{0}';";
        
        
        #endregion

        #region UPDATE Record Queries
        public static readonly string update_agency_record_by_id = "UPDATE agency_table SET \r" +
                                                                "agency_table.title = '{0}', agency_table.description = '{1}', \r" +
                                                                "agency_table.cluster_code = '{2}', agency_table.updated_by = '{3}',\r" +
                                                                "agency_table.updated_date = CURRENT_TIMESTAMP()\r" +
                                                                "WHERE agency_table.code = '{4}' and agency_table.status != 0 AND agency_table.status != -2";

        public static readonly string update_cluster_record_by_id = "UPDATE cluster_table SET \r" +
                                                                "cluster_table.title = '{0}', cluster_table.description = '{1}',\r" +
                                                                "cluster_table.sector_code = '{2}', cluster_table.updated_by = '{3}',\r" +
                                                                "cluster_table.updated_date = CURRENT_TIMESTAMP()\r" +
                                                                "WHERE cluster_table.code = '{4}' and cluster_table.status != 0 AND cluster_table.status != -2;";

        public static readonly string update_contractor_record_by_id = "UPDATE contractor_table SET\r\ncontractor_table.title = '{0}', contractor_table.description = '{1}',\r\ncontractor_table.updated_by = '{2},', contractor_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE contractor_table.code = '{3}' AND contractor_table.status != 0 AND contractor_table.status != -2\r\n";

        public static readonly string update_division_record_by_id = "UPDATE division_table SET \r\ndivision_table.title = '{0}', division_table.description = '{1}',\r\ndivision_table.office_code = '{2}', division_table.updated_by = '{3}',\r\ndivision_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE division_table.code = '{4}' and division_table.status != 0 AND division_table.status != -2;";

        public static readonly string update_nature_record_by_id = "UPDATE nature_table SET\r\nnature_table.title = '{0}', nature_table.description = '{1}',\r\nnature_table.updated_by = '{2}', nature_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE nature_table.code = '{3}'and nature_table.status != 0 AND nature_table.status != -2;";

        public static readonly string update_office_record_by_id = "UPDATE office_table SET \r\noffice_table.title = '{0}', office_table.description = '{1}',\r\noffice_table.sector_code = '{2}', office_table.updated_by = '{3}',\r\noffice_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE office_table.code = '{4}' and office_table.status != 0 AND office_table.status != -2;";

        public static readonly string update_position_record_by_id = "UPDATE position_table SET\r\nposition_table.title = '{0}', position_table.description = '{1}',\r\nposition_table.updated_by = '{2}', position_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE position_table.code = '{3}'and position_table.status != 0 AND position_table.status != -2;\r\n";

        public static readonly string update_section_record_by_id = "UPDATE section_table SET \r\nsection_table.title = '{0}', section_table.description = '{1}',\r\nsection_table.division_code = '{2}', section_table.updated_by = '{3}',\r\nsection_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE section_table.code = '{4}' and section_table.status != 0 AND section_table.status != -2;";

        public static readonly string update_sector_record_by_id = "UPDATE sector_table SET\r\nsector_table.title = '{0}', sector_table.description = '{1}',\r\nsector_table.updated_by = '{2}', sector_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE sector_table.code = '{3}'and sector_table.status != 0 AND sector_table.status != -2;";
        
        public static readonly string update_status_record_by_id = "UPDATE status_table SET\r\nstatus_table.title = '{0}', status_table.description = '{1}',\r\nstatus_table.updated_by = '{2}', status_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE status_table.code = '{3}'and status_table.status != 0 AND status_table.status != -2;";
        #endregion


        public static readonly string get_status_options = "SELECT status_table.code, status_table.title FROM status_table WHERE status_table.status != 0;";


        public static readonly string set_new_docu_infos = "INSERT INTO docu_info_table \r\nVALUES\r\n(NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');";
        public static readonly string set_new_docu_trans = "INSERT INTO docu_transaction_table\r\nVALUES\r\n(NULL, '{0}','{1}','{2}','{3}','{4}','{5}', NULL);";
        public static readonly string set_new_remarks = "INSERT INTO remarks_table \r\nVALUES\r\n(NULL, '{0}','{1}','{2}','{3}','{4}');";
        public static readonly string set_new_history = "INSERT INTO history_table \r\nVALUES\r\n(NULL, '{0}','{1}','{2}','{3}','{4}');";
        public static readonly string set_new_history_ct = "INSERT INTO history_table \r\nVALUES\r\n(NULL, '{0}','{1}','{2}','{3}', CURRENT_TIMESTAMP());";
        public static readonly string set_new_remarks_ct = "INSERT INTO remarks_table \r\nVALUES\r\n(NULL, '{0}','{1}','{2}','{3}', CURRENT_TIMESTAMP());";

        public static readonly string get_all_project_records = "SELECT docu_info_table.code, docu_info_table.document_no, docu_info_table.title,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount,  status_table.title\r\nFROM docu_info_table\r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN status_table ON docu_transaction_table.status_code = status_table.code ORDER BY receiving_date DESC";


        public static readonly string get_user_access = "SELECT \r\nuser_access_table.home, user_access_table.projects, user_access_table.employee, user_access_table.reports, user_access_table.maintenance, user_access_table.user_settings, user_access_table.activity_logs\r\nFROM user_access_table WHERE user_access_table.user_name = '{0}';";
        public static readonly string get_user_project_access = "SELECT \r\nuser_access_table.projects_add,\r\nuser_access_table.projects_view,\r\nuser_access_table.projects_update,\r\nuser_access_table.projects_delete\r\nFROM user_access_table\r\nWHERE user_access_table.user_name = '{0}';";
        public static readonly string get_user_employee_access = "SELECT \r\nuser_access_table.employee_add,\r\nuser_access_table.employee_view,\r\nuser_access_table.employee_update,\r\nuser_access_table.employee_delete\r\nFROM user_access_table\r\nWHERE user_access_table.user_name = '{0}';";
        public static readonly string get_user_maintenance_access = "SELECT \r\nuser_access_table.maintenance_add,\r\nuser_access_table.maintenance_view,\r\nuser_access_table.maintenance_update,\r\nuser_access_table.maintenance_delete\r\nFROM user_access_table\r\nWHERE user_access_table.user_name = '{0}';";

        public static readonly string get_user_role_title = "SELECT user_role_table.title \r\nFROM user_info_table\r\nINNER JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\nWHERE user_info_table.user_name = '{0}';";

        public static readonly string get_employee_off_pos_by_id = "SELECT office_table.title, position_table.title FROM emp_info_table\r\nINNER JOIN section_table ON emp_info_table.section_code = section_table.code\r\nINNER JOIN division_table ON section_table.division_code = division_table.code\r\nINNER JOIN office_table ON division_table.office_code = office_table.code\r\nINNER JOIN position_table ON emp_info_table.position_code = position_table.code\r\nWHERE emp_info_table.code = '{0}';";

        public static readonly string get_user_role_options = "SELECT user_role_table.code, user_role_table.title, user_role_table.description FROM user_role_table\r\nWHERE user_role_table.status != 0 AND user_role_table.status != -2";
        public static readonly string get_user_role_access_by_id = "SELECT user_role_table.home, user_role_table.projects, user_role_table.employee, \r\nuser_role_table.reports, user_role_table.maintenance, user_role_table.user_settings,\r\nuser_role_table.activity_logs \r\nFROM user_role_table\r\nWHERE user_role_table.code = '{0}';";
        public static readonly string get_user_role_projects_by_id = "SELECT user_role_table.projects_add, user_role_table.projects_view,\r\nuser_role_table.projects_update, user_role_table.projects_delete\r\nFROM user_role_table WHERE user_role_table.code = '{0}';";
        public static readonly string get_user_role_employee_by_id = "SELECT user_role_table.employee_add, user_role_table.employee_view,\r\nuser_role_table.employee_update, user_role_table.employee_delete\r\nFROM user_role_table \r\nWHERE user_role_table.code = '{0}';";
        public static readonly string get_user_role_maintenance_by_id = "SELECT user_role_table.maintenance_add, user_role_table.maintenance_view,\r\nuser_role_table.maintenance_update, user_role_table.maintenance_delete\r\nFROM user_role_table \r\nWHERE user_role_table.code = '{0}';";
        //public static readonly string get_user_role_user_settings_by_id = "SELECT user_role_table.user_settings_add, user_role_table.user_settings_view,\r\nuser_role_table.user_settings_update, user_role_table.user_settings_delete\r\nFROM user_role_table \r\nWHERE user_role_table.code = '{0}';";

        public static readonly string set_user_cred = "INSERT INTO user_cred_table (user_cred_table.user_name, user_cred_table.password) VALUES ('{0}', '{1}');";
        public static readonly string set_user_info = "INSERT INTO user_info_table\r\n(user_info_table.user_name, user_info_table.employee_code, \r\nuser_info_table.role_code, user_info_table.status, \r\nuser_info_table.created_by, user_info_table.created_date)\r\nVALUES \r\n('{0}','{1}','{2}','1','{3}', CURRENT_TIMESTAMP());";
        public static readonly string set_user_access = "INSERT INTO user_access_table\r\nVALUES\r\n(NULL, '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',\r\n'{12}','{13}','{14}','{15}','{16}','{17}','{18}',\r\n'{19}')";

        public static readonly string get_user_record = "SELECT user_info_table.employee_code, office_table.title, position_table.title, user_info_table.user_name, user_role_table.title\r\nFROM user_info_table\r\nINNER JOIN emp_info_table ON user_info_table.employee_code = emp_info_table.code\r\nINNER JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\nINNER JOIN position_table ON emp_info_table.position_code = position_table.code\r\nINNER JOIN section_table ON emp_info_table.section_code = section_table.code\r\nINNER JOIN division_table ON section_table.division_code = division_table.code\r\nINNER JOIN office_table ON division_table.office_code =  office_table.code\r\nWHERE user_info_table.employee_code = '{0}';\r\n";
        public static readonly string get_all_active_user = "SELECT user_info_table.employee_code, emp_info_table.full_name, office_table.title, position_table.title, user_role_table.title\r\n\r\nFROM user_info_table\r\nLEFT JOIN emp_info_table ON user_info_table.employee_code = emp_info_table.code\r\nLEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r\nLEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r\nLEFT JOIN division_table ON section_table.division_code = division_table.code\r\nLEFT JOIN office_table ON division_table.office_code = office_table.code\r\n\r\nLEFT JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\nWHERE user_info_table.status = 1\r\nORDER BY user_info_table.employee_code;\r\n;";
        public static readonly string get_user_access_by_id = "SELECT user_access_table.home, user_access_table.projects, user_access_table.employee, user_access_table.reports,  \r\nuser_access_table.maintenance, user_access_table.user_settings, user_access_table.activity_logs\r\nFROM user_access_table \r\nWHERE user_access_table.user_name = (SELECT user_info_table.user_name FROM user_info_table WHERE employee_code = '{0}');";
        public static readonly string get_user_project_access_by_id = "SELECT user_access_table.projects_add, user_access_table.projects_view, user_access_table.projects_update, user_access_table.projects_delete\r\nFROM user_access_table \r\nWHERE user_access_table.user_name = (SELECT user_info_table.user_name FROM user_info_table WHERE employee_code = '{0}');";
        public static readonly string get_user_employee_access_by_id = "SELECT user_access_table.employee_add, user_access_table.employee_view, user_access_table.employee_update, user_access_table.employee_delete\r\nFROM user_access_table \r\nWHERE user_access_table.user_name = (SELECT user_info_table.user_name FROM user_info_table WHERE employee_code = '{0}');";
        public static readonly string get_user_maintenance_access_by_id = "SELECT user_access_table.maintenance_add, user_access_table.maintenance_view, user_access_table.maintenance_update, user_access_table.maintenance_delete\r\nFROM user_access_table \r\nWHERE user_access_table.user_name = (SELECT user_info_table.user_name FROM user_info_table WHERE employee_code = '{0}');";
        //public static readonly string get_user_user_setting_access_by_id = "SELECT user_access_table.user_settings_add, user_access_table.user_settings_view, user_access_table.user_settings_update, user_access_table.user_settings_delete\r\nFROM user_access_table \r\nWHERE user_access_table.user_name = (SELECT user_info_table.user_name FROM user_info_table WHERE employee_code = '{0}');";

        public static readonly string get_user_full_name_by_id = "SELECT emp_info_table.full_name FROM emp_info_table WHERE emp_info_table.code = '{0}';";

        public static readonly string set_new_password = "UPDATE user_cred_table SET \r\nuser_cred_table.password = '{0}'\r\nWHERE user_cred_table.user_name = '{1}';";
        public static readonly string set_new_role = "UPDATE user_info_table SET\r\nuser_info_table.role_code = '{0}'\r\nWHERE user_info_table.user_name = '{1}';";
        public static readonly string set_new_access = "UPDATE user_access_table SET\r\n\r\nuser_access_table.home = '{0}',\r\nuser_access_table.projects = '{1}',\r\nuser_access_table.projects_add = '{2}',\r\nuser_access_table.projects_view = '{3}',\r\nuser_access_table.projects_update = '{4}',\r\nuser_access_table.projects_delete = '{5}',\r\nuser_access_table.employee = '{6}',\r\nuser_access_table.employee_add = '{7}',\r\nuser_access_table.employee_view = '{8}',\r\nuser_access_table.employee_update = '{9}',\r\nuser_access_table.employee_delete = '{10}',\r\nuser_access_table.reports = '{11}',\r\nuser_access_table.maintenance = '{12}',\r\nuser_access_table.maintenance_add = '{13}',\r\nuser_access_table.maintenance_view = '{14}',\r" +
                                                        "user_access_table.maintenance_update = '{15}',\r\nuser_access_table.maintenance_delete = '{16}',\r\nuser_access_table.user_settings = '{17}', \r\nuser_access_table.activity_logs = '{18}'\r\n\r\nWHERE user_access_table.user_name = '{19}';";
        public static readonly string update_user_trail = "UPDATE user_info_table \r\nSET\r\nuser_info_table.updated_by = '{0}',\r\nuser_info_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE\r\nuser_info_table.employee_code = '{1}';\r\n";

        public static readonly string get_all_role_records = "SELECT user_role_table.code, user_role_table.title, user_role_table.description FROM user_role_table\r\nWHERE user_role_table.status NOT IN (0, -2);";

        public static readonly string set_new_role_access = "INSERT INTO user_role_table \r\nVALUES (NULL, \r\n'{0}', '{1}', '{2}', \r\n'{3}', \r\n'{4}', '{5}', '{6}', '{7}', '{8}', \r\n'{9}', '{10}', '{11}', '{12}', '{13}', \r\n'{14}',\r\n'{15}', '{16}', '{17}', '{18}', '{19}', \r\n'{20}',\r\n'{21}', \r\n'1', '{22}', CURRENT_TIMESTAMP(), NULL, NULL) ;";
        public static readonly string get_role_record = "SELECT user_role_table.title, user_role_table.description FROM user_role_table \r\nWHERE user_role_table.code = '{0}' AND user_role_table.status != 0; ";

        public static readonly string get_role_access_record = "SELECT \r\nuser_role_table.home,\r\nuser_role_table.projects,\r\nuser_role_table.employee,\r\nuser_role_table.reports,\r\nuser_role_table.maintenance, \r\nuser_role_table.user_settings,\r\nuser_role_table.activity_logs\r\nFROM user_role_table\r\nWHERE user_role_table.code = '{0}' AND user_role_table.status != 0;";
        public static readonly string get_projects_access_record = "SELECT  user_role_table.projects_add, user_role_table.projects_view, user_role_table.projects_update, user_role_table.projects_delete\r\nFROM user_role_table\r\nWHERE user_role_table.code = '{0}' AND user_role_table.status != 0;\r\n";
        public static readonly string get_employee_access_record = "SELECT  user_role_table.employee_add, user_role_table.employee_view, user_role_table.employee_update, user_role_table.employee_delete\r\nFROM user_role_table\r\nWHERE user_role_table.code = '{0}' AND user_role_table.status != 0;";
        public static readonly string get_maintenance_access_record = "SELECT  user_role_table.maintenance_add, user_role_table.maintenance_view, user_role_table.maintenance_update, user_role_table.maintenance_delete\r\nFROM user_role_table\r\nWHERE user_role_table.code = '{0}' AND user_role_table.status != 0;";
        public static readonly string update_role_access = "UPDATE user_role_table SET\r\nuser_role_table.title = \"{0}\", \r\nuser_role_table.description = \"{1}\",\r\nuser_role_table.home = \"{2}\",\r\nuser_role_table.projects = \"{3}\",\r\nuser_role_table.projects_add = \"{4}\",\r\nuser_role_table.projects_view = \"{5}\",\r\nuser_role_table.projects_update = \"{6}\",\r\nuser_role_table.projects_delete = \"{7}\",\r\nuser_role_table.employee = \"{8}\",\r\nuser_role_table.employee_add = \"{9}\",\r\nuser_role_table.employee_view = \"{10}\",\r\nuser_role_table.employee_update = \"{11}\",\r\nuser_role_table.employee_delete = \"{12}\",\r\nuser_role_table.reports = \"{13}\",\r\nuser_role_table.maintenance = \"{14}\",\r\nuser_role_table.maintenance_add = \"{15}\",\r\nuser_role_table.maintenance_view = \"{16}\",\r\nuser_role_table.maintenance_update = \"{17}\",\r\nuser_role_table.maintenance_delete = \"{18}\",\r\nuser_role_table.user_settings = \"{19}\",\r\nuser_role_table.activity_logs = \"{20}\",\r\nuser_role_table.updated_by = \"{21}\",\r\nuser_role_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE user_role_table.code = \"{22}\" AND user_role_table.status != 0;";

        public static readonly string get_project_record = "SELECT \r\ndocu_info_table.document_no,\r\ndocu_info_table.title,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount, 2)),\r\ndocu_info_table.period,\r\ndocu_info_table.receiving_date,\r\nstatus_table.title,\r\nsector_table.title,\r\ncluster_table.title,\r\nagency_table.title,\r\ncontractor_table.title,\r\nnature_table.title,\r\ndivision_table.title,\r\ndocu_info_table.subject,\r\n(SELECT remarks_table.description FROM remarks_table WHERE remarks_table.docu_code = docu_info_table.code)\r\n\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN status_table ON docu_transaction_table.status_code = status_table.code\r\n\r\nINNER JOIN agency_table ON docu_transaction_table.agency_code = agency_table.code\r\nINNER JOIN cluster_table ON agency_table.cluster_code = cluster_table.code\r\nINNER JOIN sector_table ON cluster_table.sector_code = sector_table.code\r\n\r\nINNER JOIN contractor_table ON docu_transaction_table.contractor_code = contractor_table.code\r\nINNER JOIN nature_table ON docu_transaction_table.nature_code = nature_table.code\r\nINNER JOIN division_table ON docu_transaction_table.division_code = division_table.code\r\n\r\n\r\nWHERE docu_info_table.code = '{0}';";
        public static readonly string update_project_record = "UPDATE docu_info_table SET \r\ndocu_info_table.document_no = '{0}',\r\ndocu_info_table.title = '{1}',\r\ndocu_info_table.amount = '{2}',\r\ndocu_info_table.period = '{3}',\r\ndocu_info_table.subject = '{4}',\r\ndocu_info_table.receiving_date = '{5}' \r\nWHERE docu_info_table.code = '{6}' \r\n;";
        public static readonly string update_project_transaction = "UPDATE docu_transaction_table SET\r\ndocu_transaction_table.agency_code = '{0}',\r\ndocu_transaction_table.contractor_code ='{1}',\r\ndocu_transaction_table.nature_code ='{2}',\r\ndocu_transaction_table.division_code ='{3}',\r\ndocu_transaction_table.status_code = '{4}'\r\nWHERE docu_transaction_table.docu_code = '{5}'";
        public static readonly string update_project_remarks = "UPDATE remarks_table SET\r\nremarks_table.description = '{0}'\r\nWHERE remarks_table.docu_code = '{1}';";

        public static readonly string get_remarks_by_id = "SELECT remarks_table.description FROM remarks_table WHERE remarks_table.docu_code = '{0}'";
        public static readonly string update_remarks_by_id = "UPDATE remarks_table SET \r\nremarks_table.description = '{0}'\r\nWHERE remarks_table.docu_code = '{1}';";
        public static readonly string update_docu_status_by_id = "UPDATE docu_transaction_table SET \r\ndocu_transaction_table.status_code = '{0}'\r\nWHERE docu_transaction_table.docu_code = '{1}';";

        public static readonly string get_status_code_by_id = "SELECT status_table.code From status_table WHERE status_table.title = '{0}';";
        public static readonly string get_project_history_by_id = "SELECT  history_table.description , \r\nhistory_table.created_by, \r\nDATE_FORMAT(history_table.created_date, \"%W, %M %d, %Y\" ) as date\r\nFROM history_table \r\nWHERE history_table.docu_code = '{0}'";

        public static readonly string get_project_all_search = "SELECT docu_info_table.code, docu_info_table.document_no, docu_info_table.title, CONCAT('₱ ', FORMAT(docu_info_table.amount, 2)) as amount, status_table.title\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code =  docu_transaction_table.docu_code\r\nINNER JOIN status_table ON docu_transaction_table.status_code = status_table.code\r\nWHERE (docu_info_table.code LIKE '%{0}%' OR docu_info_table.document_no LIKE '%{0}%'\r\nOR docu_info_table.title LIKE '%{0}%') ORDER BY receiving_date DESC;";
        public static readonly string get_project_specific_search = "SELECT docu_info_table.code, docu_info_table.document_no, docu_info_table.title, CONCAT('₱ ', FORMAT(docu_info_table.amount, 2)) as amount, status_table.title\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code =  docu_transaction_table.docu_code\r\nINNER JOIN status_table ON docu_transaction_table.status_code = status_table.code\r\nWHERE (docu_info_table.{0} LIKE '%{1}%')ORDER BY receiving_date DESC;";
        public static readonly string get_project_status_search = "SELECT docu_info_table.code, docu_info_table.document_no, docu_info_table.title, CONCAT('₱ ', FORMAT(docu_info_table.amount, 2)) as amount, status_table.title\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code =  docu_transaction_table.docu_code\r\nINNER JOIN status_table ON docu_transaction_table.status_code = status_table.code\r\nWHERE (status_table.title LIKE '%{0}%')ORDER BY receiving_date DESC;";


        public static readonly string get_all_forward_records = "SELECT forward_table.code, forward_table.title, forward_table.description FROM forward_table\r\nWHERE forward_table.status != 0;";
        public static readonly string set_new_forward_record = "INSERT INTO forward_table \r\nVALUES(NULL, '{0}', '{1}', '{2}', 1, '{3}', CURRENT_TIMESTAMP(), NULL, NULL);";
        public static readonly string get_forward_record_by_id = "SELECT forward_table.title,  forward_table.description FROM forward_table\r\nWHERE forward_table.code = '{0}' AND forward_table.status != 0;";
        public static readonly string update_forward_record_by_id = "UPDATE forward_table \r\nSET\r\nforward_table.title = '{0}',\r\nforward_table.description = '{1}',\r\nforward_table.updated_by = '{2}',\r\nforward_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE \r\nforward_table.code = '{3}' AND forward_table.status != 0;";

        public static readonly string get_record_status = "SELECT {0}.status FROM {0} \r\nWHERE {0}.code = '{1}';";


        public static readonly string get_cluster_search = "SELECT cluster_table.code, cluster_table.title, cluster_table.description FROM cluster_table\r\nWHERE (cluster_table.code LIKE '%{0}%' OR cluster_table.title LIKE '%{0}%')\r\nAND (cluster_table.status != 0 AND cluster_table.status != -2);";
        public static readonly string get_sector_search = "SELECT sector_table.code, sector_table.title, sector_table.description FROM sector_table\r\nWHERE (sector_table.code LIKE '%{0}%' OR sector_table.title LIKE '%{0}%')\r\nAND (sector_table.status != 0 AND sector_table.status != -2);";
        public static readonly string get_office_search = "SELECT office_table.code, office_table.title, office_table.description FROM office_table\r\nWHERE (office_table.code LIKE '%{0}%' OR office_table.title LIKE '%{0}%')\r\nAND (office_table.status != 0 AND office_table.status != -2);";
        public static readonly string get_division_search = "SELECT division_table.code, division_table.title, division_table.description FROM division_table\r\nWHERE (division_table.code LIKE '%{0}%' OR division_table.title LIKE '%{0}%')\r\nAND (division_table.status != 0 AND division_table.status != -2);";
        public static readonly string get_section_search = "SELECT section_table.code, section_table.title, section_table.description FROM section_table\r\nWHERE (section_table.code LIKE '%{0}%' OR section_table.title LIKE '%{0}%')\r\nAND (section_table.status != 0 AND section_table.status != -2);";
        public static readonly string get_position_search = "SELECT position_table.code, position_table.title, position_table.description FROM position_table\r\nWHERE (position_table.code LIKE '%{0}%' OR position_table.title LIKE '%{0}%')\r\nAND (position_table.status != 0 AND position_table.status != -2);";
        public static readonly string get_role_search = "SELECT user_role_table.code, user_role_table.title, user_role_table.description FROM user_role_table\r\nWHERE (user_role_table.code LIKE '%{0}%' OR user_role_table.title LIKE '%{0}%')\r\nAND (user_role_table.status != 0 AND user_role_table.status != -2);";
        public static readonly string get_employee_search = "SELECT emp_info_table.code, emp_info_table.full_name, emp_info_table.email FROM emp_info_table\r\nWHERE (emp_info_table.code LIKE '%{0}%' OR emp_info_table.full_name LIKE '%{0}%')\r\nAND (emp_info_table.status != 0 AND emp_info_table.status != -2);";

        public static readonly string get_agency_search = "SELECT agency_table.code, agency_table.title, agency_table.description FROM agency_table\r\nWHERE \r\n(agency_table.code LIKE '%{0}%' OR agency_table.title LIKE '%{0}%')\r\nAND \r\n(agency_table.status != 0 AND agency_table.status != -2);";
        public static readonly string get_contractor_search = "SELECT contractor_table.code, contractor_table.title, contractor_table.description FROM contractor_table\r\nWHERE \r\n(contractor_table.code LIKE '%{0}%' OR contractor_table.title LIKE '%{0}%')\r\nAND \r\n(contractor_table.status != 0 AND contractor_table.status != -2);\r\n";
        public static readonly string get_nature_search = "SELECT nature_table.code, nature_table.title, nature_table.description FROM nature_table\r\nWHERE \r\n(nature_table.code LIKE '%{0}%' OR nature_table.title LIKE '%{0}%')\r\nAND \r\n(nature_table.status != 0 AND nature_table.status != -2);";

        public static readonly string get_free_employee_search = "SELECT emp_info_table.code, emp_info_table.full_name, emp_info_table.email FROM emp_info_table\r\nWHERE (emp_info_table.code LIKE '%{0}%' OR emp_info_table.full_name LIKE '%{0}%')\r\nAND (NOT (SELECT COUNT(*) FROM user_info_table WHERE user_info_table.employee_code = emp_info_table.code))\r\nAND (emp_info_table.status != 0 AND emp_info_table.status != -2);";

        public static readonly string get_office_sector_search = "SELECT office_table.code, office_table.title, office_table.description FROM office_table\r\nWHERE (office_table.code LIKE '%{0}%' OR office_table.title LIKE '%{0}%')\r\nAND (office_table.status != 0 AND office_table.status != -2)\r\nAND (office_table.sector_code = '{1}');\r\n";
        public static readonly string get_division_office_search = "SELECT division_table.code, division_table.title, division_table.description FROM division_table\r\nWHERE (division_table.code LIKE '%{0}%' OR division_table.title LIKE '%{0}%')\r\nAND (division_table.status != 0 AND division_table.status != -2)\r\nAND (division_table.office_code = '{1}');\r\n";
        public static readonly string get_section_division_search = "SELECT section_table.code, section_table.title, section_table.description FROM section_table\r\nWHERE (section_table.code LIKE '%{0}%' OR section_table.title LIKE '%{0}%')\r\nAND (section_table.status != 0 AND section_table.status != -2)\r\nAND (section_table.division_code = '{1}');";

        public static readonly string get_all_employee_records_search = "SELECT \r\n        emp_info_table.code, \r\n        emp_info_table.full_name, \r\n        office_table.title,\r\n        position_table.title,\r\n        CASE  \r\n            WHEN emp_info_table.status = 1 THEN 'Active' \r\n            WHEN emp_info_table.status = 0 THEN 'Inactive' \r\n            ELSE 'Terminated'\r\n        END AS status \r\n    FROM \r\n        emp_info_table  \r\n        LEFT JOIN position_table ON emp_info_table.position_code = position_table.code \r\n        LEFT JOIN section_table ON emp_info_table.section_code = section_table.code \r\n        LEFT JOIN division_table ON section_table.division_code = division_table.code \r\n        LEFT JOIN office_table ON division_table.office_code = office_table.code \r\n    WHERE \r\n    (\r\n        emp_info_table.code LIKE '%{0}%' OR emp_info_table.full_name LIKE '%{0}%' OR \r\n        office_table.title LIKE '%{0}%' OR position_table.title LIKE '%{0}%'  OR\r\n        CASE  \r\n            WHEN emp_info_table.status = 1 THEN 'Active' \r\n            WHEN emp_info_table.status = 0 THEN 'Inactive' \r\n            ELSE 'Terminated'\r\n        END LIKE '%{0}%'\r\n    \r\n    ) AND emp_info_table.status NOT IN (-2, -1)\r\n";
        public static readonly string get_specific_employee_search = "SELECT \r\n        emp_info_table.code, \r\n        emp_info_table.full_name, \r\n        office_table.title,\r\n        position_table.title,\r\n        CASE  \r\n            WHEN emp_info_table.status = 1 THEN 'Active' \r\n            WHEN emp_info_table.status = 0 THEN 'Inactive' \r\n            ELSE 'Terminated'\r\n        END AS status \r\n    FROM \r\n        emp_info_table  \r\n        LEFT JOIN position_table ON emp_info_table.position_code = position_table.code \r\n        LEFT JOIN section_table ON emp_info_table.section_code = section_table.code \r\n        LEFT JOIN division_table ON section_table.division_code = division_table.code \r\n        LEFT JOIN office_table ON division_table.office_code = office_table.code \r\n    WHERE \r\n    (\r\n        {0} LIKE '%{1}%' \r\n    ) \r\n    AND emp_info_table.status NOT IN (-2, -1);";
        public static readonly string get_status_employee_search = "SELECT \r\n        emp_info_table.code, \r\n        emp_info_table.full_name, \r\n        office_table.title,\r\n        position_table.title,\r\n        CASE  \r\n            WHEN emp_info_table.status = 1 THEN 'Active' \r\n            WHEN emp_info_table.status = 0 THEN 'Inactive' \r\n            ELSE 'Terminated'\r\n        END AS status \r\n    FROM \r\n        emp_info_table  \r\n        LEFT JOIN position_table ON emp_info_table.position_code = position_table.code \r\n        LEFT JOIN section_table ON emp_info_table.section_code = section_table.code \r\n        LEFT JOIN division_table ON section_table.division_code = division_table.code \r\n        LEFT JOIN office_table ON division_table.office_code = office_table.code \r\n    WHERE \r\n    (\r\n        CASE  \r\n            WHEN emp_info_table.status = 1 THEN 'Active' \r\n            WHEN emp_info_table.status = 0 THEN 'Inactive' \r\n            ELSE 'Terminated'\r\n        END LIKE '%{0}%'\r\n    \r\n    ) AND emp_info_table.status NOT IN (-2, -1)";

        public static readonly string get_agency_all_search = "SELECT agency_table.code, agency_table.title, agency_table.description, cluster_table.title\r\nFROM agency_table INNER JOIN\r\ncluster_table ON agency_table.cluster_code = cluster_table.code\r\nWHERE\r\n(\r\n    agency_table.code LIKE '%{0}%' OR \r\n    agency_table.title LIKE '%{0}%' OR\r\n    cluster_table.title LIKE '%{0}%' \r\n)\r\nAND agency_table.status NOT IN (-2, 0)";
        public static readonly string get_cluster_all_search = "SELECT cluster_table.code, cluster_table.title, cluster_table.description, sector_table.title\r\nFROM cluster_table INNER JOIN\r\nsector_table ON cluster_table.sector_code = sector_table.code\r\nWHERE\r\n(\r\n    cluster_table.code LIKE '%{0}%' OR \r\n    cluster_table.title LIKE '%{0}%' OR\r\n    sector_table.title LIKE '%{0}%' \r\n)\r\nAND cluster_table.status NOT IN (-2, 0)";
        public static readonly string get_division_all_search = "SELECT division_table.code, division_table.title, division_table.description, office_table.title\r\nFROM division_table INNER JOIN\r\noffice_table ON division_table.office_code = office_table.code\r\nWHERE\r\n(\r\n    division_table.code LIKE '%{0}%' OR \r\n    division_table.title LIKE '%{0}%' OR\r\n    office_table.title LIKE '%{0}%' \r\n)\r\nAND division_table.status NOT IN (-2, 0)";
        public static readonly string get_office_all_search = "SELECT office_table.code, office_table.title, office_table.description, sector_table.title\r\nFROM office_table INNER JOIN\r\nsector_table ON office_table.sector_code = sector_table.code\r\nWHERE\r\n(\r\n    office_table.code LIKE '%{0}%' OR \r\n    office_table.title LIKE '%{0}%' OR\r\n    sector_table.title LIKE '%{0}%' \r\n)\r\nAND office_table.status NOT IN (-2, 0)";
        public static readonly string get_section_all_search = "SELECT section_table.code, section_table.title, section_table.description, division_table.title\r\nFROM section_table INNER JOIN\r\ndivision_table ON section_table.division_code = division_table.code\r\nWHERE\r\n(\r\n    section_table.code LIKE '%{0}%' OR \r\n    section_table.title LIKE '%{0}%' OR\r\n    division_table.title LIKE '%{0}%' \r\n)\r\nAND section_table.status NOT IN (-2, 0)";

        public static readonly string get_contractor_all_search = "SELECT contractor_table.code, contractor_table.title, contractor_table.description \r\nFROM contractor_table\r\nWHERE\r\n(\r\n    contractor_table.code LIKE '%{0}%' OR\r\n    contractor_table.title LIKE '%{0}%')\r\nAND\r\ncontractor_table.status NOT IN (-2, 0)";
        public static readonly string get_forward_all_search = "SELECT forward_table.code, forward_table.title, forward_table.description \r\nFROM forward_table\r\nWHERE\r\n(\r\n    forward_table.code LIKE '%{0}%' OR\r\n    forward_table.title LIKE '%{0}%')\r\nAND\r\nforward_table.status NOT IN (-2, 0)";
        public static readonly string get_nature_all_search = "SELECT nature_table.code, nature_table.title, nature_table.description \r\nFROM nature_table\r\nWHERE\r\n(\r\n    nature_table.code LIKE '%{0}%' OR\r\n    nature_table.title LIKE '%{0}%')\r\nAND\r\nnature_table.status NOT IN (-2, 0)";
        public static readonly string get_position_all_search = "SELECT position_table.code, position_table.title, position_table.description \r\nFROM position_table\r\nWHERE\r\n(\r\n    position_table.code LIKE '%{0}%' OR\r\n    position_table.title LIKE '%{0}%')\r\nAND\r\nposition_table.status NOT IN (-2, 0)";
        public static readonly string get_sector_all_search = "SELECT sector_table.code, sector_table.title, sector_table.description \r\nFROM sector_table\r\nWHERE\r\n(\r\n    sector_table.code LIKE '%{0}%' OR\r\n    sector_table.title LIKE '%{0}%')\r\nAND\r\nsector_table.status NOT IN (-2, 0)";
        public static readonly string get_status_all_search = "SELECT status_table.code, status_table.title, status_table.description \r\nFROM status_table\r\nWHERE\r\n(\r\n    status_table.code LIKE '%{0}%' OR\r\n    status_table.title LIKE '%{0}%')\r\nAND\r\nstatus_table.status NOT IN (-2, 0)";

        public static readonly string get_forward_title = "SELECT forward_table.code, forward_table.title FROM forward_table\r\nWHERE forward_table.status NOT IN (0, -2)";
        public static readonly string get_project_title_by_id = "SELECT docu_info_table.title FROM docu_info_table \r\nWHERE docu_info_table.document_no = '{0}';";
        public static readonly string get_project_division_by_id = "SELECT division_table.title FROM docu_transaction_table\r\nINNER JOIN division_table ON docu_transaction_table.division_code = division_table.code\r\nWHERE docu_transaction_table.docu_code = '{0}';";

        public static readonly string get_project_status_by_id = "SELECT docu_transaction_table.status_code FROM docu_transaction_table\r\nWHERE docu_transaction_table.docu_code = '{0}';";
        public static readonly string updated_date_filed_by_id = "UPDATE docu_transaction_table\r\nSET docu_transaction_table.filed_date = '{0}'\r\nWHERE docu_transaction_table.docu_code = '{1}';";

        public static readonly string get_employee_search_office = "SELECT emp_info_table.code, emp_info_table.full_name, emp_info_table.email \r\nFROM emp_info_table \r\nINNER JOIN section_table ON emp_info_table.section_code =  section_table.code\r\nINNER JOIN division_table ON section_table.division_code = division_table.code\r\nINNER JOIN office_table ON division_table.office_code = office_table.code\r\nWHERE \r\n(emp_info_table.code LIKE '%{0}%' OR emp_info_table.full_name LIKE '%{0}%')\r\nAND\r\noffice_table.code = '{1}'\r\nAND\r\nemp_info_table.status NOT IN (0, -2)";
        
        public static readonly string get_users_all_search = "SELECT \r\nuser_info_table.employee_code, \r\nemp_info_table.full_name, \r\noffice_table.title, \r\nposition_table.title, \r\nuser_role_table.title\r\n\r\nFROM user_info_table\r\n\r\nLEFT JOIN emp_info_table ON user_info_table.employee_code = emp_info_table.code\r\nLEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r\nLEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r\nLEFT JOIN division_table ON section_table.division_code = division_table.code\r\nLEFT JOIN office_table ON division_table.office_code = office_table.code\r\nLEFT JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\n\r\nWHERE \r\n(\r\n    user_info_table.employee_code LIKE '%{0}%' OR\r\n    emp_info_table.full_name LIKE '%{0}%' OR\r\n    office_table.title LIKE '%{0}%' OR\r\n    position_table.title LIKE '%{0}%' OR\r\n    user_role_table.title LIKE '%{0}%'\r\n)\r\nAND\r\nuser_info_table.status = 1\r\n;";
        public static readonly string get_users_code_search = "SELECT \r\nuser_info_table.employee_code, \r\nemp_info_table.full_name, \r\noffice_table.title, \r\nposition_table.title, \r\nuser_role_table.title\r\n\r\nFROM user_info_table\r\n\r\nLEFT JOIN emp_info_table ON user_info_table.employee_code = emp_info_table.code\r\nLEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r\nLEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r\nLEFT JOIN division_table ON section_table.division_code = division_table.code\r\nLEFT JOIN office_table ON division_table.office_code = office_table.code\r\nLEFT JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\n\r\nWHERE \r\n(\r\n    user_info_table.employee_code LIKE '%{0}%'\r\n)\r\nAND\r\nuser_info_table.status = 1";
        public static readonly string get_users_name_search = "SELECT \r\nuser_info_table.employee_code, \r\nemp_info_table.full_name, \r\noffice_table.title, \r\nposition_table.title, \r\nuser_role_table.title\r\n\r\nFROM user_info_table\r\n\r\nLEFT JOIN emp_info_table ON user_info_table.employee_code = emp_info_table.code\r\nLEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r\nLEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r\nLEFT JOIN division_table ON section_table.division_code = division_table.code\r\nLEFT JOIN office_table ON division_table.office_code = office_table.code\r\nLEFT JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\n\r\nWHERE \r\n(\r\n    emp_info_table.full_name LIKE '%{0}%'\r\n)\r\nAND\r\nuser_info_table.status = 1";
        public static readonly string get_users_office_search = "SELECT \r\nuser_info_table.employee_code, \r\nemp_info_table.full_name, \r\noffice_table.title, \r\nposition_table.title, \r\nuser_role_table.title\r\n\r\nFROM user_info_table\r\n\r\nLEFT JOIN emp_info_table ON user_info_table.employee_code = emp_info_table.code\r\nLEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r\nLEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r\nLEFT JOIN division_table ON section_table.division_code = division_table.code\r\nLEFT JOIN office_table ON division_table.office_code = office_table.code\r\nLEFT JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\n\r\nWHERE \r\n(\r\n    office_table.title LIKE '%{0}%'\r\n)\r\nAND\r\nuser_info_table.status = 1";
        public static readonly string get_users_position_search = "SELECT \r\nuser_info_table.employee_code, \r\nemp_info_table.full_name, \r\noffice_table.title, \r\nposition_table.title, \r\nuser_role_table.title\r\n\r\nFROM user_info_table\r\n\r\nLEFT JOIN emp_info_table ON user_info_table.employee_code = emp_info_table.code\r\nLEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r\nLEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r\nLEFT JOIN division_table ON section_table.division_code = division_table.code\r\nLEFT JOIN office_table ON division_table.office_code = office_table.code\r\nLEFT JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\n\r\nWHERE \r\n(\r\n    position_table.title LIKE '%{0}%'\r\n)\r\nAND\r\nuser_info_table.status = 1";
        public static readonly string get_users_role_search = "SELECT \r\nuser_info_table.employee_code, \r\nemp_info_table.full_name, \r\noffice_table.title, \r\nposition_table.title, \r\nuser_role_table.title\r\n\r\nFROM user_info_table\r\n\r\nLEFT JOIN emp_info_table ON user_info_table.employee_code = emp_info_table.code\r\nLEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r\nLEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r\nLEFT JOIN division_table ON section_table.division_code = division_table.code\r\nLEFT JOIN office_table ON division_table.office_code = office_table.code\r\nLEFT JOIN user_role_table ON user_info_table.role_code = user_role_table.code\r\n\r\nWHERE \r\n(\r\n    user_role_table.title LIKE '%{0}%'\r\n)\r\nAND\r\nuser_info_table.status = 1";

        public static readonly string get_user_audit_trail = "SELECT user_info_table.created_by, user_info_table.created_date, user_info_table.updated_by, user_info_table.updated_date \r\nFROM {0}\r\nWHERE user_info_table.employee_code = '{1}';";
        public static readonly string get_role_all_search = "SELECT user_role_table.code, user_role_table.title, user_role_table.description \r\nFROM user_role_table\r\nWHERE \r\n(\r\n    user_role_table.code LIKE '%{0}%' OR\r\n    user_role_table.title LIKE '%{0}%'\r\n\r\n)\r\nAND\r\nuser_role_table.status NOT IN (0, -2)";

        public static readonly string get_weekly_projects = "SELECT \r\ndocu_info_table.code,\r\ndocu_info_table.document_no,\r\ndocu_info_table.title,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount, 2)) as amount,\r\nDATE_FORMAT(docu_info_table.receiving_date, \"%W, %M %d, %Y\") AS date\r\nFROM docu_info_table\r\nWHERE\r\nYEARWEEK(docu_info_table.receiving_date) = YEARWEEK(NOW()) ORDER BY receiving_date DESC;";
        public static readonly string get_status_names = "SELECT status_table.title FROM status_table\r\nWHERE status_table.status = -1";

        public static readonly string get_docu_count_status = "SELECT COUNT(*)\r\nFROM docu_transaction_table\r\nWHERE docu_transaction_table.status_code = '{0}'";
        public static readonly string get_docu_count_today = "SELECT COUNT(*) \r\nFROM docu_info_table\r\nWHERE docu_info_table.receiving_date = CURRENT_DATE();";
        public static readonly string get_docu_grand_total = "SELECT COUNT(*) \r\nFROM docu_info_table";

        public static readonly string get_docu_by_default = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN division_table ON docu_transaction_table.division_code = division_table.code\r\n\r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\nAND\r\n(\r\n    docu_info_table.document_no LIKE '%{3}%' OR\r\n    docu_info_table.title LIKE '%{3}%' OR\r\n    docu_info_table.amount LIKE '%{3}%' OR\r\n    division_table.title LIKE '%{3}%' \r\n)\r\nAND\r\ndocu_transaction_table.status_code LIKE '%{4}%'\r\nORDER BY receiving_date DESC";

        public static readonly string get_docu_by_agency = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN agency_table ON docu_transaction_table.agency_code = agency_table.code\r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\nAND\r\n(\r\n    docu_info_table.document_no LIKE '%{3}%' OR\r\n    docu_info_table.title LIKE '%{3}%' OR\r\n    docu_info_table.amount LIKE '%{3}%' OR\r\n    agency_table.title LIKE '%{3}%' \r\n)\r\nORDER BY receiving_date DESC";
        public static readonly string get_docu_by_cluster = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN agency_table ON docu_transaction_table.agency_code = agency_table.code\r\nINNER JOIN cluster_table ON agency_table.cluster_code = cluster_table.code\r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\nAND\r\n(\r\n    docu_info_table.document_no LIKE '%{3}%' OR\r\n    docu_info_table.title LIKE '%{3}%' OR\r\n    docu_info_table.amount LIKE '%{3}%' OR\r\n    cluster_table.title LIKE '%{3}%' \r\n)\r\nORDER BY receiving_date DESC";
        public static readonly string get_docu_by_sector = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN agency_table ON docu_transaction_table.agency_code = agency_table.code\r\nINNER JOIN cluster_table ON agency_table.cluster_code = cluster_table.code\r\nINNER JOIN sector_table ON cluster_table.sector_code = sector_table.code\r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\nAND\r\n(\r\n    docu_info_table.document_no LIKE '%{3}%' OR\r\n    docu_info_table.title LIKE '%{3}%' OR\r\n    docu_info_table.amount LIKE '%{3}%' OR\r\n    sector_table.title LIKE '%{3}%' \r\n)\r\nORDER BY receiving_date DESC";
        public static readonly string get_docu_by_contractor = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN contractor_table ON docu_transaction_table.contractor_code = contractor_table.code\r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\nAND\r\n(\r\n    docu_info_table.document_no LIKE '%{3}%' OR\r\n    docu_info_table.title LIKE '%{3}%' OR\r\n    docu_info_table.amount LIKE '%{3}%' OR\r\n    contractor_table.title LIKE '%{3}%' \r\n)\r\nORDER BY receiving_date DESC";
        public static readonly string get_docu_by_nature = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN nature_table ON docu_transaction_table.nature_code = nature_table.code\r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\nAND\r\n(\r\n    docu_info_table.document_no LIKE '%{3}%' OR\r\n    docu_info_table.title LIKE '%{3}%' OR\r\n    docu_info_table.amount LIKE '%{3}%' OR\r\n    nature_table.title LIKE '%{3}%' \r\n)\r\nORDER BY receiving_date DESC";
        public static readonly string get_docu_by_division = "SELECT docu_info_table.document_no,\r\nCONCAT('₱ ', FORMAT(docu_info_table.amount,2)) AS amount, \r\nDATE_FORMAT(docu_info_table.receiving_date, '%M %d, %Y') AS receiving_date,\r\ndocu_info_table.subject\r\nFROM docu_info_table \r\nINNER JOIN docu_transaction_table ON docu_info_table.code = docu_transaction_table.docu_code\r\nINNER JOIN division_table ON docu_transaction_table.division_code = division_table.code\r\nWHERE \r\n({0} BETWEEN '{1}' AND '{2}') \r\nAND\r\n(\r\n    docu_info_table.document_no LIKE '%{3}%' OR\r\n    docu_info_table.title LIKE '%{3}%' OR\r\n    docu_info_table.amount LIKE '%{3}%' OR\r\n    division_table.title LIKE '%{3}%' \r\n)\r\nORDER BY receiving_date DESC";

        public static readonly string get_all_status = "SELECT \r\nstatus_table.code,\r\nstatus_table.title\r\nFROM status_table;";

    }
}
