namespace COA_PRIS.Screens
{
    partial class Audit_Trail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audit_Trail));
            this.parent_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.content_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.priS_Label_Entry1 = new COA_PRIS.UserControlUtil.PRIS_UserControl.PRIS_Label_Entry();
            this.priS_Label_Entry2 = new COA_PRIS.UserControlUtil.PRIS_UserControl.PRIS_Label_Entry();
            this.priS_Label_Entry3 = new COA_PRIS.UserControlUtil.PRIS_UserControl.PRIS_Label_Entry();
            this.priS_Label_Entry4 = new COA_PRIS.UserControlUtil.PRIS_UserControl.PRIS_Label_Entry();
            this.parent_Panel.SuspendLayout();
            this.top_Panel.SuspendLayout();
            this.content_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // parent_Panel
            // 
            this.parent_Panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_Panel.BaseColor = System.Drawing.Color.Transparent;
            this.parent_Panel.Controls.Add(this.content_Panel);
            this.parent_Panel.Controls.Add(this.gunaPanel1);
            this.parent_Panel.Controls.Add(this.top_Panel);
            resources.ApplyResources(this.parent_Panel, "parent_Panel");
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Radius = 8;
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.gunaLabel1);
            resources.ApplyResources(this.top_Panel, "top_Panel");
            this.top_Panel.Name = "top_Panel";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            resources.ApplyResources(this.gunaLabel1, "gunaLabel1");
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Name = "gunaLabel1";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            resources.ApplyResources(this.gunaPanel1, "gunaPanel1");
            this.gunaPanel1.Name = "gunaPanel1";
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.White;
            this.content_Panel.Controls.Add(this.priS_Label_Entry1);
            this.content_Panel.Controls.Add(this.priS_Label_Entry2);
            this.content_Panel.Controls.Add(this.priS_Label_Entry3);
            this.content_Panel.Controls.Add(this.priS_Label_Entry4);
            resources.ApplyResources(this.content_Panel, "content_Panel");
            this.content_Panel.Name = "content_Panel";
            // 
            // priS_Label_Entry1
            // 
            resources.ApplyResources(this.priS_Label_Entry1, "priS_Label_Entry1");
            this.priS_Label_Entry1.Name = "priS_Label_Entry1";
            this.priS_Label_Entry1.Title = "Label";
            this.priS_Label_Entry1.Value = "";
            // 
            // priS_Label_Entry2
            // 
            resources.ApplyResources(this.priS_Label_Entry2, "priS_Label_Entry2");
            this.priS_Label_Entry2.Name = "priS_Label_Entry2";
            this.priS_Label_Entry2.Title = "Label";
            this.priS_Label_Entry2.Value = "";
            // 
            // priS_Label_Entry3
            // 
            resources.ApplyResources(this.priS_Label_Entry3, "priS_Label_Entry3");
            this.priS_Label_Entry3.Name = "priS_Label_Entry3";
            this.priS_Label_Entry3.Title = "Label";
            this.priS_Label_Entry3.Value = "";
            // 
            // priS_Label_Entry4
            // 
            resources.ApplyResources(this.priS_Label_Entry4, "priS_Label_Entry4");
            this.priS_Label_Entry4.Name = "priS_Label_Entry4";
            this.priS_Label_Entry4.Title = "Label";
            this.priS_Label_Entry4.Value = "";
            // 
            // Audit_Trail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.parent_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Audit_Trail";
            this.Load += new System.EventHandler(this.Audit_Trail_Load);
            this.parent_Panel.ResumeLayout(false);
            this.top_Panel.ResumeLayout(false);
            this.content_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel parent_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.FlowLayoutPanel content_Panel;
        private UserControlUtil.PRIS_UserControl.PRIS_Label_Entry priS_Label_Entry1;
        private UserControlUtil.PRIS_UserControl.PRIS_Label_Entry priS_Label_Entry2;
        private UserControlUtil.PRIS_UserControl.PRIS_Label_Entry priS_Label_Entry3;
        private UserControlUtil.PRIS_UserControl.PRIS_Label_Entry priS_Label_Entry4;
    }
}