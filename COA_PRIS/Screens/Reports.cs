using COA_PRIS.Screens.Subscreens.Employees;
using COA_PRIS.Screens.Subscreens.Reports;
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

namespace COA_PRIS.Screens
{
    public partial class Reports : Form
    {
        private Tab_Manager tab_Manager;

        private Form current_Form = null;

        private readonly ProjectRequest_Reports_Sub reports_Submodule = new ProjectRequest_Reports_Sub();

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            foreach (Control control in nav_panel.Controls)
                if (control is GunaButton)
                    tab_Manager.Nav_buttons.Add(control);

            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(reports_Btn, false);

            reports_Btn.PerformClick();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (GunaButton)sender;
            switch (button.Name)
            {
                case "reports_Btn":
                    current_Form = tab_Manager.switch_Form(reports_Submodule, current_Form, container_Panel);
                    break;


            }
            tab_Manager.active_Button(button, false);
        }
    }
}
