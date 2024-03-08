using Guna.UI.WinForms;
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
    public partial class Dashboard : Form
    {


        public Dashboard()
        {
            InitializeComponent();

            inboxUserControl1.Hide();
            docuHistoryUserControl1.Hide();
            statReportUserControl1.Hide();
            docuDownloadUserControl1.Hide();
            sysSetupUserControl1.Hide();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaButtonReset(gunaButton2);
            gunaLabel1.Text = "Inbox";
            userControlReset(inboxUserControl1);
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButtonReset(GunaButton btn)
        {
            gunaButton1.Enabled = true;
            gunaButton2.Enabled = true;
            gunaButton3.Enabled = true;
            gunaButton4.Enabled = true;
            gunaButton5.Enabled = true;
            gunaButton6.Enabled = true;

            btn.Enabled = false;
        }

        private void userControlReset(UserControl uc)
        {
            dashboardUserControl1.Hide();
            inboxUserControl1.Hide();
            docuHistoryUserControl1.Hide();
            statReportUserControl1.Hide();
            docuDownloadUserControl1.Hide();
            sysSetupUserControl1.Hide();

            uc.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            gunaButtonReset(gunaButton1);
            gunaLabel1.Text = "Dashboard";
            userControlReset(dashboardUserControl1);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            gunaButtonReset(gunaButton3);
            gunaLabel1.Text = "Document History";
            userControlReset(docuHistoryUserControl1);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            gunaButtonReset(gunaButton4);
            gunaLabel1.Text = "Status Report";
            userControlReset(statReportUserControl1);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            gunaButtonReset(gunaButton5);
            gunaLabel1.Text = "Document Download";
            userControlReset(docuDownloadUserControl1);
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            gunaButtonReset(gunaButton6);
            gunaLabel1.Text = "System Setup";
            userControlReset(sysSetupUserControl1);
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

        }
    }
}
