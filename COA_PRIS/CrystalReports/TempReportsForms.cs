﻿using COA_PRIS.Screens;
using COA_PRIS.Utilities;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
        private string Table;
        Database_Manager db_manager = new Database_Manager();
        public TempReportsForms(string table = null)
        {
            InitializeComponent();
            Table = table;  

            
        }


        private void TempReportsForms_Load(object sender, EventArgs e)
        {
            using (db_manager)
            {
                try
                {

                    Console.WriteLine($"{Database_Query.last_query} {reportViewer1}");
                    //takes what type of report is generated
                    switch (Table)
                    {
                        case "log":
                            reportViewer1.LocalReport.ReportEmbeddedResource = "COA_PRIS.CrystalReports.Report1.rdlc";
                            break;
                        case "project":
                            reportViewer1.LocalReport.ReportEmbeddedResource = "COA_PRIS.CrystalReports.ProjectRequestReport.rdlc";
                            break; ;
                        case "action":
                            reportViewer1.LocalReport.ReportEmbeddedResource = "COA_PRIS.CrystalReports.Report2.rdlc";
                            break; ;
                        default: break;
                    }
                    db_manager.ExecuteQueryReportViewerDataSource(Database_Query.last_query, reportViewer1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error generating report: {ex.Message}", "Error");
                }
            }

            reportViewer1.LocalReport.DisplayName = "REPORT-" + DateTime.Now.ToString("yyyy'-'MM'-'ddHHmm");
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
