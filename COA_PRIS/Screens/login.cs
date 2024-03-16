using COA_PRIS.Utilities;
using Guna.UI.WinForms;
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
        private Validator validator;
        private Login_Manager login_manager;
        private Database_Manager database_manager;

        public login()
        {
            InitializeComponent();
            validator = new Validator();  
            login_manager = new Login_Manager();
            database_manager = new Database_Manager();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = Login_btn;
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = login_entry.Text.ToString();
            string password = login_entry.Text.ToString();

            if ((!validator.Required(login_entry) || string.Equals(username, "Username")) 
                && (!validator.Required(password_entry) || string.Equals(password, "Password")))
            {
                MessageBox.Show("Username and Password are required.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((!validator.Required(login_entry) || string.Equals(username, "Username")) && (validator.Required(password_entry)))
            {
                MessageBox.Show("Username is required.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((validator.Required(login_entry)) && (!validator.Required(password_entry) || string.Equals(password, "Password")))
            {
                MessageBox.Show("Password is required.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                login_Function();
            }

        }
        private void login_Function()
        {   
            int state_ret, user_exist;
            string username = login_entry.Text.ToString();
            string password = password_entry.Text.ToString();

            bool login_ret = login_manager.authenticate(username, password);

            using (database_manager)
            {
                user_exist = Convert.ToInt32(database_manager.ExecuteScalar(string.Format(Database_Query.login_query, username)));
                state_ret = Convert.ToInt32(database_manager.ExecuteScalar(string.Format(Database_Query.check_acc_status, username)));
            }
            if (login_ret && state_ret == 1)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else if (!login_ret && state_ret == 1)
            {
                attempts--;
                error_label.Text = $"You have {attempts} more attempt/s remaining.";
                error_label.Visible = true;
                MessageBox.Show("Incorrect Credentials\nExceeding the number of attempts will deactivate the account.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (login_ret && state_ret == 0)
            {
                MessageBox.Show("The account you are trying to access is currenty deactivated.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Incorrect Credentials", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (attempts == 0)
            {
                using (var db_Manager = new Database_Manager())
                {
                    var disable_user = db_Manager.ExecuteNonQuery(string.Format(Database_Query.deact_acc, username));
                }

                MessageBox.Show("Exceed number of login attempts.\nThe application will now close.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
                this.ActiveControl = null;
                attempts = 3;
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

        private void login_entry_Enter(object sender, EventArgs e)
        {
            if (string.Equals(login_entry.Text.ToString(), "Username"))
                login_entry.Text = "";
        }

        private void password_entry_Enter(object sender, EventArgs e)
        {
            if (string.Equals(password_entry.Text.ToString(), "Password"))
            {
                password_entry.Text = "";
                password_entry.PasswordChar = '*';
            }       
        }

        private void password_entry_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password_entry.Text.ToString()))
            { 
                password_entry.Text = "Password";
            }
            
        }

        private void login_entry_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_entry.Text.ToString()))
                login_entry.Text = "Username";
        }
    }
}
