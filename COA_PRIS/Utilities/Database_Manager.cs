using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COA_PRIS.CrystalReports;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace COA_PRIS.Utilities
{
    internal class Database_Manager : IDisposable
    {
        private MySqlConnection Connection;
        public Database_Manager() 
        { 
            Connect();
        }
        private void Connect() 
        {
            if (Connection == null)
            {
                DBConnection.Instance().IsConnect();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            var dbCon = DBConnection.Instance();
            DataTable dataTable = new DataTable();

            using (MySqlCommand command = new MySqlCommand(query, dbCon.Connection))
            {
                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing query: {ex.Message}");
                }
            }

            return dataTable;
        }

        public DataTable ExecuteQueryXD(string query)
        {
            var dbCon = DBConnection.Instance();
            DataTable dataTable = new DataTable();

            using (MySqlCommand command = new MySqlCommand(query, dbCon.Connection))
            {
                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing query: {ex.Message}");
                }
            }

            return dataTable;
        }

        public int ExecuteNonQuery(string query)
        {
            var dbCon = DBConnection.Instance();
            int rowsAffected = 0;

            using (MySqlCommand command = new MySqlCommand(query, dbCon.Connection))
            {
                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing nonquery command: {ex.Message}", "Error");
                    Console.WriteLine();
                }
            }

            return rowsAffected;
        }

        public object ExecuteScalar(string query) 
        {
            var dbCon = DBConnection.Instance();
            object ret = null;

            using (MySqlCommand command = new MySqlCommand(query, dbCon.Connection))
            {
                try
                {
                    ret = command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing scalar command: {ex.Message}");
                }
            }

            return ret;
        }
        public void Dispose() 
        { 
            if (Connection != null)
            {
                Connection.Close();
                Connection.Dispose();
                Connection = null;
            }
        }
    }
}
