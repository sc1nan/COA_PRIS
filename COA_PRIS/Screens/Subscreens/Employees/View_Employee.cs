using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.Utilities;
using Google.Protobuf.WellKnownTypes;
using Guna.UI.WinForms;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Type = System.Type;

namespace COA_PRIS.Screens.Subscreens.Employees
{
    public partial class View_Employee : Form
    {
        private Database_Manager database_manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();

        private Audit_Trail audit_Trail;

        private bool is_ClosingProgrammatically = false;
        private List<Control> controls;
        private List<PRIS_Label_Selector> selectors;
        public event Action callback;
        private string Record_ID
        {
            get { return emp_id.Text; }
            set { emp_id.Text = value;}
        }
        public View_Employee(string record_ID)
        {
            InitializeComponent();
            Record_ID = record_ID;
            InitializeControls();
            SetValues();
        }



        /*        private void InitializeControls()
                {
                    var controls = new List<UserControl[]>
                    {
                        new UserControl[]
                        {
                            new Label_Text("Full Name :"),
                            new Label_Text("Email :"),
                            new Label_Text("Contact Number :")
                        },
                        new UserControl[]
                        {
                            new Label_Drop("Sector :", Database_Query.get_sector_options, false),
                            new Label_Drop("Office :", Database_Query.get_office_options, false),
                            new Label_Drop("Division :", Database_Query.get_division_options, false),
                            new Label_Drop("Section :", Database_Query.get_section_option, false),
                            new Label_Drop("Position :", Database_Query.get_position_options, false)
                        }
                    };

                    for (int i = 0; i < controls.Count; i++)
                    {
                        var panel = new FlowLayoutPanel
                        {
                            Size = new Size(control_Panel.Width / 2, control_Panel.Height),
                            Margin = Padding.Empty
                        };

                        control_Panel.Controls.Add(panel);

                        foreach (var control in controls[i])
                        {
                            panel.Controls.Add(control);
                            control.Width = panel.Width;

                            if (control is Label_Drop labelDrop)
                            { 
                                //labelDrop.DropboxChanged += label_Drop_Callback; 
                                //labelDrop.Enabled_Dropbox = false;
                            }
                        }
                    }
                }*/

        private void InitializeControls() 
        {
            util.SetControls(PRISControls(), control_Panel);
            
            controls = util.SearchControls<Control>(control_Panel, new List<Type> { typeof(PRIS_Label_Selector), typeof(PRIS_Label_Entry) });
            selectors = util.SearchControls<PRIS_Label_Selector>(control_Panel, new List<Type> { typeof(PRIS_Label_Selector) });
        }

