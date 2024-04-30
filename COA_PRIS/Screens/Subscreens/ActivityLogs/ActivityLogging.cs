using COA_PRIS.CrystalReports;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens.Subscreens.ActivityLogs
{
    public partial class ActivityLogging : Form
    {
        Activity_Manager activity_manager;
        Database_Manager database_Manager = new Database_Manager();
        Util util = new Util();
        readonly string[] log_table_names = { "user_name", "activity" };
        private int min_lim = 0;
        private readonly int max_lim = 15;
        private int page_cnt = 1;
        public ActivityLogging()
        {
            InitializeComponent();
            previous_Button.Enabled = false;
            sortComboBox.SelectedText = "user_name";
            sortComboBox.SelectedIndex = 0;
            DisplayLogsTable();
            //setup user controls
            searchBar1.Ambatu(logsSearchBox_TextChanged);
            ChangeDataDates();
            dateFilter1.Ambatu(dateTimePicker_ValueChanged);
            dateFilter1.toValue = DateTime.Today;
            dateFilter1.fromValue = DateTime.Today;
            //disables next logs button
            Check_Count();
            //set theme to data grid view
            AddThemeToDGV();
        }

        private void Populate_Table(int type_of_spec)
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
            LogsTable.DataSource = util.FormatDataTableLimit(dt, min_lim);
            //set theme to data grid view
            AddThemeToDGV();
        }



        private void previous_Button_Click(object sender, EventArgs e)
        {
            page_cnt--;
            pageCountTextbox.Text = page_cnt.ToString();
            //next_Button.Enabled = true;
            //min_lim = max_lim * (page_cnt - 1);
            //if (page_cnt <= 1) previous_Button.Enabled = false;
            Check_Count();
            Populate_Table(3);
        }

        private void next_Button_Click(object sender, EventArgs e)
        {
            page_cnt++;
            pageCountTextbox.Text = page_cnt.ToString();
            //previous_Button.Enabled = true;
            //min_lim = max_lim * (page_cnt - 1);
            //if ((min_lim + max_lim) >= activity_manager.Count_Activity_Logs()) next_Button.Enabled = false;
            Check_Count();
            Populate_Table(3);
        }

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            //checks to see if user presses enter
            if (e.KeyData == Keys.Enter)
            {
                int result;
                object b = pageCountTextbox.Text;
                //checks to see if user input is a number
                if (int.TryParse(b.ToString(), out result))
                {
                    //checks maximum amount of pages
                    int xd = (Activity_Logs_Count() / 15) + 1;
                    //checks if user input is less than or equal to maximum amount of pages and not below 1
                    if (result <= xd && result >= 1)
                    {
                        page_cnt = result; //puts user input as page count
                        Check_Count();
                        Populate_Table(3);
                    }
                }
                //if wrong, puts last know page count to text box
                pageCountTextbox.Text = page_cnt.ToString();
            }
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            var temprepp = Application.OpenForms["TempReportsForms"];
            if (temprepp == null)
            {
                temprepp = new TempReportsForms("log");
            }
            temprepp.Show();
        }

        private void AddThemeToDGV()
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

        private void ChangeDataDates()
        {
            dateFilter1.ToValueChanged += dateTimePicker_ValueChanged;
            dateFilter1.FromValueChanged += dateTimePicker_ValueChanged;
        }
        
        private void Check_Count()
        {
            min_lim = max_lim * (page_cnt - 1);

            if ((min_lim + max_lim) >= Activity_Logs_Count()) next_Button.Enabled = false;
            else next_Button.Enabled = true;

            if (page_cnt <= 1) previous_Button.Enabled = false;
            else previous_Button.Enabled = true;
        }

        private int Activity_Logs_Count()
        {
            string from_Date = dateFilter1.fromValue.ToString("yyyy/MM/dd 00:00:00");
            string current_time = DateTime.Now.ToString("HH':'mm':'ss");
            string to_Date = dateFilter1.toValue.ToString("yyyy/MM/dd " + current_time);
            int log_count = activity_manager.Count_Activity_Logs(from_Date, to_Date);
            return log_count;
        }

        #region change content base on events
        //on tab switch
        private void ActivityLogging_VisibleChanged(object sender, EventArgs e)
        {
            refresh_Button.PerformClick();
        }
        //handles refresh button
        private void refresh_Button_Click(object sender, EventArgs e)
        {
            Populate_Table(3);
        }
        //handles datetime value changes
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateFilter1.toValue < dateFilter1.fromValue)
                dateFilter1.fromValue = dateFilter1.toValue;
            Populate_Table(3);
        }
        //handles search bar text change
        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            changeTableContent();
            page_cnt = 1;
            pageCountTextbox.Text = page_cnt.ToString();
        }
        //display activity logs
        private void DisplayLogsTable()
        {
            Populate_Table(1);
        }
        //changes table content based on filter value change
        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            changeTableContent();
        }
        //changes table content
        private void changeTableContent()
        {
            Populate_Table(2);
        }
        #endregion
    }
}
