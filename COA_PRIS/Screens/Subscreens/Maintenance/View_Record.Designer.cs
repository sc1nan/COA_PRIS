namespace COA_PRIS.Screens.Subscreens.Maintenance
{
    partial class View_Record
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
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.config_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.audit_Trail_Btn = new Guna.UI.WinForms.GunaButton();
            this.delete_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.code_Title = new Guna.UI.WinForms.GunaLabel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.parent_Panel = new Guna.UI.WinForms.GunaPanel();
            this.controlMain_Panel = new Guna.UI.WinForms.GunaPanel();
            this.error_provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bottom_Panel = new Guna.UI.WinForms.GunaPanel();
            this.button_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.contro_Control_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.control_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.save_Btn = new Guna.UI.WinForms.GunaButton();
            this.update_Btn = new Guna.UI.WinForms.GunaButton();
            this.top_Panel.SuspendLayout();
            this.config_Panel.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.parent_Panel.SuspendLayout();
            this.controlMain_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).BeginInit();
            this.bottom_Panel.SuspendLayout();
            this.button_Panel.SuspendLayout();
            this.contro_Control_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.config_Panel);
            this.top_Panel.Controls.Add(this.gunaPanel1);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(10, 10);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(664, 60);
            this.top_Panel.TabIndex = 2;
            // 
            // config_Panel
            // 
            this.config_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.config_Panel.BackColor = System.Drawing.Color.Transparent;
            this.config_Panel.Controls.Add(this.audit_Trail_Btn);
            this.config_Panel.Controls.Add(this.update_Btn);
            this.config_Panel.Controls.Add(this.delete_Btn);
            this.config_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.config_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.config_Panel.Location = new System.Drawing.Point(220, 0);
            this.config_Panel.Name = "config_Panel";
            this.config_Panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.config_Panel.Size = new System.Drawing.Size(444, 60);
            this.config_Panel.TabIndex = 1;
            // 
            // audit_Trail_Btn
            // 
            this.audit_Trail_Btn.AnimationHoverSpeed = 0.07F;
            this.audit_Trail_Btn.AnimationSpeed = 0.03F;
            this.audit_Trail_Btn.BackColor = System.Drawing.Color.Transparent;
            this.audit_Trail_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.audit_Trail_Btn.BorderColor = System.Drawing.Color.Black;
            this.audit_Trail_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audit_Trail_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.audit_Trail_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.audit_Trail_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.audit_Trail_Btn.ForeColor = System.Drawing.Color.White;
            this.audit_Trail_Btn.Image = global::COA_PRIS.Properties.Resources.audit_icon;
            this.audit_Trail_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.audit_Trail_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.audit_Trail_Btn.Location = new System.Drawing.Point(389, 0);
            this.audit_Trail_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.audit_Trail_Btn.Name = "audit_Trail_Btn";
            this.audit_Trail_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.audit_Trail_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.audit_Trail_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.audit_Trail_Btn.OnHoverImage = null;
            this.audit_Trail_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.audit_Trail_Btn.Radius = 5;
            this.audit_Trail_Btn.Size = new System.Drawing.Size(55, 55);
            this.audit_Trail_Btn.TabIndex = 3;
            this.audit_Trail_Btn.Click += new System.EventHandler(this.audit_Trail_Btn_Click);
            // 
            // delete_Btn
            // 
            this.delete_Btn.AnimationHoverSpeed = 0.07F;
            this.delete_Btn.AnimationSpeed = 0.03F;
            this.delete_Btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.delete_Btn.BorderColor = System.Drawing.Color.Black;
            this.delete_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.delete_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Btn.ForeColor = System.Drawing.Color.White;
            this.delete_Btn.Image = global::COA_PRIS.Properties.Resources.trash_bin;
            this.delete_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.delete_Btn.Location = new System.Drawing.Point(184, 0);
            this.delete_Btn.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.delete_Btn.Name = "delete_Btn";
            this.delete_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.delete_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delete_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.delete_Btn.OnHoverImage = null;
            this.delete_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.delete_Btn.Radius = 5;
            this.delete_Btn.Size = new System.Drawing.Size(55, 55);
            this.delete_Btn.TabIndex = 4;
            this.delete_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_Btn.Click += new System.EventHandler(this.delete_Btn_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaPanel1.Controls.Add(this.code_Title);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(220, 60);
            this.gunaPanel1.TabIndex = 0;
            // 
            // code_Title
            // 
            this.code_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code_Title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_Title.ForeColor = System.Drawing.Color.White;
            this.code_Title.Location = new System.Drawing.Point(0, 0);
            this.code_Title.Name = "code_Title";
            this.code_Title.Size = new System.Drawing.Size(220, 60);
            this.code_Title.TabIndex = 0;
            this.code_Title.Text = "ABC000000000";
            this.code_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(10, 70);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(664, 5);
            this.line_Panel.TabIndex = 3;
            // 
            // parent_Panel
            // 
            this.parent_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.parent_Panel.Controls.Add(this.controlMain_Panel);
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(10, 75);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Padding = new System.Windows.Forms.Padding(8);
            this.parent_Panel.Size = new System.Drawing.Size(664, 576);
            this.parent_Panel.TabIndex = 4;
            // 
            // controlMain_Panel
            // 
            this.controlMain_Panel.Controls.Add(this.contro_Control_Panel);
            this.controlMain_Panel.Controls.Add(this.bottom_Panel);
            this.controlMain_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMain_Panel.Location = new System.Drawing.Point(8, 8);
            this.controlMain_Panel.Name = "controlMain_Panel";
            this.controlMain_Panel.Size = new System.Drawing.Size(648, 560);
            this.controlMain_Panel.TabIndex = 3;
            // 
            // error_provider
            // 
            this.error_provider.BlinkRate = 0;
            this.error_provider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_provider.ContainerControl = this;
            // 
            // bottom_Panel
            // 
            this.bottom_Panel.Controls.Add(this.button_Panel);
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_Panel.Location = new System.Drawing.Point(0, 498);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Size = new System.Drawing.Size(648, 62);
            this.bottom_Panel.TabIndex = 9;
            // 
            // button_Panel
            // 
            this.button_Panel.ColumnCount = 2;
            this.button_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.button_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.button_Panel.Controls.Add(this.save_Btn, 0, 0);
            this.button_Panel.Controls.Add(this.cancel_Btn, 0, 0);
            this.button_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Panel.Location = new System.Drawing.Point(0, 0);
            this.button_Panel.Margin = new System.Windows.Forms.Padding(8);
            this.button_Panel.Name = "button_Panel";
            this.button_Panel.RowCount = 1;
            this.button_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.07207F));
            this.button_Panel.Size = new System.Drawing.Size(648, 62);
            this.button_Panel.TabIndex = 8;
            this.button_Panel.Visible = false;
            // 
            // contro_Control_Panel
            // 
            this.contro_Control_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contro_Control_Panel.BackColor = System.Drawing.Color.Transparent;
            this.contro_Control_Panel.BaseColor = System.Drawing.Color.White;
            this.contro_Control_Panel.Controls.Add(this.control_Panel);
            this.contro_Control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contro_Control_Panel.Location = new System.Drawing.Point(0, 0);
            this.contro_Control_Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.contro_Control_Panel.Name = "contro_Control_Panel";
            this.contro_Control_Panel.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.contro_Control_Panel.Radius = 8;
            this.contro_Control_Panel.Size = new System.Drawing.Size(648, 498);
            this.contro_Control_Panel.TabIndex = 10;
            // 
            // control_Panel
            // 
            this.control_Panel.AutoSize = true;
            this.control_Panel.BackColor = System.Drawing.Color.Transparent;
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.control_Panel.Location = new System.Drawing.Point(10, 5);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Size = new System.Drawing.Size(633, 483);
            this.control_Panel.TabIndex = 5;
            this.control_Panel.WrapContents = false;
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.AnimationHoverSpeed = 0.07F;
            this.cancel_Btn.AnimationSpeed = 0.03F;
            this.cancel_Btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.cancel_Btn.BorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancel_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.cancel_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Image = global::COA_PRIS.Properties.Resources.close;
            this.cancel_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.cancel_Btn.Location = new System.Drawing.Point(0, 8);
            this.cancel_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.cancel_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancel_Btn.OnHoverImage = null;
            this.cancel_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.cancel_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_Btn.Radius = 8;
            this.cancel_Btn.Size = new System.Drawing.Size(130, 54);
            this.cancel_Btn.TabIndex = 10;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // save_Btn
            // 
            this.save_Btn.AnimationHoverSpeed = 0.07F;
            this.save_Btn.AnimationSpeed = 0.03F;
            this.save_Btn.BackColor = System.Drawing.Color.Transparent;
            this.save_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.save_Btn.BorderColor = System.Drawing.Color.Black;
            this.save_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.save_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Btn.ForeColor = System.Drawing.Color.White;
            this.save_Btn.Image = null;
            this.save_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.save_Btn.Location = new System.Drawing.Point(481, 8);
            this.save_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.save_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Btn.OnHoverImage = null;
            this.save_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.save_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.save_Btn.Radius = 8;
            this.save_Btn.Size = new System.Drawing.Size(167, 54);
            this.save_Btn.TabIndex = 11;
            this.save_Btn.Text = "Confirm Update";
            this.save_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // update_Btn
            // 
            this.update_Btn.AnimationHoverSpeed = 0.07F;
            this.update_Btn.AnimationSpeed = 0.03F;
            this.update_Btn.BackColor = System.Drawing.Color.Transparent;
            this.update_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.update_Btn.BorderColor = System.Drawing.Color.Black;
            this.update_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.update_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.update_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Btn.ForeColor = System.Drawing.Color.White;
            this.update_Btn.Image = global::COA_PRIS.Properties.Resources.update;
            this.update_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_Btn.ImageSize = new System.Drawing.Size(40, 40);
            this.update_Btn.Location = new System.Drawing.Point(244, 0);
            this.update_Btn.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.update_Btn.Name = "update_Btn";
            this.update_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.update_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.update_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.update_Btn.OnHoverImage = null;
            this.update_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.update_Btn.Radius = 5;
            this.update_Btn.Size = new System.Drawing.Size(140, 55);
            this.update_Btn.TabIndex = 9;
            this.update_Btn.Text = "Update";
            this.update_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_Btn.Click += new System.EventHandler(this.update_Btn_Click);
            // 
            // View_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.parent_Panel);
            this.Controls.Add(this.line_Panel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Record";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Record_FormClosing);
            this.Load += new System.EventHandler(this.View_Record_Load);
            this.top_Panel.ResumeLayout(false);
            this.config_Panel.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.parent_Panel.ResumeLayout(false);
            this.controlMain_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).EndInit();
            this.bottom_Panel.ResumeLayout(false);
            this.button_Panel.ResumeLayout(false);
            this.contro_Control_Panel.ResumeLayout(false);
            this.contro_Control_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel parent_Panel;
        private Guna.UI.WinForms.GunaPanel controlMain_Panel;
        private Guna.UI.WinForms.GunaLabel code_Title;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.ErrorProvider error_provider;
        private System.Windows.Forms.FlowLayoutPanel config_Panel;
        private Guna.UI.WinForms.GunaButton audit_Trail_Btn;
        private Guna.UI.WinForms.GunaButton delete_Btn;
        private Guna.UI.WinForms.GunaPanel bottom_Panel;
        private System.Windows.Forms.TableLayoutPanel button_Panel;
        private Guna.UI.WinForms.GunaElipsePanel contro_Control_Panel;
        private System.Windows.Forms.FlowLayoutPanel control_Panel;
        private Guna.UI.WinForms.GunaButton save_Btn;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaButton update_Btn;
    }
}