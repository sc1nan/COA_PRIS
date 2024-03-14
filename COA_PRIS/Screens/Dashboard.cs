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
        bool sidebarExpand;
        public Dashboard()
        {
            InitializeComponent();
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
            Dashboardform dash = new Dashboardform();
            dash.TopLevel = false;
            Baseform.Controls.Add(dash);
            dash.BringToFront();
            dash.Show();
        }
    }
}
