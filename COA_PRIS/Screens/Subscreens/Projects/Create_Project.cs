using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens.Subscreens.Projects
{
    public partial class Create_Project : Form
    {
        private Add_Project add_Project;
        public Create_Project()
        {
            InitializeComponent();
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            add_Project = new Add_Project();
            add_Project.ShowDialog();
        }
    }
}
