namespace COA_PRIS.Screens.Subscreens.Projects
{
    partial class Project_Create
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
            this.components = new System.ComponentModel.Container();
            this.bottom_Panel = new Guna.UI.WinForms.GunaPanel();
            this.create_Btn = new Guna.UI.WinForms.GunaButton();
            this.body_Panel = new Guna.UI.WinForms.GunaPanel();
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.error_Panel = new Guna.UI.WinForms.GunaPanel();
            this.control_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.id_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.project_id = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.status_Panel = new Guna.UI.WinForms.GunaPanel();
            this.bottom_Panel.SuspendLayout();
            this.body_Panel.SuspendLayout();
            this.content_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).BeginInit();
            this.id_Panel.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottom_Panel
            // 
            this.bottom_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottom_Panel.Controls.Add(this.create_Btn);
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_Panel.Location = new System.Drawing.Point(0, 843);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.bottom_Panel.Size = new System.Drawing.Size(1591, 58);
            this.bottom_Panel.TabIndex = 5;
            // 
            // create_Btn
            // 
            this.create_Btn.AnimationHoverSpeed = 0.07F;
            this.create_Btn.AnimationSpeed = 0.03F;
            this.create_Btn.BackColor = System.Drawing.Color.Transparent;
            this.create_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.create_Btn.BorderColor = System.Drawing.Color.Black;
            this.create_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.create_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.create_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.create_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Btn.ForeColor = System.Drawing.Color.White;
            this.create_Btn.Image = null;
            this.create_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.create_Btn.Location = new System.Drawing.Point(1403, 0);
            this.create_Btn.Name = "create_Btn";
            this.create_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.create_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.create_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.create_Btn.OnHoverImage = null;
            this.create_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.create_Btn.Radius = 8;
            this.create_Btn.Size = new System.Drawing.Size(180, 50);
            this.create_Btn.TabIndex = 0;
            this.create_Btn.Text = "Create Record";
            this.create_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.create_Btn.Click += new System.EventHandler(this.create_Btn_Click);
            // 
            // body_Panel
            // 
            this.body_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.body_Panel.Controls.Add(this.content_Panel);
            this.body_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_Panel.Location = new System.Drawing.Point(0, 58);
            this.body_Panel.Name = "body_Panel";
            this.body_Panel.Padding = new System.Windows.Forms.Padding(8);
            this.body_Panel.Size = new System.Drawing.Size(1591, 785);
            this.body_Panel.TabIndex = 6;
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.White;
            this.content_Panel.Controls.Add(this.error_Panel);
            this.content_Panel.Controls.Add(this.control_Panel);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(8, 8);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(1575, 769);
            this.content_Panel.TabIndex = 0;
            // 
            // error_Panel
            // 
            this.error_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.error_Panel.Location = new System.Drawing.Point(0, 737);
            this.error_Panel.Name = "error_Panel";
            this.error_Panel.Size = new System.Drawing.Size(1575, 32);
            this.error_Panel.TabIndex = 1;
            // 
            // control_Panel
            // 
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(0, 0);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.control_Panel.Size = new System.Drawing.Size(1575, 769);
            this.control_Panel.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this.content_Panel;
            // 
            // error_Provider
            // 
            this.error_Provider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_Provider.ContainerControl = this;
            // 
            // id_Panel
            // 
            this.id_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.id_Panel.Controls.Add(this.gunaElipsePanel1);
            this.id_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.id_Panel.Location = new System.Drawing.Point(0, 0);
            this.id_Panel.Name = "id_Panel";
            this.id_Panel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.id_Panel.Size = new System.Drawing.Size(260, 58);
            this.id_Panel.TabIndex = 0;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.project_id);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(8, 8);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 8;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(244, 50);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // project_id
            // 
            this.project_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.project_id.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_id.Location = new System.Drawing.Point(0, 0);
            this.project_id.Name = "project_id";
            this.project_id.Size = new System.Drawing.Size(244, 50);
            this.project_id.TabIndex = 0;
            this.project_id.Text = "PRJ000000000";
            this.project_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoSize = true;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel1.Location = new System.Drawing.Point(1591, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.gunaPanel1.Size = new System.Drawing.Size(0, 58);
            this.gunaPanel1.TabIndex = 1;
            // 
            // top_Panel
            // 
            this.top_Panel.BackColor = System.Drawing.Color.White;
            this.top_Panel.Controls.Add(this.status_Panel);
            this.top_Panel.Controls.Add(this.gunaPanel1);
            this.top_Panel.Controls.Add(this.id_Panel);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1591, 58);
            this.top_Panel.TabIndex = 2;
            // 
            // status_Panel
            // 
            this.status_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.status_Panel.BackColor = System.Drawing.Color.Transparent;
            this.status_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.status_Panel.Location = new System.Drawing.Point(1291, 0);
            this.status_Panel.Name = "status_Panel";
            this.status_Panel.Size = new System.Drawing.Size(300, 58);
            this.status_Panel.TabIndex = 2;
            // 
            // Project_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1591, 901);
            this.Controls.Add(this.body_Panel);
            this.Controls.Add(this.bottom_Panel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project_Create";
            this.Text = "Project_Create";
            this.bottom_Panel.ResumeLayout(false);
            this.body_Panel.ResumeLayout(false);
            this.content_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_Provider)).EndInit();
            this.id_Panel.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel bottom_Panel;
        private Guna.UI.WinForms.GunaPanel body_Panel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton create_Btn;
        private System.Windows.Forms.ErrorProvider error_Provider;
        private Guna.UI.WinForms.GunaPanel content_Panel;
        private Guna.UI.WinForms.GunaPanel error_Panel;
        private Guna.UI.WinForms.GunaPanel control_Panel;
        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaPanel status_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel id_Panel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel project_id;
    }
}