using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens.Subscreens.Employees
{
    public partial class Employee_Submodule : Form
    {
        private Database_Manager database_manager;
        private Theme theme;
        private Util util;

        private readonly Add_Employee add_Employee = new Add_Employee();
        public Employee_Submodule()
        {
            InitializeComponent();
            database_manager = new Database_Manager();
            theme = new Theme();
            util = new Util();
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            
            add_Employee.ShowDialog();
        }

        private void Employee_Submodule_Load(object sender, EventArgs e)
        {
            (bool, int)[] column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 35), (true, 20), (true, 20), (true, 10) }; ;
            (string, DataGridViewContentAlignment)[] column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Employee Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Full Name",DataGridViewContentAlignment.MiddleLeft),
                        ("Office",DataGridViewContentAlignment.MiddleLeft),
                        ("Position", DataGridViewContentAlignment.MiddleLeft),
                        ("Status", DataGridViewContentAlignment.MiddleLeft)
                    }; ;
            database_manager = new Database_Manager();
            DataTable dt = new DataTable();

            using (database_manager)
                dt = database_manager.ExecuteQuery(Database_Query.get_employee_records);


            data_View.DataSource = util.format_DataTable(dt);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);
        }
    }
}
