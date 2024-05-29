using COA_PRIS.Screens;
using COA_PRIS.Utilities;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace COA_PRIS
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NetworkConfig.json");
            ConnectionInfo connectionInfo = ReadJsonFile(filePath);


            if (connectionInfo != null)
            {
                if (string.IsNullOrEmpty(connectionInfo.IPAddress) ||
                    string.IsNullOrEmpty(connectionInfo.Username) ||
                    string.IsNullOrEmpty(connectionInfo.Password))
                {
                    Application.Run(new SetUp("initial"));

                }
                else
                {
                    //Task.Run(() => StartClient(connectionInfo.IPAddress, connectionInfo.Port)); //Client Side
                    Task.Run(() => StartServer(connectionInfo.IPAddress, connectionInfo.Port)); //Server Side
                    Application.Run(new Login());
                }
            }
            else 
            {
                MessageBox.Show("Error in setup. Contact developers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static async Task StartClient(string ip, int port) 
        {
            await ClientManager.InitializeAsync(ip, port);
        }

        static async Task StartServer(string ip, int port)
        {
            await ServerManager.InitializeServerAsync(ip, port);
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
