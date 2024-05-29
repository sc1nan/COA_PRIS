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
        public TempReportsForms(string table = null)
        {
            InitializeComponent();

            Database_Manager db_manager = new Database_Manager();

            using (db_manager)
            {
                try
                {
                    //takes what type of report is generated
                    switch (table)
                    {
                        case "log":
                            reportViewer1.LocalReport.ReportEmbeddedResource = "COA_PRIS.CrystalReports.Report1.rdlc";
                            break;
                        case "project":
                            reportViewer1.LocalReport.ReportEmbeddedResource = "COA_PRIS.CrystalReports.ProjectRequestReport.rdlc";
                            break;;
                        case "action":
                            reportViewer1.LocalReport.ReportEmbeddedResource = "COA_PRIS.CrystalReports.Report2.rdlc";
                            break; ;
                        default: break;
                    }
                    Console.WriteLine($"{Database_Query.last_query} {reportViewer1}");
                    db_manager.ExecuteQueryReportViewerDataSource(Database_Query.last_query, reportViewer1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error generating report: {ex.Message}", "Error");
                }
            }

            reportViewer1.LocalReport.DisplayName = "REPORT-" + DateTime.Now.ToString("yyyy'-'MM'-'ddHHmm");
        }

        private void TempReportsForms_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            //this.reportViewer1.RefreshReport();
        }

        private void FilterReports()
        {
            //ReportParameter 
            //reportViewer1.LocalReport.setpa
        }

    }
}
