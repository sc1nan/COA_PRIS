using COA_PRIS.UserControlUtil.PRIS_UserControl;
using COA_PRIS.Utilities;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens.Subscreens.Maintenance
{
    public partial class View_Record : Form
    {

        private Database_Manager Database_Manager = new Database_Manager();
        private Util util = new Util();
        private Validator validator = new Validator();
        private Audit_Trail audit_Trail;

        private string Record_ID;
        private string Read_Query; 
        private string Update_Query { get; set; }
        private string Table { get; set; }

        private bool is_ClosingProgrammatically = false;

        public event Action callback;
        private Dictionary<string, string> InitialValues;

        private int status = 0;

        public View_Record(string record_ID, UserControl[] controls, string read_Query, string update_Query, string table)
        {
            InitializeComponent();
            InitializeControls(controls);
            this.Record_ID = record_ID;
            this.Read_Query = read_Query;
            this.Update_Query = update_Query;
            this.Table = table;

            Access_Manager();
            using (Database_Manager)
            {
                status = Convert.ToInt32(Database_Manager.ExecuteScalar(string.Format(Database_Query.get_record_status, Table, Record_ID)));
            }

            delete_Btn.Enabled = (status == -1 || status == -2) ? false : true;
            update_Btn.Enabled = status == -2 ? false : true;


        }

        private void Access_Manager()
        {
            DataTable ret;
            using (Database_Manager)
                ret = Database_Manager.ExecuteQuery(string.Format(Database_Query.get_user_maintenance_access, Activity_Manager.CurrentUser));

            if (ret != null)
            {
                update_Btn.Visible = ret.Rows[0][2].ToString() == "1" ? true : false;
            }

        }

        private void View_Record_Load(object sender, EventArgs e)
        {
            code_Title.Text = this.Record_ID;
            SetRecords();

        }

        private void InitializeControls(UserControl[] controls)
        {
            control_Panel.SuspendLayout();
            foreach (var control in controls)
            {
                control_Panel.Controls.Add(control);
                control.Size = new Size(control_Panel.Width, control.Height);
            }
            control_Panel.ResumeLayout(false);
            control_Panel.PerformLayout();

        }

        private void SetRecords() 
        {
            validator.PRISReadOnly(control_Panel, true);
            DataTable ret = new DataTable();
            InitialValues = new Dictionary<string, string>();

            using (Database_Manager) 
            {
                ret = Database_Manager.ExecuteQuery(string.Format(this.Read_Query, this.Record_ID));
            }

            if (ret.Columns.Count == control_Panel.Controls.Count)
                for (int control_index = 0; control_index < ret.Columns.Count; control_index++)
                    if (control_Panel.Controls[control_index] is IPRIS_UserControl)
                    {
                        var user_control = (IPRIS_UserControl)control_Panel.Controls[control_index];
                        user_control.Value = (string)ret.Rows[0][control_index];
                        InitialValues.Add(user_control.Title, user_control.Value);
                    }

                
            
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            change_ViewControls(true);
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                change_ViewControls(false); 
                SetRecords();
            }
        }

        private void change_ViewControls(bool is_Enabled = true) 
        {
            validator.PRISReadOnly(control_Panel, !is_Enabled);

            update_Btn.Enabled = !is_Enabled;
            delete_Btn.Enabled = !is_Enabled;

            this.button_Panel.Visible = is_Enabled;
            this.button_Panel.Enabled = is_Enabled;

        }

        private void audit_Trail_Btn_Click(object sender, EventArgs e)
        {
            audit_Trail = new Audit_Trail(this.Record_ID, this.Table);
            audit_Trail.ShowDialog();
        }

        private async void save_Btn_Click(object sender, EventArgs e)
        {
            string UpdateMessage = "Fields : ";

            if (!validator.PRISRequired(control_Panel, error_provider))
                return;

            if (validator.PRISUpdateCheck(parent_Panel, InitialValues).Count == 0)
            {
                MessageBox.Show("There are no changes in the project record.", "PRIS Update Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update?", "PRIS Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            foreach ((string, string, string) value in validator.PRISUpdateCheck(parent_Panel, InitialValues))
                UpdateMessage += $"{value.Item1}, ";


            int ret = 0;


            List<List<string>> entries = new List<List<string>>();

            List<string> values = new List<string>();

            foreach (Control control in control_Panel.Controls)
            {
                if (control is IPRIS_UserControl)
                {
                    var user_control = (IPRIS_UserControl)control;
                    values.Add(user_control.Value?.Trim() ?? "");
                }
            }
            values.Add(Activity_Manager.CurrentUser);
            values.Add(code_Title.Text);
            entries.Add(values);

            using (Database_Manager)
                ret = Database_Manager.ExecuteNonQuery(util.GenerateQuery(entries, Update_Query));

            Console.WriteLine(util.GenerateQuery(entries, Update_Query));
            if (ret == 1)
            {
                using (Database_Manager)
                {
                    string code_type = Database_Manager.ExecuteScalar(string.Format(Database_Query.return_module_name, Table)).ToString();
                    //make activity log
                    Database_Manager.ExecuteQuery(string.Format(Database_Query.log_maintenance_activity_edit, Activity_Manager.CurrentUser, $"Updated Record : {code_type} {code_Title.Text}"));
                }

                //Server
                await ServerManager.SendMessageToClientsAsync(code_Title.Text);

                //Client
                //await ClientManager.SendMessageAsync(project_id.Text);

                MessageBox.Show($"{code_Title.Text} is successfully Updated.", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                callback?.Invoke();
                is_ClosingProgrammatically = true;
                Close();
                
            }

        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure to delete {code_Title.Text}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                using (Database_Manager)
                {
                    Database_Manager.ExecuteNonQuery(string.Format(Database_Query.delete_record_by_id, this.Table, this.Record_ID));
                    string code_type = Database_Manager.ExecuteScalar(string.Format(Database_Query.return_module_name, Table)).ToString();
                    Database_Manager.ExecuteQuery(string.Format(Database_Query.log_maintenance_activity_delete, Activity_Manager.CurrentUser, code_type, code_Title.Text));
                }
                MessageBox.Show($"{code_Title.Text} is successfully deleted", "Delete Confirmation");
                is_ClosingProgrammatically = true;
                Close();
                callback?.Invoke();
            }

        }


        private void View_Record_FormClosing(object sender, FormClosingEventArgs e)
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
