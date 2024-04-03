using COA_PRIS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.UserControlUtil
{
    public partial class Label_Drop : UserControl
    {
        private Database_Manager database_Manager;
        public override string Text { get; set; }
        private string Title { get; set; }
        private string Option_Query { get; set; }

        public Label_Drop(string _title, string option_Query)
        {
            InitializeComponent();
            this.Title = _title;
            this.Option_Query = option_Query;
        }

        private void Label_Drop_Load(object sender, EventArgs e)
        {
            this.title.Text = Title;
            Set_Option(Option_Query);
        }

        private void Set_Option(string query) 
        {
            database_Manager = new Database_Manager();
            DataTable ret = new DataTable();
            Dictionary<string, string> option_Pairs = new Dictionary<string, string>();


            using (database_Manager) 
            { 
                ret = database_Manager.ExecuteQuery(query);
            }

            if (ret != null) 
            {
                foreach (DataRow row in ret.Rows)
                {
                    string key = row[0].ToString();
                    string value = row[1].ToString();

                    option_Pairs[key] = value;
                }

                dropbox.DisplayMember = "value";
                dropbox.ValueMember = "key"; 
                dropbox.DataSource = new BindingSource(option_Pairs, null);
            }

        }
        private void dropbox_TextChanged(object sender, EventArgs e)
        {
            this.Text = (string)dropbox.SelectedValue;
        }
    }
}
