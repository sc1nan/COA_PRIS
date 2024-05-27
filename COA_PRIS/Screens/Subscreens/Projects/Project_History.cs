using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
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

        private void InitializeControls() 
        {
            var column_Widths = new (bool, int)[] { (true, 3), (true, 62), (true, 15), (true, 20) };
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

            util.SetControls(PRIS_TitleControls(), title_Panel);

            var titleControls = util.SearchControls<UserControl>(title_Panel, new List<Type>() { typeof(PRIS_Label_Entry) });


            ((IPRIS_UserControl)titleControls[0]).Value = ProjectCode;

            /*using (Database_Manager)
            {
                var ret = Database_Manager.ExecuteScalar(string.Format(Database_Query.get_project_title_by_id, ProjectNumber));
                var div = Database_Manager.ExecuteScalar(string.Format(Database_Query.get_project_division_by_id, ProjectCode));

                ((IPRIS_UserControl)titleControls[1]).Value = ret.ToString();
                ((IPRIS_UserControl)selectors[0]).Value = div.ToString();
            }*/



        }

        private List<UserControl[]> PRIS_TitleControls()
        {
            List<UserControl[]> controls = new List<UserControl[]>()
            {
                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Routing Slip Number :", _isReadOnly: true, _showMessage: false),
                },
                new UserControl[]
                {
                   new PRIS_Label_Entry(_title: "Project Title :", _isReadOnly: true, _showMessage: false),
                }

            };

            return controls;
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
