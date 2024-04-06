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
        }
        private void Add_Record_Load(object sender, EventArgs e)
        {
            database_manager = new Database_Manager();
            show_NewID();

            this.emp_id.Text = util.generate_ID("emp_info_table");

            DataTable ret = new DataTable();
            Dictionary<string, string> option_Values = new Dictionary<string, string>();
            option_Values.Add("0", "Select Sector");

            using (database_manager) 
            {
                ret = database_manager.ExecuteQuery("SELECT sector_table.code, sector_table.title FROM sector_table WHERE sector_table.`status` = 1;");
            }

            foreach (DataRow row in ret.Rows) 
            {
                var key = (string)row[0];
                var value = (string)row[1];

                option_Values[key] = value;

                //Console.WriteLine($"{row[0]} | {row[1]}");
            }

            sector_DropBox.DisplayMember = "value";
            sector_DropBox.ValueMember = "key";
            sector_DropBox.DataSource = new BindingSource(option_Values, null);



        }



        private void save_Btn_Click(object sender, EventArgs e)
        {

           
            //validator = new Validator();
            MessageBox.Show((string)sector_DropBox.SelectedValue + (string)Office_DropBox.SelectedValue + (string)division_DropBox.SelectedValue + (string)sector_DropBox.SelectedValue);


            validator = new Validator();

            if (validator.Required_TextBox(field_Panel, error_Employee)) 
            {

                using (database_manager) 
                {
                    //database_manager.ExecuteNonQuery(string.Format(Database_Query.get_acc, emp_id, f))
                    //string.Format("{0},{1},{2},{3}", emp_id.Text, txtName.Text, txtEmail.Text, txtContact.Text,   )
                    database_manager.ExecuteNonQuery(string.Format(Database_Query.set_new_employee, emp_id.Text, txtName.Text, txtEmail.Text, txtContact.Text, section_DropBox.SelectedValue.ToString(), position_DropBox.SelectedValue.ToString(), "james"));
                
                }
            
            
            }
            section_DropBox.DataSource = null;
            Office_DropBox.DataSource = null;
            division_DropBox.DataSource = null;
            sector_DropBox.DataSource = null;
            position_DropBox.DataSource = null;
           
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

        public void getoffice()
        {
            database_manager = new Database_Manager();
            show_NewID();

            DataTable ret = new DataTable();
            Dictionary<string, string> option_Values = new Dictionary<string, string>();
            option_Values.Add("0", "Select Office");

            using (database_manager)
            {
                ret = database_manager.ExecuteQuery("SELECT office_table.code, office_table.title FROM office_table WHERE office_table.`status` = 1;");
            }

            foreach (DataRow row in ret.Rows)
            {
                var key = (string)row[0];
                var value = (string)row[1];

                option_Values[key] = value;
                
                //Console.WriteLine($"{row[0]} | {row[1]}");
            }

            Office_DropBox.DisplayMember = "value";
            Office_DropBox.ValueMember = "key";
            Office_DropBox.DataSource = new BindingSource(option_Values, null);
        }

        private void sector_DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sector_DropBox.SelectedValue ?? "0").ToString() != "0")
            {
                getoffice();
                Office_DropBox.Enabled = true;
            }
            else
            {
                Office_DropBox.Enabled = false;
            }

        }

        public void getDivision ()
        {
            database_manager = new Database_Manager();
            show_NewID();

            DataTable ret = new DataTable();
            Dictionary<string, string> option_Values = new Dictionary<string, string>();
            option_Values.Add("0", "Select Division");

            using (database_manager)
            {
                ret = database_manager.ExecuteQuery("SELECT division_table.code, division_table.title FROM division_table WHERE division_table.`status` = 1;");
            }

            foreach (DataRow row in ret.Rows)
            {
                var key = (string)row[0];
                var value = (string)row[1];

                option_Values[key] = value;

                //Console.WriteLine($"{row[0]} | {row[1]}");
            }

           division_DropBox.DisplayMember = "value";
            division_DropBox.ValueMember = "key";
            division_DropBox.DataSource = new BindingSource(option_Values, null);
        }
        private void Office_DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Office_DropBox.SelectedValue ?? "0").ToString() != "0")
            {
                getDivision();
                division_DropBox.Enabled = true;
            }
            else
            {
                division_DropBox.Enabled = false;
            }
        }

        public void getSection()
        {
            database_manager = new Database_Manager();
            show_NewID();

            DataTable ret = new DataTable();
            Dictionary<string, string> option_Values = new Dictionary<string, string>();
            option_Values.Add("0", "Select Section");

            using (database_manager)
            {
                ret = database_manager.ExecuteQuery("SELECT section_table.code, section_table.title FROM section_table WHERE section_table.`status` = 1;");
            }

            foreach (DataRow row in ret.Rows)
            {
                var key = (string)row[0];
                var value = (string)row[1];

                option_Values[key] = value;

                //Console.WriteLine($"{row[0]} | {row[1]}");
            }

            section_DropBox.DisplayMember = "value";
            section_DropBox.ValueMember = "key";
            section_DropBox.DataSource = new BindingSource(option_Values, null);
        }
        public void getPosition()
        {
            database_manager = new Database_Manager();
            show_NewID();

            DataTable ret = new DataTable();
            Dictionary<string, string> option_Values = new Dictionary<string, string>();
            option_Values.Add("0", "Select Position");

            using (database_manager)
            {
                ret = database_manager.ExecuteQuery("SELECT position_table.code, position_table.title FROM position_table WHERE position_table.`status` = 1;");
            }

            foreach (DataRow row in ret.Rows)
            {
                var key = (string)row[0];
                var value = (string)row[1];

                option_Values[key] = value;

                //Console.WriteLine($"{row[0]} | {row[1]}");
            }

            position_DropBox.DisplayMember = "value";
            position_DropBox.ValueMember = "key";
            position_DropBox.DataSource = new BindingSource(option_Values, null);
        }
        private void section_DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((section_DropBox.SelectedValue ?? "0").ToString() != "0")
            {
               getPosition();
                position_DropBox.Enabled = true;
            }
            else
            {
                 
                position_DropBox.Enabled = false;
            }
        }

        private void division_DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((division_DropBox.SelectedValue ?? "0").ToString() != "0")
            {
                getSection();
                section_DropBox.Enabled = true;
            }
            else
            {
                section_DropBox.Enabled = false;
            }
        }

        private void position_DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
