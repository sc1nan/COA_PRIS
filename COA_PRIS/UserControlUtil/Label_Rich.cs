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
    public partial class Label_Rich : UserControl
    {
        public override string Text {get; set;}
        private string Title { get; set; }
        public Label_Rich(string _title)
        {
            InitializeComponent();
            this.Title = _title;
        }

        private void Label_Rich_Load(object sender, EventArgs e)
        {
            this.title.Text = this.Title;
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            this.Text = richText.Text;

            if (this.Text.Length == richText.MaxLength) 
            {
                label_rich_error.SetError(richText, "Maximum characters reached.");
                richText.BorderColor = Color.Red;
            }
        }
    }
}
