using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COA_PRIS.Screens.Subscreens.Projects
{
    public partial class Project_Forward : Form
    {
        private Validator validator = new Validator();
        private Database_Manager Database_Manager = new Database_Manager();
        private Util util = new Util();

        private string ProjectCode;
        private string ProjectNumber;

        public Action ToRefresh;

        private bool is_ClosingProgrammatically = false;

        public Project_Forward(string _projectCode, string _projectNumber)
        {
            InitializeComponent();
            ProjectCode = _projectCode;
            ProjectNumber = _projectNumber;
            InitializeControls();
            
        }


        private void InitializeControls()
        {
            project_id.Text = ProjectCode;

            util.SetControls(PRIS_TitleControls(), title_Panel);
            util.SetControls(PRIS_Controls(), parent_Panel);

            var titleControls = util.SearchControls<UserControl>(title_Panel, new List<Type>() { typeof(PRIS_Label_Entry) });
            var selectors = util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(PRIS_Label_Selector) });
            var checkers = util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(PRIS_Label_MainCheckBox) });

            ((IPRIS_UserControl)titleControls[0]).Value = ProjectNumber;

            using (Database_Manager)
            {
                var ret = Database_Manager.ExecuteScalar(string.Format(Database_Query.get_project_title_by_id, ProjectNumber));
                var div = Database_Manager.ExecuteScalar(string.Format(Database_Query.get_project_division_by_id, ProjectCode));
                
                //((IPRIS_UserControl)titleControls[1]).Value = ret.ToString();
                ((IPRIS_UserControl)selectors[0]).Value = div.ToString();
            }

            foreach (PRIS_Label_MainCheckBox check in checkers) 
            {
                check.Check_Changed += checkCallBack;
            }

        }

        private void checkCallBack(object sender, EventArgs e) 
        {
            var check = (PRIS_Label_MainCheckBox)sender;
            
            var checkers = util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(PRIS_Label_MainCheckBox) });
            var controls = util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(IPRIS_UserControl) });

            switch (check.Title) 
            {
                case "Received":
                    ((PRIS_Label_MainCheckBox)checkers[1]).ReadOnly = check.Value == "1" ? true : false;
                    ((PRIS_Label_MainCheckBox)checkers[2]).ReadOnly = check.Value == "1" ? true : false;
                    break;
                case "Released":
                    ((PRIS_Label_MainCheckBox)checkers[0]).ReadOnly = check.Value == "1" ? true: false;
                    ((PRIS_Label_MainCheckBox)checkers[2]).ReadOnly = check.Value == "1" ? true : false;
                    break;
                case "Filed":
                    ((PRIS_Label_MainCheckBox)checkers[0]).ReadOnly = check.Value == "1" ? true : false;
                    ((PRIS_Label_MainCheckBox)checkers[1]).ReadOnly = check.Value == "1" ? true : false;
                    break;
            }

            for (int controlIndex = 0; controlIndex < 3; controlIndex++) 
            {
                ((IPRIS_UserControl)controls[controlIndex]).ReadOnly = check.Value == "1" ? true : false;
            }

        }

        private List<UserControl[]> PRIS_Controls()
        {
            Dictionary<string, string> dropBoxValue = new Dictionary<string, string>();
            using (Database_Manager) 
            {
                var ret = Database_Manager.ExecuteQuery(Database_Query.get_forward_title);

                foreach (DataRow row in ret.Rows)
                    dropBoxValue.Add(row[0].ToString(), row[1].ToString());
            }

            List<UserControl[]> controls = new List<UserControl[]>()
            {


                new UserControl[]
                {
                    new PRIS_Label_DropBox(_title: "Forward to :", _dropboxValues: dropBoxValue, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Division :",
                            _searchQuery: string.Format(Database_Query.get_division_office_search, "{0}","SYSTEM_OFC000002") ,
                            _query: string.Format(Database_Query.get_division_options_by_id, "SYSTEM_OFC000002"),
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Employee Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Employee Name",DataGridViewContentAlignment.MiddleLeft),
                                    ("Position",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: false, _isRequired: false, _showMessage: false),

                    new PRIS_Label_Selector(_title:"Technical Audit Specialist :",
                            _searchQuery: string.Format(Database_Query.get_employee_search_office, "{0}", "SYSTEM_OFC000002"),
                            _query: string.Format(Database_Query.get_employee_options_by_office,  "SYSTEM_OFC000002"),
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Employee Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Employee Name",DataGridViewContentAlignment.MiddleLeft),
                                    ("Position",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: false, _isRequired: false, _showMessage: false),


                    new PRIS_Label_Rich(_title: "Description :", _entryHeight: 260, _isRequired: true)

                },
                new UserControl[]
                {
                    new PRIS_Date_Picker(_title: "Date :" ),
                    new PRIS_Label_MainCheckBox(_title: "Received", _isChecked: false, _isReadOnly: false),
                    new PRIS_Label_MainCheckBox(_title: "Released", _isChecked: false, _isReadOnly: false),
                    new PRIS_Label_MainCheckBox(_title: "Filed", _isChecked: false, _isReadOnly: false),
                    new PRIS_Label_Rich(_title: "Remarks :", _entryHeight: 250, _isRequired: false),
                }




            };

            return controls;


        }
        private List<UserControl[]> PRIS_TitleControls()
        {
            List<UserControl[]> controls = new List<UserControl[]>()
            {
                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Routing Slip Number :", _isReadOnly: true, _showMessage: false),
                }

            };

            return controls;
        }

        private async void proceed_Btn_ClickAsync(object sender, EventArgs e)
        {

            if (!validator.PRISRequired(parent_Panel, errorProvider))
                return;


            Random random = new Random();

            Dictionary <string, string> values = new Dictionary<string, string>();

            int ret = 0;
            var controls = util.SearchControls<UserControl>(parent_Panel, new List<Type>(){ typeof(IPRIS_UserControl)});

            foreach (IPRIS_UserControl control in controls)
            {
                if (control is PRIS_Label_Selector)
                    values.Add(control.Title, ((PRIS_Label_Selector)control).RawValue);
                
                else 
                    values.Add(control.Title, control.Value);
            }

            
            using (Database_Manager)
            {
                string message = string.Empty;
                string historyCode = util.GenerateRandomID(random, "history_table");

                if (string.Equals(values["Received"], "0") && string.Equals(values["Released"], "0") && string.Equals(values["Filed"], "0"))
                {
                    if (string.Equals(values["Forward to"], "SYSTEM_FOR000001"))
                    {
                        message = $"Forwarded to {((PRIS_Label_DropBox)controls[0]).RawValue} - {values["Division"]} : {values["Description"]}";
                    }
                    else if (string.Equals(values["Forward to"], "SYSTEM_FOR000005"))
                    {
                        if (string.Equals(((PRIS_Label_Selector)controls[2]).RawValue, "Select Technical Audit Specialist Record"))
                        {
                            MessageBox.Show("Select an auditor record", "PRIS Forward Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            message = $"Forwarded to {((PRIS_Label_DropBox)controls[0]).RawValue} - {values["Technical Audit Specialist"]} : {values["Description"]}";
                        }
                    }
                    else
                    {
                        message = $"Forwarded to {((PRIS_Label_DropBox)controls[0]).RawValue} : {values["Description"]}";
                    }

                    if (MessageBox.Show("Are you sure you want to proceed?", "PRIS Forward Confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history, historyCode, message, ProjectCode, Activity_Manager.CurrentUser, values["Date"]));
                    ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_docu_status_by_id, "SYSTEM_STS000002", ProjectCode));

                }
                else 
                {
                    if (MessageBox.Show("Are you sure you want to proceed?", "PRIS Forward Confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    if (string.Equals(values["Released"], "1"))
                    {
                        ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history, historyCode, $"Project Record Released : {values["Description"]}", ProjectCode, Activity_Manager.CurrentUser, values["Date"]));
                        ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_docu_status_by_id, "SYSTEM_STS000004", ProjectCode));
                    }

                    if (string.Equals(values["Filed"], "1"))
                    {
                        ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history, historyCode, $"Project Record Filed : {values["Description"]}", ProjectCode, Activity_Manager.CurrentUser, values["Date"]));
                        ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_docu_status_by_id, "SYSTEM_STS000003", ProjectCode));
                        ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.updated_date_filed_by_id, values["Date"], ProjectCode));
                    }

                    if (string.Equals(values["Received"], "1"))
                    {
                        ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history, historyCode, $"Project Record Received : {values["Description"]}", ProjectCode, Activity_Manager.CurrentUser, values["Date"]));
                    }
                }

                if (!string.IsNullOrEmpty(values["Remarks"]))
                {
                    var remark = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_remarks_by_id, ProjectCode));
                    ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_remarks_by_id, $"{remark.Rows[0][0]} \n\n{values["Remarks"]}", ProjectCode));
                }

               


            }

            if (ret != 0) 
            {
                //Server
                await ServerManager.SendMessageToClientsAsync(project_id.Text);

                //Client
                //await ClientManager.SendMessageAsync(project_id.Text);


                MessageBox.Show($"{ProjectCode} is successfully updated.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                is_ClosingProgrammatically = true;
                ToRefresh?.Invoke();
                Close();
            }

                


        }

        private void Project_Forward_FormClosing(object sender, FormClosingEventArgs e)
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
