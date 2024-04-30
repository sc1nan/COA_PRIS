namespace COA_PRIS.Screens
{
    partial class User
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
            this.nav_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.user_Btn = new Guna.UI.WinForms.GunaButton();
            this.roles_Btn = new Guna.UI.WinForms.GunaButton();
            this.deactive_Btn = new Guna.UI.WinForms.GunaButton();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.container_Panel = new Guna.UI.WinForms.GunaPanel();
            this.nav_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nav_Panel
            // 
            this.nav_Panel.Controls.Add(this.user_Btn);
            this.nav_Panel.Controls.Add(this.roles_Btn);
            this.nav_Panel.Controls.Add(this.deactive_Btn);
            this.nav_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_Panel.Location = new System.Drawing.Point(10, 10);
            this.nav_Panel.Name = "nav_Panel";
            this.nav_Panel.Size = new System.Drawing.Size(1520, 55);
            this.nav_Panel.TabIndex = 3;
            // 
            // user_Btn
            // 
            this.user_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.user_Btn.AnimationHoverSpeed = 0.07F;
            this.user_Btn.AnimationSpeed = 0.03F;
            this.user_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.user_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.user_Btn.BorderColor = System.Drawing.Color.Black;
            this.user_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.user_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.user_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.user_Btn.ForeColor = System.Drawing.Color.White;
            this.user_Btn.Image = global::COA_PRIS.Properties.Resources.group;
            this.user_Btn.ImageOffsetX = 5;
            this.user_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.user_Btn.Location = new System.Drawing.Point(0, 0);
            this.user_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.user_Btn.Name = "user_Btn";
            this.user_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.user_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.user_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.user_Btn.OnHoverImage = null;
            this.user_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.user_Btn.Size = new System.Drawing.Size(200, 55);
            this.user_Btn.TabIndex = 3;
            this.user_Btn.Text = "USERS";
            this.user_Btn.TextOffsetX = 5;
            this.user_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // roles_Btn
            // 
            this.roles_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roles_Btn.AnimationHoverSpeed = 0.07F;
            this.roles_Btn.AnimationSpeed = 0.03F;
            this.roles_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.roles_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.roles_Btn.BorderColor = System.Drawing.Color.Black;
            this.roles_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roles_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.roles_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.roles_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.roles_Btn.ForeColor = System.Drawing.Color.White;
            this.roles_Btn.Image = global::COA_PRIS.Properties.Resources.settings;
            this.roles_Btn.ImageOffsetX = 5;
            this.roles_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.roles_Btn.Location = new System.Drawing.Point(201, 0);
            this.roles_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.roles_Btn.Name = "roles_Btn";
            this.roles_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.roles_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.roles_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.roles_Btn.OnHoverImage = null;
            this.roles_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.roles_Btn.Size = new System.Drawing.Size(200, 55);
            this.roles_Btn.TabIndex = 6;
            this.roles_Btn.Text = "ROLES";
            this.roles_Btn.TextOffsetX = 5;
            this.roles_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // deactive_Btn
            // 
            this.deactive_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deactive_Btn.AnimationHoverSpeed = 0.07F;
            this.deactive_Btn.AnimationSpeed = 0.03F;
            this.deactive_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.deactive_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.deactive_Btn.BorderColor = System.Drawing.Color.Black;
            this.deactive_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deactive_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deactive_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.deactive_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.deactive_Btn.ForeColor = System.Drawing.Color.White;
            this.deactive_Btn.Image = global::COA_PRIS.Properties.Resources.moon;
            this.deactive_Btn.ImageOffsetX = 5;
            this.deactive_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.deactive_Btn.Location = new System.Drawing.Point(402, 0);
            this.deactive_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.deactive_Btn.Name = "deactive_Btn";
            this.deactive_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.deactive_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deactive_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.deactive_Btn.OnHoverImage = null;
            this.deactive_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.deactive_Btn.Size = new System.Drawing.Size(200, 55);
            this.deactive_Btn.TabIndex = 5;
            this.deactive_Btn.Text = "DEACTIVATED";
            this.deactive_Btn.TextOffsetX = 5;
            this.deactive_Btn.Click += new System.EventHandler(this.button_Click);
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(10, 65);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(1520, 5);
            this.line_Panel.TabIndex = 4;
            // 
            // container_Panel
            // 
            this.container_Panel.BackColor = System.Drawing.Color.White;
            this.container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Panel.Location = new System.Drawing.Point(10, 70);
            this.container_Panel.Name = "container_Panel";
            this.container_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.container_Panel.Size = new System.Drawing.Size(1520, 765);
            this.container_Panel.TabIndex = 5;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.container_Panel);
            this.Controls.Add(this.line_Panel);
            this.Controls.Add(this.nav_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.nav_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel nav_Panel;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel container_Panel;
        private Guna.UI.WinForms.GunaButton user_Btn;
        private Guna.UI.WinForms.GunaButton deactive_Btn;
        private Guna.UI.WinForms.GunaButton roles_Btn;
    }
}