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
            if(Username.Text.ToString() == "asd" && Password.Text.ToString() == "qwert")
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


        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
                Username.Text = "";
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
                Password.Text = "";
        }
    }
}
