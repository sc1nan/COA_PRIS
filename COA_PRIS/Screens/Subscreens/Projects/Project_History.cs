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
    public partial class Project_History : Form
    {
        private Database_Manager Database_Manager = new Database_Manager();
        private Util util = new Util();

        private string ProjectCode;
        public Project_History(string projectCode)
        {
            InitializeComponent();
            ProjectCode = projectCode;
            project_id.Text = projectCode;
            InitializeControls();
        }

        private void Project_History_Load(object sender, EventArgs e)
        {

        }

        private void InitializeControls() 
        {
            var column_Widths = new (bool, int)[] { (true, 5), (true, 60), (true, 15), (true, 20) };
            var column_Text_Align = new (string, DataGridViewContentAlignment)[]
            {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Description", DataGridViewContentAlignment.MiddleLeft),
                        ("Source ",DataGridViewContentAlignment.MiddleCenter),
                        ("Date",DataGridViewContentAlignment.MiddleCenter),
            };
            using (Database_Manager)
                data_View.DataSource = util.FormatDataTable(Database_Manager.ExecuteQuery(string.Format(Database_Query.get_project_history_by_id, ProjectCode)));

            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }
    }
}
