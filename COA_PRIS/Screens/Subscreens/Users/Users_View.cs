using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.UserControlUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COA_PRIS.Utilities;

namespace COA_PRIS.Screens.Subscreens.Users
{
    public partial class Users_View : Form
    {

        private Util util = new Util();

        private bool is_ClosingProgrammatically = false;

        private PRIS_Label_Entry password;
        public Users_View()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {

            util.SetControls(controls: PRISUserControls_Selection(), parent: selection_Panel);
            util.SetControls(controls: PRISUserControls_Accounts(), parent: account_Panel);
            util.SetControls(controls: PRISUserControls_Roles(), parent: content_Panel);

            password.Visible = false;

        }

        private List<UserControl[]> PRISUserControls_Selection()
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {

                    new PRIS_Label_Entry(_title: "Employee Name :", _isRequired: false, _isReadOnly: true),
                    new PRIS_Label_Entry(_title: "Office :", _isRequired: false, _isReadOnly: true),
                    new PRIS_Label_Entry(_title: "Position :", _isRequired: false, _isReadOnly: true),


                }
            };

            return control;
        }
        private List<UserControl[]> PRISUserControls_Accounts()
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Username :", _isRequired: true, _isReadOnly: true),
                    password = new PRIS_Label_Entry(_title: "Password :", _isRequired: true),
                    new PRIS_Label_Selector(_title:"Role :",
                            _query: Database_Query.get_user_role_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Role Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Role",DataGridViewContentAlignment.MiddleLeft),
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 80),},
                            _enabled: true, _read_Only: true, _isRequired: true),
                }
            };

            return control;
        }
        private List<UserControl[]> PRISUserControls_Roles()
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_MainCheckBox(_title: "Home", _isChecked: true, _isReadOnly: true),

                    new PRIS_Label_MainCheckBox(_title: "Projects", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true),("Delete Records", false, true) }),

                    new PRIS_Label_MainCheckBox(_title: "Employee", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true),("Delete Records", false, true) }),

                    new PRIS_Label_MainCheckBox(_title: "Reports", _isChecked: false),

                    new PRIS_Label_MainCheckBox(_title: "Maintenance", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true),("Delete Records", false, true) }),

                    new PRIS_Label_MainCheckBox(_title: "User Settings", _isChecked: false,
                        _boxes: new (string, bool, bool)[] { ("Add Records", false, true),("View Records", true, true),("Update Records", false, true),("Delete Records", false, true) }),

                    new PRIS_Label_MainCheckBox(_title: "Activity Logs", _isChecked: false),
                }
            };

            return control;
        }

        private void Users_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;

                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
           change_ViewControls(true);
        }

        private void change_ViewControls(bool is_Enabled = true)
        {
            //validator.PRISReadOnly(control_Panel, !is_Enabled);

            update_Btn.Enabled = !is_Enabled;
            delete_Btn.Enabled = !is_Enabled;

            password.Visible = is_Enabled;
            this.button_Panel.Visible = is_Enabled;
            this.button_Panel.Enabled = is_Enabled;

        }

        private void cancel_Btn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                change_ViewControls(false);
                //set_Records();
            }
        }
    }
}
