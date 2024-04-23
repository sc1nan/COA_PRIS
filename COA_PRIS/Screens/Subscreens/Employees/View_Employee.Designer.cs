namespace COA_PRIS.Screens.Subscreens.Employees
{
    partial class View_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Employee));
            this.parent_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.main_Panel = new Guna.UI.WinForms.GunaPanel();
            this.control_main_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.control_Panel = new Guna.UI.WinForms.GunaPanel();
            this.error_Panel = new Guna.UI.WinForms.GunaPanel();
            this.error_Message = new Guna.UI.WinForms.GunaLabel();
            this.bottom_Panel = new Guna.UI.WinForms.GunaPanel();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.save_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.config_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.audit_Trail_Btn = new Guna.UI.WinForms.GunaButton();
            this.update_Btn = new Guna.UI.WinForms.GunaButton();
            this.delete_Btn = new Guna.UI.WinForms.GunaButton();
            this.emp_id = new Guna.UI.WinForms.GunaLabel();
            this._error = new System.Windows.Forms.ErrorProvider(this.components);
            this.parent_Panel.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.main_Panel.SuspendLayout();
            this.control_main_Panel.SuspendLayout();
            this.error_Panel.SuspendLayout();
            this.bottom_Panel.SuspendLayout();
            this.top_Panel.SuspendLayout();
            this.config_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._error)).BeginInit();
            this.SuspendLayout();
            // 
            // parent_Panel
            // 
            this.parent_Panel.AutoSize = true;
            this.parent_Panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_Panel.Controls.Add(this.gunaPanel4);
            this.parent_Panel.Controls.Add(this.gunaPanel3);
            this.parent_Panel.Controls.Add(this.top_Panel);
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(8, 8);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Size = new System.Drawing.Size(1088, 745);
            this.parent_Panel.TabIndex = 1;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel4.Controls.Add(this.main_Panel);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 60);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Padding = new System.Windows.Forms.Padding(8);
            this.gunaPanel4.Size = new System.Drawing.Size(1088, 685);
            this.gunaPanel4.TabIndex = 3;
            // 
            // main_Panel
            // 
            this.main_Panel.Controls.Add(this.control_main_Panel);
            this.main_Panel.Controls.Add(this.bottom_Panel);
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(8, 8);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(1072, 669);
            this.main_Panel.TabIndex = 1;
            // 
            // control_main_Panel
            // 
            this.control_main_Panel.BackColor = System.Drawing.Color.Transparent;
            this.control_main_Panel.BaseColor = System.Drawing.Color.White;
            this.control_main_Panel.Controls.Add(this.control_Panel);
            this.control_main_Panel.Controls.Add(this.error_Panel);
            this.control_main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_main_Panel.Location = new System.Drawing.Point(0, 0);
            this.control_main_Panel.Name = "control_main_Panel";
            this.control_main_Panel.Padding = new System.Windows.Forms.Padding(15, 20, 15, 5);
            this.control_main_Panel.Size = new System.Drawing.Size(1072, 609);
            this.control_main_Panel.TabIndex = 3;
            // 
            // control_Panel
            // 
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(15, 20);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Size = new System.Drawing.Size(1042, 552);
            this.control_Panel.TabIndex = 1;
            // 
            // error_Panel
            // 
            this.error_Panel.Controls.Add(this.error_Message);
            this.error_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.error_Panel.Location = new System.Drawing.Point(15, 572);
            this.error_Panel.Name = "error_Panel";
            this.error_Panel.Size = new System.Drawing.Size(1042, 32);
            this.error_Panel.TabIndex = 0;
            // 
            // error_Message
            // 
            this.error_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.error_Message.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_Message.ForeColor = System.Drawing.Color.Red;
            this.error_Message.Location = new System.Drawing.Point(0, 0);
            this.error_Message.Margin = new System.Windows.Forms.Padding(3);
            this.error_Message.Name = "error_Message";
            this.error_Message.Padding = new System.Windows.Forms.Padding(5);
            this.error_Message.Size = new System.Drawing.Size(1042, 32);
            this.error_Message.TabIndex = 4;
            this.error_Message.Text = "Error Message";
            this.error_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_Message.Visible = false;
            // 
            // bottom_Panel
            // 
            this.bottom_Panel.BackColor = System.Drawing.Color.Transparent;
            this.bottom_Panel.Controls.Add(this.cancel_Btn);
            this.bottom_Panel.Controls.Add(this.save_Btn);
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_Panel.Location = new System.Drawing.Point(0, 609);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.bottom_Panel.Size = new System.Drawing.Size(1072, 60);
            this.bottom_Panel.TabIndex = 2;
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.AnimationHoverSpeed = 0.07F;
            this.cancel_Btn.AnimationSpeed = 0.03F;
            this.cancel_Btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.cancel_Btn.BorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancel_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.cancel_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Image = null;
            this.cancel_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancel_Btn.Location = new System.Drawing.Point(0, 8);
            this.cancel_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cancel_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancel_Btn.OnHoverImage = null;
            this.cancel_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.cancel_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_Btn.Radius = 8;
            this.cancel_Btn.Size = new System.Drawing.Size(160, 52);
            this.cancel_Btn.TabIndex = 2;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancel_Btn.Visible = false;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // save_Btn
            // 
            this.save_Btn.AnimationHoverSpeed = 0.07F;
            this.save_Btn.AnimationSpeed = 0.03F;
            this.save_Btn.BackColor = System.Drawing.Color.Transparent;
            this.save_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.save_Btn.BorderColor = System.Drawing.Color.Black;
            this.save_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.save_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Btn.ForeColor = System.Drawing.Color.White;
            this.save_Btn.Image = null;
            this.save_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.save_Btn.Location = new System.Drawing.Point(912, 8);
            this.save_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.save_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Btn.OnHoverImage = null;
            this.save_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.save_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.save_Btn.Radius = 8;
            this.save_Btn.Size = new System.Drawing.Size(160, 52);
            this.save_Btn.TabIndex = 3;
            this.save_Btn.Text = "Update Record";
            this.save_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Btn.Visible = false;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 55);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1088, 5);
            this.gunaPanel3.TabIndex = 1;
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.config_Panel);
            this.top_Panel.Controls.Add(this.emp_id);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1088, 55);
            this.top_Panel.TabIndex = 2;
            // 
            // config_Panel
            // 
            this.config_Panel.AutoSize = true;
            this.config_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.config_Panel.BackColor = System.Drawing.Color.Transparent;
            this.config_Panel.Controls.Add(this.audit_Trail_Btn);
            this.config_Panel.Controls.Add(this.update_Btn);
            this.config_Panel.Controls.Add(this.delete_Btn);
            this.config_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.config_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.config_Panel.Location = new System.Drawing.Point(883, 0);
            this.config_Panel.Name = "config_Panel";
            this.config_Panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.config_Panel.Size = new System.Drawing.Size(205, 55);
            this.config_Panel.TabIndex = 2;
            // 
            // audit_Trail_Btn
            // 
            this.audit_Trail_Btn.AnimationHoverSpeed = 0.07F;
            this.audit_Trail_Btn.AnimationSpeed = 0.03F;
            this.audit_Trail_Btn.BackColor = System.Drawing.Color.Transparent;
            this.audit_Trail_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.audit_Trail_Btn.BorderColor = System.Drawing.Color.Black;
            this.audit_Trail_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.audit_Trail_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.audit_Trail_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.audit_Trail_Btn.ForeColor = System.Drawing.Color.White;
            this.audit_Trail_Btn.Image = ((System.Drawing.Image)(resources.GetObject("audit_Trail_Btn.Image")));
            this.audit_Trail_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.audit_Trail_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.audit_Trail_Btn.Location = new System.Drawing.Point(155, 5);
            this.audit_Trail_Btn.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.audit_Trail_Btn.Name = "audit_Trail_Btn";
            this.audit_Trail_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.audit_Trail_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.audit_Trail_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.audit_Trail_Btn.OnHoverImage = null;
            this.audit_Trail_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.audit_Trail_Btn.Radius = 5;
            this.audit_Trail_Btn.Size = new System.Drawing.Size(45, 45);
            this.audit_Trail_Btn.TabIndex = 3;
            this.audit_Trail_Btn.Click += new System.EventHandler(this.audit_Trail_Btn_Click);
            // 
            // update_Btn
            // 
            this.update_Btn.AnimationHoverSpeed = 0.07F;
            this.update_Btn.AnimationSpeed = 0.03F;
            this.update_Btn.BackColor = System.Drawing.Color.Transparent;
            this.update_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.update_Btn.BorderColor = System.Drawing.Color.Black;
            this.update_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.update_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.update_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Btn.ForeColor = System.Drawing.Color.White;
            this.update_Btn.Image = null;
            this.update_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.update_Btn.Location = new System.Drawing.Point(50, 5);
            this.update_Btn.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.update_Btn.Name = "update_Btn";
            this.update_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.update_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.update_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.update_Btn.OnHoverImage = null;
            this.update_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.update_Btn.Radius = 5;
            this.update_Btn.Size = new System.Drawing.Size(100, 45);
            this.update_Btn.TabIndex = 5;
            this.update_Btn.Text = "Update";
            this.update_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_Btn.Click += new System.EventHandler(this.update_Btn_Click);
            // 
            // delete_Btn
            // 
            this.delete_Btn.AnimationHoverSpeed = 0.07F;
            this.delete_Btn.AnimationSpeed = 0.03F;
            this.delete_Btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.delete_Btn.BorderColor = System.Drawing.Color.Black;
            this.delete_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.delete_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Btn.ForeColor = System.Drawing.Color.White;
            this.delete_Btn.Image = global::COA_PRIS.Properties.Resources.trash_bin;
            this.delete_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.delete_Btn.Location = new System.Drawing.Point(0, 5);
            this.delete_Btn.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.delete_Btn.Name = "delete_Btn";
            this.delete_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.delete_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delete_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.delete_Btn.OnHoverImage = null;
            this.delete_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.delete_Btn.Radius = 5;
            this.delete_Btn.Size = new System.Drawing.Size(45, 45);
            this.delete_Btn.TabIndex = 4;
            this.delete_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_Btn.Click += new System.EventHandler(this.delete_Btn_Click);
            // 
            // emp_id
            // 
            this.emp_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.emp_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.emp_id.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_id.ForeColor = System.Drawing.Color.White;
            this.emp_id.Location = new System.Drawing.Point(0, 0);
            this.emp_id.Margin = new System.Windows.Forms.Padding(0);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(267, 55);
            this.emp_id.TabIndex = 0;
            this.emp_id.Text = "New Employee Record";
            this.emp_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _error
            // 
            this._error.BlinkRate = 0;
            this._error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._error.ContainerControl = this;
            // 
            // View_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 761);
            this.Controls.Add(this.parent_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Employee";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Employee_FormClosing);
            this.parent_Panel.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.main_Panel.ResumeLayout(false);
            this.control_main_Panel.ResumeLayout(false);
            this.error_Panel.ResumeLayout(false);
            this.bottom_Panel.ResumeLayout(false);
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            this.config_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel parent_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaPanel main_Panel;
        private Guna.UI.WinForms.GunaElipsePanel control_main_Panel;
        private Guna.UI.WinForms.GunaPanel bottom_Panel;
        private Guna.UI.WinForms.GunaButton save_Btn;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaLabel emp_id;
        private System.Windows.Forms.FlowLayoutPanel config_Panel;
        private Guna.UI.WinForms.GunaButton audit_Trail_Btn;
        private Guna.UI.WinForms.GunaButton update_Btn;
        private Guna.UI.WinForms.GunaButton delete_Btn;
        private System.Windows.Forms.ErrorProvider _error;
        private Guna.UI.WinForms.GunaPanel control_Panel;
        private Guna.UI.WinForms.GunaPanel error_Panel;
        private Guna.UI.WinForms.GunaLabel error_Message;
    }
}