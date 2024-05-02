using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace COA_PRIS.Screens.Subscreens.Employees
{
    public partial class Add_Employee : Form
    {
        private Database_Manager database_manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();

        private bool is_ClosingProgrammatically = false;
        private List<PRIS_Label_Selector> selectors;
        public event Action callback;
        public Add_Employee()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void Add_Record_Load(object sender, EventArgs e)
        {
            emp_id.Text = util.GenerateID("emp_info_table");
        }

        private void InitializeControls() 
        {
            util.SetControls(PRISControls(), control_Panel);
            selectors = util.SearchControls<PRIS_Label_Selector>(control_Panel, new List<Type> { typeof(PRIS_Label_Selector) });
            for(int num = 0; num < selectors.Count - 1 ; num++)
                selectors[num].SelectionChanged += PRIS_Selector_Callback;
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
                    break;
                case "Office":
                    num = 2;
                    selectors[num].SelectorQuery =  string.Format(Database_Query.get_division_options_by_id, selector.Value);
                    break;
                case "Division":
                    num = 3;
                    selectors[num].SelectorQuery = string.Format(Database_Query.get_section_options_by_id, selector.Value);
                    break;
                case "Section":
                    num = 4;
                    selectors[4].EnableSelector = true;
                    break;
            }
            using (database_manager)
                ret = database_manager.ExecuteQuery(selectors[num].SelectorQuery);
            
            var isEmpty = ret.Rows.Count == 0 ? true: false;
            selectors[num].EnableSelector = !isEmpty;

            for (int i = num; i < selectors.Count; i++) 
            {
                if (!selectors[num].EnableSelector)
                {
                    selectors[i].EnableSelector = false;
                    selectors[i].EntryText = "No Valid Record";
                }
                else
                {
                    selectors[i].EntryText = $"Select {selectors[i].Title} Record";
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
                            _enabled: true, _read_Only: false),

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
                            _enabled: false, _read_Only: false),

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
                            _enabled: false, _read_Only: false),

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
                            _enabled: false, _read_Only: false),

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
                            _enabled: false, _read_Only: false)
                }

            };
            return controls;
        }
        
        private void save_Btn_Click(object sender, EventArgs e)
        {
            int ret = 0;

            if (!validator.RequiredTextBox(control_Panel, error_Employee, error_Message))
                return;

            /*if (MessageBox.Show("Proceed to add employee record?", "Employee Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
               return;*/

            var controls = util.SearchControls<UserControl>(control_Panel, new List<Type> { typeof(UserControl)});
            var values = new List<string> { emp_id.Text };

            foreach (IPRIS_UserControl control in controls)
                values.Add(control.Value);

            var entries = new List<List<string>> { new List<string> { values[0], values[1], values[2], values[3], values[7], values[8], Activity_Manager.CurrentUser}};

            using (database_manager)
                ret = database_manager.ExecuteNonQuery(util.GenerateQuery(entries, Database_Query.set_new_employee));


            if (ret == 1)
            {
                MessageBox.Show($"{emp_id.Text} is successfully added.", "New Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                is_ClosingProgrammatically = true;
                callback?.Invoke();
                Close();
                
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

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            is_ClosingProgrammatically = false;
            Close();
        }
    }
}
