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
                if (MessageBox.Show("Are you sure you want to logout", "Logout Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Createboard cr = new Createboard();
            cr.TopLevel = false;
            Baseform.Controls.Add(cr);
            //home.BringToFront();
            cr.Show();

        }

        private void gunaPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
