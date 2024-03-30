using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COA_PRIS.Utilities
{
    internal class Validator
    {

        public Validator()
        {
        }

        public List<control> search_Control<control>(Control parent) where control : Control
        { 
            List<control> ret_Controls = new List<control>();
            Queue<Control> q_control = new Queue<Control>();

            q_control.Enqueue(parent);

            while (q_control.Count > 0)
            { 
                Control con = q_control.Dequeue();

                if (con is control _con) 
                   ret_Controls.Add(_con);

                if (con.HasChildren)
                    foreach (Control child_Control in con.Controls)
                        q_control.Enqueue(child_Control);
            }

            return ret_Controls;
        }
        public bool Required_TextBox(Control parent, ErrorProvider error)
        {
            List<GunaTextBox> guna_TextBox = search_Control<GunaTextBox>(parent);

            bool is_Required = true; 

            foreach (GunaTextBox text_Box in guna_TextBox) 
            {
                if (string.IsNullOrWhiteSpace(text_Box.Text))
                {
                    error.SetError(text_Box, $"{text_Box.Tag} is required.");
                    text_Box.BorderColor = Color.Red;
                    is_Required = false;
                }
                else
                {
                    text_Box.BorderColor = Color.Empty; 
                }
            }
            return is_Required;
        }
    }
}
