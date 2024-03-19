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
        public Dashboard()
        {
            InitializeComponent();
            SidebarContainer.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            gunaButton1.PerformClick();
        }
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            home = new Home();
            home.TopLevel = false;
            Baseform.Controls.Add(home);
            //home.BringToFront();
            home.Show();
            button_Reset(gunaButton1);
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
                    //Application.Exit();
                    this.Hide();
                    login login = new login();
                    login.ShowDialog();
                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            /*ProjectCreation pr = new ProjectCreation();
            pr.TopLevel = false;
            Baseform.Controls.Add(pr);
            //home.BringToFront();
            pr.Show();*/
            //Createbtn.Enabled = false;
            //Createbtn.BackColor = Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            button_Reset(Createbtn);
        }

        private void gunaPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button_Reset(GunaButton active_GunaButton)
        {
            gunaButton1.Enabled = true;
            Createbtn.Enabled = true;
            gunaButton3.Enabled = true;
            gunaButton4.Enabled = true;
            gunaButton7.Enabled = true;

            gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            Createbtn.BaseColor = System.Drawing.Color.Transparent;
            gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            gunaButton4.BaseColor = System.Drawing.Color.Transparent;
            gunaButton7.BaseColor = System.Drawing.Color.Transparent;

            active_GunaButton.Enabled = false;
            active_GunaButton.BaseColor = Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            button_Reset(gunaButton3);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            button_Reset(gunaButton4);
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            button_Reset(gunaButton7);
        }
    }
}
