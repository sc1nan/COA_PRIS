using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace COA_PRIS.Utilities
{
    internal class Tab_Manager
    {
        private Colors Colors;

        private List<Control> Navigation_Buttons = new List<Control>();

        private List<object> Sub_Frames = new List<object>();
        public Control Header_Title { get; set; }

        public List<object> Sub_frames 
        { 
            get { return Sub_Frames; }
            set { Sub_Frames = value; }
        }
        public List<Control> Nav_buttons 
        {
            get { return Navigation_Buttons; }
            set { Navigation_Buttons = value; }
        }
        public void active_Button(GunaButton button, bool has_Title = false, string selected_color = "#365486", string unselected_color = "#1B303B")
        {
            foreach (var buttons in Navigation_Buttons)
            {
                if (buttons.Name.Equals(button.Name))
                {
                    Console.WriteLine(buttons.Name);
                    button.BackColor = Colors.Hex_To_RGB(selected_color);
                    if (has_Title)
                        change_Title(button.Text.ToUpper());
                }
                else
                {
                    buttons.BackColor = Colors.Hex_To_RGB(unselected_color);
                }
            }
        }

        private void change_Title(string title) 
        { 
            Header_Title.Text = title;
        }


        public Form switch_Form(Form form, Form current_Form, GunaPanel main_Panel)
        {

            //This function is repsonsible for switching forms.
            //form = the form to be displayed.
            //current_form = the currently displayed form.
            //main_Panel = is the panel on which the form should be attached.

            
            //If form is not active, hide the inactive form to allow current form to show.
            if (current_Form != null && current_Form != form)
                current_Form.Hide();

            //Allow the from to fill the main panel.
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;


            //Add the form to the main panel if the form does not a children of the main panel.
            if (!main_Panel.Controls.Contains(form))
                main_Panel.Controls.Add(form);

            //Show the form and set the current form. 
            form.Show();
            return form;


        }
    }
}
