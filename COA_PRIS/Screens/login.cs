using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS
{
    public partial class login : Form
    {
        private int attempts = 3;
        private string _user_name;
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
            int status_result = 0;

            _user_name = gunaTextBox1.Text.ToString();
            if (dbCon.IsConnect())
            {
                var check_status_cmd = new MySqlCommand(String.Format(Database_Query.check_acc_status, gunaTextBox1.Text.ToString()), dbCon.Connection);
                status_result = Convert.ToInt32(check_status_cmd.ExecuteScalar());

                var log_cmd = new MySqlCommand(String.Format(Database_Query.login_query, gunaTextBox1.Text.ToString(), gunaTextBox2.Text.ToString()), dbCon.Connection);
                ret = Convert.ToInt32(log_cmd.ExecuteScalar());

                dbCon.Close();
            }

            if (ret == 1 && status_result == 1) {
                Dashboard formu = new Dashboard();
                formu.Show();
                this.Hide();
            }


            if ((_user_name == gunaTextBox1.Text.ToString() && ret == 0) && attempts != 0)
            {
                attempts--;
                MessageBox.Show("Same USN");
            }
            else if (attempts == 0) 
            {
                MessageBox.Show("Jesser is displeased");
            }
            else
            {
                _user_name = gunaTextBox1.Text.ToString();
                MessageBox.Show("Diff USN");
                attempts = 3;
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

        private void gunaElipsePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text.ToString() == "")
            {
                MessageBox.Show("Enter your username", "Missing Credentials");
            }
            Console.WriteLine(_user_name);  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            DevInfo info = new DevInfo();
            info.Show();
        }
    }
}
