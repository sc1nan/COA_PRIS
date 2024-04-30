using COA_PRIS.Utilities;
using Guna.UI.WinForms;
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
    public partial class Selector : Form
    {
        private Database_Manager database_manager = new Database_Manager();
        private Util util = new Util();
        private (string, DataGridViewContentAlignment)[] ColumnsTitlesAlignment { get; set; }
        private (bool, int)[] ColumnWidths { get; set; }
        private string SelectorQuery { get; set; }

        private PRIS_Label_Selector Label_Selector;

        private bool is_ClosingProgrammatically = false;

        public string InfoText 
        {
            get { return info_Label.Text; }
            set { info_Label.Text = value; }

        }

        public Selector(object _sender, string _title, string _query, (string, DataGridViewContentAlignment)[] _column_Title_Alignment,
            (bool, int)[] _column_Widths)
        {
            InitializeComponent();


            var button = (GunaButton)_sender;
            Label_Selector = (PRIS_Label_Selector)button.Parent.Parent;

            this.selector_Title.Text = _title.ToUpper();
            this.SelectorQuery = _query;
            this.ColumnsTitlesAlignment = _column_Title_Alignment;
            this.ColumnWidths = _column_Widths;
            Set_Selections();

        }

        private void Selector_Load(object sender, EventArgs e)
        {
            
        }
        private void Set_Selections() 
        {
            DataTable data_Table = new DataTable();

            using (database_manager)
                data_Table = database_manager.ExecuteQuery(SelectorQuery);

            data_View.DataSource = null;
            data_View.Rows.Clear();
            data_View.DataSource = util.FormatDataTable(data_Table);


            Theme.gridView_Style(data_View, this.ColumnWidths, this.ColumnsTitlesAlignment);
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void Selector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;

                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            is_ClosingProgrammatically = false;
            this.Close();
        }

        private void data_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetData();
        }
        private void GetData() 
        {
            int currentIndex = data_View.CurrentRow?.Index ?? -1;

            if (currentIndex >= 0)
            {
                string key = data_View.Rows[currentIndex].Cells[1].Value?.ToString();
                string value = data_View.Rows[currentIndex].Cells[2].Value?.ToString();

                if (key != null && value != null)
                {
                    var ret = new Dictionary<string, string> { { key, value } };
                    Label_Selector.ReturnValues = ret;
                }
            }
            is_ClosingProgrammatically = true;
            this.Close();
        }
    }
}
