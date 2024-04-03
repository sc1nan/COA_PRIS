namespace COA_PRIS.Screens
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.SidebarContainer = new Guna.UI.WinForms.GunaPanel();
            this.sideExpand_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tab_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_Panel = new Guna.UI.WinForms.GunaPanel();
            this.HomeBtn = new Guna.UI.WinForms.GunaButton();
            this.creation_Panel = new Guna.UI.WinForms.GunaPanel();
            this.Createbtn = new Guna.UI.WinForms.GunaButton();
            this.report_Panel = new Guna.UI.WinForms.GunaPanel();
            this.ReportBtn = new Guna.UI.WinForms.GunaButton();
            this.employee_Panel = new Guna.UI.WinForms.GunaPanel();
            this.EmployeeBtn = new Guna.UI.WinForms.GunaButton();
            this.user_Panel = new Guna.UI.WinForms.GunaPanel();
            this.UserBtn = new Guna.UI.WinForms.GunaButton();
            this.maintenance_Panel = new Guna.UI.WinForms.GunaPanel();
            this.MaintenanceBtn = new Guna.UI.WinForms.GunaButton();
            this.log_Panel = new Guna.UI.WinForms.GunaPanel();
            this.LogBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.headerTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.title_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.Main_Form = new Guna.UI.WinForms.GunaPanel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.SidebarContainer.SuspendLayout();
            this.tab_panel.SuspendLayout();
            this.home_Panel.SuspendLayout();
            this.creation_Panel.SuspendLayout();
            this.report_Panel.SuspendLayout();
            this.employee_Panel.SuspendLayout();
            this.user_Panel.SuspendLayout();
            this.maintenance_Panel.SuspendLayout();
            this.log_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.title_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarContainer
            // 
            this.SidebarContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.SidebarContainer.Controls.Add(this.sideExpand_Btn);
            this.SidebarContainer.Controls.Add(this.gunaLabel2);
            this.SidebarContainer.Controls.Add(this.tab_panel);
            this.SidebarContainer.Controls.Add(this.gunaCirclePictureBox1);
            this.SidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.SidebarContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarContainer.MaximumSize = new System.Drawing.Size(250, 1056);
            this.SidebarContainer.MinimumSize = new System.Drawing.Size(95, 990);
            this.SidebarContainer.Name = "SidebarContainer";
            this.SidebarContainer.Size = new System.Drawing.Size(95, 991);
            this.SidebarContainer.TabIndex = 10;
            // 
            // sideExpand_Btn
            // 
            this.sideExpand_Btn.AnimationHoverSpeed = 0.07F;
            this.sideExpand_Btn.AnimationSpeed = 0.03F;
            this.sideExpand_Btn.BackColor = System.Drawing.Color.Transparent;
            this.sideExpand_Btn.BaseColor = System.Drawing.Color.Transparent;
            this.sideExpand_Btn.BorderColor = System.Drawing.Color.Black;
            this.sideExpand_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideExpand_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sideExpand_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.sideExpand_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sideExpand_Btn.ForeColor = System.Drawing.Color.White;
            this.sideExpand_Btn.Image = global::COA_PRIS.Properties.Resources.swipe_right;
            this.sideExpand_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sideExpand_Btn.ImageSize = new System.Drawing.Size(35, 35);
            this.sideExpand_Btn.Location = new System.Drawing.Point(22, 107);
            this.sideExpand_Btn.Name = "sideExpand_Btn";
            this.sideExpand_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.sideExpand_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sideExpand_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.sideExpand_Btn.OnHoverImage = null;
            this.sideExpand_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.sideExpand_Btn.Radius = 10;
            this.sideExpand_Btn.Size = new System.Drawing.Size(50, 50);
            this.sideExpand_Btn.TabIndex = 0;
            this.sideExpand_Btn.Click += new System.EventHandler(this.sidebar_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(83, 9);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(165, 70);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Technical Services Office";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_panel
            // 
            this.tab_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_panel.BackColor = System.Drawing.Color.Transparent;
            this.tab_panel.Controls.Add(this.home_Panel);
            this.tab_panel.Controls.Add(this.creation_Panel);
            this.tab_panel.Controls.Add(this.report_Panel);
            this.tab_panel.Controls.Add(this.employee_Panel);
            this.tab_panel.Controls.Add(this.user_Panel);
            this.tab_panel.Controls.Add(this.maintenance_Panel);
            this.tab_panel.Controls.Add(this.log_Panel);
            this.tab_panel.Location = new System.Drawing.Point(0, 175);
            this.tab_panel.Margin = new System.Windows.Forms.Padding(0);
            this.tab_panel.Name = "tab_panel";
            this.tab_panel.Size = new System.Drawing.Size(95, 816);
            this.tab_panel.TabIndex = 6;
            // 
            // home_Panel
            // 
            this.home_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_Panel.Controls.Add(this.HomeBtn);
            this.home_Panel.Location = new System.Drawing.Point(0, 2);
            this.home_Panel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.home_Panel.Name = "home_Panel";
            this.home_Panel.Size = new System.Drawing.Size(250, 70);
            this.home_Panel.TabIndex = 2;
            this.home_Panel.Tag = "Tabs";
            // 
            // HomeBtn
            // 
            this.HomeBtn.AnimationHoverSpeed = 0.07F;
            this.HomeBtn.AnimationSpeed = 0.03F;
            this.HomeBtn.BaseColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderColor = System.Drawing.Color.Black;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.HomeBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = global::COA_PRIS.Properties.Resources.home_icon_silhouette;
            this.HomeBtn.ImageOffsetX = 15;
            this.HomeBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.HomeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.HomeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.HomeBtn.OnHoverImage = null;
            this.HomeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.HomeBtn.Size = new System.Drawing.Size(250, 70);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Tag = "ControlTabs";
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextOffsetX = 18;
            this.HomeBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // creation_Panel
            // 
            this.creation_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creation_Panel.Controls.Add(this.Createbtn);
            this.creation_Panel.Location = new System.Drawing.Point(0, 76);
            this.creation_Panel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.creation_Panel.Name = "creation_Panel";
            this.creation_Panel.Size = new System.Drawing.Size(250, 70);
            this.creation_Panel.TabIndex = 1;
            this.creation_Panel.Tag = "Tabs";
            // 
            // Createbtn
            // 
            this.Createbtn.AnimationHoverSpeed = 0.07F;
            this.Createbtn.AnimationSpeed = 0.03F;
            this.Createbtn.BaseColor = System.Drawing.Color.Transparent;
            this.Createbtn.BorderColor = System.Drawing.Color.Black;
            this.Createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Createbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Createbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Createbtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.ForeColor = System.Drawing.Color.White;
            this.Createbtn.Image = global::COA_PRIS.Properties.Resources.project;
            this.Createbtn.ImageOffsetX = 15;
            this.Createbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Createbtn.Location = new System.Drawing.Point(0, 0);
            this.Createbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Createbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Createbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Createbtn.OnHoverImage = null;
            this.Createbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Createbtn.Size = new System.Drawing.Size(250, 70);
            this.Createbtn.TabIndex = 3;
            this.Createbtn.Tag = "ControlTabs";
            this.Createbtn.Text = "Projects";
            this.Createbtn.TextOffsetX = 18;
            this.Createbtn.Click += new System.EventHandler(this.button_Click);
            // 
            // report_Panel
            // 
            this.report_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_Panel.Controls.Add(this.ReportBtn);
            this.report_Panel.Location = new System.Drawing.Point(0, 150);
            this.report_Panel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.report_Panel.Name = "report_Panel";
            this.report_Panel.Size = new System.Drawing.Size(250, 70);
            this.report_Panel.TabIndex = 1;
            this.report_Panel.Tag = "Tabs";
            // 
            // ReportBtn
            // 
            this.ReportBtn.AnimationHoverSpeed = 0.07F;
            this.ReportBtn.AnimationSpeed = 0.03F;
            this.ReportBtn.BaseColor = System.Drawing.Color.Transparent;
            this.ReportBtn.BorderColor = System.Drawing.Color.Black;
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ReportBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.Image = global::COA_PRIS.Properties.Resources.business_report__1_;
            this.ReportBtn.ImageOffsetX = 15;
            this.ReportBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.ReportBtn.Location = new System.Drawing.Point(0, 0);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ReportBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ReportBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ReportBtn.OnHoverImage = null;
            this.ReportBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ReportBtn.Size = new System.Drawing.Size(250, 70);
            this.ReportBtn.TabIndex = 4;
            this.ReportBtn.Tag = "ControlTabs";
            this.ReportBtn.Text = "Reports";
            this.ReportBtn.TextOffsetX = 18;
            this.ReportBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // employee_Panel
            // 
            this.employee_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_Panel.Controls.Add(this.EmployeeBtn);
            this.employee_Panel.Location = new System.Drawing.Point(0, 224);
            this.employee_Panel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.employee_Panel.Name = "employee_Panel";
            this.employee_Panel.Size = new System.Drawing.Size(250, 70);
            this.employee_Panel.TabIndex = 1;
            this.employee_Panel.Tag = "Tabs";
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.AnimationHoverSpeed = 0.07F;
            this.EmployeeBtn.AnimationSpeed = 0.03F;
            this.EmployeeBtn.BaseColor = System.Drawing.Color.Transparent;
            this.EmployeeBtn.BorderColor = System.Drawing.Color.Black;
            this.EmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EmployeeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.EmployeeBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeBtn.Image = global::COA_PRIS.Properties.Resources.employee;
            this.EmployeeBtn.ImageOffsetX = 15;
            this.EmployeeBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.EmployeeBtn.Location = new System.Drawing.Point(0, 0);
            this.EmployeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.EmployeeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EmployeeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.EmployeeBtn.OnHoverImage = null;
            this.EmployeeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.EmployeeBtn.Size = new System.Drawing.Size(250, 70);
            this.EmployeeBtn.TabIndex = 5;
            this.EmployeeBtn.Tag = "ControlTabs";
            this.EmployeeBtn.Text = "Employees";
            this.EmployeeBtn.TextOffsetX = 18;
            this.EmployeeBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // user_Panel
            // 
            this.user_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_Panel.Controls.Add(this.UserBtn);
            this.user_Panel.Location = new System.Drawing.Point(0, 298);
            this.user_Panel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.user_Panel.Name = "user_Panel";
            this.user_Panel.Size = new System.Drawing.Size(250, 70);
            this.user_Panel.TabIndex = 6;
            this.user_Panel.Tag = "Tabs";
            // 
            // UserBtn
            // 
            this.UserBtn.AnimationHoverSpeed = 0.07F;
            this.UserBtn.AnimationSpeed = 0.03F;
            this.UserBtn.BaseColor = System.Drawing.Color.Transparent;
            this.UserBtn.BorderColor = System.Drawing.Color.Black;
            this.UserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UserBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserBtn.FocusedColor = System.Drawing.Color.Empty;
            this.UserBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.Color.White;
            this.UserBtn.Image = global::COA_PRIS.Properties.Resources.user_avatar__1_;
            this.UserBtn.ImageOffsetX = 15;
            this.UserBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.UserBtn.Location = new System.Drawing.Point(0, 0);
            this.UserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.UserBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UserBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.UserBtn.OnHoverImage = null;
            this.UserBtn.OnPressedColor = System.Drawing.Color.Black;
            this.UserBtn.Size = new System.Drawing.Size(250, 70);
            this.UserBtn.TabIndex = 5;
            this.UserBtn.Tag = "ControlTabs";
            this.UserBtn.Text = "User Settings";
            this.UserBtn.TextOffsetX = 18;
            this.UserBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // maintenance_Panel
            // 
            this.maintenance_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintenance_Panel.Controls.Add(this.MaintenanceBtn);
            this.maintenance_Panel.Location = new System.Drawing.Point(0, 372);
            this.maintenance_Panel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.maintenance_Panel.Name = "maintenance_Panel";
            this.maintenance_Panel.Size = new System.Drawing.Size(250, 70);
            this.maintenance_Panel.TabIndex = 7;
            this.maintenance_Panel.Tag = "Tabs";
            // 
            // MaintenanceBtn
            // 
            this.MaintenanceBtn.AnimationHoverSpeed = 0.07F;
            this.MaintenanceBtn.AnimationSpeed = 0.03F;
            this.MaintenanceBtn.BaseColor = System.Drawing.Color.Transparent;
            this.MaintenanceBtn.BorderColor = System.Drawing.Color.Black;
            this.MaintenanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaintenanceBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MaintenanceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaintenanceBtn.FocusedColor = System.Drawing.Color.Empty;
            this.MaintenanceBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintenanceBtn.ForeColor = System.Drawing.Color.White;
            this.MaintenanceBtn.Image = global::COA_PRIS.Properties.Resources.services;
            this.MaintenanceBtn.ImageOffsetX = 15;
            this.MaintenanceBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.MaintenanceBtn.Location = new System.Drawing.Point(0, 0);
            this.MaintenanceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MaintenanceBtn.Name = "MaintenanceBtn";
            this.MaintenanceBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.MaintenanceBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MaintenanceBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.MaintenanceBtn.OnHoverImage = null;
            this.MaintenanceBtn.OnPressedColor = System.Drawing.Color.Black;
            this.MaintenanceBtn.Size = new System.Drawing.Size(250, 70);
            this.MaintenanceBtn.TabIndex = 6;
            this.MaintenanceBtn.Tag = "ControlTabs";
            this.MaintenanceBtn.Text = "Maintenance";
            this.MaintenanceBtn.TextOffsetX = 18;
            this.MaintenanceBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // log_Panel
            // 
            this.log_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.log_Panel.Controls.Add(this.LogBtn);
            this.log_Panel.Location = new System.Drawing.Point(0, 446);
            this.log_Panel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.log_Panel.Name = "log_Panel";
            this.log_Panel.Size = new System.Drawing.Size(250, 70);
            this.log_Panel.TabIndex = 5;
            this.log_Panel.Tag = "Tabs";
            // 
            // LogBtn
            // 
            this.LogBtn.AnimationHoverSpeed = 0.07F;
            this.LogBtn.AnimationSpeed = 0.03F;
            this.LogBtn.BaseColor = System.Drawing.Color.Transparent;
            this.LogBtn.BorderColor = System.Drawing.Color.Black;
            this.LogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LogBtn.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.ForeColor = System.Drawing.Color.White;
            this.LogBtn.Image = global::COA_PRIS.Properties.Resources.log_file;
            this.LogBtn.ImageOffsetX = 15;
            this.LogBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.LogBtn.Location = new System.Drawing.Point(0, 0);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.LogBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LogBtn.OnHoverImage = null;
            this.LogBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LogBtn.Size = new System.Drawing.Size(250, 70);
            this.LogBtn.TabIndex = 5;
            this.LogBtn.Tag = "ControlTabs";
            this.LogBtn.Text = "Logs";
            this.LogBtn.TextOffsetX = 18;
            this.LogBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::COA_PRIS.Properties.Resources.TSO_Logo_1_removebg_preview;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(11, 9);
            this.gunaCirclePictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(70, 70);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.AutoSize = true;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1684, 0);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1362, 26);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(111, 25);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "MAMA MO";
            // 
            // headerTitle
            // 
            this.headerTitle.AutoSize = true;
            this.headerTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitle.ForeColor = System.Drawing.Color.White;
            this.headerTitle.Location = new System.Drawing.Point(171, 13);
            this.headerTitle.Margin = new System.Windows.Forms.Padding(10);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.headerTitle.Size = new System.Drawing.Size(79, 29);
            this.headerTitle.TabIndex = 10;
            this.headerTitle.Text = "120123";
            this.headerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.Controls.Add(this.title_Panel);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Location = new System.Drawing.Point(95, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1589, 90);
            this.gunaPanel1.TabIndex = 11;
            // 
            // title_Panel
            // 
            this.title_Panel.AutoSize = true;
            this.title_Panel.BackColor = System.Drawing.Color.Transparent;
            this.title_Panel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title_Panel.Controls.Add(this.headerTitle);
            this.title_Panel.Location = new System.Drawing.Point(-6, 15);
            this.title_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.title_Panel.Name = "title_Panel";
            this.title_Panel.Size = new System.Drawing.Size(260, 58);
            this.title_Panel.TabIndex = 10;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(1503, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 11;
            this.gunaPictureBox2.TabStop = false;
            // 
            // Main_Form
            // 
            this.Main_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Form.BackColor = System.Drawing.Color.Gainsboro;
            this.Main_Form.Location = new System.Drawing.Point(95, 90);
            this.Main_Form.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Form.Name = "Main_Form";
            this.Main_Form.Size = new System.Drawing.Size(1591, 901);
            this.Main_Form.TabIndex = 10;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1684, 991);
            this.Controls.Add(this.SidebarContainer);
            this.Controls.Add(this.Main_Form);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 1000);
            this.Name = "Dashboard";
            this.Text = "Project Request Information System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SidebarContainer.ResumeLayout(false);
            this.tab_panel.ResumeLayout(false);
            this.home_Panel.ResumeLayout(false);
            this.creation_Panel.ResumeLayout(false);
            this.report_Panel.ResumeLayout(false);
            this.employee_Panel.ResumeLayout(false);
            this.user_Panel.ResumeLayout(false);
            this.maintenance_Panel.ResumeLayout(false);
            this.log_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.title_Panel.ResumeLayout(false);
            this.title_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel SidebarContainer;
        private Guna.UI.WinForms.GunaButton HomeBtn;
        private Guna.UI.WinForms.GunaPanel home_Panel;
        private Guna.UI.WinForms.GunaButton EmployeeBtn;
        private Guna.UI.WinForms.GunaButton ReportBtn;
        private Guna.UI.WinForms.GunaButton Createbtn;
        private Guna.UI.WinForms.GunaPanel report_Panel;
        private Guna.UI.WinForms.GunaPanel creation_Panel;
        private Guna.UI.WinForms.GunaPanel log_Panel;
        private Guna.UI.WinForms.GunaButton LogBtn;
        private Guna.UI.WinForms.GunaPanel employee_Panel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel headerTitle;
        private Guna.UI.WinForms.GunaPanel user_Panel;
        private Guna.UI.WinForms.GunaButton UserBtn;
        private Guna.UI.WinForms.GunaButton sideExpand_Btn;
        private System.Windows.Forms.FlowLayoutPanel tab_panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel Main_Form;
        private Guna.UI.WinForms.GunaButton MaintenanceBtn;
        private Guna.UI.WinForms.GunaPanel maintenance_Panel;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI.WinForms.GunaElipsePanel title_Panel;
    }
}