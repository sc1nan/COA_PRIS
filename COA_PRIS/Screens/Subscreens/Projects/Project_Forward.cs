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
        public Project_Forward(string _projectCode, string _projectNumber)
        {
            InitializeComponent();
            ProjectCode = _projectCode;
            ProjectNumber = _projectNumber;

            InitializeControls();

        }


        private void InitializeControls()
        {
            util.SetControls(PRIS_Controls(), parent_Panel);
            util.SetControls(PRIS_SelectionControls(), selection_Panel);
            IPRIS_UserControl projectNumber = (IPRIS_UserControl)(util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(PRIS_Label_Entry) }))[0];
            projectNumber.Value = ProjectNumber;
            project_id.Text = ProjectCode;  


        }

        private List<UserControl[]> PRIS_Controls()
        {
            List<string> dropBoxValue = new List<string>
            {
                 "Division" , "O.D. S.C.", "D3", "D4"
            };

            List<UserControl[]> controls = new List<UserControl[]>()
            {


                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Routing Slip Number :", _isReadOnly: true),
                    new PRIS_Label_Selector(_title:"TAS :",
                            _searchQuery: Database_Query.get_employee_search,
                            _query: Database_Query.get_employee_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Employee Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Employee Name",DataGridViewContentAlignment.MiddleLeft),
                                    ("Position",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: false, _isRequired: false),


                    new PRIS_Label_Rich(_title: "Description :", _entryHeight: 400, _isRequired: false)

                },
                new UserControl[]
                {
                    new PRIS_Date_Picker(_title: "Date :" ),
                    new PRIS_Label_DropBox(_title: "Forward to :", _dropboxValues: dropBoxValue, _isRequired: true),
                    new PRIS_Label_Rich(_title: "Remarks :", _entryHeight: 400, _isRequired: false),
                }




            };

            return controls;


        }
        private List<UserControl[]> PRIS_SelectionControls()
        {
            List<UserControl[]> controls = new List<UserControl[]>()
            {
                new UserControl[]
                {
                    new PRIS_Label_MainCheckBox(_title: "Received", _isChecked: false, _isReadOnly: false),
                },
                new UserControl[]
                {
                    new PRIS_Label_MainCheckBox(_title: "Filed", _isChecked: false, _isReadOnly: false),
                }

            };

            return controls;
        }

        private void proceed_Btn_Click(object sender, EventArgs e)
        {
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


            if (string.IsNullOrEmpty(values["Description"]) && string.IsNullOrEmpty(values["Remarks"]) && string.Equals(values["TAS"], "Select TAS Record")) 
            {
                MessageBox.Show("No inputs to be added to the project record", "PRIS Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Console.WriteLine($"{values["Description"]} {values["Remarks"]} {values["TAS"]}");







            using (Database_Manager) 
            {

                /*if (!string.IsNullOrEmpty(values["Description"]))
                {
                    string historyCode = util.GenerateRandomID(random, "history_table");
                    ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history, historyCode, $"Forwarded to {values["Forward to"]} : {values["Description"]}", ProjectCode, Activity_Manager.CurrentUser));

                    var active = Database_Manager.ExecuteScalar(string.Format(Database_Query.get_status_code_by_name, "Active"));
                    Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_docu_status_by_id, (string)active, ProjectCode));

                }

                if (!string.IsNullOrEmpty(values["Remarks"]))
                {
                    
                    var remark = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_remarks_by_id, ProjectCode));
                    ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_remarks_by_id, $"{remark.Rows[0][0]} \n\n{values["Remarks"]}", ProjectCode));
                }

                if (!string.Equals(values["TAS"], "Select TAS Record"))
                {
                    string historyCode = util.GenerateRandomID(random, "history_table");
                    ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history, historyCode, $"TAS : {values["TAS"]}", ProjectCode, Activity_Manager.CurrentUser));

                }

                */

            }

            if (ret != 0) 
            {
                MessageBox.Show($"{ProjectCode} - {values["Project Number"]} is successfully updated.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToRefresh?.Invoke();
                
                Close();


            }

                


        }
    }
}
