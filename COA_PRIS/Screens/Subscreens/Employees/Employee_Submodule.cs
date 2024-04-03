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

namespace COA_PRIS.Screens.Subscreens.Employees
{
    public partial class Employee_Submodule : Form
    {
        Database_Manager database_manager;

        private readonly Add_Record add_Record = new Add_Record();
        public Employee_Submodule()
        {
            InitializeComponent();
            database_manager = new Database_Manager();
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            

            add_Record.ShowDialog();
        }
    }
}
