namespace COA_PRIS.Screens
{
    partial class SetUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUp));
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.parent_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.add_RecordBtn = new Guna.UI.WinForms.GunaButton();
            this.control_Panel = new Guna.UI.WinForms.GunaPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaElipsePanel4.SuspendLayout();
            this.parent_Panel.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaElipsePanel4.Controls.Add(this.parent_Panel);
            this.gunaElipsePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel4.Location = new System.Drawing.Point(20, 20);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Padding = new System.Windows.Forms.Padding(5);
            this.gunaElipsePanel4.Radius = 10;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(444, 553);
            this.gunaElipsePanel4.TabIndex = 3;
            // 
            // parent_Panel
            // 
            this.parent_Panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_Panel.BaseColor = System.Drawing.Color.White;
            this.parent_Panel.Controls.Add(this.gunaPanel2);
            this.parent_Panel.Controls.Add(this.control_Panel);
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(5, 5);
            this.parent_Panel.Margin = new System.Windows.Forms.Padding(10);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.parent_Panel.Radius = 10;
            this.parent_Panel.Size = new System.Drawing.Size(434, 543);
            this.parent_Panel.TabIndex = 3;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.add_RecordBtn);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(10, 473);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(414, 60);
            this.gunaPanel2.TabIndex = 1;
            // 
            // add_RecordBtn
            // 
            this.add_RecordBtn.AnimationHoverSpeed = 0.07F;
            this.add_RecordBtn.AnimationSpeed = 0.03F;
            this.add_RecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.add_RecordBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.add_RecordBtn.BorderColor = System.Drawing.Color.Black;
            this.add_RecordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_RecordBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_RecordBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_RecordBtn.FocusedColor = System.Drawing.Color.Empty;
            this.add_RecordBtn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_RecordBtn.ForeColor = System.Drawing.Color.White;
            this.add_RecordBtn.Image = null;
            this.add_RecordBtn.ImageOffsetX = 8;
            this.add_RecordBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.add_RecordBtn.Location = new System.Drawing.Point(0, 0);
            this.add_RecordBtn.Margin = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.add_RecordBtn.Name = "add_RecordBtn";
            this.add_RecordBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.add_RecordBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_RecordBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_RecordBtn.OnHoverImage = null;
            this.add_RecordBtn.OnPressedColor = System.Drawing.Color.Black;
            this.add_RecordBtn.Radius = 6;
            this.add_RecordBtn.Size = new System.Drawing.Size(414, 60);
            this.add_RecordBtn.TabIndex = 6;
            this.add_RecordBtn.Tag = "AddRecord";
            this.add_RecordBtn.Text = "Save Credentials";
            this.add_RecordBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_RecordBtn.Click += new System.EventHandler(this.add_RecordBtn_Click);
            // 
            // control_Panel
            // 
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(10, 10);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Size = new System.Drawing.Size(414, 523);
            this.control_Panel.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 593);
            this.Controls.Add(this.gunaElipsePanel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetUp";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetUp";
            this.gunaElipsePanel4.ResumeLayout(false);
            this.parent_Panel.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private Guna.UI.WinForms.GunaElipsePanel parent_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel control_Panel;
        private Guna.UI.WinForms.GunaButton add_RecordBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}