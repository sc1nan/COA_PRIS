using COA_PRIS.Screens;
using COA_PRIS.Utilities;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.CrystalReports
{
    public partial class TempReportsForms : Form
    {
        public TempReportsForms()
        {
            InitializeComponent();

            Database_Manager db_manager = new Database_Manager();

            using (db_manager)
            {
                try
                {
                    db_manager.ExecuteQueryXD(Database_Query.last_query, reportViewer1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error generating report: {ex.Message}", "Error");
                }
            }

            reportViewer1.LocalReport.DisplayName = "LOGS REPORT-" + DateTime.Now.ToString("yyyy'-'MM'-'ddHHmm");
        }

        private void TempReportsForms_Load(object sender, EventArgs e)
        {
            
            //this.reportViewer1.RefreshReport();
        }

    }
}
