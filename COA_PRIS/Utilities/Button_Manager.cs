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
    internal class Button_Manager
    {

        private List<Control> SideBar_Buttons = new List<Control>();
        public Control Header_Title { get; set; }

        public List<Control> SideBar 
        {
            get { return SideBar_Buttons; }
            set { SideBar_Buttons = value; }
        }

        public void active_Button(GunaButton gunaButton) 
        {
            foreach (var side_bar in SideBar_Buttons)
            {
                if (side_bar.Name.Equals(gunaButton.Name)) 
                {
                    //54, 84, 134
                    gunaButton.BackColor = Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
                    change_Title(gunaButton.Text.ToUpper());
                }
                else
                {
                    side_bar.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
                }
            }
        }

        private void change_Title(string title) 
        { 
            Header_Title.Text = title;
        }

       


    }
}
