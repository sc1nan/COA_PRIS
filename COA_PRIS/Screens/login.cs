using COA_PRIS.Screens;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Windows.Forms;

namespace COA_PRIS
{
    public partial class Login : Form
    {
        private const int attempts = 3;

        private int left_Attempts = attempts;

        private Validator validator;
        private Login_Manager login_manager;
        private Activity_Manager activity_manager;
        private Database_Manager database_manager;
        private SetUp SetUp;
        public Login()
        {
            InitializeComponent();
            validator = new Validator();
            login_manager = new Login_Manager();
            activity_manager = new Activity_Manager();
            database_manager = new Database_Manager();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //Server
            ServerManager.MessageReceived += Network_Callback;

            this.AcceptButton = Login_btn;
        }

        private async void Network_Callback(object sender, string message) 
        {
            Console.WriteLine(message);

            await ServerManager.SendMessageToClientsAsync("Reset Clients");
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = username_entry.Text.Trim();
            string password = password_entry.Text.Trim();

            bool entry_Complete = false;

            //MessageBox.Show(username);

            if (!string.Equals(username_entry.Text, "Username") && !string.Equals(password_entry.Text, "Password"))
                entry_Complete = validator.RequiredTextBox(parent_Panel, login_Error, error_Message);
            else
                MessageBox.Show("Check your inputs.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (entry_Complete)
                process_Login(username, password);
        }

        private void process_Login(string username, string password)
        {
            bool login_Result = login_manager.Authenricate(username, password);
            int account_Status;

            using (database_manager)
            {
                account_Status = Convert.ToInt32(database_manager.ExecuteScalar(String.Format(Database_Query.check_acc_status, username)));
            }

            if (login_Result && account_Status == 1)
            {
                activity_manager.Log_Activity(username, Log_Message.login_message);
                Activity_Manager.CurrentUser = username;
                
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
                failed_Login(username, account_Status);
            }

        }

        private void failed_Login(string username, int account_Status)
        {
            int account;

            using (database_manager)
            {
                account = Convert.ToInt32(database_manager.ExecuteScalar(string.Format(Database_Query.get_acc, username)));
            }



            if (account_Status == 0 && account == 1)
            {
                MessageBox.Show("The account you are trying to access is currently deactivated.\n" +
                    "Contact the administator about your account.",
                    "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (account_Status == 0 && account == 0) 
            {
                MessageBox.Show("Credentials does not exist.\n",
                    "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                left_Attempts--;
                if (left_Attempts == 0)
                {
                    /*using (database_manager)
                    {
                        database_manager.ExecuteNonQuery(string.Format(Database_Query.deact_acc, username));
                    }*/
                    MessageBox.Show("Exceeded number of login attempts.\nThe application will now close.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                else
                {
                    error_Message.Text = $"You have {left_Attempts} more attempt/s remaining.";
                    error_Message.Visible = true;
                }
                MessageBox.Show("Incorrect Credentials", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            DevInfo info = new DevInfo();
            info.Show();

        }
        private void login_entry_Enter(object sender, EventArgs e)
        {
            if (string.Equals(username_entry.Text.ToString(), "Username"))
                username_entry.Text = "";
        }

        private void password_entry_Enter(object sender, EventArgs e)
        {
            if (string.Equals(password_entry.Text.ToString(), "Password"))
            {
                password_entry.Text = "";
                password_entry.PasswordChar = '*';
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (e.CloseReason == CloseReason.UserClosing)
                    if (MessageBox.Show("Are you sure you want to close the application?", "Close Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                        e.Cancel = true;

                    else
                        Application.Exit();




        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SetUp = new SetUp("setup");
            SetUp.ShowDialog();
        }
    }
}
