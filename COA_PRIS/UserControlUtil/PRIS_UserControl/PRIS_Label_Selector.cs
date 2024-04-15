using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace COA_PRIS.UserControlUtil
{
    public partial class PRIS_Label_Selector : UserControl, IPRIS_UserControl
    {
        private Dictionary<string, string> valuePairs = new Dictionary<string, string>();
        private Database_Manager database_Manager = new Database_Manager();
        private Selector selector;


        public string Title
        {
            get { return title.Text.Replace(":", " ").Trim(); }
            set { title.Text = value; }
        }

        public string Value
        {
            get { return ReturnValues.FirstOrDefault(x => x.Value == entry.Text).Key;}
            set { entry.Text = value; }
        }

        public Dictionary<string, string> ReturnValues 
        {
            get { return valuePairs; }
            set { valuePairs = value; Value = value[valuePairs.Keys.Single()];} 
        }

        private string SelectorQuery { get; set; }
        private (string, DataGridViewContentAlignment)[] ColumnsTitlesAlignment { get; set; }
        private (bool, int)[] ColumnWidths { get; set; }

        public PRIS_Label_Selector()
        {
            InitializeComponent();
        }

        public PRIS_Label_Selector(string _title, string _query, DockStyle _dock, 
            (string, DataGridViewContentAlignment)[] _column_Title_Alignment,
            (bool, int)[] _column_Widths
            )
        {
            InitializeComponent();
            this.Title = _title;
            this.entry.Tag = $"!req_{this.Title}";
            this.SelectorQuery = _query;
            //this.Dock = _dock;
            this.ColumnsTitlesAlignment = _column_Title_Alignment;
            this.ColumnWidths = _column_Widths;
            SetSelection();
        }

        private void SetSelection() 
        {
            DataTable ret;
            using (database_Manager)
               ret = database_Manager.ExecuteQuery(this.SelectorQuery);

            foreach (DataRow row in ret.Rows) 
                ReturnValues.Add((string)row[0], (string)row[1]);
        
        }


        private void search_Click(object sender, EventArgs e)
        {
            selector = new Selector(sender, this.Title, this.SelectorQuery, this.ColumnsTitlesAlignment, this.ColumnWidths);
            selector.ShowDialog();
        }
    }
}
