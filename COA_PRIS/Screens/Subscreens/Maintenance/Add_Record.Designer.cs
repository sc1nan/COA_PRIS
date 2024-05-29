namespace COA_PRIS.Screens.Subscreens.Maintenance
{
    partial class Add_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Record));
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.line_Panel = new Guna.UI.WinForms.GunaPanel();
            this.parent_Panel = new Guna.UI.WinForms.GunaPanel();
            this.content_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.control_Panel = new Guna.UI.WinForms.GunaPanel();
            this.control_Bottom = new Guna.UI.WinForms.GunaPanel();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.create_Btn = new Guna.UI.WinForms.GunaButton();
            this.control_Top = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.code_Title = new Guna.UI.WinForms.GunaLabel();
            this.error_provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.top_Panel.SuspendLayout();
            this.parent_Panel.SuspendLayout();
            this.content_Panel.SuspendLayout();
            this.control_Bottom.SuspendLayout();
            this.control_Top.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).BeginInit();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.title);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(10, 10);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(664, 50);
            this.top_Panel.TabIndex = 1;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(220, 50);
            this.title.TabIndex = 0;
            this.title.Text = "New Record";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line_Panel
            // 
            this.line_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.line_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.line_Panel.Location = new System.Drawing.Point(10, 60);
            this.line_Panel.Name = "line_Panel";
            this.line_Panel.Size = new System.Drawing.Size(664, 5);
            this.line_Panel.TabIndex = 2;
            // 
            // parent_Panel
            // 
            this.parent_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.parent_Panel.Controls.Add(this.content_Panel);
            this.parent_Panel.Controls.Add(this.control_Bottom);
            this.parent_Panel.Controls.Add(this.control_Top);
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(10, 65);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Padding = new System.Windows.Forms.Padding(8);
            this.parent_Panel.Size = new System.Drawing.Size(664, 636);
            this.parent_Panel.TabIndex = 3;
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.Transparent;
            this.content_Panel.BaseColor = System.Drawing.Color.White;
            this.content_Panel.Controls.Add(this.control_Panel);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(8, 71);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.content_Panel.Radius = 8;
            this.content_Panel.Size = new System.Drawing.Size(648, 494);
            this.content_Panel.TabIndex = 4;
            // 
            // control_Panel
            // 
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(10, 5);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Size = new System.Drawing.Size(633, 479);
            this.control_Panel.TabIndex = 1;
            // 
            // control_Bottom
            // 
            this.control_Bottom.Controls.Add(this.cancel_Btn);
            this.control_Bottom.Controls.Add(this.create_Btn);
            this.control_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.control_Bottom.Location = new System.Drawing.Point(8, 565);
            this.control_Bottom.Margin = new System.Windows.Forms.Padding(5);
            this.control_Bottom.Name = "control_Bottom";
            this.control_Bottom.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.control_Bottom.Size = new System.Drawing.Size(648, 63);
            this.control_Bottom.TabIndex = 3;
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
            this.cancel_Btn.Size = new System.Drawing.Size(130, 55);
            this.cancel_Btn.TabIndex = 9;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // create_Btn
            // 
            this.create_Btn.AnimationHoverSpeed = 0.07F;
            this.create_Btn.AnimationSpeed = 0.03F;
            this.create_Btn.BackColor = System.Drawing.Color.Transparent;
            this.create_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.create_Btn.BorderColor = System.Drawing.Color.Black;
            this.create_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.create_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.create_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.create_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Btn.ForeColor = System.Drawing.Color.White;
            this.create_Btn.Image = global::COA_PRIS.Properties.Resources.add_file;
            this.create_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.create_Btn.Location = new System.Drawing.Point(518, 8);
            this.create_Btn.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.create_Btn.Name = "create_Btn";
            this.create_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.create_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.create_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.create_Btn.OnHoverImage = null;
            this.create_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.create_Btn.Radius = 8;
            this.create_Btn.Size = new System.Drawing.Size(130, 55);
            this.create_Btn.TabIndex = 8;
            this.create_Btn.Text = "Create";
            this.create_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // control_Top
            // 
            this.control_Top.Controls.Add(this.gunaElipsePanel1);
            this.control_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.control_Top.Location = new System.Drawing.Point(8, 8);
            this.control_Top.Margin = new System.Windows.Forms.Padding(5);
            this.control_Top.Name = "control_Top";
            this.control_Top.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.control_Top.Size = new System.Drawing.Size(648, 63);
            this.control_Top.TabIndex = 2;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.code_Title);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 8;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(212, 55);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // code_Title
            // 
            this.code_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code_Title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_Title.Location = new System.Drawing.Point(0, 0);
            this.code_Title.Name = "code_Title";
            this.code_Title.Size = new System.Drawing.Size(212, 55);
            this.code_Title.TabIndex = 0;
            this.code_Title.Text = "ABC000000000";
            this.code_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error_provider
            // 
            this.error_provider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_provider.ContainerControl = this;
            // 
            // Add_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.parent_Panel);
            this.Controls.Add(this.line_Panel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 680);
            this.Name = "Add_Record";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIS Add Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Record_FormClosing);
            this.Load += new System.EventHandler(this.Add_Agency_Load);
            this.top_Panel.ResumeLayout(false);
            this.parent_Panel.ResumeLayout(false);
            this.content_Panel.ResumeLayout(false);
            this.control_Bottom.ResumeLayout(false);
            this.control_Top.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaPanel line_Panel;
        private Guna.UI.WinForms.GunaPanel parent_Panel;
        private Guna.UI.WinForms.GunaPanel control_Top;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaLabel code_Title;
        private System.Windows.Forms.ErrorProvider error_provider;
        private Guna.UI.WinForms.GunaPanel control_Bottom;
        private Guna.UI.WinForms.GunaElipsePanel content_Panel;
        private Guna.UI.WinForms.GunaPanel control_Panel;
        private Guna.UI.WinForms.GunaButton create_Btn;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
    }
}