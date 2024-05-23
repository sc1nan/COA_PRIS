using COA_PRIS.CrystalReports;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.UserControlUtil.Jesser_Util
{
    internal class GenericTable
    {
        Activity_Manager activity_manager = new Activity_Manager();
        Database_Manager database_manager = new Database_Manager();
        Util util = new Util();
        private readonly int max_lim = 15;
        private string Query { get; set; }

        //depends on unique class
        /*readonly string[] log_table_names = { "user_name", "activity" };
        private int min_lim = 0;
        private int page_cnt = 1;*/

        public void Populate_Table(int type_of_spec, DateFilter dateFilter1, SearchBar searchBar1, GunaDataGridView LogsTable, GunaComboBox sortComboBox, string[] log_table_names, int min_lim, string data_Table_Type)
        {
            //adds items to table
            DataTable dt = new DataTable();
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);

            switch (data_Table_Type)
            {
                case "acclog":
                    dt = FillAccLogsTable(type_of_spec, from_Date, to_Date, searchBar1, min_lim, sortComboBox, log_table_names);
                    break;
                case "actlog":
                    dt = FillActLogsTable(type_of_spec, from_Date, to_Date, searchBar1, min_lim, sortComboBox, log_table_names);
                    break;
                case "project":
                    dt = FillProjectsTable(type_of_spec, from_Date, to_Date, searchBar1, min_lim, sortComboBox, log_table_names);
                    break;
                default: break;
            }

            LogsTable.DataSource = util.FormatDataTableLimit(dt, min_lim);
            AddThemeToDGV(LogsTable, data_Table_Type);

        }

        private DataTable FillAccLogsTable(int type_of_spec, string from_Date, string to_Date, SearchBar searchBar1, int min_lim, GunaComboBox sortComboBox, string[] log_table_names)
        {
            DataTable dt = new DataTable();
            switch (type_of_spec)
            {
                //display all account logs within date
                case 1:
                    dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    break;
                //display logs within specified date
                case 2:
                    dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                //conditional statement
                case 3:
                    if (searchBar1.Text == null) dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    else dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                //display all activity logs within date
                case 4:
                    dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    break;
                //display logs within specified date
                case 5:
                    dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                //conditional statement
                case 6:
                    if (searchBar1.Text == null) dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    else dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                default: break;
            }
            return dt;
        }

        private DataTable FillActLogsTable(int type_of_spec, string from_Date, string to_Date, SearchBar searchBar1, int min_lim, GunaComboBox sortComboBox, string[] log_table_names)
        {
            DataTable dt = new DataTable();
            switch (type_of_spec)
            {
                //display all activity logs within date
                case 1:
                    dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    break;
                //display logs within specified date
                case 2:
                    dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                //conditional statement
                case 3:
                    if (searchBar1.Text == null) dt = activity_manager.Display_Activity_Logs_Table(from_Date, to_Date, min_lim);
                    else dt = activity_manager.Display_Specified_Activity_Logs_Table(from_Date, to_Date, min_lim, searchBar1.Text, log_table_names[sortComboBox.SelectedIndex]);
                    break;
                default: break;
            }
            return dt;
        }

        private DataTable FillProjectsTable(int type_of_spec, string from_Date, string to_Date, SearchBar searchBar1, int min_lim, GunaComboBox sortComboBox, string[] log_table_names)
        {
            DataTable dt = new DataTable();
            string sort_by = log_table_names[sortComboBox.SelectedIndex];
            switch (type_of_spec)
            {
                case 1:
                    Query = string.Format(Database_Query.get_general_project_records_by_date, sort_by, from_Date, to_Date);
                    break;
                case 2:
                    Query = string.Format(Database_Query.get_specific_project_records_by_date2, sort_by, from_Date, to_Date, searchBar1.Text);
                    break;
                case 3:
                    if (searchBar1.Text != null) Query = string.Format(Database_Query.get_general_project_records_by_date, sort_by, from_Date, to_Date);
                    else Query = string.Format(Database_Query.get_specific_project_records_by_date2, sort_by, from_Date, to_Date, searchBar1.Text);
                    break;
                default: break;
            }
            Database_Query.last_query = Query;
            Database_Manager database_Manager = new Database_Manager();
            util = new Util();
            using (database_Manager) dt = database_Manager.ExecuteQuery(Query);
            return dt;
        }

        private void AddThemeToDGV(GunaDataGridView data_View, string data_Table_Type)
        {
            //Add Theme.cs DataGridView Style
            (bool, int)[] column_Widths = null;
            (string, DataGridViewContentAlignment)[] column_Text_Align = null;
            switch (data_Table_Type)
            {
                case "actlog":
                    goto case "log";
                case "acclog":
                    goto case "log";
                case "log":
                    column_Widths = new (bool, int)[] { (true, 3), (true, 20), (true, 47), (true, 30) }; ;
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            ("Username", DataGridViewContentAlignment.MiddleLeft),
                            ("Activity", DataGridViewContentAlignment.MiddleLeft),
                            ("Date And Time", DataGridViewContentAlignment.MiddleCenter)
                        }; ;
                    break;
                case "project":
                    //column_Widths = new (bool, int)[] { (true, 3), (true, 9), (true, 9), (true, 9), (true, 10), (true, 10), (true, 10), (true, 30), (true, 10) };
                    //column_Widths = new (bool, int)[] { (true, 10), (true, 10), (true, 10), (true, 10), (true, 10), (true, 10), (true, 30), (true, 10) };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 15), (true, 15), (true, 10), (true, 45) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                        {
                            ("#", DataGridViewContentAlignment.MiddleRight),
                            //("Document ID", DataGridViewContentAlignment.MiddleCenter),
                            ("Document Code", DataGridViewContentAlignment.MiddleCenter),
                            ("Document Number",DataGridViewContentAlignment.MiddleCenter),
                            ("Amount",DataGridViewContentAlignment.MiddleRight),
                            //("Title", DataGridViewContentAlignment.MiddleLeft),
                            ("Period",DataGridViewContentAlignment.MiddleCenter),
                            //("Receiving Date",DataGridViewContentAlignment.MiddleCenter),
                            ("Subject Matter",DataGridViewContentAlignment.MiddleLeft)
                        };
                    break;
                default: break;
            }

            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }

        public void GenerateReportForm(string table = null)
        {
            var temprepp = Application.OpenForms["TempReportsForms"];
            if (temprepp == null)
            {
                temprepp = new TempReportsForms(table);
            }
            temprepp.Show();
        }

        public void Check_Count(GunaButton next_Button, GunaButton previous_Button, DateFilter dateFilter1, int min_lim, int page_cnt, string data_Table_Type)
        {
            min_lim = max_lim * (page_cnt - 1);

            if ((min_lim + max_lim) >= Records_Count(dateFilter1, data_Table_Type)) next_Button.Enabled = false;
            else next_Button.Enabled = true;

            if (page_cnt <= 1) previous_Button.Enabled = false;
            else previous_Button.Enabled = true;
        }

        private int Records_Count(DateFilter dateFilter1, string data_Table_Type)
        {
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            int rec_count = 0;
            switch (data_Table_Type)
            {
                case "actlog":
                    rec_count = activity_manager.Count_Activity_Logs(from_Date, to_Date);
                    break;
                case "acclog":
                    rec_count = activity_manager.Count_Account_Logs(from_Date, to_Date);
                    break;
                case "project":
                    break;
                default: break;
            }
            return rec_count;
        }

        public void UserChangePageCountInput(GunaTextBox pageCountTextbox, DateFilter dateFilter1, SearchBar searchBar1, GunaDataGridView LogsTable, GunaComboBox sortComboBox, GunaButton next_Button, GunaButton previous_Button, int page_cnt, int min_lim, string[] log_table_names, string data_Table_Type)
        {
            int result;
            object b = pageCountTextbox.Text;
            //checks to see if user input is a number
            if (int.TryParse(b.ToString(), out result))
            {
                //checks maximum amount of pages
                int xd = (Records_Count(dateFilter1, data_Table_Type) / max_lim) + 1;
                //checks if user input is less than or equal to maximum amount of pages and not below 1
                if (result <= xd && result >= 1)
                {
                    page_cnt = result; //puts user input as page count
                    Check_Count(next_Button, previous_Button, dateFilter1, min_lim, page_cnt, data_Table_Type);
                    Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, min_lim, data_Table_Type);
                }
            }
            //if wrong, puts last know page count to text box
            pageCountTextbox.Text = page_cnt.ToString();
        }

        public void UserChangePage(GunaTextBox pageCountTextbox, DateFilter dateFilter1, SearchBar searchBar1, GunaDataGridView LogsTable, GunaComboBox sortComboBox, GunaButton next_Button, GunaButton previous_Button, int page_cnt, int min_lim, string[] log_table_names, bool next, string data_Table_Type)
        {
            if(next) page_cnt++;
            else page_cnt--;

            pageCountTextbox.Text = page_cnt.ToString();
            Check_Count(next_Button, previous_Button, dateFilter1, min_lim, page_cnt, data_Table_Type);
            Populate_Table(3, dateFilter1, searchBar1, LogsTable, sortComboBox, log_table_names, min_lim, data_Table_Type);
        }

    }
}
