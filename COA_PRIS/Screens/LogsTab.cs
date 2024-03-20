using COA_PRIS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens
{
    public partial class LogsTab : Form
    {
        Activity_Manager activity_manager;
        string[] column_names = { "User Name", "Activity", "Time", "Jonh" };
        string[] log_table_names = { "user_name", "activity", "activity_datetime"};
        public LogsTab()
        {
            InitializeComponent();
            sortComboBox.SelectedText = "user_name";
            DisplayLogsTable();
            sortComboBox.SelectedIndex = 0;
        }

        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (logsSearchBox.Text.ToString() == "") DisplayLogsTable();
            activity_manager = new Activity_Manager();
            LogsTable.DataSource = activity_manager.Display_Specific_Logs_Table(logsSearchBox.Text.ToString(), log_table_names[sortComboBox.SelectedIndex]);
        }

        private void DisplayLogsTable()
        {
            activity_manager = new Activity_Manager();
            LogsTable.DataSource = activity_manager.Display_Logs_Table();
            foreach (DataGridViewColumn column in LogsTable.Columns)
            {
                column.HeaderText = column_names[column.Index];
            }
        }

        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(log_table_names[sortComboBox.SelectedIndex]);
        }
    }
}
