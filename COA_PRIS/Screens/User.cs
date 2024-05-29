using COA_PRIS.Screens.Subscreens.Projects;
using COA_PRIS.Screens.Subscreens.Users;
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
    public partial class User : Form
    {
        private Form current_Form = null;
        private Tab_Manager tab_Manager = new Tab_Manager();

        private readonly Users_Lists users_Lists = new Users_Lists();
        private readonly Users_Roles users_Roles = new Users_Roles();
        private readonly Users_Create users_Create = new Users_Create();

        public Action ResetTable;

        public User()
        {
            InitializeComponent();
        }

        public void Network_Callback()
        {


        }
        private void User_Load(object sender, EventArgs e)
        {
            foreach (Control control in nav_Panel.Controls)
                if (control is GunaButton)
                    tab_Manager.Nav_buttons.Add(control);

            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(user_Btn, false);

            user_Btn.PerformClick();

        }

        private void button_Click(object sender, EventArgs e) 
        {
            var button = (GunaButton)sender;
            Form form = null;

            switch (button.Name)
            {
                case "user_Btn":
                    form = users_Lists;
                    break;
                case "roles_Btn":
                    form = users_Roles;
                    break;
            }
            if (form != null)
                current_Form = tab_Manager.switch_Form(form, current_Form, container_Panel);

            tab_Manager.active_Button(button, false);

        }
    }
}
