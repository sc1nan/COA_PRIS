using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COA_PRIS.CrystalReports;
using COA_PRIS.UserControlUtil.Jesser_Util;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;

namespace COA_PRIS.Screens.Subscreens.Reports
{
    public partial class ProjectRequest_Reports_Sub : Form, IGenericTableVariables
    {
        private Database_Manager Database_Manager = new Database_Manager();
        /*private int min_lim = 0;
        private int page_cnt = 1;*/
        public int min_lim { get; set; }
        public int page_cnt { get; set; }
        GenericTable genericTable = new GenericTable();
        //private Util util;
        readonly string[] date_types = { "period", "receiveing_date" };
        private Dictionary<string, string> status_type = new Dictionary<string, string>();
        private readonly string[] table_names = { "period", "receiveing_date" };
        /*int IGenericTableVariables.min_lim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IGenericTableVariables.page_cnt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }*/
        public ProjectRequest_Reports_Sub()
        {
            InitializeComponent();
            //setup filter
            sortComboBox.DataSource = new string[] { "All", "Agency", "Cluster", "Sector", "Contractor", "Nature", "Division"};
            sortComboBox.SelectedIndex = 0;




            //setup user controls
            searchBar1.Ambatu(logsSearchBox_TextChanged);
            ChangeDataDates();
            dateFilter1.Ambatu(dateTimePicker_ValueChanged);
            dateFilter1.toValue = DateTime.Today;
            dateFilter1.fromValue = DateTime.Today;
            //fill in content datagridview
            genericTable.Populate_Table(3, dateFilter1, searchBar1, contentTable, sortComboBox, date_types, min_lim, "project", status);
            //setup page button
            genericTable.Check_Count(next_Button, previous_Button, dateFilter1, min_lim, page_cnt, "project");

        }
        private void ProjectRequest_Reports_Sub_Load(object sender, EventArgs e)
        {
            DataTable ret;
            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(Database_Query.get_all_status);

            status_type.Add("", "All");
            foreach (DataRow row in ret.Rows)
            {
                status_type.Add(row[0].ToString(), row[1].ToString());
            }

            status.DataSource = new BindingSource(status_type, null);
            status.DisplayMember = "Value";
            status.ValueMember = "Key";

            status.SelectedIndex = 3;

        }

        //change data grid view content according to search box
        private void logsSearchBox_TextChanged(object sender, EventArgs e)
        {
            genericTable.Populate_Table(3, dateFilter1, searchBar1, contentTable, sortComboBox, date_types, min_lim, "project", status);
        }

        private void previous_Button_Click(object sender, EventArgs e)
        {
            genericTable.UserChangePage(pageCountTextbox, dateFilter1, searchBar1, contentTable, sortComboBox, next_Button, previous_Button, page_cnt, min_lim, date_types, false, "project");
        }

        private void next_Button_Click(object sender, EventArgs e)
        {
            genericTable.UserChangePage(pageCountTextbox, dateFilter1, searchBar1, contentTable, sortComboBox, next_Button, previous_Button, page_cnt, min_lim, date_types, true, "project");
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            if (contentTable.Rows.Count != 0)
                genericTable.GenerateReportForm("project");
            else
                MessageBox.Show("There is no data to process in this filter or search option", "PRIS Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //add events to date time picker
        private void ChangeDataDates()
        {
            dateFilter1.ToValueChanged += dateTimePicker_ValueChanged;
            dateFilter1.FromValueChanged += dateTimePicker_ValueChanged;
        }
        //if date time picker change values
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateFilter1.toValue < dateFilter1.fromValue)
                dateFilter1.fromValue = dateFilter1.toValue;
            genericTable.Populate_Table(3, dateFilter1, searchBar1, contentTable, sortComboBox, date_types, min_lim, "project", status);
            genericTable.Check_Count(next_Button, previous_Button, dateFilter1, min_lim, page_cnt, "project");
        }
        //change table content based on filter values
        private void refresh_Button_Click(object sender, EventArgs e)
        {
            status.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
            genericTable.Populate_Table(3, dateFilter1, searchBar1, contentTable, sortComboBox, date_types, min_lim, "project", status);
        }

        private void pageCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            //checks to see if user presses enter
            if (e.KeyData == Keys.Enter)
            {
                genericTable.UserChangePageCountInput(pageCountTextbox, dateFilter1, searchBar1, contentTable, sortComboBox, next_Button, previous_Button, page_cnt, min_lim, date_types, "project");
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericTable.Populate_Table(3, dateFilter1, searchBar1, contentTable, sortComboBox, date_types, min_lim, "project", status);
        }


    }
}
