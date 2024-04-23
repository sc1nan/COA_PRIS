using COA_PRIS.UserControlUtil;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
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

namespace COA_PRIS.Screens.Subscreens.Projects
{
    public partial class Project_Create : Form
    {
        private Database_Manager database_Manager = new Database_Manager();
        private Validator validator = new Validator();
        private Util util = new Util();

        private PRIS_Label_Status PRIS_Status;
        Dictionary<string, string> values;
        public Project_Create()
        {
            InitializeComponent();
            InitzializeControls();
            project_id.Text = util.GenerateID("docu_info_table");

        }


        public void InitzializeControls()
        {
            util.SetControls(PRISUserControls(), control_Panel);
            DataTable ret;
            using (database_Manager)
                ret = database_Manager.ExecuteQuery(Database_Query.get_status_options);

            PRIS_Status = new PRIS_Label_Status(_title: "Status :", _options: ret);
            PRIS_Status.Title = "Status :";
            PRIS_Status.Value = "Pending";
            PRIS_Status.ReadOnly = true;
            PRIS_Status.Dock = DockStyle.Top;
            status_Panel.Controls.Add(PRIS_Status);
        }

        private List<UserControl[]> PRISUserControls() 
        {
            List<UserControl[]> control = new List<UserControl[]>
            {
                new UserControl[]
                {
                   
                    new PRIS_Label_Entry(_title: "Project Number :", _isRequired: true),
                    new PRIS_Label_Rich(_title: "Project Title :", _isRequired: true, _entryHeight: 230),
                    new PRIS_Label_Entry(_title: "Amount :", _isRequired: true),
                    new PRIS_Date_Picker(_title: "Period :", _isRequired: true),
                    new PRIS_Date_Picker(_title: "Date Received :", _isRequired: true),
                },
                new UserControl[]
                {
                    new PRIS_Label_Rich(_title: "Subject : ", _isRequired: true, _entryHeight: 335),

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
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Cluster :",
                            _query: Database_Query.get_cluster_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Sector Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Sector",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    new PRIS_Label_Selector(_title:"Agency :",
                            _query: Database_Query.get_agency_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Agency Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Agency",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: false, _isRequired: true),

                    
                },

                new UserControl[] 
                {
                    new PRIS_Label_Selector(_title:"Contractor :",
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

                    new PRIS_Label_Selector(_title:"TAS :",
                            _query: Database_Query.get_employee_options,
                            _column_Title_Alignment: new (string, DataGridViewContentAlignment)[]
                                {
                                    ("#", DataGridViewContentAlignment.MiddleRight),
                                    ("Contractor Code",DataGridViewContentAlignment.MiddleCenter),
                                    ("Contractor",DataGridViewContentAlignment.MiddleLeft),
                                    ("Description",DataGridViewContentAlignment.MiddleLeft)
                                },
                            _column_Widths: new (bool, int)[] { (true, 5), (true, 15), (true, 40), (true, 40),},
                            _enabled: true, _read_Only: false, _isRequired: false),

                    new PRIS_Label_Rich(_title: "Remarks : ", _isRequired: false, _entryHeight: 230),
                }

            };   
        
            return control;
        
        
        }

        private void create_Btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(validator.PRISRequired(control_Panel, error_Provider).ToString());
            if (!validator.PRISRequired(control_Panel, error_Provider))
                return;

            var controls = util.SearchControls<UserControl>(control_Panel, new List<Type> { typeof(IPRIS_UserControl) });

            var history_code = util.GenerateID("history_table");
            var remarks_code = util.GenerateID("remarks_table");


            values = new Dictionary<string, string>();
            foreach (IPRIS_UserControl con in controls) 
                values.Add(con.Title, con.Value);


            Console.WriteLine(string.Format(Database_Query.set_new_docu_infos, project_id.Text, values["Project Number"], values["Project Title"], values["Amount"], values["Period"],values["Subject"], values["Date Received"]));

            Console.WriteLine(string.Format(Database_Query.set_new_history, history_code, string.Format(Log_Message.set_docu_message, project_id.Text, values["Project Number"], values["Project Title"], Activity_Manager.CurrentUser), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), project_id.Text));
            Console.WriteLine(string.Format(Database_Query.set_new_remarks, remarks_code, values["Remarks"], project_id.Text));

            Console.WriteLine(string.Format(Database_Query.set_new_docu_trans, project_id.Text, values["Agency"], values["Contractor"], values["Nature"], values["Division"], values["TAS"], remarks_code, PRIS_Status.Value, null));

            using (database_Manager)
            {
                database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_docu_infos, project_id.Text, values["Project Number"], values["Project Title"], values["Amount"], values["Period"], values["Subject"], values["Date Received"]));

                database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_history, history_code, string.Format(Log_Message.set_docu_message, project_id.Text, values["Project Number"], values["Project Title"], Activity_Manager.CurrentUser), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), project_id.Text));

                database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_remarks, remarks_code, values["Remarks"], project_id.Text));

                database_Manager.ExecuteNonQuery(string.Format(Database_Query.set_new_docu_trans, project_id.Text, values["Agency"], values["Contractor"], values["Nature"], values["Division"], values["TAS"], remarks_code, PRIS_Status.Value, null));
            }
        }


    }
}
