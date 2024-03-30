using System;
using System.Diagnostics;
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
        private readonly Projects projects_Tab = new Projects();
        private readonly Home landing_Home = new Home();
        private readonly Employee employee_Tab = new Employee();
        private readonly ActivityLogs log_Tab = new ActivityLogs();
        private readonly Maintenance maintenance_Tab = new Maintenance();

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
            tab_Manager.active_Button(EmployeeBtn);
            MaintenanceBtn.PerformClick();
        }

        private void SidebarTimer_tick(object sender, EventArgs e)
        {
            int deltaWidth = sidebar_Expanded ? -10 : 10;
            SidebarContainer.Width += deltaWidth;
            sideExpand_Btn.Image = sidebar_Expanded ? Resources.swipe_right : Resources.swipe_left;

            if (SidebarContainer.Width == SidebarContainer.MinimumSize.Width || SidebarContainer.Width == SidebarContainer.MaximumSize.Width)
            {
                sidebar_Expanded = !sidebar_Expanded;
                sidebar_Timer.Stop();
            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            sidebar_Timer.Start();
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
            Form form = null;

            switch (button.Name)
            {
                case "HomeBtn":
                    form = landing_Home;
                    break;
                case "Createbtn":
                    // Handle Create button click
                    current_Form = tab_Manager.switch_Form(projects_Tab, current_Form, Main_Form);
                    break;
                case "ReportBtn":
                    // Handle Report button click
                    break;
                case "EmployeeBtn":
                    form = employee_Tab;
                    break;
                case "LogBtn":
                    form = log_Tab;
                    break;
                case "UserBtn":
                    // Handle User button click
                    break;
                case "MaintenanceBtn":
                    form = maintenance_Tab;
                    break;
            }
            if (form != null)
                current_Form = tab_Manager.switch_Form(form, current_Form, Main_Form);

            tab_Manager.active_Button(button, true);
        }
    }
}
