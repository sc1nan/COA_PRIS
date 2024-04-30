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
    public partial class PRIS_Label_Entry : UserControl, IPRIS_UserControl
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
            get { return entry.Text; }
            set { entry.Text = value; }
        }

        public bool ReadOnly
        {
            get { return entry.ReadOnly; }
            set { entry.ReadOnly = value; }
        }
        public bool EnabledText 
        {
            get { return entry.Enabled; }
            set { entry.Enabled = value; }
        }
        public PRIS_Label_Entry()
        {
            InitializeComponent();
        }

        public PRIS_Label_Entry(string _title, bool _isRequired = true, bool _isReadOnly = false) 
        {
            InitializeComponent();
            this.title.Text = _title;
            this.entry.Tag = _title.Replace(":","").Trim();
            this.IsRequired = _isRequired;
            this.ReadOnly = _isReadOnly;
            
            
        }
    }
}
