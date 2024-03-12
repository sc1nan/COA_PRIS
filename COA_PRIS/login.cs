using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS
{
    public partial class login : Form
    {
        
        private int attempts = 3;
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
            var dbCon = DBConnection.Instance();
            int ret = 0;
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(String.Format(Database_Query.login_query, gunaTextBox1.Text.ToString(), 
                    gunaTextBox2.Text.ToString()), dbCon.Connection);
                var scalar = cmd.ExecuteScalar();
                ret = Convert.ToInt32(scalar);
                dbCon.Close();
            }
            if (ret == 0)
            {
                attempts--;
                MessageBox.Show("Incorrect credentials");

            }
            else
            {
                Dashboard formu = new Dashboard();
                formu.Show();
                this.Hide();
            }

            /*if (attempts == 0)
            {
                MessageBox.Show("Exceed Attempts");
            }
            */

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
