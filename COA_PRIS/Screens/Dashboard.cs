using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using COA_PRIS.Properties;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COA_PRIS.Screens
{
    partial class Dashboard : Form
    {
        private bool sidebar_Expanded = false;
        private Form current_Form = null;
        private Login_Manager login_manager;
        private Database_Manager database_manager;
        private Tab_Manager tab_Manager;
        private Activity_Manager manager;
        private Log_Message message;
        private readonly Projects projects_Tab = new Projects();
        private readonly Home landing_Home = new Home();
        private readonly Employee employee_Tab = new Employee();
        private readonly ActivityLogs log_Tab = new ActivityLogs();
        private readonly Maintenance maintenance_Tab = new Maintenance();

        public Dashboard()
        {
            InitializeComponent();
            //SidebarContainer.BringToFront();
            title_Panel.BringToFront();

            //this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();
            login_manager = new Login_Manager();

            foreach (Control control in tab_panel.Controls)
                tab_Manager.Nav_buttons.Add(control.Controls[0]);

            login_manager.active_Account = "james";
            tab_Manager.Header_Title = headerTitle;
            tab_Manager.active_Button(EmployeeBtn, true);
            EmployeeBtn.PerformClick();
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
                    activityManager.Log_Activity("admin", Log_Message.logout_message);
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

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Activity_Manager activityManager = new Activity_Manager();
            database_manager = new Database_Manager();
            if (MessageBox.Show("Are you sure you want to logout", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                activityManager.Log_ActivityOut("admin", Log_Message.logout_message);

                    login log = new login();
                    log.ShowDialog();
                    this.Close();
               
               
            }
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            var button = (GunaButton)sender;

            headerTitle.Text = button.Tag.ToString().ToUpper();
            button_ToolTip.SetToolTip(button, button.Tag.ToString().ToUpper());
        }
    }
}
