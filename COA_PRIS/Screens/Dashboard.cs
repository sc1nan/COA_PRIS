using System;
using System.Windows.Forms;
using COA_PRIS.Properties;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;

namespace COA_PRIS.Screens
{
    partial class Dashboard : Form
    {
        private bool sidebar_Expanded = true;
        private Form current_Form = null;

        private Tab_Manager tab_Manager;
        
        private readonly Home landing_Home = new Home();
        private readonly Employee employee_Tab = new Employee();
        private readonly ActivityLogs log_Tab = new ActivityLogs();

        public Dashboard()
        {
            InitializeComponent();
            SidebarContainer.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();

            foreach (Control control in tab_panel.Controls)
                tab_Manager.Nav_buttons.Add(control.Controls[0]);


            tab_Manager.Header_Title = headerTitle;
            tab_Manager.active_Button(HomeBtn);
            HomeBtn.PerformClick();
        }

        private void SidebarTimer_tick(object sender, EventArgs e)
        {
            //Expands the sidebar.
            if (sidebar_Expanded)
            {
                SidebarContainer.Width -= 10;
                sideExpand_Btn.Image = Resources.swipe_right;
                if (SidebarContainer.Width == SidebarContainer.MinimumSize.Width)
                {
                    sidebar_Expanded = false;
                    SidebarTimer.Stop();
                }
            }

            //Retracts the sidebar
            else
            {
                SidebarContainer.Width += 10;
                sideExpand_Btn.Image = Resources.swipe_left;
                if (SidebarContainer.Width == SidebarContainer.MaximumSize.Width)
                {
                    sidebar_Expanded = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Activity_Manager activityManager = new Activity_Manager();
                if (MessageBox.Show("Are you sure you want to logout", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    activityManager.Log_Activity("james", Log_Message.logout_message);
                    Application.Exit();
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (GunaButton)sender;
            switch (button.Name)
            {
                case "HomeBtn":
                    current_Form = tab_Manager.switch_Form(landing_Home, current_Form, Main_Form);
                    //buswitch_Form(landingHome);
                    break;
                case "Createbtn":
                    // Handle Create button click
                    break;
                case "ReportBtn":
                    // Handle Report button click
                    break;
                case "EmployeeBtn":
                    current_Form = tab_Manager.switch_Form(employee_Tab, current_Form, Main_Form);
                    break;
                case "LogBtn":
                    current_Form = tab_Manager.switch_Form(log_Tab, current_Form, Main_Form);
                    break;
                case "UserBtn":
                    // Handle User button click
                    break;
            }
            tab_Manager.active_Button(button, true);
        }
    }
}
