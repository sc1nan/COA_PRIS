﻿using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens.Subscreens.Employees
{
    public partial class Employee_Submodule : Form
    {
        private Database_Manager database_manager = new Database_Manager();
        private Util util = new Util();

        private Add_Employee add_Employee;
        private View_Employee view_Employee;
        public Employee_Submodule()
        {
            InitializeComponent();
            
        }

        private void Employee_Submodule_Load(object sender, EventArgs e)
        {
            Set_Table();
            PRIS_Seachbox.DropboxValues = new List<string>() { "All", "Code", "Full Name", "Office", "Position", "Status" };
            PRIS_Seachbox.Search_Typed += Search_Callback;
        }
        private void Search_Callback(object sender, EventArgs e)
        {
            DataTable ret = null;
            using (database_manager)
            {
                switch (PRIS_Seachbox.Dropbox_Text)
                {
                    case "All":
                        ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_all_employee_records_search, PRIS_Seachbox.Search_Text));
                        break;
                    case "Code":
                        ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_specific_employee_search, "emp_info_table.code", PRIS_Seachbox.Search_Text));
                        break;
                    case "Full Name":
                        ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_specific_employee_search, "emp_info_table.full_name", PRIS_Seachbox.Search_Text));
                        break;
                    case "Office":
                        ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_specific_employee_search, "office_table.title", PRIS_Seachbox.Search_Text));
                        break;
                    case "Position":
                        ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_specific_employee_search, "position_table.title ", PRIS_Seachbox.Search_Text));
                        break;
                    case "Status":
                        ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_status_employee_search, PRIS_Seachbox.Search_Text));
                        break;
                }
            }
            data_View.DataSource = util.FormatDataTable(ret);
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            add_Employee = new Add_Employee();
            add_Employee.callback += refresh_Callback;
            add_Employee.ShowDialog();
            
        }


        private void Set_Table() 
        {
            (bool, int)[] column_Widths = new (bool, int)[] { (true, 3), (true, 12), (true, 30), (true, 25), (true, 20), (true, 10) }; ;
            (string, DataGridViewContentAlignment)[] column_Text_Align = new (string, DataGridViewContentAlignment)[]
                    {
                        ("#", DataGridViewContentAlignment.MiddleRight),
                        ("Employee Code", DataGridViewContentAlignment.MiddleCenter),
                        ("Full Name",DataGridViewContentAlignment.MiddleLeft),
                        ("Office",DataGridViewContentAlignment.MiddleLeft),
                        ("Position", DataGridViewContentAlignment.MiddleLeft),
                        ("Status", DataGridViewContentAlignment.MiddleCenter)
                    }; ;
            database_manager = new Database_Manager();
            DataTable dt;

            using (database_manager)
                dt = database_manager.ExecuteQuery(Database_Query.get_employee_records);


            data_View.DataSource = util.FormatDataTable(dt);
            Theme.gridView_Style(data_View, column_Widths, column_Text_Align);

        }
        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            refresh_Table();
            PRIS_Seachbox.Clear();
        }
        private void refresh_Callback() 
        {
            refresh_Table();
        }
        private void refresh_Table() 
        {
            DataTable dt = new DataTable();

            using (database_manager)
                dt = database_manager.ExecuteQuery(Database_Query.get_employee_records);

            data_View.DataSource = util.FormatDataTable(dt);
        }

        private void view_RecordBtn_Click(object sender, EventArgs e)
        {
            if(data_View.Rows.Count == 0)
                 return; 

            string record_code = (string)data_View.Rows[data_View.CurrentRow.Index].Cells[1].Value;

            view_Employee = new View_Employee(record_code);
            view_Employee.callback += refresh_Callback;
            view_Employee.ShowDialog();
        }

    }
}
