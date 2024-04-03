using Org.BouncyCastle.Crypto.Prng;
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
    public partial class Label_Text : UserControl
    {
        public override string Text {get; set;}
        private string Title { get; set; }
        public Label_Text(string _title)
        {
            InitializeComponent();
            this.Title = _title;
        }

        private void Label_Text_Load(object sender, EventArgs e)
        {
            this.title.Text = this.Title;
        }

        private void entry_TextChanged(object sender, EventArgs e)
        {
            this.Text = entry.Text;
            if (this.Text.Length == entry.MaxLength) 
            {
                label_Text_Error.SetError(entry, "Maximum characters reached.");
                entry.BorderColor = Color.Red;
            }
        }
    }
}
