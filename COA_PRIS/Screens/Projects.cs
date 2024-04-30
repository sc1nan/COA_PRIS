using COA_PRIS.Screens.Subscreens.Employees;
using COA_PRIS.Screens.Subscreens.Projects;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens
{
    public partial class Projects : Form
    {
        private Form current_Form = null;
        private Tab_Manager tab_Manager = new Tab_Manager();

        private readonly Project_List project_List = new Project_List();
        private readonly Project_Create project_Create = new Project_Create();
        public Projects()
        {
            InitializeComponent();
        }

        
        private void Projects_Load(object sender, EventArgs e)
        {

            foreach (Control control in nav_panel.Controls)
                if (control is GunaButton)
                    tab_Manager.Nav_buttons.Add(control);
            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(record_Btn, false);
            record_Btn.PerformClick();

            project_List.ToCreate += ToCreate;
        }
        private void button_Clicked(object sender, EventArgs e)
        {
            var button = (GunaButton)sender;
            Form form = null;

            switch (button.Name)
            {
                case "record_Btn":
                    form = project_List;
                    break;
                case "create_Btn":
                    form = project_Create;
                    break;
            }
            if (form != null)
                current_Form = tab_Manager.switch_Form(form, current_Form, container_Panel);

            tab_Manager.active_Button(button, false);
        }

        private void ToCreate() 
        {
            create_Btn.PerformClick();
        }
    }
}
