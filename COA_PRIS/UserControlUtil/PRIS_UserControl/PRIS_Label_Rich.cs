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

namespace COA_PRIS.UserControlUtil.PRIS_UserControl
{
    public partial class PRIS_Label_Rich : UserControl, IPRIS_UserControl
    {
        public bool IsRequiredValue = false;
        private Color CurrentColor;
        public Control ErrorRoot
        {
            get { return entry_Panel; }
        }
        public Control IndicatorRoot
        {
            get { return entry_Panel; }
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
            get { return entry.Text.Trim(); }
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
        public int EntryHeight 
        {
            get { return this.Height; }
            set { this.Height = value;  }
        }

        public PRIS_Label_Rich()
        {
            InitializeComponent();
        }

        public PRIS_Label_Rich(string _title, bool _isRequired = true, int _entryHeight = 150 )
        {
            InitializeComponent();
            this.title.Text = _title;
            this.entry.Tag = _title.Replace(":", "").Trim();
            this.IsRequired = _isRequired;
            this.Height = _entryHeight;
        }

        private void entry_Enter(object sender, EventArgs e)
        {
            CurrentColor = entry_Panel.BaseColor;
            entry_Panel.BaseColor = Color.FromArgb(27, 48, 59);
        }

        private void entry_Leave(object sender, EventArgs e)
        {
            entry_Panel.BaseColor = (CurrentColor == Color.Red) ? Color.Red : Theme.Hex_To_RGB("#d3d3d3");
        }
    }
}
