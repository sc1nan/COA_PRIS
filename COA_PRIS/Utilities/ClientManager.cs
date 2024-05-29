using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS.Utilities
{
    internal class ClientManager
    {
        public static event EventHandler<string> MessageReceived
        {
            add { TCPClient.MessageReceived += value; }
            remove { TCPClient.MessageReceived -= value; }
        }

        public static async Task InitializeAsync(string ipAddressString, int port)
        {
            await TCPClient.ConnectAsync(ipAddressString, port);
        }

        public static async Task SendMessageAsync(string message)
        {
            await TCPClient.SendAsync(message);
        }

        public static void DisconnectAsync()
        {
            TCPClient.Disconnect();
        }
    }
}
