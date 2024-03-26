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
    public partial class Splash_Screen : Form
    {

        private string text;
        private int len = 0;
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(len < text.Length)
            //{
            //    lblText.Text = lblText.Text + text.ElementAt(len);
            //    len++;

            //}
            //else 
            //    timer1.Stop();
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            string text = lblText.Text;
            lblText.Text = "";
            timer1.Start();
        }
    }
}
