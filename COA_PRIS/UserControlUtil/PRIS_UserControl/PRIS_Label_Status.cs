using COA_PRIS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.UserControlUtil.PRIS_UserControl
{
    public partial class PRIS_Label_Status : UserControl, IPRIS_UserControl
    {
        public bool IsRequiredValue = false;
        public Control ErrorRoot
        {
            get { return entry; }
        }
        public Control IndicatorRoot
        {
            get { return entry; }
        }
        public bool IsRequired
        {
            get { return IsRequiredValue; }
            set { IsRequiredValue = value; }
        }
        public string Title
        {
            get { return title.Text.Replace(":", " ").Trim(); }
            set { title.Text = value; }
        }

        public string Value
        {
            get { return entry.SelectedValue.ToString(); }
            set { entry.SelectedIndex = entry.FindStringExact(value); }
        }

        public bool ReadOnly
        {
            get { return entry.Enabled; }
            set { entry.Enabled = !value;}
        }

        public DataTable DropdownOptions 
        { 
            get{ return (DataTable)entry.DataSource; }
            set
            { 
                entry.DisplayMember = "title";
                entry.ValueMember = "code";
                entry.DataSource = value;
            }
        }

        public PRIS_Label_Status()
        {
            InitializeComponent();
        }


        public PRIS_Label_Status(string _title, DataTable _options, string _value, bool _readOnly , bool _icons = true)
        {
            InitializeComponent();
            this.title.Text = _title;
            this.DropdownOptions = _options;
            this.icon.Visible = _icons;
            this.Value = _value;
            this.ReadOnly = _readOnly;
            
        }

        private void entry_TextChanged(object sender, EventArgs e)
        {
            if (icon.Enabled || icon.Visible) 
            {
                switch (entry.Text) 
                {
                    case "Active":
                        icon.Image = Resources.active;
                        break;
                    case "Pending":
                        icon.Image = Resources.pending;
                        break;
                    case "Filed":
                        icon.Image = Resources.filed;
                        break;

                }
            }
        }
    }
}
