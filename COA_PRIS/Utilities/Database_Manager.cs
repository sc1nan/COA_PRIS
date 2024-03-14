using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace COA_PRIS.Utilities
{
    public class Database_Manager : IDisposable
    {
        private MySqlConnection connection;
        private bool conn;
        public Database_Manager() 
        { 
            Connect();
        }
        private void Connect() 
        {
            if (connection == null)
            {
                var conn = DBConnection.Instance().IsConnect();
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
                    Console.WriteLine($"Error executing nonquery command: {ex.Message}");
                }
            }

            return rowsAffected;
        }
        public void Dispose() 
        { 
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}
