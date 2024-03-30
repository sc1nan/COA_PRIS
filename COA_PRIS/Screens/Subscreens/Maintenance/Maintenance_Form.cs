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

namespace COA_PRIS.Screens.Subscreens.Maintenance
{
    public partial class Maintenance_Form : Form
    {
        private Database_Manager database_Manager;
        public Maintenance_Form()
        {
            InitializeComponent();
        }

        private void Maintenance_Form_Load(object sender, EventArgs e)
        {
            
        }

        public void set_Form(string table_Query, string form_Title = "Record",
            
            bool has_Add_Record = true, bool has_View_Record = true,
            bool has_Refresh = true) 
        {

            
            
            show_Table(table_Query);

        }

        public void show_Table(string query) 
        {
            database_Manager = new Database_Manager();
            DataTable dt = new DataTable();

            using (database_Manager)
            {
                dt = database_Manager.ExecuteQuery(query);
            }

            data_View.Refresh();
            data_View.DataSource = dt;
        }
    }
}
