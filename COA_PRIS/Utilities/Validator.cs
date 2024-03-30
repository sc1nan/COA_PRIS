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

        public List<GunaTextBox> search_Textbox(Control panel) 
        { 
            List<GunaTextBox> guna_TextBoxes = new List<GunaTextBox>();
            Queue<Control> q_control = new Queue<Control>();

            q_control.Enqueue(panel);

            while (q_control.Count > 0)
            { 
                Control control = q_control.Dequeue();

                if (control is GunaTextBox textBox) 
                   guna_TextBoxes.Add(textBox);

                if (control.HasChildren)
                    foreach (Control child_Control in control.Controls)
                        q_control.Enqueue(child_Control);
            }

            return guna_TextBoxes;
        }
        public bool Required_TextBox(Control panel, ErrorProvider error)
        {
            List<GunaTextBox> guna_TextBox = search_Textbox(panel);

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
