using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.UserControlUtil.PRIS_UserControl
{
    public partial class PRIS_Label_MainCheckBox : UserControl, IPRIS_UserControl
    {
        public bool IsRequiredValue = false;
        public bool HasBoxes = false;
        private bool _isExpanded = false;
        private (string, bool, bool)[] _Boxes = null;
        

        public Control ErrorRoot
        {
            get { return title; }
        }
        public Control IndicatorRoot
        {
            get { return container_Panel; }
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
            get { return check.Checked ? "1" : "0"; }
            set 
            {
                if (ReadOnly)
                {
                    if (value == null)
                        check.Checked = false;
                    else
                        check.Checked = string.Equals(value, "1") ? true : false;
                    
                }
            }
        }

        public bool ReadOnly
        {
            get { return check.Enabled; }
            set { check.Enabled = !value; }
        }
        public bool Expand
        {
            get { return _isExpanded; }
            set { ExpandBox(value); }
        }

        public (string, bool, bool)[] Boxes
        {
            get { return _Boxes; }
            set 
            { 
                _Boxes = value;
                HasBoxes =  value != null ? true: false;
            }
        }
        public List<bool> BoxValues  
        {
            get 
            {
                if (_Boxes != null && bottom_Panel.Controls.Count != 0)
                {
                    List<bool> result = new List<bool>();
                    for (int boxIndex = 0; boxIndex < _Boxes.Length; boxIndex++)
                        result.Add(((PRIS_Label_CheckBox)bottom_Panel.Controls[boxIndex]).Value);
                    return result;
                }
                else 
                    return null;
            }
            set 
            {
                if (_Boxes != null && bottom_Panel.Controls.Count != 0)
                    for (int boxIndex = 0; boxIndex < _Boxes.Length; boxIndex++)
                        ((PRIS_Label_CheckBox)bottom_Panel.Controls[boxIndex]).Value = value[boxIndex]; 
            }
        }

        public List<string> BoxTitle
        {
            get 
            {
                List<string> val = new List<string>();
                for (int boxIndex = 0; boxIndex < _Boxes.Length; boxIndex++) 
                {
                    val.Add(Boxes[boxIndex].Item1);
                }
                return val;
            }
        }

        public PRIS_Label_MainCheckBox()
        {
            InitializeComponent();
        }

        public PRIS_Label_MainCheckBox(string _title, (string, bool, bool)[] _boxes = null, bool _isExpanded = false, bool _isChecked = false,
            bool _isReadOnly = false)
        {
            InitializeComponent();
            this.Title = _title;
            this.Expand = _isExpanded;
            this.Boxes = _boxes;
            this.check.Checked = _isChecked;
            this.ReadOnly = _isReadOnly;
        }

        private void ExpandBox(bool _value)
        {
            _isExpanded = _value;

            if (_Boxes != null) 
            { 
                bottom_Panel.Enabled = _value;
                bottom_Panel.Visible = _value;
            }
        }


        private void PRIS_Label_RoleCheckBox_Load(object sender, EventArgs e)
        {
            if (_Boxes != null && _Boxes.Length != 0) 
                for (int i = 0; i < _Boxes.Length; i++)
                    bottom_Panel.Controls.Add(new PRIS_Label_CheckBox(_title: _Boxes[i].Item1, _checked: _Boxes[i].Item2, _enabled: _Boxes[i].Item3));
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            this.Expand = check.Checked;
            if (_Boxes != null && bottom_Panel.Controls.Count != 0 && !check.Checked) 
                foreach (PRIS_Label_CheckBox checkBox in bottom_Panel.Controls) 
                    checkBox.Value = check.Checked;
        }

        private void PRIS_Label_MainCheckBox_SizeChanged(object sender, EventArgs e)
        {
            if (this.Dock == DockStyle.Top) 
            {
                var width =this.Size.Width - 2 * (top_Panel.Margin.Right + content_Panel.Margin.Right + container_Panel.Margin.Right);

                this.top_Panel.Width = width;
                this.bottom_Panel.Width = width;
                this.bottom_Panel.MaximumSize = new Size(width,0);
            }
        }

        private void title_Click(object sender, EventArgs e)
        {
            this.check.Checked = !this.check.Checked;
        }

    }
}
