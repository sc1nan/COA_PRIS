using COA_PRIS.Screens.Subscreens.Maintenance;
using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
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
        private Add_Record Add_Record;
        private View_Record View_Record;
        private Util util;

        private string Query { get; set; }
        private string Active_Form { get; set; }
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

            this.Active_Form = (string)button.Tag;
            show_Table(Query);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            UserControl[] controls = null;
            string insert_Query = null;
            string table = null;

            switch (Active_Form)
            {
                case "Agency":
                    table = "agency_table";
                    insert_Query = Database_Query.set_new_agency;
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Agency Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Cluster :",   _dock: DockStyle.Bottom, 
                            _query: Database_Query.get_cluster_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Cluster Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Cluster",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };

                    break;

                case "Cluster":
                    insert_Query = Database_Query.set_new_cluster;
                    table = "cluster_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Cluster Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Sector :",   _dock: DockStyle.Bottom, 
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };

                    break;

                case "Contractor":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Contractor Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                    };
                    insert_Query = Database_Query.set_new_contractor;
                    table = "contractor_table";
                    break;

                case "Division":
                    insert_Query = Database_Query.set_new_division;
                    table = "division_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Division Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Office :",   _dock: DockStyle.Bottom,
                            _query: Database_Query.get_office_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Office Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Office",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };
                    break;

                case "Nature":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Nature Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                    };
                    insert_Query = Database_Query.set_new_nature;
                    table = "nature_table";
                    break;

                case "Office":
                    insert_Query = Database_Query.set_new_office;
                    table = "office_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Office Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Sector :",   _dock: DockStyle.Bottom,
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };
                    break;

                case "Position":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Position Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                    };
                    insert_Query = Database_Query.set_new_position;
                    table = "position_table";
                    break;

                case "Section":
                    insert_Query =Database_Query.set_new_section;
                    table = "section_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Section Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Division :", _dock: DockStyle.Bottom,
                            _query: Database_Query.get_division_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };
                    break;

                case "Sector":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Sector Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                    };
                    insert_Query = Database_Query.set_new_sector;
                    table = "sector_table";
                    break;
            }
            
            Add_Record = new Add_Record(controls, insert_Query, table);
            Add_Record.callback += callback_Function;
            Add_Record.ShowDialog();
        }

        private void show_Table(string query)
        {
            DataTable dt = new DataTable();

            using (database_Manager)
                dt = database_Manager.ExecuteQuery(query);

            data_View.DataSource = null;
            data_View.Rows.Clear();
            data_View.DataSource = util.format_DataTable(dt);
        }

        public void refresh_Table()
        {
            DataTable dt = new DataTable();

            using (database_Manager)
                dt = database_Manager.ExecuteQuery(Query);

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

        private void view_Btn_Click(object sender, EventArgs e)
        {

            string record_code = (string)data_View.Rows[data_View.CurrentRow.Index].Cells[1].Value;
            UserControl[] controls = null;
            string read_Query = null;
            string update_Query = null;
            string table = null;

            switch (Active_Form)
            {
                case "Agency":
                    read_Query = Database_Query.get_agency_record_by_id;
                    update_Query = Database_Query.update_agency_record_by_id;
                    table = "agency_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Agency Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Cluster :",   _dock: DockStyle.Bottom,
                            _query: Database_Query.get_cluster_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Cluster Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Cluster",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };
                    break;

                case "Cluster":
                    read_Query = Database_Query.get_cluster_record_by_id;
                    update_Query = Database_Query.update_cluster_record_by_id;
                    table = "cluster_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Cluster Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Sector :",   _dock: DockStyle.Bottom,
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };

                    break;

                case "Contractor":
                    read_Query = Database_Query.get_contractor_record_by_id;
                    update_Query = Database_Query.update_contractor_record_by_id;
                    table = "contractor_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Cluster Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                    };
                    break;

                case "Division":
                    read_Query = Database_Query.get_division_record_by_id;
                    update_Query = Database_Query.update_division_record_by_id;
                    table = "division_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Division Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Office :",   _dock: DockStyle.Bottom,
                            _query: Database_Query.get_office_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Office Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Office",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };
                    break;
                case "Nature":
                    read_Query = Database_Query.get_nature_record_by_id;
                    update_Query = Database_Query.update_nature_record_by_id;
                    table = "nature_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Nature Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                    };
                    break;

                case "Office":
                    read_Query = Database_Query.get_office_record_by_id;
                    update_Query = Database_Query.update_office_record_by_id;
                    table = "office_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Office Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Sector :",   _dock: DockStyle.Bottom,
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };
                    break;

                case "Position":
                    read_Query = Database_Query.get_position_record_by_id;
                    update_Query = Database_Query.update_position_record_by_id;
                    table = "position_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Position Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                    };
                    break;

                case "Section":
                    read_Query = Database_Query.get_section_record_by_id;
                    update_Query = Database_Query.update_section_record_by_id;
                    table = "section_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Section Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                        new PRIS_Label_Selector(_title:"Division :",   _dock: DockStyle.Bottom,
                            _query: Database_Query.get_division_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Division Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Division",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),})
                    };
                    break;

                case "Sector":
                    read_Query = Database_Query.get_sector_record_by_id;
                    update_Query = Database_Query.update_sector_record_by_id;
                    table = "sector_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Sector Name :", _dock: DockStyle.Top),
                        new PRIS_Label_Rich(_title: "Description :", _dock: DockStyle.Fill),
                    };
                    break;
            }

            View_Record = new View_Record(record_code, controls, read_Query,update_Query, table);
            View_Record.callback += callback_Function; 
            View_Record.ShowDialog();

        }
    }
}
