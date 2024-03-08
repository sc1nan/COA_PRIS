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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = Loginbtn;
        }

  
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(gunaTextBox1.Text.ToString() == "asd" && gunaTextBox2.Text.ToString() == "qwert")
            {
                Console.WriteLine("asd");
                Dashboard formu = new Dashboard();
                formu.Show();
                this.Hide();
            }
            else
            {
                Console.WriteLine("das");
            }

        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if(gunaTextBox1.Text == "Username")
                gunaTextBox1.Text = "";
        }

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "Password")
                gunaTextBox2.Text = "";
        }
    }
}
