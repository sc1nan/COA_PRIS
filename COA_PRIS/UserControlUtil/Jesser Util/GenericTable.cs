using COA_PRIS.CrystalReports;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
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
        Activity_Manager activity_manager;
        Database_Manager database_Manager = new Database_Manager();
        Util util = new Util();
        readonly string[] log_table_names = { "user_name", "activity" };
        private int min_lim = 0;
        private readonly int max_lim = 15;
        private int page_cnt = 1;

        private void Populate_Table(int type_of_spec, DateFilter dateFilter1, TextBox searchBar1, GunaDataGridView LogsTable, GunaComboBox sortComboBox)
        {
            activity_manager = new Activity_Manager();
            //adds items to table
            DataTable dt = new DataTable();
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            switch (type_of_spec)
            {
                //display all logs within date
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

            //populate table with number
            LogsTable.DataSource = util.format_DataTableLimit(dt, min_lim);
            //set theme to data grid view
            AddThemeToDGV(LogsTable);

        }

        private void AddThemeToDGV(GunaDataGridView LogsTable)
        {
            //Add Theme.cs DataGridView Style
            (bool, int)[] column_Widths = new (bool, int)[] { (true, 3), (true, 20), (true, 47), (true, 30) }; ;
            (string, DataGridViewContentAlignment)[] column_Text_Align = new (string, DataGridViewContentAlignment)[]
            {
                ("#", DataGridViewContentAlignment.MiddleRight),
                ("Username", DataGridViewContentAlignment.MiddleLeft),
                ("Activity", DataGridViewContentAlignment.MiddleLeft),
                ("Date And Time", DataGridViewContentAlignment.MiddleCenter)
            }; ;

            Theme.gridView_Style(LogsTable, column_Widths, column_Text_Align);
        }

        public void GenerateReportForm()
        {
            var temprepp = Application.OpenForms["TempReportsForms"];
            if (temprepp == null)
            {
                temprepp = new TempReportsForms();
            }
            temprepp.Show();
        }

        private void Check_Count(GunaButton next_Button, GunaButton previous_Button, DateFilter dateFilter1)
        {
            min_lim = max_lim * (page_cnt - 1);

            if ((min_lim + max_lim) >= Activity_Logs_Count(dateFilter1)) next_Button.Enabled = false;
            else next_Button.Enabled = true;

            if (page_cnt <= 1) previous_Button.Enabled = false;
            else previous_Button.Enabled = true;
        }

        private int Activity_Logs_Count(DateFilter dateFilter1)
        {
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            int log_count = activity_manager.Count_Activity_Logs(from_Date, to_Date);
            return log_count;
        }
    }
}
