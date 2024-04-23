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

namespace COA_PRIS.UserControlUtil
{
    public partial class DataTableMultiplePages : UserControl
    {
        Activity_Manager activity_manager;
        //string[] column_names = { "User Name", "Activity", "Time" };
        string[] log_table_names = { "user_name", "activity", "activity_datetime" };
        private int min_lim = 0;
        int page_count = 1;
        public DataTableMultiplePages()
        {
            /*if (column_names == null) column_names = new string[] { "column 1", "column 2", "column 3" };
            InitializeComponent();
            //fix sort combobox
            changeGunaTableStyle(data_table);
            for (int i = 0; i < column_names.Length; i++)
            {
                sort_combobox.Items.Add(column_names[i]);
            }
            sort_combobox.SelectedText = column_names[0];
            sort_combobox.SelectedIndex = 0;

            SetTableHeader(column_names);

            min_lim = minimum_limit;
            DisplayLogsTable();*/
        }


        private void DisplayLogsTable()
        {
            //adds items to table
            activity_manager = new Activity_Manager();
            //data_table.DataSource = activity_manager.Display_Three_Logs_Table(min_lim);
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            Change_Page("prev");
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            Change_Page("next");
        }

        private void page_count_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            Change_Page("skip");
        }

        private void Change_Page(string type)
        {
            switch (type)
            {
                case "prev":
                    page_count--;
                    break;
                case "next":
                    page_count++;
                    break;
                case "skip":
                    page_count = Convert.ToInt32(page_count_textbox.Text);
                    break;
                default: break;
            }
            //changes button state
            switch (page_count)
            {
                case 1:
                    next_button.Enabled = true;
                    previous_button.Enabled = false;
                    break;
                case 3:
                    next_button.Enabled = false;
                    previous_button.Enabled = true;
                    break;
                default:
                    next_button.Enabled = true;
                    previous_button.Enabled = true;
                    break;
            }
            
            page_count_textbox.Text = page_count.ToString();

        }

        private void SetTableHeader(string[] column_names)
        {
            //Changes column name, change this later
            foreach (DataGridViewColumn column in data_table.Columns)
            {
                column.HeaderText = column_names[column.Index];
            }
        }

        public void changeTableContent(GunaTextBox searchBox, GunaDataGridView sourceTable, GunaComboBox filterComboBox)
        {
            if (searchBox.Text.ToString() == "") DisplayLogsTable();
            activity_manager = new Activity_Manager();
            //sourceTable.DataSource = activity_manager.Display_Specific_Logs_Table(searchBox.Text.ToString(), log_table_names[filterComboBox.SelectedIndex]);

        }
    }
}
