using COA_PRIS.UserControlUtil;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
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
    public partial class ActivityLogs : Form
    {
        Activity_Manager activity_manager;
        readonly string[] column_names = { "User Name", "Activity", "Time"};
        readonly string[] log_table_names = { "user_name", "activity", "activity_datetime"};
        private int min_lim = 0;
        private int page_cnt = 1;
        public ActivityLogs()
        {
            InitializeComponent();
            gunaButton1.Enabled = false;
            sortComboBox.SelectedText = "user_name";
            sortComboBox.SelectedIndex = 0;
            DisplayLogsTable();
            searchBar1.Ambatu(logsSearchBox_TextChanged);
        }

        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            changeTableContent(searchBar1.Text, LogsTable, sortComboBox);
        }

        private void DisplayLogsTable()
        {
            //Changes column name, change this later
            foreach (DataGridViewColumn column in LogsTable.Columns)
            {
                column.HeaderText = column_names[column.Index];
            }
            changeGunaTableStyle(LogsTable);
            //adds items to table
            activity_manager = new Activity_Manager();
            LogsTable.DataSource = activity_manager.Display_Three_Logs_Table(min_lim);
        }

        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            changeTableContent(searchBar1.Text, LogsTable, sortComboBox);
        }

        private void changeTableContent(string searchBox, GunaDataGridView sourceTable, GunaComboBox filterComboBox)
        {
            //if (searchBox.Text.ToString() == "") DisplayLogsTable();
            //activity_manager = new Activity_Manager();
            //sourceTable.DataSource = activity_manager.Display_Specific_Logs_Table(searchBox.Text.ToString(), log_table_names[filterComboBox.SelectedIndex]);
            if (searchBox == "") DisplayLogsTable();
            activity_manager = new Activity_Manager();
            sourceTable.DataSource = activity_manager.Display_Ten_Specific_Logs_Table(searchBox, log_table_names[filterComboBox.SelectedIndex], 0);

        }

        private void changeGunaTableStyle(GunaDataGridView gunaTable)
        {
            //Changes column header style
            GunaDataGridViewHeaderStyle columnHeaderStyle = new GunaDataGridViewHeaderStyle(gunaTable.ColumnHeadersDefaultCellStyle, gunaTable);
            columnHeaderStyle.Font = new Font("Bahnschrift", 14.25F);
            columnHeaderStyle.Height = 40;
            columnHeaderStyle.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            

            //Chamges row styles
            GunaDataGridViewRowsStyle rowStyle = new GunaDataGridViewRowsStyle(gunaTable.DefaultCellStyle, gunaTable);
            rowStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            rowStyle.SelectionForeColor = Color.White;
            rowStyle.Font = new Font("Bahnschrift", 14.25F);
            rowStyle.Height = 40;
            Padding newPadding = new Padding(24, 3, 3, 3);
            foreach (DataGridViewColumn column in gunaTable.Columns)
            {
                if (column.Index == 0)
                {
                    column.DefaultCellStyle.Padding = newPadding;
                    column.HeaderCell.Style.Padding = newPadding;
                }
            }
            //alternating colors in rows
            int i = 0;
            foreach (DataGridViewRow row in gunaTable.Rows)
            {
                i++;
                if (i % 2 == 0)
                {
                    rowStyle.BackColor = Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            page_cnt--;
            nextLogsBtn.Enabled = true;
            min_lim = 7 * (page_cnt - 1);
            activity_manager = new Activity_Manager();
            LogsTable.DataSource = activity_manager.Display_Three_Logs_Table(min_lim);
            pageCountTextbox.Text = page_cnt.ToString();
            if (page_cnt <= 1) gunaButton1.Enabled = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            page_cnt++;
            gunaButton1.Enabled = true;
            min_lim = 7 * (page_cnt-1);
            activity_manager = new Activity_Manager();
            LogsTable.DataSource = activity_manager.Display_Three_Logs_Table(min_lim);
            pageCountTextbox.Text = page_cnt.ToString();

            if ((min_lim+7) >= activity_manager.Count_Logs()) nextLogsBtn.Enabled = false;
        }

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                page_cnt = Convert.ToInt32(pageCountTextbox.Text);
                
                if (page_cnt <= 1) gunaButton1.Enabled = false;
                min_lim = 7 * (page_cnt - 1);
                activity_manager = new Activity_Manager();
                LogsTable.DataSource = activity_manager.Display_Three_Logs_Table(min_lim);
            }
        }

    }
}
