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
    public partial class ProjectCreation2 : Form
    {
        public ProjectCreation2()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ProjectCreation project = new ProjectCreation();
            project.TopLevel = false;
            base.Controls.Add(project);
            project.BringToFront();
            project.Show();
        }
    }
}
