using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COA_PRIS.Utilities;
using MySql.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.IO;

namespace COA_PRIS
{
    internal class DBConnection 
    {
        private DBConnection() { }

        public MySqlConnection Connection { get; private set; }

        private static DBConnection _instance = null;

        public static DBConnection Instance() 
        { 
            if(_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect() 
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NetworkConfig.json");

            ConnectionInfo connectionInfo = ReadJsonFile(filePath);

            if (Connection == null)
            {
                if (String.IsNullOrEmpty(Database_Credentials.database) && connectionInfo != null)
                    return false;
                string connection = string.Format("Server={0}; database={1}; UID={2}; password={3}",

                    //connectionInfo.IPAddress,  //Client Side
                    Database_Credentials.server, //Server Side
                    Database_Credentials.database, 
                    connectionInfo.Username, 
                    connectionInfo.Password);

                Connection = new MySqlConnection(connection);
                Connection.Open();
            }
            return true;    
        }

        static ConnectionInfo ReadJsonFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<ConnectionInfo>(jsonString);
            }
            else
            {
                Console.WriteLine($"File '{filePath}' not found.");
                return null;
            }
        }
    }
}
