using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
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

namespace COA_PRIS.Screens
{
    public partial class Audit_Trail : Form
    {

        private string Record_ID { get; set; }
        private string Table { get; set; }
        private Database_Manager database_Manager;
        
        public Audit_Trail(string record_ID, string table)
        {
            InitializeComponent();
            this.Record_ID = record_ID;
            this.Table = table;
        }

        private void Audit_Trail_Load(object sender, EventArgs e)
        {
            string[] title = new string[] { "Created By :", "Created Date :", "Updated By :", "Updated Date :" };
            database_Manager = new Database_Manager();

            DataTable ret = new DataTable();
            
            using (database_Manager)
            {
                ret = database_Manager.ExecuteQuery(string.Format(Database_Query.get_audit_trail_by_id, this.Table, this.Record_ID));
            }

            if (content_Panel.Controls.Count == ret.Columns.Count)
            {
                for (int index = 0; index < content_Panel.Controls.Count; index++)
                {
                    PRIS_Label_Entry label_Entry = (PRIS_Label_Entry)content_Panel.Controls[index];
                    label_Entry.Title = title[index];
                    label_Entry.Value = ret.Rows[0][index].ToString();
                    label_Entry.ReadonlyText = true;
                }
            }
        }
    }
}
