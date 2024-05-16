using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Size s = monthCalendar1.SingleMonthSize;
            Size d = new Size(150, 55);
            s = d;
            monthCalendar1.Size = s;
        }

        private void Main_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


