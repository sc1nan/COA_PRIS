namespace COA_PRIS.Screens.Subscreens.Reports
{
    partial class ProjectRequest_Reports_Sub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectRequest_Reports_Sub));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateFilter1 = new COA_PRIS.UserControlUtil.DateFilter();
            this.searchBar1 = new COA_PRIS.UserControlUtil.SearchBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.status = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.sortComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.add_RecordBtn = new Guna.UI.WinForms.GunaButton();
            this.refresh_Btn = new Guna.UI.WinForms.GunaButton();
            this.previous_Button = new Guna.UI.WinForms.GunaButton();
            this.pageCountTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.next_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.main_Panel = new System.Windows.Forms.Panel();
            this.content_Panel = new System.Windows.Forms.Panel();
            this.contentTable = new Guna.UI.WinForms.GunaDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.main_Panel.SuspendLayout();
            this.content_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentTable)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dateFilter1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sortComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.add_RecordBtn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.refresh_Btn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1567, 68);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dateFilter1
            // 
            this.dateFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateFilter1.BackColor = System.Drawing.Color.Transparent;
            this.dateFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFilter1.fromValue = new System.DateTime(2024, 4, 8, 10, 35, 15, 477);
            this.dateFilter1.Location = new System.Drawing.Point(928, 3);
            this.dateFilter1.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.dateFilter1.Name = "dateFilter1";
            this.dateFilter1.Size = new System.Drawing.Size(359, 60);
            this.dateFilter1.TabIndex = 12;
            this.dateFilter1.toValue = new System.DateTime(2024, 4, 8, 10, 35, 15, 477);
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.White;
            this.searchBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar1.Location = new System.Drawing.Point(3, 3);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(494, 60);
            this.searchBar1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.status, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gunaLabel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(633, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(222, 60);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.BaseColor = System.Drawing.Color.White;
            this.status.BorderColor = System.Drawing.Color.Silver;
            this.status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.status.DropDownHeight = 220;
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FocusedColor = System.Drawing.Color.Empty;
            this.status.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.FormattingEnabled = true;
            this.status.IntegralHeight = false;
            this.status.ItemHeight = 48;
            this.status.Location = new System.Drawing.Point(80, 3);
            this.status.Margin = new System.Windows.Forms.Padding(0);
            this.status.MaxDropDownItems = 10;
            this.status.Name = "status";
            this.status.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.status.OnHoverItemForeColor = System.Drawing.Color.White;
            this.status.Radius = 6;
            this.status.Size = new System.Drawing.Size(142, 54);
            this.status.TabIndex = 5;
            this.status.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(74, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Status :";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.Transparent;
            this.sortComboBox.BaseColor = System.Drawing.Color.White;
            this.sortComboBox.BorderColor = System.Drawing.Color.Silver;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.sortComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortComboBox.DropDownHeight = 350;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.DropDownWidth = 220;
            this.sortComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.sortComboBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.ForeColor = System.Drawing.Color.Black;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.IntegralHeight = false;
            this.sortComboBox.ItemHeight = 50;
            this.sortComboBox.Location = new System.Drawing.Point(500, 5);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.sortComboBox.MaxDropDownItems = 10;
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.sortComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sortComboBox.Radius = 6;
            this.sortComboBox.Size = new System.Drawing.Size(130, 56);
            this.sortComboBox.TabIndex = 9;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // add_RecordBtn
            // 
            this.add_RecordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_RecordBtn.AnimationHoverSpeed = 0.07F;
            this.add_RecordBtn.AnimationSpeed = 0.03F;
            this.add_RecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.add_RecordBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.add_RecordBtn.BorderColor = System.Drawing.Color.Black;
            this.add_RecordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_RecordBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_RecordBtn.FocusedColor = System.Drawing.Color.Empty;
            this.add_RecordBtn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_RecordBtn.ForeColor = System.Drawing.Color.White;
            this.add_RecordBtn.Image = global::COA_PRIS.Properties.Resources.business_report__1_;
            this.add_RecordBtn.ImageOffsetX = 8;
            this.add_RecordBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.add_RecordBtn.Location = new System.Drawing.Point(1345, 5);
            this.add_RecordBtn.Margin = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.add_RecordBtn.Name = "add_RecordBtn";
            this.add_RecordBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.add_RecordBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_RecordBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_RecordBtn.OnHoverImage = null;
            this.add_RecordBtn.OnPressedColor = System.Drawing.Color.Black;
            this.add_RecordBtn.Radius = 6;
            this.add_RecordBtn.Size = new System.Drawing.Size(222, 55);
            this.add_RecordBtn.TabIndex = 13;
            this.add_RecordBtn.Tag = "AddRecord";
            this.add_RecordBtn.Text = "Generate Report";
            this.add_RecordBtn.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // refresh_Btn
            // 
            this.refresh_Btn.AnimationHoverSpeed = 0.07F;
            this.refresh_Btn.AnimationSpeed = 0.03F;
            this.refresh_Btn.BackColor = System.Drawing.Color.Transparent;
            this.refresh_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.refresh_Btn.BorderColor = System.Drawing.Color.Black;
            this.refresh_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refresh_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.refresh_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refresh_Btn.ForeColor = System.Drawing.Color.White;
            this.refresh_Btn.Image = global::COA_PRIS.Properties.Resources.refresh__1_;
            this.refresh_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refresh_Btn.ImageSize = new System.Drawing.Size(35, 35);
            this.refresh_Btn.Location = new System.Drawing.Point(864, 5);
            this.refresh_Btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 0);
            this.refresh_Btn.Name = "refresh_Btn";
            this.refresh_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.refresh_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh_Btn.OnHoverImage = null;
            this.refresh_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.refresh_Btn.Radius = 6;
            this.refresh_Btn.Size = new System.Drawing.Size(55, 55);
            this.refresh_Btn.TabIndex = 11;
            this.refresh_Btn.Click += new System.EventHandler(this.refresh_Button_Click);
            // 
            // previous_Button
            // 
            this.previous_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previous_Button.AnimationHoverSpeed = 0.07F;
            this.previous_Button.AnimationSpeed = 0.03F;
            this.previous_Button.BackColor = System.Drawing.Color.White;
            this.previous_Button.BaseColor = System.Drawing.Color.White;
            this.previous_Button.BorderColor = System.Drawing.Color.White;
            this.previous_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.previous_Button.FocusedColor = System.Drawing.Color.White;
            this.previous_Button.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.previous_Button.ForeColor = System.Drawing.Color.White;
            this.previous_Button.Image = ((System.Drawing.Image)(resources.GetObject("previous_Button.Image")));
            this.previous_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.previous_Button.Location = new System.Drawing.Point(3, 3);
            this.previous_Button.Name = "previous_Button";
            this.previous_Button.OnHoverBaseColor = System.Drawing.Color.White;
            this.previous_Button.OnHoverBorderColor = System.Drawing.Color.White;
            this.previous_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.previous_Button.OnHoverImage = null;
            this.previous_Button.OnPressedColor = System.Drawing.Color.White;
            this.previous_Button.Size = new System.Drawing.Size(46, 42);
            this.previous_Button.TabIndex = 0;
            this.previous_Button.Text = "<";
            this.previous_Button.Click += new System.EventHandler(this.previous_Button_Click);
            // 
            // pageCountTextbox
            // 
            this.pageCountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageCountTextbox.BackColor = System.Drawing.Color.White;
            this.pageCountTextbox.BaseColor = System.Drawing.Color.White;
            this.pageCountTextbox.BorderColor = System.Drawing.Color.White;
            this.pageCountTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pageCountTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.pageCountTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pageCountTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pageCountTextbox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageCountTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.pageCountTextbox.Location = new System.Drawing.Point(55, 15);
            this.pageCountTextbox.Name = "pageCountTextbox";
            this.pageCountTextbox.PasswordChar = '\0';
            this.pageCountTextbox.SelectedText = "";
            this.pageCountTextbox.Size = new System.Drawing.Size(90, 30);
            this.pageCountTextbox.TabIndex = 2;
            this.pageCountTextbox.Text = "1";
            this.pageCountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageCountTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageCountTextbox_KeyDown);
            // 
            // next_Button
            // 
            this.next_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next_Button.AnimationHoverSpeed = 0.07F;
            this.next_Button.AnimationSpeed = 0.03F;
            this.next_Button.BackColor = System.Drawing.Color.Transparent;
            this.next_Button.BaseColor = System.Drawing.Color.White;
            this.next_Button.BorderColor = System.Drawing.Color.Black;
            this.next_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next_Button.FocusedColor = System.Drawing.Color.Empty;
            this.next_Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_Button.ForeColor = System.Drawing.Color.White;
            this.next_Button.Image = ((System.Drawing.Image)(resources.GetObject("next_Button.Image")));
            this.next_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.next_Button.Location = new System.Drawing.Point(151, 3);
            this.next_Button.Name = "next_Button";
            this.next_Button.OnHoverBaseColor = System.Drawing.Color.White;
            this.next_Button.OnHoverBorderColor = System.Drawing.Color.White;
            this.next_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.next_Button.OnHoverImage = null;
            this.next_Button.OnPressedColor = System.Drawing.Color.White;
            this.next_Button.Size = new System.Drawing.Size(46, 42);
            this.next_Button.TabIndex = 1;
            this.next_Button.Text = ">";
            this.next_Button.Click += new System.EventHandler(this.next_Button_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.tableLayoutPanel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1567, 68);
            this.gunaPanel1.TabIndex = 8;
            // 
            // main_Panel
            // 
            this.main_Panel.Controls.Add(this.content_Panel);
            this.main_Panel.Controls.Add(this.tableLayoutPanel2);
            this.main_Panel.Controls.Add(this.gunaPanel1);
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(0, 0);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(1567, 817);
            this.main_Panel.TabIndex = 11;
            // 
            // content_Panel
            // 
            this.content_Panel.Controls.Add(this.contentTable);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(0, 68);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(1567, 691);
            this.content_Panel.TabIndex = 12;
            // 
            // contentTable
            // 
            this.contentTable.AllowUserToAddRows = false;
            this.contentTable.AllowUserToDeleteRows = false;
            this.contentTable.AllowUserToResizeColumns = false;
            this.contentTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.contentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contentTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.contentTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.contentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.contentTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contentTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.contentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contentTable.EnableHeadersVisualStyles = false;
            this.contentTable.GridColor = System.Drawing.Color.Gainsboro;
            this.contentTable.Location = new System.Drawing.Point(0, 0);
            this.contentTable.Margin = new System.Windows.Forms.Padding(0);
            this.contentTable.MultiSelect = false;
            this.contentTable.Name = "contentTable";
            this.contentTable.ReadOnly = true;
            this.contentTable.RowHeadersVisible = false;
            this.contentTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contentTable.RowTemplate.DividerHeight = 1;
            this.contentTable.RowTemplate.ReadOnly = true;
            this.contentTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.contentTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contentTable.ShowCellErrors = false;
            this.contentTable.ShowCellToolTips = false;
            this.contentTable.ShowEditingIcon = false;
            this.contentTable.ShowRowErrors = false;
            this.contentTable.Size = new System.Drawing.Size(1567, 691);
            this.contentTable.TabIndex = 2;
            this.contentTable.Tag = "Table";
            this.contentTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.contentTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.contentTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.contentTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.contentTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.contentTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.contentTable.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.contentTable.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.contentTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.contentTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.contentTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.contentTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.contentTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.contentTable.ThemeStyle.HeaderStyle.Height = 23;
            this.contentTable.ThemeStyle.ReadOnly = true;
            this.contentTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.contentTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.contentTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.contentTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.contentTable.ThemeStyle.RowsStyle.Height = 22;
            this.contentTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.contentTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 759);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1567, 58);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel2.Controls.Add(this.previous_Button);
            this.flowLayoutPanel2.Controls.Add(this.pageCountTextbox);
            this.flowLayoutPanel2.Controls.Add(this.next_Button);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(683, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 52);
            this.flowLayoutPanel2.TabIndex = 12;
            this.flowLayoutPanel2.Visible = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.contentTable;
            // 
            // ProjectRequest_Reports_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1567, 817);
            this.Controls.Add(this.main_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectRequest_Reports_Sub";
            this.Text = "ProjectRequest_Reports_Sub";
            this.Load += new System.EventHandler(this.ProjectRequest_Reports_Sub_Load);
            this.VisibleChanged += new System.EventHandler(this.refresh_Button_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.main_Panel.ResumeLayout(false);
            this.content_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentTable)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaButton previous_Button;
        private Guna.UI.WinForms.GunaTextBox pageCountTextbox;
        private Guna.UI.WinForms.GunaButton next_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Panel content_Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private UserControlUtil.SearchBar searchBar1;
        private Guna.UI.WinForms.GunaComboBox sortComboBox;
        private Guna.UI.WinForms.GunaButton refresh_Btn;
        private UserControlUtil.DateFilter dateFilter1;
        private Guna.UI.WinForms.GunaButton add_RecordBtn;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView contentTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI.WinForms.GunaComboBox status;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}