using COA_PRIS.Utilities;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens
{
    public partial class Trash : Form
    {   
        private Database_Manager Database_Manager = new Database_Manager();
        private Util Util = new Util();

        private string SearchQuery;
        private string Query;
        private string UpdateQuery;

        private (string, DataGridViewContentAlignment)[] ColumnTitle;
        private (bool, int)[] ColumnWidths;

        private bool is_ClosingProgrammatically = false;

        public Trash(string _trashQuery, string _searchQuery, string _updateQuery,
            (string, DataGridViewContentAlignment)[] _column_Title_Alignment,
            (bool, int)[] _column_Widths,
            string title = "Trash")
        {
            InitializeComponent();
            this.Query = _trashQuery;
            this.SearchQuery = _searchQuery;
            this.UpdateQuery = _updateQuery;
            this.selector_Title.Text = title;
            this.ColumnTitle = _column_Title_Alignment;
            this.ColumnWidths = _column_Widths;
        }

        private void Trash_Load(object sender, EventArgs e)
        {
            DataTable ret;

            using(Database_Manager)
                ret = Database_Manager.ExecuteQuery(this.Query);

               
            data_View.DataSource = Util.FormatDataTable(ret);
            Theme.gridView_Style(data_View, this.ColumnWidths, this.ColumnTitle);

            PRIS_Search.DropboxValues = null;
            PRIS_Search.Search_Typed += Search_CallBack;

        }

        private void Search_CallBack(object sender, EventArgs e) 
        {
            DataTable ret;

            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(this.SearchQuery);
            data_View.DataSource = Util.FormatDataTable(ret);


        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            DataTable ret;

            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(this.Query);


            data_View.DataSource = Util.FormatDataTable(ret);
        }

        private void Trash_FormClosing(object sender, FormClosingEventArgs e)
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
            Close();
        }
    }
}
