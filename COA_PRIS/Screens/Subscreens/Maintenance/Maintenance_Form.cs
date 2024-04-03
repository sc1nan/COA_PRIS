using COA_PRIS.Utilities;
using System;
using System.Collections;
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
        private Control[] controls;
        public Maintenance_Form()
        {
            InitializeComponent();
            controls = new Control[]  {search_Panel, add_Btn, view_Btn, delete_Btn };
        }

        private void Maintenance_Form_Load(object sender, EventArgs e)
        {
            hide_Controls();
        }

        public void set_Form(string table_Query, bool[] enabled_Controls) 
        {
            for (int i = 0; i < controls.Length; i++)
                controls[i].Visible = enabled_Controls[i];
            


            show_Table(table_Query);
        }

        private void show_Table(string query) 
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

        private void hide_Controls()
        {
            foreach (Control control in controls) 
            { 
                control.Visible = false;
            }
        }

    }
}
