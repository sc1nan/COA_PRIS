namespace COA_PRIS.Screens.Subscreens.Projects
{
    partial class Project_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project_History));
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.print_BTN = new Guna.UI.WinForms.GunaButton();
            this.project_id = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.bottom_Panel = new Guna.UI.WinForms.GunaPanel();
            this.save_Btn = new Guna.UI.WinForms.GunaButton();
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.table_Panel = new Guna.UI.WinForms.GunaPanel();
            this.data_View = new Guna.UI.WinForms.GunaDataGridView();
            this.title_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.top_Panel.SuspendLayout();
            this.bottom_Panel.SuspendLayout();
            this.content_Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.table_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).BeginInit();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.print_BTN);
            this.top_Panel.Controls.Add(this.project_id);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(10, 10);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1464, 60);
            this.top_Panel.TabIndex = 0;
            // 
            // print_BTN
            // 
            this.print_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_BTN.AnimationHoverSpeed = 0.07F;
            this.print_BTN.AnimationSpeed = 0.03F;
            this.print_BTN.BackColor = System.Drawing.Color.Transparent;
            this.print_BTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.print_BTN.BorderColor = System.Drawing.Color.Black;
            this.print_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print_BTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.print_BTN.FocusedColor = System.Drawing.Color.Empty;
            this.print_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.print_BTN.ForeColor = System.Drawing.Color.White;
            this.print_BTN.Image = global::COA_PRIS.Properties.Resources.to_do__2_;
            this.print_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.print_BTN.ImageSize = new System.Drawing.Size(30, 30);
            this.print_BTN.Location = new System.Drawing.Point(1409, 0);
            this.print_BTN.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.print_BTN.Name = "print_BTN";
            this.print_BTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.print_BTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.print_BTN.OnHoverForeColor = System.Drawing.Color.White;
            this.print_BTN.OnHoverImage = null;
            this.print_BTN.OnPressedColor = System.Drawing.Color.Black;
            this.print_BTN.Radius = 5;
            this.print_BTN.Size = new System.Drawing.Size(55, 55);
            this.print_BTN.TabIndex = 11;
            this.print_BTN.Click += new System.EventHandler(this.print_BTN_Click);
            // 
            // project_id
            // 
            this.project_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.project_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.project_id.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_id.ForeColor = System.Drawing.Color.White;
            this.project_id.Location = new System.Drawing.Point(0, 0);
            this.project_id.Name = "project_id";
            this.project_id.Size = new System.Drawing.Size(220, 60);
            this.project_id.TabIndex = 1;
            this.project_id.Text = "PRJ000000001";
            this.project_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(10, 70);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1464, 5);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // bottom_Panel
            // 
            this.bottom_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottom_Panel.Controls.Add(this.save_Btn);
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_Panel.Location = new System.Drawing.Point(10, 736);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.bottom_Panel.Size = new System.Drawing.Size(1464, 65);
            this.bottom_Panel.TabIndex = 2;
            this.bottom_Panel.Visible = false;
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
            this.save_Btn.Location = new System.Drawing.Point(1351, 0);
            this.save_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.save_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Btn.OnHoverImage = null;
            this.save_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.save_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.save_Btn.Radius = 8;
            this.save_Btn.Size = new System.Drawing.Size(103, 55);
            this.save_Btn.TabIndex = 11;
            this.save_Btn.Text = "OK";
            this.save_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.content_Panel.Controls.Add(this.tableLayoutPanel1);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(10, 75);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.content_Panel.Size = new System.Drawing.Size(1464, 661);
            this.content_Panel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.table_Panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.title_Panel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1444, 641);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // table_Panel
            // 
            this.table_Panel.BackColor = System.Drawing.Color.White;
            this.table_Panel.Controls.Add(this.data_View);
            this.table_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Panel.Location = new System.Drawing.Point(0, 130);
            this.table_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.table_Panel.Name = "table_Panel";
            this.table_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.table_Panel.Size = new System.Drawing.Size(1444, 511);
            this.table_Panel.TabIndex = 3;
            // 
            // data_View
            // 
            this.data_View.AllowUserToAddRows = false;
            this.data_View.AllowUserToDeleteRows = false;
            this.data_View.AllowUserToResizeColumns = false;
            this.data_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.data_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_View.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_View.EnableHeadersVisualStyles = false;
            this.data_View.GridColor = System.Drawing.Color.Gainsboro;
            this.data_View.Location = new System.Drawing.Point(10, 10);
            this.data_View.Margin = new System.Windows.Forms.Padding(0);
            this.data_View.MultiSelect = false;
            this.data_View.Name = "data_View";
            this.data_View.ReadOnly = true;
            this.data_View.RowHeadersVisible = false;
            this.data_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_View.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_View.RowTemplate.DividerHeight = 1;
            this.data_View.RowTemplate.ReadOnly = true;
            this.data_View.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data_View.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_View.ShowCellErrors = false;
            this.data_View.ShowCellToolTips = false;
            this.data_View.ShowEditingIcon = false;
            this.data_View.ShowRowErrors = false;
            this.data_View.Size = new System.Drawing.Size(1424, 491);
            this.data_View.TabIndex = 2;
            this.data_View.Tag = "Table";
            this.data_View.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.data_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.data_View.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.data_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_View.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_View.ThemeStyle.HeaderStyle.Height = 23;
            this.data_View.ThemeStyle.ReadOnly = true;
            this.data_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_View.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.data_View.ThemeStyle.RowsStyle.Height = 22;
            this.data_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            // 
            // title_Panel
            // 
            this.title_Panel.BackColor = System.Drawing.Color.White;
            this.title_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.title_Panel.Location = new System.Drawing.Point(0, 0);
            this.title_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.title_Panel.Name = "title_Panel";
            this.title_Panel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.title_Panel.Size = new System.Drawing.Size(616, 120);
            this.title_Panel.TabIndex = 4;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.data_View;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 6;
            this.gunaElipse2.TargetControl = this.table_Panel;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 6;
            this.gunaElipse3.TargetControl = this.title_Panel;
            // 
            // Project_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.content_Panel);
            this.Controls.Add(this.bottom_Panel);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Project_History";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIS Project Action Logs";
            this.top_Panel.ResumeLayout(false);
            this.bottom_Panel.ResumeLayout(false);
            this.content_Panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.table_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaPanel bottom_Panel;
        private Guna.UI.WinForms.GunaPanel content_Panel;
        private Guna.UI.WinForms.GunaLabel project_id;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel table_Panel;
        private Guna.UI.WinForms.GunaDataGridView data_View;
        private Guna.UI.WinForms.GunaPanel title_Panel;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaButton save_Btn;
        private Guna.UI.WinForms.GunaButton print_BTN;
    }
}