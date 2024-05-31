using COA_PRIS.UserControlUtil.PRIS_UserControl;
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
using Microsoft.Win32;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Net.Mime.MediaTypeNames;
using Org.BouncyCastle.Utilities.Collections;
using MySqlX.XDevAPI.Relational;

namespace COA_PRIS.Screens.Subscreens.Projects
{
    public partial class Project_View : Form
    {
        private Database_Manager Database_Manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();

        private List<PRIS_Label_Selector> PRIS_Selectors;

        private Project_History Project_History;
        private Project_Forward Project_Forward;
        private string ProjectCode;
        private string ProjectNumber;

        private bool is_ClosingProgrammatically = false;
        Dictionary<string, string> values, selectorValues;
        private Dictionary<string, string> InitialValues;

        private PRIS_Label_Rich Subject;
        public Action ToRefresh;
        public Project_View(string code)
        {
            InitializeComponent();
            this.ProjectCode = code;
            InitializeControls();
            Access_Manager();
        }

        private void Access_Manager()
        {
            DataTable ret;
            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_project_access, Activity_Manager.CurrentUser));

            if (ret != null)
            {
                update_Btn.Visible = ret.Rows[0][2].ToString() == "1" ? true : false;
                forward_Btn.Visible = ret.Rows[0][2].ToString() == "1" ? true : false;
            }

        }
        public void InitializeControls()
        {
            util.SetControls(PRISUserControls(), parent_Panel);
            
            PRIS_Selectors = util.SearchControls<PRIS_Label_Selector>(parent_Panel, new List<Type>() { typeof(PRIS_Label_Selector) });
            
            project_id.Text = ProjectCode;



            foreach (PRIS_Label_Selector pris in PRIS_Selectors)
                if (string.Equals(pris.Title, "Sector") || string.Equals(pris.Title, "Cluster"))
                    pris.SelectionChanged += SelectorCallback;
            
            Set_Record();

            using (Database_Manager) 
            {
                var status = Database_Manager.ExecuteScalar(string.Format(Database_Query.get_project_status_by_id, ProjectCode)).ToString();

                if (string.Equals(status, "SYSTEM_STS000003"))
                {
                    delete_Btn.Enabled = false;
                    forward_Btn.Enabled = false;
                    update_Btn.Enabled = false;
                }
                else
                {
                    delete_Btn.Enabled = true;
                    forward_Btn.Enabled = true;
                    update_Btn.Enabled = true;
                }
            }
        }

        private void Set_Record() 
        {
            InitialValues = new Dictionary<string, string>();
            DataTable ret;
            var controls = util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(IPRIS_UserControl) });

            using (Database_Manager) 
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_project_record, ProjectCode));
            
            ProjectNumber = ret.Rows[0][0].ToString();

            for (int retIndex = 0; retIndex < ret.Columns.Count; retIndex++)
            {
                ((IPRIS_UserControl)controls[retIndex]).Value = ret.Rows[0][retIndex].ToString();
                InitialValues.Add(((IPRIS_UserControl)controls[retIndex]).Title, ((IPRIS_UserControl)controls[retIndex]).Value);
            }
            validator.PRISReadOnly(parent_Panel, true);
        
        }
        private List<UserControl[]> PRISUserControls()
        {
            DataTable ret;
            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(Database_Query.get_status_options);

            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Routing Slip Number :", _isRequired: true),
                    new PRIS_Label_Rich(_title: "Project Title :", _isRequired: true, _entryHeight: 290),
                    new PRIS_Label_Entry(_title: "Amount :", _isRequired: true, _textAlign: HorizontalAlignment.Right),
                    new PRIS_Date_Picker(_title: "Period :", _isRequired: true, _diplayFormat: "MMMM yyyy", _displayDate: DateTimePickerFormat.Custom, _isReadOnly: false),
                    new PRIS_Date_Picker(_title: "Date Received :", _isRequired: true, _isReadOnly: false),


                },
                new UserControl[]
                {
                    new PRIS_Label_Status(_title: "Status :", _options: ret, _readOnly: true, _value: "Pending"),

                    new PRIS_Label_Selector(_title:"Sector :",
                            _searchQuery : Database_Query.get_role_search, 
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Cluster :",
                            _searchQuery : Database_Query.get_cluster_search,
                            _query: Database_Query.get_cluster_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: false, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Agency :",
                            _searchQuery : Database_Query.get_agency_search,
                            _query: Database_Query.get_agency_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Agency Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Agency",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: false, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Contractor :",
                            _searchQuery : Database_Query.get_contractor_search,
                            _query: Database_Query.get_contractor_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Contractor",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Nature :",
                            _searchQuery : Database_Query.get_nature_search,
                            _query: Database_Query.get_nature_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Contractor",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Division :",
                            _searchQuery : Database_Query.get_division_search,
                            _query: Database_Query.get_division_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Contractor",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 20), (true, 40), (true, 35),},
                            _enabled: true, _read_Only: false, _isRequired: true),
                },

                new UserControl[]
                {
                    Subject = new PRIS_Label_Rich(_title: "Subject : ", _isRequired: true, _entryHeight: 350),

                    new PRIS_Label_Rich(_title: "Remarks : ", _isRequired: false, _entryHeight: 350),
                }

            };

            return control;

        }

        private void SelectorCallback(object sender, EventArgs e)
        {
            var selector = (PRIS_Label_Selector)sender;
            DataTable ret;
            int num = 0;

            switch (selector.Title)
            {
                case "Sector":
                    num = 1;
                    PRIS_Selectors[num].SelectorQuery = string.Format(Database_Query.get_cluster_options_by_id, selector.Value);
                    break;
                case "Cluster":
                    num = 2;
                    PRIS_Selectors[num].SelectorQuery = string.Format(Database_Query.get_agency_options_by_id, selector.Value);
                    break;
                case "Agency":
                    num = 3;
                    break;
            }
            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(PRIS_Selectors[num].SelectorQuery);

            var isEmpty = ret.Rows.Count == 0 ? true : false;
            PRIS_Selectors[num].EnableSelector = !isEmpty;

            for (int i = num; i < PRIS_Selectors.Count - 3; i++)
            {
                if (!PRIS_Selectors[num].EnableSelector)
                {
                    PRIS_Selectors[i].EnableSelector = false;
                    PRIS_Selectors[i].EntryText = "No Valid Record";
                }
                else
                {
                    PRIS_Selectors[i].EntryText = $"Select {PRIS_Selectors[i].Title} Record";
                }
            }


        }


        private void update_Btn_Click(object sender, EventArgs e)
        {
            change_ViewControls(true);
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                change_ViewControls(false);
                validator.PRISClearErrors(parent_Panel, errorProvider);
                Set_Record();
            }

        }

        private void change_ViewControls(bool is_Enabled) 
        {
            var status = util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(PRIS_Label_Status) });

            validator.PRISReadOnly(parent_Panel, !is_Enabled);
            ((IPRIS_UserControl)status[0]).ReadOnly = true;

            forward_Btn.Enabled = !is_Enabled;
            update_Btn.Enabled = !is_Enabled;
            delete_Btn.Enabled = !is_Enabled;

            this.button_Panel.Visible = is_Enabled;
            this.button_Panel.Enabled = is_Enabled;


        }

        private async void save_Btn_ClickAsync(object sender, EventArgs e)
        {
            string UpdateMessage = "Updated Project Record : Fields - ";

            

            if (!validator.PRISRequired(parent_Panel, errorProvider))
                return;

            if (validator.PRISUpdateCheck(parent_Panel, InitialValues).Count == 0)
            {
                MessageBox.Show("There are no changes in the project record.", "PRIS Update Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach ((string, string, string) value in validator.PRISUpdateCheck(parent_Panel, InitialValues))
                UpdateMessage += $"{value.Item1}, ";


            Random random = new Random();
            int ret = 0;

            var controls = util.SearchControls<UserControl>(parent_Panel, new List<Type>() { typeof(IPRIS_UserControl) });
            var selectors = util.SearchControls<PRIS_Label_Selector>(parent_Panel, new List<Type> { typeof(PRIS_Label_Selector) });
            var history_code = util.GenerateRandomID(random, "history_table");

            values = new Dictionary<string, string>();
            selectorValues = new Dictionary<string, string>();

            foreach (IPRIS_UserControl control in controls)
                values.Add(control.Title, control.Value);
            
            foreach (PRIS_Label_Selector selector in selectors)
                selectorValues.Add(selector.Title, selector.RawValue);


            string[] lines = Subject.Value.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            if (lines.Length >= 4)
            {

                lines[0] = $"{values["Routing Slip Number"]}";
                lines[1] = $"{selectorValues["Sector"]} | {selectorValues["Cluster"]}";
                lines[2] = $"{selectorValues["Agency"]}";
                lines[3] = $"{selectorValues["Nature"]}";

            }

            // Reconstruct the text
            string updatedText = string.Join(Environment.NewLine, lines);

            Subject.Value = updatedText;

            if (MessageBox.Show("Are you sure you want to update?", "PRIS Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using (Database_Manager) 
            {
                ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_project_record, values["Routing Slip Number"], values["Project Title"], Convert.ToDouble(values["Amount"].TrimStart('₱').Trim()), values["Period"], values["Subject"], values["Date Received"], ProjectCode));
                ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_project_transaction, values["Agency"], values["Contractor"], values["Nature"], values["Division"], values["Status"], ProjectCode));
                ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.update_project_remarks, values["Remarks"], ProjectCode));
                ret += Database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history_ct, history_code, UpdateMessage, ProjectCode, Activity_Manager.CurrentUser));
            }
            if (ret == 4) 
            {
                using (Database_Manager)
                {
                    string code_type = Database_Manager.ExecuteScalar(string.Format(Database_Query.return_module_name, "docu_info_table")).ToString();
                    //make activity log
                    Database_Manager.ExecuteQuery(string.Format(Database_Query.log_maintenance_activity_add, Activity_Manager.CurrentUser, $"Updated Record : {code_type} {ProjectCode}"));

                }



                //Server
                await ServerManager.SendMessageToClientsAsync(project_id.Text);

                //Client
                //await ClientManager.SendMessageAsync(project_id.Text);

                MessageBox.Show($"{ProjectCode} - {values["Routing Slip Number"]} is successfully updated.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToRefresh?.Invoke();
                is_ClosingProgrammatically = true;
                change_ViewControls(false);
            }
        }

        private void Project_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;

                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }

        private void forward_Btn_Click(object sender, EventArgs e)
        {
            Project_Forward = new Project_Forward(ProjectCode, ProjectNumber);
            Project_Forward.ToRefresh += Forward_Callback;
            Project_Forward.ShowDialog();
        }

        private void Forward_Callback() 
        {
            Set_Record();
            ToRefresh?.Invoke();
        }

        private void audit_Trail_Btn_Click(object sender, EventArgs e)
        {
            Project_History = new Project_History(ProjectCode);
            Project_History.ShowDialog();
        }
    }
}
