using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.Utilities;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace COA_PRIS.Screens
{
    public partial class SetUp : Form
    {
        private Util Util = new Util();
        private Validator Validator = new Validator();
        private string Type;
        public SetUp(string _type)
        {
            InitializeComponent();
            Type = _type;
            Util.SetControls(PRIS_Contols(), control_Panel);
        }

        private List<UserControl[]> PRIS_Contols() 
        {
            List<UserControl[]> controls = new List<UserControl[]>() 
            { 
                new UserControl[]
                { 
                    new PRIS_Label_Entry(_title:"Server's IP Address :", _isRequired:true),
                    new PRIS_Label_Entry(_title:"Server's Port :", _isRequired:true),

                    new PRIS_Label_Entry(_title:"Username :", _isRequired:true),
                    new PRIS_Label_Entry(_title:"Password :", _isRequired:true,_isPassword: true),
                }
            
            };
            return controls;    
        }

        private void add_RecordBtn_Click(object sender, EventArgs e)
        {
            if(!Validator.PRISRequired(parent_Panel, errorProvider1))
                return;

            var controls  = Util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(IPRIS_UserControl) });
            Dictionary<string, string> values = new Dictionary<string, string>();


            foreach (PRIS_Label_Entry control in controls) 
                values.Add(control.Title, control.Value);


            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NetworkConfig.json");

            ConnectionInfo connectionInfo = Util.ReadJsonFile(filePath);

            if (connectionInfo != null)
            {
                connectionInfo.IPAddress = values["Server's IP Address"]; 
                connectionInfo.Port = Convert.ToInt32(values["Server's Port"]);               
                connectionInfo.Username = values["Username"] ;      
                connectionInfo.Password = values["Password"];

                Util.WriteJsonFile(filePath, connectionInfo);
            }




            MessageBox.Show("Setup is done and successfull.", "PRIS Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();


            //Task.Run(() => StartClient(connectionInfo.IPAddress, connectionInfo.Port)); //Client Side
            Task.Run(() => StartServer(connectionInfo.IPAddress, connectionInfo.Port)); //Server Side
            if (string.Equals(Type, "initial")) 
            {
                Login Login = new Login();
                Login.ShowDialog();
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

    }
}
