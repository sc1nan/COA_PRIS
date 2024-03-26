namespace COA_PRIS.Screens
{
    partial class ActivityLogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogsTable = new Guna.UI.WinForms.GunaDataGridView();
            this.sortComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.logsSearchBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.pageCountTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.nextLogsBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogsTable
            // 
            this.LogsTable.AllowUserToDeleteRows = false;
            this.LogsTable.AllowUserToResizeColumns = false;
            this.LogsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.LogsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LogsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LogsTable.BackgroundColor = System.Drawing.Color.White;
            this.LogsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LogsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LogsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LogsTable.ColumnHeadersHeight = 20;
            this.LogsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.LogsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsTable.EnableHeadersVisualStyles = false;
            this.LogsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LogsTable.Location = new System.Drawing.Point(0, 112);
            this.LogsTable.Margin = new System.Windows.Forms.Padding(15);
            this.LogsTable.Name = "LogsTable";
            this.LogsTable.ReadOnly = true;
            this.LogsTable.RowHeadersVisible = false;
            this.LogsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogsTable.Size = new System.Drawing.Size(1603, 667);
            this.LogsTable.TabIndex = 1;
            this.LogsTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LogsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LogsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LogsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LogsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LogsTable.ThemeStyle.HeaderStyle.Height = 20;
            this.LogsTable.ThemeStyle.ReadOnly = true;
            this.LogsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LogsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LogsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LogsTable.ThemeStyle.RowsStyle.Height = 22;
            this.LogsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LogsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.Transparent;
            this.sortComboBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            this.sortComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.sortComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.sortComboBox.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.sortComboBox.ForeColor = System.Drawing.Color.White;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "User Name",
            "Activity",
            "Time"});
            this.sortComboBox.Location = new System.Drawing.Point(1336, 0);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.sortComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sortComboBox.Radius = 12;
            this.sortComboBox.Size = new System.Drawing.Size(267, 35);
            this.sortComboBox.TabIndex = 2;
            this.sortComboBox.SelectedValueChanged += new System.EventHandler(this.sortComboBox_SelectedValueChanged);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.sortComboBox);
            this.gunaPanel1.Controls.Add(this.panel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1603, 112);
            this.gunaPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.logsSearchBox);
            this.panel1.Location = new System.Drawing.Point(31, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 71);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(119, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 1);
            this.panel2.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 20.25F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 33);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Search:";
            // 
            // logsSearchBox
            // 
            this.logsSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.logsSearchBox.BaseColor = System.Drawing.Color.Transparent;
            this.logsSearchBox.BorderColor = System.Drawing.Color.Transparent;
            this.logsSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logsSearchBox.FocusedBaseColor = System.Drawing.Color.White;
            this.logsSearchBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.logsSearchBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.logsSearchBox.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.logsSearchBox.Location = new System.Drawing.Point(122, 25);
            this.logsSearchBox.Name = "logsSearchBox";
            this.logsSearchBox.PasswordChar = '\0';
            this.logsSearchBox.SelectedText = "";
            this.logsSearchBox.Size = new System.Drawing.Size(667, 43);
            this.logsSearchBox.TabIndex = 0;
            this.logsSearchBox.TextChanged += new System.EventHandler(this.logsSearchBox_TextChanged);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Gray;
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 112);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(25, 667);
            this.gunaPanel2.TabIndex = 4;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Gray;
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(1578, 112);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(25, 667);
            this.gunaPanel3.TabIndex = 5;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.Gray;
            this.gunaPanel4.Controls.Add(this.pageCountTextbox);
            this.gunaPanel4.Controls.Add(this.nextLogsBtn);
            this.gunaPanel4.Controls.Add(this.gunaButton1);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 779);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(1603, 135);
            this.gunaPanel4.TabIndex = 6;
            // 
            // pageCountTextbox
            // 
            this.pageCountTextbox.BaseColor = System.Drawing.Color.White;
            this.pageCountTextbox.BorderColor = System.Drawing.Color.Silver;
            this.pageCountTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pageCountTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.pageCountTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pageCountTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pageCountTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pageCountTextbox.Location = new System.Drawing.Point(736, 65);
            this.pageCountTextbox.Name = "pageCountTextbox";
            this.pageCountTextbox.PasswordChar = '\0';
            this.pageCountTextbox.SelectedText = "";
            this.pageCountTextbox.Size = new System.Drawing.Size(90, 30);
            this.pageCountTextbox.TabIndex = 2;
            this.pageCountTextbox.Text = "1";
            this.pageCountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageCountTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageCountTextbox_KeyDown);
            // 
            // nextLogsBtn
            // 
            this.nextLogsBtn.AnimationHoverSpeed = 0.07F;
            this.nextLogsBtn.AnimationSpeed = 0.03F;
            this.nextLogsBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextLogsBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.nextLogsBtn.BorderColor = System.Drawing.Color.Black;
            this.nextLogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextLogsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nextLogsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.nextLogsBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLogsBtn.ForeColor = System.Drawing.Color.White;
            this.nextLogsBtn.Image = null;
            this.nextLogsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.nextLogsBtn.Location = new System.Drawing.Point(844, 53);
            this.nextLogsBtn.Name = "nextLogsBtn";
            this.nextLogsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.nextLogsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nextLogsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.nextLogsBtn.OnHoverImage = null;
            this.nextLogsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.nextLogsBtn.Radius = 25;
            this.nextLogsBtn.Size = new System.Drawing.Size(46, 42);
            this.nextLogsBtn.TabIndex = 1;
            this.nextLogsBtn.Text = ">";
            this.nextLogsBtn.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(675, 53);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 25;
            this.gunaButton1.Size = new System.Drawing.Size(46, 42);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "<";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // ActivityLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 914);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.LogsTable);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivityLogs";
            this.Text = "LogsTab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView LogsTable;
        private Guna.UI.WinForms.GunaComboBox sortComboBox;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox logsSearchBox;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox pageCountTextbox;
        private Guna.UI.WinForms.GunaButton nextLogsBtn;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}