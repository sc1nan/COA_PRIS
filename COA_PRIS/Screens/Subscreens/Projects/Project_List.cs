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
        private Screens.Projects projects;
        private Database_Manager database_Manager = new Database_Manager();
        private Util util = new Util();

        public event Action ToCreate;

        public Project_List()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls() 
        {

            var column_Widths = new (bool, int)[] { (true, 3), (true, 10), (true, 25), (true, 35), (true, 15), (true, 10) };
            var column_Text_Align = new (string, DataGridViewContentAlignment)[]
            {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Project Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Routing Number ",DataGridViewContentAlignment.MiddleLeft),
                        ("Project Title",DataGridViewContentAlignment.MiddleLeft),
                        ("Amount", DataGridViewContentAlignment.MiddleRight),
                        ("Status", DataGridViewContentAlignment.MiddleCenter)
            };
            using (database_Manager) 
            {
               data_View.DataSource = util.FormatDataTable(database_Manager.ExecuteQuery(Database_Query.get_all_project_records)) ;
            }
                Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }
        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            ToCreate?.Invoke();
        }
    }
}
