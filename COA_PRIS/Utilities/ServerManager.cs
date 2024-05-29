using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS.Utilities
{
    internal class ServerManager
    {
        public static TCPServer Server { get; private set; }
        public static event EventHandler<string> MessageReceived;

        public static async Task InitializeServerAsync(string ipAddressString, int port)
        {
            Server = new TCPServer();
            Server.MessageReceived += Server_MessageReceived;
            await Server.StartServerAsync(ipAddressString, port);
        }

        private static void Server_MessageReceived(object sender, string message)
        {
            MessageReceived?.Invoke(sender, message);
        }

        public static async Task SendMessageToClientsAsync(string message)
        {
            if (Server != null)
            {
                await Server.SendMessageToAllClientsAsync(message);
            }
            else
            {
                Console.WriteLine("Server is not initialized.");
            }
        }

        public static async Task StopServerAsync()
        {
            if (Server != null)
            {
                await Server.StopServerAsync();
            }
            else
            {
                Console.WriteLine("Server is not initialized.");
            }
        }
    }
}
