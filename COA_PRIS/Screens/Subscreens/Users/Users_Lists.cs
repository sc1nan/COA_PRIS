using COA_PRIS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens.Subscreens.Users
{
    public partial class Users_Lists : Form
    {
        private Database_Manager database_Manager = new Database_Manager();
        private Util util = new Util();

        private Users_Create Users_Create;
        private Users_View Users_View;
        

        public Action ToCreate;
        public Users_Lists()
        {
            InitializeComponent();
        }

        private void InitializeControls() 
        { 
            
        
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            Users_Create = new Users_Create();
            Users_Create.ShowDialog();
        }

        private void Users_Lists_Load(object sender, EventArgs e)
        {
            Users_Create = new Users_Create();
            Users_Create.RefreshTable += RefreshCallback;

            (bool, int)[] column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 30), (true, 20), (true, 20), (true, 15) }; ;
            (string, DataGridViewContentAlignment)[] column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Employee Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Full Name",DataGridViewContentAlignment.MiddleLeft),
                        ("Office",DataGridViewContentAlignment.MiddleLeft),
                        ("Position", DataGridViewContentAlignment.MiddleLeft),
                        ("Role", DataGridViewContentAlignment.MiddleLeft)
                    }; ;

            DataTable ret;

            using (database_Manager)
                ret = database_Manager.ExecuteQuery(Database_Query.get_all_active_user);


            data_View.DataSource = util.FormatDataTable(ret);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);

        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            Refresh_Table();
        }

        public void RefreshCallback()
        {
            Refresh_Table();
        }
        private void Refresh_Table() 
        {
            DataTable ret;

            using (database_Manager)
                ret = database_Manager.ExecuteQuery(Database_Query.get_all_active_user);

            data_View.DataSource = util.FormatDataTable(ret);
        }

        private void view_RecordBtn_Click(object sender, EventArgs e)
        {
            Users_View = new Users_View();
            Users_View.ShowDialog();
        }
    }
}
