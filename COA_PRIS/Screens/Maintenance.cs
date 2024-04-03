using COA_PRIS.Screens.Subscreens.Maintenance;
using COA_PRIS.UserControlUtil;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens
{
    public partial class Maintenance : Form
    {
        private Database_Manager database_Manager;
        private Tab_Manager tab_Manager;
        private Add_Record Add_Agency;
        private Util util;
        private string Query { get; set; }
        private Control[] controls;

        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            database_Manager = new Database_Manager();
            tab_Manager = new Tab_Manager();
            util = new Util(); 


            tab_Manager.set_Buttons(nav_panel);
            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(agency_Btn, false);
            tab_Manager.Header_Title = title_label;

            controls = new Control[] { search_Panel, add_Btn, view_Btn, delete_Btn };

            agency_Btn.PerformClick();
        }

        private void button_Click(object sender, EventArgs e)
        { 
            var button = (GunaButton)sender;
            bool[] buttons = null;
            (bool, int)[] column_Widths = null;
            (string, DataGridViewContentAlignment)[] column_Text_Align = null;

            switch (button.Tag) 
            {
                case "Agency":
                    Query = Database_Query.get_all_agency_records;
                    buttons = new bool[] { true, true, true, true };

                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Agency Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Agency ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Cluster", DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Cluster":
                    Query = Database_Query.get_all_cluster_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[]{ (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Cluster Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Cluster ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Sector", DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Contractor":
                    Query = Database_Query.get_all_contractor_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 50), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Contractor ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Division":
                    Query = Database_Query.get_all_division_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Division Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Division",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Office",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Office":
                    Query = Database_Query.get_all_office_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Office Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Office",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Sector",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Nature":
                    Query = Database_Query.get_all_nature_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 50), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Nature Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Nature",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Position":
                    Query = Database_Query.get_all_position_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 50), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Position Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Postion",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Section":
                    Query = Database_Query.get_all_section_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 40), (true, 25), (true, 20) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Section Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Section ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft),
                        ("Division",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Sector":
                    Query = Database_Query.get_all_sector_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 50), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Sector ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

            }

            
            tab_Manager.active_Button(button, true);
           
            show_Table(Query);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            UserControl[] controls = null;
            string insert_Query = null;
            string table = null;

            switch (title_label.Text)
            {
                case "AGENCY":
                    controls = new UserControl[]
                    {
                        new Label_Text("Agency Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop("Cluster:", Database_Query.get_cluster_options)
                    };
                    insert_Query = Database_Query.set_new_agency;
                    table = "agency_table";

                    break;

                case "CLUSTER":
                    controls = new UserControl[]
                    {
                        new Label_Text("Cluster Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop("Sector:", Database_Query.get_sector_options)
                    };
                    insert_Query = Database_Query.set_new_cluster;
                    table = "cluster_table";

                    break;


                case "CONTRACTOR":
                    controls = new UserControl[]
                    {
                       new Label_Text("Contractor Name:"),
                       new Label_Rich("Description:")
                    };
                    insert_Query = Database_Query.set_new_contractor;
                    table = "contractor_table";
                    break;

                case "DIVISION":
                    controls = new UserControl[]
                    {
                        new Label_Text("Division Name:"),
                        new Label_Rich("Description:"),
                        new Label_Drop ("Office:",Database_Query.get_office_options)
                    };
                    insert_Query = Database_Query.set_new_division;
                    table = "division_table";
                    break;
                case "NATURE":
                    controls = new UserControl[]
                    {
                        new Label_Text("Nature:"),
                        new Label_Rich("Description")
                    };
                    insert_Query = Database_Query.set_new_nature;
                    table = "nature_table";
                    break;

                case "OFFICE":
                    controls = new UserControl[]
                    {
                        new Label_Text("Office Name:"),
                        new Label_Rich ("Description:"),
                        new Label_Drop("Sector:",Database_Query.get_sector_options)
                    };
                    insert_Query = Database_Query.set_new_office;
                    table = "office_table";
                    break;

                case "POSITION":
                    controls = new UserControl[]
                    {
                        new Label_Text("Position:"),
                        new Label_Rich("Description:")
                    };
                    insert_Query = Database_Query.set_new_position;
                    table = "position_table";
                    break;

                case "SECTION":
                    controls = new UserControl[]
                    {
                        new Label_Text ("Section:"),
                        new Label_Rich ("Description:"),
                        new Label_Drop ("Division:",Database_Query.get_division_options)
                    };
                    insert_Query =Database_Query.set_new_section;
                    table = "section_table";
                    break;

                case "SECTOR":
                    controls = new UserControl[]
                    {
                        new Label_Text("Sector:"),
                        new Label_Rich("Description:")
                    };
                    insert_Query = Database_Query.set_new_sector;
                    table = "sector_table";
                    break;





                    /*case "STATUS":
                        controls = new UserControl[]
                        {
                            new Label_Text("Status Name:"),
                            new Label_Rich("Description:"),
                        };
                        insert_Query = Database_Query.set_new_status;
                        table = "status_table";

                        break;*/
            }
            
            
            
            Add_Agency = new Add_Record(controls, insert_Query, table);
            Add_Agency.callback += callback_Function;
            Add_Agency.ShowDialog();
        }

        private void show_Table(string query)
        {
            DataTable dt = new DataTable();

            using (database_Manager)
            {
                dt = database_Manager.ExecuteQuery(query);
            }
            data_View.DataSource = null;
            data_View.Rows.Clear();
            data_View.DataSource = util.format_DataTable(dt);
        }

        public void refresh_Table()
        {
            DataTable dt = new DataTable();

            using (database_Manager)
            {
                dt = database_Manager.ExecuteQuery(Query);
            }
            data_View.DataSource = util.format_DataTable(dt);
        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            refresh_Table();
        }

        private void callback_Function() 
        {
            refresh_Table();
        }

        private void nav_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
