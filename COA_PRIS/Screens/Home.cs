using COA_PRIS.Properties;
using COA_PRIS.Screens;
using COA_PRIS.Utilities;
using Org.BouncyCastle.Ocsp;
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
        private Database_Manager Database_Manager = new Database_Manager();
        private Util Util = new Util();

        public Home()
        {
            InitializeComponent();

            string role = string.Empty;
            using (Database_Manager)
                role = Database_Manager.ExecuteScalar(string.Format(Database_Query.get_user_role_title, Activity_Manager.CurrentUser)).ToString();

            user_name.Text = Activity_Manager.CurrentUser;
            user_role.Text = role;

            

            animated.BringToFront();

            date_time.Text = DateTime.Now.ToString("dddd, MMMM dd, MMMM hh:mm tt");
            SetTable();

            

        }

        private async void Network_Callback(object sender, string message)
        {
            Console.WriteLine(message);
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { SetValues(); });
            else
                SetValues();

            await ServerManager.SendMessageToClientsAsync("Reset Clients");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SetValues();

            ServerManager.MessageReceived += Network_Callback;
            //ClientManager.MessageReceived += Network_Callback;

            timer.Start();
        }


        private void SetValues() 
        {
            using (Database_Manager){
                var status = Database_Manager.ExecuteQuery(Database_Query.get_status_names);
                var pending = Convert.ToInt32(Database_Manager.ExecuteScalar(string.Format(Database_Query.get_docu_count_status, "SYSTEM_STS000001"))).ToString("N0");
                var forward = Convert.ToInt32(Database_Manager.ExecuteScalar(string.Format(Database_Query.get_docu_count_status, "SYSTEM_STS000002"))).ToString("N0");
                var received = Convert.ToInt32(Database_Manager.ExecuteScalar(string.Format(Database_Query.get_docu_count_status, "SYSTEM_STS000004"))).ToString("N0");
                var filed = Convert.ToInt32(Database_Manager.ExecuteScalar(string.Format(Database_Query.get_docu_count_status, "SYSTEM_STS000003"))).ToString("N0");
                var today = Convert.ToInt32(Database_Manager.ExecuteScalar(Database_Query.get_docu_count_today)).ToString("N0");
                var total = Convert.ToInt32(Database_Manager.ExecuteScalar(Database_Query.get_docu_grand_total)).ToString("N0");
                var ret = Database_Manager.ExecuteQuery(Database_Query.get_weekly_projects);

                status_1.Text = status.Rows[0][0].ToString();
                status_2.Text = status.Rows[1][0].ToString();
                status_3.Text = status.Rows[3][0].ToString();
                status_4.Text = status.Rows[2][0].ToString();

                status_num1.Text = pending;
                status_num2.Text = forward;
                status_num3.Text = received;
                status_num4.Text = filed;
                    
                today_num.Text = today;
                total_num.Text = total;

                data_View.DataSource = Util.FormatDataTable(ret);

            }

            

            

        }

        private void SetTable() 
        {
            DataTable ret;

            var column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 20), (true, 35), (true, 15), (true, 15) };
            var column_Text_Align = new (string, DataGridViewContentAlignment)[]
            {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Project Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Routing Slip Number ",DataGridViewContentAlignment.MiddleCenter),
                        ("Project Title",DataGridViewContentAlignment.MiddleLeft),
                        ("Amount", DataGridViewContentAlignment.MiddleRight),
                        ("Date Received", DataGridViewContentAlignment.MiddleCenter)
            };
            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(Database_Query.get_weekly_projects);

            data_View.DataSource = Util.FormatDataTable(ret);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);


        
        
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            date_time.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm tt");
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            if (hour >= 5 && hour < 12)
                timeIndicator.Image = Resources.sunrise;
            else if (hour >= 12 && hour < 15)
                timeIndicator.Image = Resources.noon;
            else if (hour >= 15 && hour < 18)
                timeIndicator.Image = Resources.sunsets;
            else
                timeIndicator.Image = Resources.night;
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                SetValues();
                timer.Start();
            }
            else
                timer.Stop();
        }
    }
   }


