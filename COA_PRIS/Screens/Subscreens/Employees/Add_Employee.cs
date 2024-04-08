using COA_PRIS.UserControlUtil;
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
using System.Windows.Markup;

namespace COA_PRIS.Screens.Subscreens.Employees
{
    public partial class Add_Employee : Form
    {
        private Validator validator;
        private Database_Manager database_manager;
        private Util util = new Util();
        private bool is_ClosingProgrammatically = false;
        public Add_Employee()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void Add_Record_Load(object sender, EventArgs e)
        {
            this.emp_id.Text = util.generate_ID("emp_info_table");
        }

        private void InitializeControls() 
        {
            var controls = new List<UserControl[]> {
                // First Columns
                new UserControl[] {
                new Label_Text("Full Name :"),
                new Label_Text("Email :"),
                new Label_Text("Contact Number :") 
                },
                //Second Columns
                new UserControl[] {
                new Label_Drop("Sector :", Database_Query.get_sector_options, true),
                new Label_Drop("Office :", Database_Query.get_office_options, false),
                new Label_Drop("Division :", Database_Query.get_division_options, false),
                new Label_Drop("Section :", Database_Query.get_section_option,false),
                new Label_Drop("Position :", Database_Query.get_position_options, false),
                }
            };

            for (int i = 0; i < controls.Count; i++) 
            {
                control_Panel.Controls.Add(new FlowLayoutPanel());
                control_Panel.Controls[i].Size = new Size(control_Panel.Width/2, control_Panel.Height);
                control_Panel.Controls[i].Margin = Padding.Empty;

                for (int j = 0; j < controls[i].Length; j++)
                {
                    control_Panel.Controls[i].Controls.Add(controls[i][j]);
                    if (control_Panel.Controls[i].Controls[j] is Label_Drop) 
                    {
                        Label_Drop label_Drop = (Label_Drop)control_Panel.Controls[i].Controls[j];
                        label_Drop.DropboxChanged += label_Drop_Callback;

                    }   
                }
            }
        }

        private void label_Drop_Callback(object sender, EventArgs e) 
        {
            Label_Drop current_Dropbox = (Label_Drop)sender;
            Label_Drop next_Dropbox = null;
            var panel = control_Panel.Controls[1];
            int num = 0;

            switch (current_Dropbox.Title)
            {
                case "Sector":
                    num = 1;
                    next_Dropbox = (Label_Drop)panel.Controls[num];
                    next_Dropbox.Option_Query = string.Format(Database_Query.get_office_options_by_id, current_Dropbox.Text);
                    break;
                case "Office":
                    num = 2;
                    next_Dropbox = (Label_Drop)panel.Controls[num];
                    next_Dropbox.Option_Query = string.Format(Database_Query.get_division_options_by_id, current_Dropbox.Text);
                    break;
                case "Division":
                    num = 3;
                    next_Dropbox = (Label_Drop)panel.Controls[num];
                    next_Dropbox.Option_Query = string.Format(Database_Query.get_section_options_by_id, current_Dropbox.Text);
                    break;
                case "Section":
                    num = 4;
                    next_Dropbox = (Label_Drop)panel.Controls[num];
                    break;

            }

            if (!string.Equals(current_Dropbox.Text, "null") && next_Dropbox != null)
            {
                next_Dropbox.Enabled_Dropbox = true;
            }
            else if (next_Dropbox != null)
            {
                for (int i = num; i < panel.Controls.Count; i++)
                {
                    Label_Drop _dropbox = (Label_Drop)panel.Controls[i];
                    _dropbox.Enabled_Dropbox = false;
                }
            }
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(emp_id.Text);

            var entries = new List<List<string>>();

            for (int i = 0; i < control_Panel.Controls.Count; i++) 
            {
                var values = new List<string>();
                //Console.WriteLine(control_Panel.Controls[i]);
                for (int j = 0; j < control_Panel.Controls[i].Controls.Count; j++) 
                {
                    //Console.WriteLine(control_Panel.Controls[i].Controls[j]);
                    values.Add(control_Panel.Controls[i].Controls[j].Text);
                }
                entries.Add(values);
            }

            foreach (List<string> value in entries) 
            {
                foreach (string text in value) 
                { 
                    Console.WriteLine($"{text}");
                    
                }
                Console.WriteLine();
            }
            
        }

        private void Add_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;

                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }
    }
}
