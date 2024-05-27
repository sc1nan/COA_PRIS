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


namespace COA_PRIS.Screens.Subscreens.Projects
{
    public partial class Project_List : Form
    {
        private Database_Manager Database_Manager = new Database_Manager();
        private Util util = new Util();

        private Project_Create Project_Create;
        private Project_View Project_View;
        
        public Project_List()
        {
            InitializeComponent();
        }
        private void Project_List_Load(object sender, EventArgs e)
        {
            InitializeControls();
            Access_Manager();
            PRIS_Seachbox.DropboxValues = new List<string>() { "All", "Code", "Routing #", "Title", "Amount", "Status"};
            PRIS_Seachbox.Search_Typed += SearchBar_CallBack;
            
        }

        private void Access_Manager()
        {
            DataTable ret;
            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_project_access, Activity_Manager.CurrentUser));

            if (ret != null) 
            { 
                add_RecordBtn.Visible = ret.Rows[0][0].ToString() == "1" ? true : false  ;
                view_RecordBtn.Visible = ret.Rows[0][1].ToString() == "1" ? true : false;
            }

        }

        private void InitializeControls() 
        {

            var column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 20), (true, 40), (true, 15), (true, 10) };
            var column_Text_Align = new (string, DataGridViewContentAlignment)[]
            {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Project Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Routing Slip Number ",DataGridViewContentAlignment.MiddleCenter),
                        ("Project Title",DataGridViewContentAlignment.MiddleLeft),
                        ("Amount", DataGridViewContentAlignment.MiddleRight),
                        ("Status", DataGridViewContentAlignment.MiddleCenter)
            };
            using (Database_Manager) 
                data_View.DataSource = util.FormatDataTable(Database_Manager.ExecuteQuery(Database_Query.get_all_project_records)) ;
            
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }
        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            Project_Create = new Project_Create();
            Project_Create.ToRefresh += Refresh_Table;
            Project_Create.ShowDialog();
        }
        private void view_RecordBtn_Click(object sender, EventArgs e)
        {
            if (data_View.Rows.Count != 0) 
            {
                Project_View = new Project_View((string)data_View.Rows[data_View.CurrentRow.Index].Cells[1].Value);
                Project_View.ToRefresh += RefreshCallback;
                Project_View.ShowDialog();
            }
        }
        private void SearchBar_CallBack(object sender, EventArgs e) 
        {
            DataTable ret = null;
            using (Database_Manager)
            {
                switch (PRIS_Seachbox.Dropbox_Text) 
                {
                    case "All":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_project_all_search, PRIS_Seachbox.Search_Text));
                        break;
                    case "Code":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_project_specific_search, "code", PRIS_Seachbox.Search_Text));
                        break;
                    case "Routing #":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_project_specific_search, "document_no", PRIS_Seachbox.Search_Text));
                        break;
                    case "Title":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_project_specific_search, "title", PRIS_Seachbox.Search_Text));
                        break;
                    case "Amount":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_project_specific_search, "amount", PRIS_Seachbox.Search_Text));
                        break;
                    case "Status":
                        ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_project_status_search, PRIS_Seachbox.Search_Text));
                        break;
                }
            }
            data_View.DataSource = util.FormatDataTable(ret);
        }
        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            Refresh_Table();
            PRIS_Seachbox.Clear();
        }
        public void RefreshCallback() 
        {
            Refresh_Table();
        }
        private void Refresh_Table()
        {
            DataTable ret;

            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(Database_Query.get_all_project_records);


            data_View.DataSource = util.FormatDataTable(ret);
        }

    }
}
