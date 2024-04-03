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

namespace COA_PRIS.Screens.Subscreens.Employees
{
    public partial class Add_Employee : Form
    {
        private Validator validator;
        private Database_Manager database_manager;
        private Util util = new Util();
        public Add_Employee()
        {
            InitializeComponent();
            database_manager = new Database_Manager();
        }
        private void Add_Record_Load(object sender, EventArgs e)
        {
            show_NewID();
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            validator = new Validator();

            var ret = validator.Required_TextBox(field_Panel, add_emp_error);
        }

        private void show_NewID() 
        {
            string name = "";

            using (database_manager)
            {
                var recent_record = database_manager.ExecuteQuery(Database_Query.get_top_employee_rec);

                if (recent_record != null)
                    foreach (DataRow row in recent_record.Rows)
                        name = (string)row["employee_no"];
            }



            

            //emp_id.Text = util.generate_ID(name);

        }

    }
}
