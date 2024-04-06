using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COA_PRIS.UserControlUtil
{
    public partial class Label_Drop : UserControl
    {
        private readonly Database_Manager database_Manager = new Database_Manager();

        // Properties
        public override string Text 
        {
            get { return (string)dropbox.SelectedValue; }
            set { dropbox.SelectedValue = value; }
        }

        public bool ReadOnly { get; set; }

        private string Option_Query { get; set; }

        public Label_Drop(string _title, string option_Query)
        {
            InitializeComponent();
            this.title.Text = _title;
            this.Option_Query = option_Query;
            SetOption(Option_Query);
        }

        private void SetOption(string query)
        {
            DataTable ret;

            using (database_Manager)
            {
                ret = database_Manager.ExecuteQuery(query);
            }

            if (ret != null)
            {
                var optionPairs = GetOptionPairs(ret);

                optionPairs.Insert(0, new KeyValuePair<string, string>("0", $"Select {this.title.Text.Replace(":", "")}"));

                dropbox.DisplayMember = "value";
                dropbox.ValueMember = "key";
                dropbox.DataSource = new BindingSource(optionPairs, null);
            }
        }

        private List<KeyValuePair<string, string>> GetOptionPairs(DataTable dataTable)
        {
            var optionPairs = new List<KeyValuePair<string, string>>();

            foreach (DataRow row in dataTable.Rows)
            {
                string key = row[0].ToString();
                string value = row[1].ToString();
                optionPairs.Add(new KeyValuePair<string, string>(key, value));
            }

            return optionPairs;
        }

        private void dropbox_TextChanged(object sender, EventArgs e)
        {
            this.Text = (string)dropbox.SelectedValue;
            Console.WriteLine(dropbox.SelectedValue);
        }
    }
}
