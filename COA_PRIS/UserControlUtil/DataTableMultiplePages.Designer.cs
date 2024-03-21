namespace COA_PRIS.UserControlUtil
{
    partial class DataTableMultiplePages
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTableMultiplePages));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.previous_button = new Guna.UI.WinForms.GunaButton();
            this.next_button = new Guna.UI.WinForms.GunaButton();
            this.page_count_textbox = new Guna.UI.WinForms.GunaTextBox();
            this.page_control_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.bottom_panel = new System.Windows.Forms.TableLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.search_box = new Guna.UI.WinForms.GunaTextBox();
            this.search_box_panel = new System.Windows.Forms.Panel();
            this.searcb_box_line = new System.Windows.Forms.Label();
            this.serch_table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.top_panel = new System.Windows.Forms.TableLayoutPanel();
            this.sort_combobox = new Guna.UI.WinForms.GunaComboBox();
            this.guning_button = new Guna.UI.WinForms.GunaButton();
            this.data_table = new Guna.UI.WinForms.GunaDataGridView();
            this.page_control_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.search_box_panel.SuspendLayout();
            this.serch_table_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            this.SuspendLayout();
            // 
            // previous_button
            // 
            this.previous_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.previous_button.AnimationHoverSpeed = 0.07F;
            this.previous_button.AnimationSpeed = 0.03F;
            this.previous_button.BackColor = System.Drawing.Color.Transparent;
            this.previous_button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.previous_button.BorderColor = System.Drawing.Color.Black;
            this.previous_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.previous_button.Enabled = false;
            this.previous_button.FocusedColor = System.Drawing.Color.Empty;
            this.previous_button.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold);
            this.previous_button.ForeColor = System.Drawing.Color.White;
            this.previous_button.Image = null;
            this.previous_button.ImageSize = new System.Drawing.Size(20, 20);
            this.previous_button.Location = new System.Drawing.Point(3, 3);
            this.previous_button.Name = "previous_button";
            this.previous_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.previous_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.previous_button.OnHoverForeColor = System.Drawing.Color.White;
            this.previous_button.OnHoverImage = null;
            this.previous_button.OnPressedColor = System.Drawing.Color.Black;
            this.previous_button.Radius = 25;
            this.previous_button.Size = new System.Drawing.Size(50, 50);
            this.previous_button.TabIndex = 1;
            this.previous_button.Text = "<";
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // next_button
            // 
            this.next_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.next_button.AnimationHoverSpeed = 0.07F;
            this.next_button.AnimationSpeed = 0.03F;
            this.next_button.BackColor = System.Drawing.Color.Transparent;
            this.next_button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.next_button.BorderColor = System.Drawing.Color.Black;
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next_button.FocusedColor = System.Drawing.Color.Empty;
            this.next_button.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.ForeColor = System.Drawing.Color.White;
            this.next_button.Image = null;
            this.next_button.ImageSize = new System.Drawing.Size(20, 20);
            this.next_button.Location = new System.Drawing.Point(155, 3);
            this.next_button.Name = "next_button";
            this.next_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.next_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.next_button.OnHoverForeColor = System.Drawing.Color.White;
            this.next_button.OnHoverImage = null;
            this.next_button.OnPressedColor = System.Drawing.Color.Black;
            this.next_button.Radius = 25;
            this.next_button.Size = new System.Drawing.Size(50, 50);
            this.next_button.TabIndex = 2;
            this.next_button.Text = ">";
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // page_count_textbox
            // 
            this.page_count_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.page_count_textbox.BaseColor = System.Drawing.Color.White;
            this.page_count_textbox.BorderColor = System.Drawing.Color.Silver;
            this.page_count_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.page_count_textbox.FocusedBaseColor = System.Drawing.Color.White;
            this.page_count_textbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.page_count_textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.page_count_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_count_textbox.Location = new System.Drawing.Point(59, 3);
            this.page_count_textbox.Name = "page_count_textbox";
            this.page_count_textbox.PasswordChar = '\0';
            this.page_count_textbox.SelectedText = "";
            this.page_count_textbox.Size = new System.Drawing.Size(90, 50);
            this.page_count_textbox.TabIndex = 3;
            this.page_count_textbox.Text = "1";
            this.page_count_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.page_count_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.page_count_textbox_KeyDown);
            // 
            // page_control_panel
            // 
            this.page_control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.page_control_panel.AutoSize = true;
            this.page_control_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.page_control_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.page_control_panel.Controls.Add(this.previous_button);
            this.page_control_panel.Controls.Add(this.page_count_textbox);
            this.page_control_panel.Controls.Add(this.next_button);
            this.page_control_panel.Location = new System.Drawing.Point(376, 3);
            this.page_control_panel.Name = "page_control_panel";
            this.page_control_panel.Size = new System.Drawing.Size(208, 71);
            this.page_control_panel.TabIndex = 4;
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottom_panel.ColumnCount = 1;
            this.bottom_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottom_panel.Controls.Add(this.page_control_panel, 0, 0);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 463);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.RowCount = 1;
            this.bottom_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottom_panel.Size = new System.Drawing.Size(960, 77);
            this.bottom_panel.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 20.25F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(49, 38);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 33);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Search:";
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.Color.Transparent;
            this.search_box.BaseColor = System.Drawing.Color.Transparent;
            this.search_box.BorderColor = System.Drawing.Color.Transparent;
            this.search_box.BorderSize = 0;
            this.search_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search_box.FocusedBaseColor = System.Drawing.Color.White;
            this.search_box.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.search_box.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.search_box.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.search_box.Location = new System.Drawing.Point(0, 15);
            this.search_box.Margin = new System.Windows.Forms.Padding(0);
            this.search_box.Name = "search_box";
            this.search_box.PasswordChar = '\0';
            this.search_box.SelectedText = "";
            this.search_box.Size = new System.Drawing.Size(221, 49);
            this.search_box.TabIndex = 3;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // search_box_panel
            // 
            this.search_box_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_panel.Controls.Add(this.search_box);
            this.search_box_panel.Controls.Add(this.searcb_box_line);
            this.search_box_panel.Location = new System.Drawing.Point(161, 3);
            this.search_box_panel.Name = "search_box_panel";
            this.search_box_panel.Size = new System.Drawing.Size(221, 65);
            this.search_box_panel.TabIndex = 7;
            // 
            // searcb_box_line
            // 
            this.searcb_box_line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searcb_box_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searcb_box_line.Location = new System.Drawing.Point(0, 64);
            this.searcb_box_line.Margin = new System.Windows.Forms.Padding(0);
            this.searcb_box_line.Name = "searcb_box_line";
            this.searcb_box_line.Size = new System.Drawing.Size(221, 1);
            this.searcb_box_line.TabIndex = 8;
            this.searcb_box_line.Text = "label1";
            // 
            // serch_table_panel
            // 
            this.serch_table_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serch_table_panel.ColumnCount = 2;
            this.serch_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.2987F));
            this.serch_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.7013F));
            this.serch_table_panel.Controls.Add(this.gunaLabel1, 0, 0);
            this.serch_table_panel.Controls.Add(this.search_box_panel, 1, 0);
            this.serch_table_panel.Location = new System.Drawing.Point(3, 3);
            this.serch_table_panel.Name = "serch_table_panel";
            this.serch_table_panel.RowCount = 1;
            this.serch_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serch_table_panel.Size = new System.Drawing.Size(385, 71);
            this.serch_table_panel.TabIndex = 7;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.ColumnCount = 3;
            this.top_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.top_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.top_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.top_panel.Controls.Add(this.serch_table_panel, 0, 0);
            this.top_panel.Controls.Add(this.sort_combobox, 1, 0);
            this.top_panel.Controls.Add(this.guning_button, 2, 0);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.RowCount = 1;
            this.top_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.top_panel.Size = new System.Drawing.Size(960, 77);
            this.top_panel.TabIndex = 8;
            // 
            // sort_combobox
            // 
            this.sort_combobox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sort_combobox.BackColor = System.Drawing.Color.Transparent;
            this.sort_combobox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            this.sort_combobox.BorderColor = System.Drawing.Color.Transparent;
            this.sort_combobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sort_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sort_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort_combobox.FocusedColor = System.Drawing.Color.Empty;
            this.sort_combobox.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.sort_combobox.ForeColor = System.Drawing.Color.White;
            this.sort_combobox.FormattingEnabled = true;
            this.sort_combobox.Location = new System.Drawing.Point(431, 39);
            this.sort_combobox.Name = "sort_combobox";
            this.sort_combobox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.sort_combobox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sort_combobox.Radius = 12;
            this.sort_combobox.Size = new System.Drawing.Size(146, 35);
            this.sort_combobox.TabIndex = 9;
            this.sort_combobox.SelectedValueChanged += new System.EventHandler(this.sort_combobox_SelectedValueChanged);
            // 
            // guning_button
            // 
            this.guning_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guning_button.AnimationHoverSpeed = 0.07F;
            this.guning_button.AnimationSpeed = 0.03F;
            this.guning_button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guning_button.BorderColor = System.Drawing.Color.Black;
            this.guning_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guning_button.FocusedColor = System.Drawing.Color.Empty;
            this.guning_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guning_button.ForeColor = System.Drawing.Color.White;
            this.guning_button.Image = ((System.Drawing.Image)(resources.GetObject("guning_button.Image")));
            this.guning_button.ImageSize = new System.Drawing.Size(20, 20);
            this.guning_button.Location = new System.Drawing.Point(709, 3);
            this.guning_button.Name = "guning_button";
            this.guning_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guning_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.guning_button.OnHoverForeColor = System.Drawing.Color.White;
            this.guning_button.OnHoverImage = null;
            this.guning_button.OnPressedColor = System.Drawing.Color.Black;
            this.guning_button.Size = new System.Drawing.Size(160, 71);
            this.guning_button.TabIndex = 10;
            this.guning_button.Text = "gunaButton1";
            // 
            // data_table
            // 
            this.data_table.AllowUserToDeleteRows = false;
            this.data_table.AllowUserToResizeColumns = false;
            this.data_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.data_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.data_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_table.BackgroundColor = System.Drawing.Color.White;
            this.data_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.data_table.ColumnHeadersHeight = 20;
            this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_table.DefaultCellStyle = dataGridViewCellStyle9;
            this.data_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_table.EnableHeadersVisualStyles = false;
            this.data_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_table.Location = new System.Drawing.Point(0, 77);
            this.data_table.Margin = new System.Windows.Forms.Padding(15);
            this.data_table.Name = "data_table";
            this.data_table.ReadOnly = true;
            this.data_table.RowHeadersVisible = false;
            this.data_table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_table.Size = new System.Drawing.Size(960, 386);
            this.data_table.TabIndex = 9;
            this.data_table.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.data_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.data_table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_table.ThemeStyle.HeaderStyle.Height = 20;
            this.data_table.ThemeStyle.ReadOnly = true;
            this.data_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_table.ThemeStyle.RowsStyle.Height = 22;
            this.data_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DataTableMultiplePages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_table);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.bottom_panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataTableMultiplePages";
            this.Size = new System.Drawing.Size(960, 540);
            this.page_control_panel.ResumeLayout(false);
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.search_box_panel.ResumeLayout(false);
            this.serch_table_panel.ResumeLayout(false);
            this.serch_table_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton previous_button;
        private Guna.UI.WinForms.GunaButton next_button;
        private Guna.UI.WinForms.GunaTextBox page_count_textbox;
        private System.Windows.Forms.FlowLayoutPanel page_control_panel;
        private System.Windows.Forms.TableLayoutPanel bottom_panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox search_box;
        private System.Windows.Forms.Panel search_box_panel;
        private System.Windows.Forms.Label searcb_box_line;
        private System.Windows.Forms.TableLayoutPanel serch_table_panel;
        private System.Windows.Forms.TableLayoutPanel top_panel;
        private Guna.UI.WinForms.GunaComboBox sort_combobox;
        private Guna.UI.WinForms.GunaButton guning_button;
        private Guna.UI.WinForms.GunaDataGridView data_table;
    }
}
