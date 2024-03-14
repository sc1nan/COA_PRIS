using COA_PRIS.Screens;
﻿using COA_PRIS.Utilities;
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
        private MySqlConnection connection;
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
            DataTable ret, stat = new DataTable();
            using (var db_Manager = new Database_Manager()) 
            {
                ret = db_Manager.ExecuteQuery(string.Format(Database_Query.login_query, gunaTextBox1.Text.ToString(), gunaTextBox2.Text.ToString()));
                stat = db_Manager.ExecuteQuery(string.Format(Database_Query.check_acc_status, gunaTextBox1.Text.ToString()));
            }
            
            if (ret.Rows.Count == 1)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                this.Hide();
            }
            else
            {
                attempts--;
                gunaLabel3.Text = $"You have {attempts} more attempt/s remaining,";
                gunaLabel3.Visible = true ;
                MessageBox.Show("Incorrect Credentials", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (attempts == 0) 
            {
                MessageBox.Show("Exceed number of login attempts.\nThe application will now close.",
                    "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
                this.ActiveControl = null;
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
            {   
                gunaTextBox2.Text = "";
                gunaTextBox2.PasswordChar = '*';
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            DevInfo info = new DevInfo();
            info.Show();
        }
        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to close the application?", "Close Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }
    }
}
