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
    public partial class PRIS_Label_DropBox : UserControl, IPRIS_UserControl
    {
        public bool IsRequiredValue = false;

        public bool IsVisible
        {
            get { return this.Visible; }
            set { this.Visible = value; }
        }
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
            get { return entry.Text; }
            set { entry.Text = value; }
        }

        public bool ReadOnly
        {
            get { return entry.Enabled; }
            set { entry.Enabled = value; }
        }

        public List<string> DropboxValues
        {
            set { entry.DataSource = value; }
        }

        public PRIS_Label_DropBox()
        {
            InitializeComponent();
        }

        public PRIS_Label_DropBox(string _title, List<string> _dropboxValues, bool _isRequired = true)
        {
            InitializeComponent();
            this.Title = _title;
            this.IsRequired = _isRequired;
            this.DropboxValues = _dropboxValues;
        }

    }
}
