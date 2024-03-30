using COA_PRIS.Screens.Subscreens.Maintenance;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
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

namespace COA_PRIS.Screens
{
    public partial class Maintenance : Form
    {
        private Tab_Manager tab_Manager;
        private Maintenance_Form maintenance_Form = new Maintenance_Form();
        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            tab_Manager.set_Buttons(nav_panel);
            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(agency_Btn, false);
            tab_Manager.Header_Title = title_label;

            agency_Btn.PerformClick();
            show_Form();

        }

        private void button_Click(object sender, EventArgs e)
        { 
            var button = (GunaButton)sender;
            string query = null;

            switch (button.Tag) 
            {
                case "AGENCY":
                    query = Database_Query.get_all_agency_records;
                    break;
                case "CLUSTER":
                    query = Database_Query.get_all_cluster_records;
                    break;
            }

            
            maintenance_Form.set_Form(query, (string)button.Tag);
            tab_Manager.active_Button(button, true);
        }

        private void show_Form()
        {
            maintenance_Form.TopLevel = false;
            maintenance_Form.Dock = DockStyle.Fill;
            subCon_Panel.Controls.Add(maintenance_Form);
            maintenance_Form.Show();
        }
    }




}
