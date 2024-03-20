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
    public partial class Dashboard : Form
    {
        bool sidebarExpand = true;
        Home home;
        LogsTab logTab;
        Button_Manager button_Manager;
        public Dashboard()
        {
            InitializeComponent();
            SidebarContainer.BringToFront();

            

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            button_Manager = new Button_Manager();
            HomeBtn.PerformClick();

            //Get all the button on the Side Nav
            foreach (Control contron in SidebarContainer.Controls)
            {
                if (contron.Tag != null && string.Equals("Tabs", contron.Tag.ToString())) 
                {
                    button_Manager.SideBar.Add(contron.Controls[0]);
                }
            }
            button_Manager.Header_Title = headerTitle;
            button_Manager.active_Button(HomeBtn);
        }

        private void SidebarTimer_tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidebarContainer.Width -= 10;
                if(SidebarContainer.Width == SidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                SidebarContainer.Width += 10;
                if(SidebarContainer.Width == SidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start(); 
        }

        private void home_BtnClick(object sender, EventArgs e)
        {
            home = new Home();
            home.TopLevel = false;
            Baseform.Controls.Add(home);
            //home.BringToFront();
            home.Show();
            button_Manager.active_Button(HomeBtn);
        }

        private void Baseform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidebarContainer_MouseHover(object sender, EventArgs e)
        {
            //SidebarTimer.Start();
        }

        private void SidebarContainer_MouseLeave(object sender, EventArgs e)
        {
            //SidebarTimer.Start();
        }


        private void create_BtnClick(object sender, EventArgs e)
        {
            /*ProjectCreation pr = new ProjectCreation();
            pr.TopLevel = false;
            Baseform.Controls.Add(pr);
            //home.BringToFront();
            pr.Show();*/
            //Createbtn.Enabled = false;
            //Createbtn.BackColor = Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            button_Manager.active_Button(Createbtn);
        }

        

        private void report_BtnClick(object sender, EventArgs e)
        {
            //button_Reset(ReportsBtn, "Document History");
            button_Manager.active_Button(ReportBtn);
        }

        private void employee_BtnClick(object sender, EventArgs e)
        {
            //button_Reset(EmployeeBtn, "Employees");
            button_Manager.active_Button(EmployeeBtn);
        }

        private void log_BtnClick(object sender, EventArgs e)
        {
            home.Hide();
            logTab = new LogsTab();
            logTab.TopLevel = false;
            Baseform.Controls.Add(logTab);
            logTab.Show();
            button_Manager.active_Button(LogBtn);
            //button_Reset(ActivityBtn, "Log History");
        }
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Activity_Manager activity_manager = new Activity_Manager();
                if (MessageBox.Show("Are you sure you want to logout", "Logout Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    //for testing
                    activity_manager.Log_Activity("james", Log_Message.logout_message);
                    Application.Exit();
                    
                                        


                    //Disable for development
                    /*this.Hide();
                    login login = new login();
                    login.ShowDialog();*/
                }
            }
        }
    }
}
