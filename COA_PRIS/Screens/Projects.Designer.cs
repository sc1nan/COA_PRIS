namespace COA_PRIS.Screens
{
    partial class Projects
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
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.record_Btn = new Guna.UI.WinForms.GunaButton();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.container_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.Transparent;
            this.nav_panel.Controls.Add(this.record_Btn);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(10, 10);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(1536, 60);
            this.nav_panel.TabIndex = 2;
            // 
            // record_Btn
            // 
            this.record_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.record_Btn.AnimationHoverSpeed = 0.07F;
            this.record_Btn.AnimationSpeed = 0.03F;
            this.record_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.record_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.record_Btn.BorderColor = System.Drawing.Color.Black;
            this.record_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.record_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.record_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.record_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.record_Btn.ForeColor = System.Drawing.Color.White;
            this.record_Btn.Image = global::COA_PRIS.Properties.Resources.document;
            this.record_Btn.ImageOffsetX = 5;
            this.record_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.record_Btn.Location = new System.Drawing.Point(0, 0);
            this.record_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.record_Btn.Name = "record_Btn";
            this.record_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.record_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.record_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.record_Btn.OnHoverImage = null;
            this.record_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.record_Btn.Size = new System.Drawing.Size(200, 60);
            this.record_Btn.TabIndex = 2;
            this.record_Btn.Text = "PROJECTS";
            this.record_Btn.TextOffsetX = 5;
            this.record_Btn.Click += new System.EventHandler(this.button_Clicked);
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(10, 70);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(1536, 5);
            this.line_Panel.TabIndex = 3;
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.White;
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(10, 75);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.container_Panel.Size = new System.Drawing.Size(1536, 799);
            this.container_Panel.TabIndex = 4;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.container_Panel);
            this.Controls.Add(this.line_Panel);
            this.Controls.Add(this.nav_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projects";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Guna.UI.WinForms.GunaButton record_Btn;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel container_Panel;
    }
}