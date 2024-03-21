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

namespace COA_PRIS.UserControlUtil
{
    public partial class DataTableMultiplePages : UserControl
    {
        int page_count = 1;
        public DataTableMultiplePages()
        {
            InitializeComponent();
        }

        private void previous_button_Click(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {

        }

        private void page_count_textbox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Change_Page(string type)
        {
            page_count--;
            next_button.Enabled = true;
            previous_button.Enabled = true;
        }
    }
}
