namespace COA_PRIS
{
    partial class Home
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

        protected string[] column_names = {"User Name", "Activity", "Time"};

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Main_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel6 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Main_Panel.SuspendLayout();
            this.gunaElipsePanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_Panel.BaseColor = System.Drawing.SystemColors.Control;
            this.Main_Panel.Controls.Add(this.gunaElipsePanel2);
            this.Main_Panel.Controls.Add(this.gunaElipsePanel3);
            this.Main_Panel.Controls.Add(this.gunaElipsePanel1);
            this.Main_Panel.Controls.Add(this.gunaElipsePanel4);
            this.Main_Panel.Controls.Add(this.label1);
            this.Main_Panel.Controls.Add(this.gunaElipsePanel6);
            this.Main_Panel.Controls.Add(this.gunaElipsePanel5);
            this.Main_Panel.Location = new System.Drawing.Point(-4, 0);
            this.Main_Panel.Margin = new System.Windows.Forms.Padding(5);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Radius = 10;
            this.Main_Panel.Size = new System.Drawing.Size(1698, 932);
            this.Main_Panel.TabIndex = 0;
            this.Main_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Panel_Paint);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // gunaElipsePanel5
            // 
            this.gunaElipsePanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.gunaElipsePanel5.Controls.Add(this.monthCalendar1);
            this.gunaElipsePanel5.Location = new System.Drawing.Point(1322, 276);
            this.gunaElipsePanel5.Name = "gunaElipsePanel5";
            this.gunaElipsePanel5.Radius = 10;
            this.gunaElipsePanel5.Size = new System.Drawing.Size(341, 247);
            this.gunaElipsePanel5.TabIndex = 2;
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel4.Location = new System.Drawing.Point(486, 23);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Radius = 20;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(411, 230);
            this.gunaElipsePanel4.TabIndex = 3;
            // 
            // gunaElipsePanel6
            // 
            this.gunaElipsePanel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel6.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel6.Location = new System.Drawing.Point(32, 317);
            this.gunaElipsePanel6.Name = "gunaElipsePanel6";
            this.gunaElipsePanel6.Radius = 20;
            this.gunaElipsePanel6.Size = new System.Drawing.Size(724, 560);
            this.gunaElipsePanel6.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recently Added Projects";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(812, 23);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(411, 230);
            this.gunaElipsePanel1.TabIndex = 4;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Location = new System.Drawing.Point(37, 23);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 20;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(411, 230);
            this.gunaElipsePanel2.TabIndex = 4;
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel3.Location = new System.Drawing.Point(1267, 23);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 20;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(414, 230);
            this.gunaElipsePanel3.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1697, 901);
            this.Controls.Add(this.Main_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.gunaElipsePanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel Main_Panel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel5;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel6;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        /*private UserControlUtil.DataTableMultiplePages dataTableMultiplePages1;*/
    }
}