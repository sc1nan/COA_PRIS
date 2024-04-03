using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COA_PRIS.UserControlUtil;
using COA_PRIS.Utilities;
using COA_PRIS.Screens;

namespace COA_PRIS.Screens.Subscreens.Maintenance
{
    public partial class Add_Record : Form
    {
        private Database_Manager database_Manager;

        private Util util;
        private Validator validator;
        private string Insert_Query { get; set; }
        private string Table { get; set; }

        public delegate void callback_Function();
        public event callback_Function callback;

        public Add_Record( UserControl[] controls,string insert_Query, string table)
        {
            InitializeComponent();
            initialize_Controls(controls);

            this.Insert_Query = insert_Query;
            this.Table = table;
        }

        private void Add_Agency_Load(object sender, EventArgs e)
        {
            database_Manager = new Database_Manager();
            validator = new Validator();
            util = new Util();
            code_Title.Text = util.generate_ID(this.Table);

        }

        private void initialize_Controls(UserControl[] controls) 
        {
            for (int i = 0; i < controls.Length; i++)
            {
                control_Panel.Controls.Add(controls[i]);
                control_Panel.Controls[i].Size = new Size(control_Panel.Size.Width - 8, control_Panel.Controls[i].Size.Height);
            }

        }

        private void save_Btn_Click(object sender, EventArgs e)
        {

            if (validator.Required_TextBox(control_Panel, error_provider))
            {
                List<List<string>> entries = new List<List<string>>();

                List<string> values = new List<string>();       
                values.Add(code_Title.Text);

                foreach (Control control in control_Panel.Controls)
                {
                    if (control.Text == null)
                        values.Add((string)null);
                    else
                        values.Add(control.Text.Trim());
                }
                values.Add("james");
                entries.Add(values);


                using (database_Manager)
                {
                    database_Manager.ExecuteNonQuery(util.generate_Query(entries, Insert_Query));
                }

                //Console.WriteLine(util.generate_Query(entries, Insert_Query));
                //MessageBox.Show(util.generate_Query(entries, Insert_Query));
                
                this.Dispose();
            }
            
            callback?.Invoke();
        }
    }
}
