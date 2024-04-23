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
    public partial class PRIS_Date_Picker : UserControl, IPRIS_UserControl
    {
        public bool IsRequiredValue = false;
        public Control ErrorRoot
        {
            get { return date; }
        }
        public Control IndicatorRoot
        {
            get { return date; }
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
        public bool ReadOnly
        {
            get { return date.Enabled; }
            set { date.Enabled = value; }
        }

        public string Value
        {
            get { return date.Value.ToString("yyyy-MM-dd HH:mm:ss"); }
            set { date.Value = DateTime.Parse(value); }
        }
        public PRIS_Date_Picker()
        {
            InitializeComponent();
            date.Value = DateTime.Today;
        }

        public PRIS_Date_Picker(string _title, bool _isRequired = true)
        {
            InitializeComponent();
            date.Value = DateTime.Today;
            this.title.Text = _title;
            this.IsRequired = _isRequired;
        }

    }
}
