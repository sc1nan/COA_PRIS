using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.Utilities;
using Org.BouncyCastle.Asn1.Crmf;
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

namespace COA_PRIS.Screens.Subscreens.Projects
{
    public partial class Project_Create : Form
    {
        private Database_Manager database_Manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();

        private List<PRIS_Label_Selector> PRIS_Selectors;
        private PRIS_Label_Rich Subject;
        private PRIS_Label_Entry Reference;

        private string InitialString = "STSS-TSO-OD-";

        Dictionary<string, string> values;

        public Action ToRefresh;
        private bool is_ClosingProgrammatically = false;
        public Project_Create()
        {
            InitializeComponent();
            project_id.Text = util.GenarateUID("docu_info_table");
            InitzializeControls();

        }


        public void InitzializeControls()
        {
            util.SetControls(PRISUserControls(), control_Panel);
            Reference = util.SearchControls<PRIS_Label_Entry>(control_Panel, new List<Type>() { typeof(PRIS_Label_Entry) })[0];
            PRIS_Selectors = util.SearchControls<PRIS_Label_Selector>(control_Panel, new List<Type>() { typeof(PRIS_Label_Selector) });

            foreach (PRIS_Label_Selector pris in PRIS_Selectors)
            {
                if (string.Equals(pris.Title, "Sector") || string.Equals(pris.Title, "Cluster"))
                    pris.SelectionChanged += SelectorCallback;

                if (string.Equals(pris.Title, "Nature"))
                    pris.SelectionChanged += NatureToSubject;
            }
            Reference.Text_Changed += InsertToSubject;
            Reference.SpecialChar = InitialString;

        }

        private void NatureToSubject(object sender, EventArgs e) 
        {
            var entry = (PRIS_Label_Selector)sender;
            //Console.WriteLine(entry.Value);

        }
        private void InsertToSubject(object sender, EventArgs e) 
        {
            
            var entry = (PRIS_Label_Entry)sender;

            Subject.Value = entry.Value;
            
        
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
                    //Subject.Value = $"{Subject.Value + "\n" + selector.RawValue}";
                    break;
                case "Cluster":
                    num = 2;
                    PRIS_Selectors[num].SelectorQuery = string.Format(Database_Query.get_agency_options_by_id, selector.Value);
                    //Subject.Value = $"{Subject.Value}-{ selector.RawValue}";
                    break;
                case "Agency":
                    num = 3;
                    //Subject.Value = $"{Subject.Value + "\n" + selector.RawValue}";
                    break;
            }
            using (database_Manager)
                ret = database_Manager.ExecuteQuery(PRIS_Selectors[num].SelectorQuery);

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

        private List<UserControl[]> PRISUserControls() 
        {
            DataTable ret;
            using (database_Manager)
                ret = database_Manager.ExecuteQuery(Database_Query.get_status_options);

            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                    new PRIS_Label_Entry(_title: "Routing Slip Number :", _isRequired: true),
                    new PRIS_Label_Rich(_title: "Project Title :", _isRequired: true, _entryHeight: 290),
                    new PRIS_Label_Entry(_title: "Amount :", _isRequired: true, _textAlign: HorizontalAlignment.Right, _isCurrency: true),
                    new PRIS_Date_Picker(_title: "Period :", _isRequired: true, _diplayFormat: "MMMM yyyy", _displayDate: DateTimePickerFormat.Custom, _isReadOnly: false),
                    new PRIS_Date_Picker(_title: "Date Received :", _isRequired: true, _isReadOnly: false),
                    

                },
                new UserControl[]
                {
                    new PRIS_Label_Status(_title: "Status :", _options: ret, _readOnly: true, _value: "Pending"),

                    new PRIS_Label_Selector(_title:"Sector :",
                            _searchQuery: Database_Query.get_sector_search,
                            _query: Database_Query.get_sector_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Cluster :",
                            _searchQuery: Database_Query.get_cluster_search,
                            _query: Database_Query.get_cluster_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: false, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Agency :",
                            _searchQuery: Database_Query.get_agency_search,
                            _query: Database_Query.get_agency_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Agency Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Agency",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: false, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Contractor :",
                            _searchQuery: Database_Query.get_contractor_search,
                            _query: Database_Query.get_contractor_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Contractor",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Nature :",
                            _searchQuery: Database_Query.get_nature_search,
                            _query: Database_Query.get_nature_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Contractor",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Division :",
                            _searchQuery: Database_Query.get_division_search,
                            _query: Database_Query.get_division_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Contractor",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: false, _isRequired: true),
                },

                new UserControl[] 
                {
                    Subject = new PRIS_Label_Rich(_title: "Subject : ", _isRequired: true, _entryHeight: 350),

                    new PRIS_Label_Rich(_title: "Remarks : ", _isRequired: true, _entryHeight: 350),
                }

            };   
        
            return control;
        
        
        }

        private void create_Btn_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if (!validator.PRISRequired(control_Panel, error_Provider))
                return;
            Random random = new Random();

            var controls = util.SearchControls<UserControl>(control_Panel, new List<Type> { typeof(IPRIS_UserControl) });

            var history_code = util.GenerateRandomID(random, "history_table");
            var remarks_code = util.GenerateRandomID(random, "remarks_table");


            values = new Dictionary<string, string>();
            foreach (IPRIS_UserControl pris in controls)
                values.Add(pris.Title, pris.Value);
            


            using (database_Manager)
            {
                ret += database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_docu_infos, project_id.Text, values["Routing Slip Number"], values["Project Title"], values["Amount"], values["Period"], values["Subject"], values["Date Received"]));
                ret += database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_docu_trans, project_id.Text, values["Agency"], values["Contractor"], values["Nature"], values["Division"], values["Status"]));
                ret += database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history, history_code, "Project Record Created", project_id.Text, Activity_Manager.CurrentUser));
                ret += database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_remarks, remarks_code, values["Remarks"], project_id.Text, Activity_Manager.CurrentUser));
            }


            if (ret == 4)
            {
                //is_ClosingProgrammatically = true;
                MessageBox.Show($"{values["Routing Slip Number"]} - {values["Routing Slip Number"]} is successfully added.", "PRIS Record Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControls();
                ToRefresh?.Invoke();
                //Close();
            }

        }

        private void ResetControls() 
        {
            var controls = util.SearchControls<UserControl>(control_Panel, new List<Type> { typeof(IPRIS_UserControl) });

            foreach (IPRIS_UserControl con in controls)
            {
                con.Value = null; 
                if (con is PRIS_Label_Status)
                    ((PRIS_Label_Status)con).Value = "Pending";
                
            }
            Reference.SpecialChar = InitialString;
            validator.PRISClearErrors(control_Panel, error_Provider);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void Project_Create_FormClosing(object sender, FormClosingEventArgs e)
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
