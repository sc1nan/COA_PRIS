using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using COA_PRIS.Properties;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using Org.BouncyCastle.Asn1.Cmp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COA_PRIS.Screens
{
    partial class Dashboard : Form
    {
        private Form current_Form = null;
        private Login_Manager login_manager;
        private Database_Manager database_manager = new Database_Manager();
        private Tab_Manager tab_Manager;
        private Activity_Manager activity_manager;

        private readonly Projects projects_Tab = new Projects();
        private readonly Home landing_Home = new Home();
        private readonly Employee employee_Tab = new Employee();
        private readonly ActivityLogs log_Tab = new ActivityLogs();
        private readonly Maintenance maintenance_Tab = new Maintenance();
        private readonly Reports reports_Tab = new Reports();
        private readonly User user_Tab = new User();

        public Dashboard()
        {
            InitializeComponent();
            title_Panel.BringToFront();

            Activity_Manager.CurrentUser = "TSO_Dev";
            //this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();
            login_manager = new Login_Manager();
            activity_manager = new Activity_Manager();
            foreach (Control control in tab_panel.Controls)
                tab_Manager.Nav_buttons.Add(control.Controls[0]);

            activity_manager.Log_Activity(Activity_Manager.CurrentUser, "Logged In");

            tab_Manager.Header_Title = headerTitle;
            tab_Manager.active_Button(EmployeeBtn, true);
            ProjectBtn.PerformClick();

            gunaLabel1.Text = Activity_Manager.CurrentUser;

            Access_Manager();
        }


        private void Access_Manager() 
        {          
            DataTable ret;
            using (database_manager)
                ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_user_access, Activity_Manager.CurrentUser));

            if (ret != null) 
                for (int retIndex = 0; retIndex < ret.Columns.Count; retIndex++) 
                    tab_panel.Controls[retIndex].Visible = (int)ret.Rows[0][retIndex] == 1 ? true: false;
            
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
                    activityManager.Log_Activity(Activity_Manager.CurrentUser, Log_Message.logout_message);
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
                case "ProjectBtn":
                    form = projects_Tab;
                    break;
                case "ReportBtn":
                    form = reports_Tab;
                    break;
                case "EmployeeBtn":
                    form = employee_Tab;
                    break;
                case "LogBtn":
                    form = log_Tab;
                    break;
                case "UserBtn":
                    form = user_Tab;
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
                activityManager.Log_ActivityOut(Activity_Manager.CurrentUser, Log_Message.logout_message);
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
                this.Dispose();
               
               
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