        private void SetValues() 
        {
            DataTable ret;

            using (database_manager)
                ret = database_manager.ExecuteQuery(string.Format(Database_Query.get_employee_record_by_id, this.Record_ID));

            if (ret.Columns.Count == controls.Count)
            {
                for (int val_Index = 0; val_Index < ret.Columns.Count; val_Index++)
                {
                    var user_control = (IPRIS_UserControl)controls[val_Index];
                    user_control.ReadOnly = true;
                    user_control.Value = (string)ret.Rows[0][val_Index];
                }

            }
        }
        private List<UserControl[]> PRISControls()
        {
            List<UserControl[]> controls = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Employee's Full Name :"),
                    new PRIS_Label_Entry(_title: "Email Address :"),
                    new PRIS_Label_Entry(_title: "Contact Number :")
                },
                new UserControl[]
                {
                    new PRIS_Label_Selector(_title:"Sector :",
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: true),

                    new PRIS_Label_Selector(_title:"Office :"  ,
                            _query: Database_Query.get_office_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Office Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Office",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: true),

                    new PRIS_Label_Selector(_title:"Division :"  ,
                            _query: Database_Query.get_division_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Division Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Divsion",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: true),

                    new PRIS_Label_Selector(_title:"Section :"  ,
                            _query: Database_Query.get_section_option,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Section Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Section",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: true),

                    new PRIS_Label_Selector(_title:"Position :"  ,
                            _query: Database_Query.get_position_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Section Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Section",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: true)
                }

            };
            return controls;
        }


        private void update_Btn_Click(object sender, EventArgs e)
        {
            change_ViewControls(true);



            for (int selector_Index = 0; selector_Index < selectors.Count; selector_Index++)
            {
                if (selector_Index > 0 && selector_Index < selectors.Count - 1)
                    selectors[selector_Index].EnableSelector = false;

                if (selector_Index < selectors.Count - 1) 
                    selectors[selector_Index].SelectionChanged += PRIS_Selector_Callback;
  
            }
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                change_ViewControls(false);
                for (int num = 0; num < selectors.Count; num++)
                {
                    selectors[num].ReadOnly = true;
                    selectors[num].EnableSelector = true;
                    selectors[num].SelectionChanged -= PRIS_Selector_Callback;
                }
                error_Message.Text = string.Empty;
                error_Message.Visible = true;
                _error.Clear();
                SetValues();
            }
        }

        private void change_ViewControls(bool is_Enabled = true)
        {
            update_Btn.Enabled = !is_Enabled;
            delete_Btn.Enabled = !is_Enabled;

            save_Btn.Enabled = is_Enabled;
            save_Btn.Visible = is_Enabled;

            cancel_Btn.Visible = is_Enabled;
            cancel_Btn.Enabled = is_Enabled;

            for (int con_Index = 0; con_Index < controls.Count; con_Index++)
            {
                var user_Controls = (IPRIS_UserControl)controls[con_Index];
                user_Controls.ReadOnly = !is_Enabled;
            }
        }

        private void PRIS_Selector_Callback(object sender, EventArgs e)
        {
            var selector = (PRIS_Label_Selector)sender;
            DataTable ret;
            int num = 0;

            switch (selector.Title) 
            {
                case "Sector":
                    num = 1;
                    selectors[num].SelectorQuery = string.Format(Database_Query.get_office_options_by_id, selector.Value);
                    selectors[num].InfoText = $"Records based on {selectors[num - 1].RawValue}";
                    break;
                case "Office":
                    num = 2;
                    selectors[num].SelectorQuery = string.Format(Database_Query.get_division_options_by_id, selector.Value);
                    selectors[num].InfoText = $"Records based on {selectors[num - 1].RawValue}";
                    break;
                case "Division":
                    num = 3;
                    selectors[num].SelectorQuery = string.Format(Database_Query.get_section_options_by_id, selector.Value);
                    selectors[num].InfoText = $"Records based on {selectors[num - 1].RawValue}";
                    break;
                case "Section":
                    num = 4;
                    break;
                
            }
            using (database_manager)
                ret = database_manager.ExecuteQuery(selectors[num].SelectorQuery);

            var isEmpty = ret.Rows.Count == 0 ? true : false;
            selectors[num].EnableSelector = !isEmpty;
            

            if (!util.SearchString(ret, selectors[num].Value))
                _error.SetError(selectors[num].Button, $"{selectors[num].RawValue} is not a record of {selectors[num - 1].RawValue}.");
            else 
                _error.SetError(selectors[num].Button, string.Empty);

            if (util.SearchString(selectors[num - 1].RawOptions, selectors[num - 1].RawValue))
                _error.SetError(selectors[num - 1].Button, string.Empty);

        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            int ret;
            var error_Entries = util.SearchControls<Control>(control_Panel, new List<Type> { typeof(GunaTextBox), typeof(GunaButton) });

            foreach (Control control in error_Entries)
                if (!string.IsNullOrEmpty(_error.GetError(control)))
                {
                    error_Message.Text = "Error in records selections.";
                    error_Message.Visible = true;
                    return;
                }
            if (!validator.Required_TextBox(control_Panel, _error, error_Message))
                return;

            var values = new List<string>();

            foreach (IPRIS_UserControl userControl in controls) 
                values.Add(userControl.Value);
            

            var entries = new List<List<string>> { new List<string> { values[0], values[1], values[3], values[6], values[7], "admin", emp_id.Text } } ;

            using (database_manager)
                ret = database_manager.ExecuteNonQuery(util.generate_Query(entries, Database_Query.update_employee_record_by_id));

            if (ret == 1)
            {
                if (MessageBox.Show($"{emp_id.Text} is successfully added.", "New Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    is_ClosingProgrammatically = true;
                    callback?.Invoke();
                    Close();
                }
            }
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure to delete {emp_id.Text}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                using (database_manager)
                    database_manager.ExecuteNonQuery(string.Format(Database_Query.delete_record_by_id, "emp_info_table", this.Record_ID));

                MessageBox.Show($"{emp_id.Text} is successfully deleted", "Delete Confirmation");
                is_ClosingProgrammatically = true;
                Close();
                callback?.Invoke();
            }
        }

        private void audit_Trail_Btn_Click(object sender, EventArgs e)
        {
            audit_Trail = new Audit_Trail(this.Record_ID, "emp_info_table");
            audit_Trail.ShowDialog();
        }

        private void View_Employee_FormClosing(object sender, FormClosingEventArgs e)
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
