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
        public string Title
        {
            get { return title.Text; }
            set { title.Text = value; }
        }

        public string Value
        {
            get { return entry.Text; }
            set { entry.Text = value; }
        }

        public bool EnabledText
        {
            get { return entry.Enabled; }
            set { entry.Enabled = value; }
        }
        public bool ReadonlyText
        {
            get { return entry.ReadOnly; }
            set { entry.ReadOnly = value; }
        }

        public PRIS_Label_Rich()
        {
            InitializeComponent();
        }

        public PRIS_Label_Rich(string _title, DockStyle _dock)
        {
            InitializeComponent();
            //this.Dock = _dock;
            this.title.Text = _title;
            this.entry.Tag = _title.Replace(":", "").Trim();

        }

    }
}
