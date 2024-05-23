using COA_PRIS.Screens.Subscreens.Maintenance;
using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using Org.BouncyCastle.Asn1.Cmp;
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
        private Database_Manager database_Manager = new Database_Manager();
        private Tab_Manager tab_Manager = new Tab_Manager();
        private Util util = new Util();
        private Add_Record Add_Record;
        private View_Record View_Record;

        private string Query { get; set; }
        private string SearchQuery;
        private string Active_Form { get; set; }
        private Control[] controls;

        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {


            tab_Manager.set_Buttons(nav_panel);
            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(agency_Btn, false);
            tab_Manager.Header_Title = title_label;

            controls = new Control[] { add_RecordBtn, view_RecordBtn, delete_Btn };

            PRIS_Seachbox.DropboxValues = null;
            PRIS_Seachbox.Search_Typed += Search_Callback;

            agency_Btn.PerformClick();
        }

        private void Search_Callback(object sender, EventArgs e) 
        {
            DataTable ret;

            using (database_Manager)
                ret = database_Manager.ExecuteQuery(string.Format(SearchQuery, PRIS_Seachbox.Search_Text));

            data_View.DataSource = util.FormatDataTable(ret);
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
                    buttons = new bool[] { true, true, true, true };
                    Query = Database_Query.get_all_agency_records;
                    SearchQuery = Database_Query.get_agency_all_search;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 40), (true, 22), (true, 20) };
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
                    buttons = new bool[] { true, true, true, true };
                    Query = Database_Query.get_all_cluster_records;
                    SearchQuery = Database_Query.get_cluster_all_search;
                    column_Widths = new (bool, int)[]{ (true, 3), (true, 15), (true, 40), (true, 22), (true, 20) };
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
                    buttons = new bool[] { true, true, true, true };
                    SearchQuery = Database_Query.get_contractor_all_search;
                    Query = Database_Query.get_all_contractor_records;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 47), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Contractor ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Forward":
                    SearchQuery = Database_Query.get_forward_all_search;
                    Query = Database_Query.get_all_forward_records;
                    buttons = new bool[] { true, true, true, true };
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 47), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Forward Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Title ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Division":
                    buttons = new bool[] { true, true, true, true };
                    Query = Database_Query.get_all_division_records;
                    SearchQuery = Database_Query.get_division_all_search;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 40), (true, 22), (true, 20) };
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
                    buttons = new bool[] { true, true, true, true };
                    Query = Database_Query.get_all_office_records;
                    SearchQuery = Database_Query.get_office_all_search;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 40), (true, 22), (true, 20) };
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
                    buttons = new bool[] { true, true, true, true };
                    SearchQuery = Database_Query.get_nature_all_search;
                    Query = Database_Query.get_all_nature_records;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 47), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Nature Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Nature",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Position":
                    buttons = new bool[] { true, true, true, true };
                    SearchQuery = Database_Query.get_position_all_search;
                    Query = Database_Query.get_all_position_records;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 47), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Position Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Postion",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Section":
                    buttons = new bool[] { true, true, true, true };
                    Query = Database_Query.get_all_section_records;
                    SearchQuery = Database_Query.get_section_all_search;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 40), (true, 22), (true, 20) };
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
                    buttons = new bool[] { true, true, true, true };
                    SearchQuery = Database_Query.get_sector_all_search;
                    Query = Database_Query.get_all_sector_records;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 47), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Sector ",DataGridViewContentAlignment.MiddleLeft),
                        ("Description",DataGridViewContentAlignment.MiddleLeft)
                    };
                    break;

                case "Status":
                    buttons = new bool[] { true, true, true, true };
                    SearchQuery = Database_Query.get_status_all_search;
                    Query = Database_Query.get_all_status_records;
                    column_Widths = new (bool, int)[] { (true, 3), (true, 15), (true, 47), (true, 35) };
                    column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Status Code",DataGridViewContentAlignment.MiddleCenter),
                        ("Status ",DataGridViewContentAlignment.MiddleLeft),
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
                    insert_Query = Database_Query.set_new_agency;
                    table = "agency_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Agency Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight: 250),
                        new PRIS_Label_Selector(_title:"Cluster :",
                            _searchQuery: Database_Query.get_cluster_search,
                            _query: Database_Query.get_cluster_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Cluster Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Cluster",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),}
                            )
                    };

                    break;

                case "Cluster":
                    insert_Query = Database_Query.set_new_cluster;
                    table = "cluster_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Cluster Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 250),
                        new PRIS_Label_Selector(_title:"Sector :", 
                            _searchQuery: Database_Query.get_sector_search,
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] {(true, 5), (true, 20), (true, 40), (true, 35),})
                    };

                    break;

                case "Contractor":
                    insert_Query = Database_Query.set_new_contractor;
                    table = "contractor_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Contractor Name :"),
                        new PRIS_Label_Rich(_title: "Description :" ,_entryHeight: 350),
                    };
                    break;

                case "Division":
                    insert_Query = Database_Query.set_new_division;
                    table = "division_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Division Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 250),
                        new PRIS_Label_Selector(_title:"Office :",
                            _searchQuery: Database_Query.get_office_search,
                            _query: Database_Query.get_office_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Office Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Office",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),})
                    };
                    break;

                case "Forward":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Forward Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 350),
                    };
                    insert_Query = Database_Query.set_new_forward_record;
                    table = "forward_table";
                    break;

                case "Nature":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Nature Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 350),
                    };
                    insert_Query = Database_Query.set_new_nature;
                    table = "nature_table";
                    break;

                case "Office":
                    insert_Query = Database_Query.set_new_office;
                    table = "office_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Office Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 250),
                        new PRIS_Label_Selector(_title:"Sector :",
                            _searchQuery: Database_Query.get_sector_search,
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),})
                    };
                    break;

                case "Position":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Position Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 350),
                    };
                    insert_Query = Database_Query.set_new_position;
                    table = "position_table";
                    break;

                case "Section":
                    insert_Query =Database_Query.set_new_section;
                    table = "section_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Section Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 250),
                        new PRIS_Label_Selector(_title:"Division :",
                            _searchQuery: Database_Query.get_division_search,
                            _query: Database_Query.get_division_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),})
                    };
                    break;

                case "Sector":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Sector Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 350),
                    };
                    insert_Query = Database_Query.set_new_sector;
                    table = "sector_table";
                    break;

                case "Status":
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Status Name :"),
                        new PRIS_Label_Rich(_title: "Description :",_entryHeight: 350),
                    };
                    insert_Query = Database_Query.set_new_status;
                    table = "status_table";
                    break;
            }
            
            Add_Record = new Add_Record(new List<UserControl[]> { controls }, insert_Query, table);
            Add_Record.callback += callback_Function;
            Add_Record.ShowDialog();
        }

        private void view_Btn_Click(object sender, EventArgs e)
        {
            if (data_View.Rows.Count == 0) 
            {
                //MessageBox.Show("There are no record currently to show", "PRIS View Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


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
                        new PRIS_Label_Entry(_title: "Agency Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 260),
                        new PRIS_Label_Selector(_title:"Cluster :",
                            _searchQuery : Database_Query.get_cluster_search,
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
                        new PRIS_Label_Entry(_title: "Cluster Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 260),
                        new PRIS_Label_Selector(_title:"Sector :",
                            _searchQuery : Database_Query.get_sector_search,
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
                        new PRIS_Label_Entry(_title: "Cluster Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 360),
                    };
                    break;

                case "Forward":
                    read_Query = Database_Query.get_forward_record_by_id;
                    update_Query = Database_Query.update_forward_record_by_id;
                    table = "forward_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Forward Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 360),
                    };
                    break;

                case "Division":
                    read_Query = Database_Query.get_division_record_by_id;
                    update_Query = Database_Query.update_division_record_by_id;
                    table = "division_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Division Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 260),
                        new PRIS_Label_Selector(_title:"Office :",
                            _searchQuery : Database_Query.get_office_search,
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
                        new PRIS_Label_Entry(_title: "Nature Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 360),
                    };
                    break;

                case "Office":
                    read_Query = Database_Query.get_office_record_by_id;
                    update_Query = Database_Query.update_office_record_by_id;
                    table = "office_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Office Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 260),
                        new PRIS_Label_Selector(_title:"Sector :",
                            _searchQuery : Database_Query.get_sector_search,
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
                        new PRIS_Label_Entry(_title: "Position Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 360),
                    };
                    break;

                case "Section":
                    read_Query = Database_Query.get_section_record_by_id;
                    update_Query = Database_Query.update_section_record_by_id;
                    table = "section_table";
                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Section Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight : 260),
                        new PRIS_Label_Selector(_title:"Division :",
                            _searchQuery : Database_Query.get_division_search,
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
                        new PRIS_Label_Entry(_title: "Sector Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight: 360),
                    };
                    break;

                case "Status":
                    read_Query = Database_Query.get_status_record_by_id;
                    update_Query = Database_Query.update_status_record_by_id;
                    table = "status_table";

                    controls = new UserControl[]
                    {
                        new PRIS_Label_Entry(_title: "Status Name :"),
                        new PRIS_Label_Rich(_title: "Description :", _entryHeight: 360),
                    };
                    break;
            }

            View_Record = new View_Record(record_code, controls, read_Query,update_Query, table);
            View_Record.callback += callback_Function; 
            View_Record.ShowDialog();

        }


        private void show_Table(string query)
        {
            DataTable dt = new DataTable();

            using (database_Manager)
                dt = database_Manager.ExecuteQuery(query);

            data_View.DataSource = null;
            data_View.Rows.Clear();
            data_View.DataSource = util.FormatDataTable(dt);
        }

        public void refresh_Table()
        {
            DataTable dt = new DataTable();

            using (database_Manager)
                dt = database_Manager.ExecuteQuery(Query);

            data_View.DataSource = util.FormatDataTable(dt);
        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            refresh_Table();
            PRIS_Seachbox.Clear();
        }

        private void callback_Function() 
        {
            refresh_Table();
        }

    }
}
