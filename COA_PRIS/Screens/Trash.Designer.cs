namespace COA_PRIS.Screens
{
    partial class Trash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.data_View = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.info_Label = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PRIS_Search = new COA_PRIS.UserControlUtil.PRIS_UserControl.PRIS_Search_DropBox();
            this.refresh_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.create_Btn = new Guna.UI.WinForms.GunaButton();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.selector_Title = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel3.Controls.Add(this.gunaPanel5);
            this.gunaPanel3.Controls.Add(this.gunaPanel4);
            this.gunaPanel3.Controls.Add(this.gunaPanel6);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(10, 70);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.gunaPanel3.Size = new System.Drawing.Size(1164, 631);
            this.gunaPanel3.TabIndex = 5;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel5.Controls.Add(this.data_View);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel5.Location = new System.Drawing.Point(10, 68);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.gunaPanel5.Size = new System.Drawing.Size(1144, 490);
            this.gunaPanel5.TabIndex = 9;
            // 
            // data_View
            // 
            this.data_View.AllowUserToAddRows = false;
            this.data_View.AllowUserToDeleteRows = false;
            this.data_View.AllowUserToResizeColumns = false;
            this.data_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.data_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.data_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_View.BackgroundColor = System.Drawing.Color.White;
            this.data_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_View.DefaultCellStyle = dataGridViewCellStyle15;
            this.data_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_View.EnableHeadersVisualStyles = false;
            this.data_View.GridColor = System.Drawing.Color.Gainsboro;
            this.data_View.Location = new System.Drawing.Point(0, 8);
            this.data_View.Margin = new System.Windows.Forms.Padding(0);
            this.data_View.MultiSelect = false;
            this.data_View.Name = "data_View";
            this.data_View.ReadOnly = true;
            this.data_View.RowHeadersVisible = false;
            this.data_View.RowTemplate.DividerHeight = 1;
            this.data_View.RowTemplate.ReadOnly = true;
            this.data_View.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_View.ShowCellErrors = false;
            this.data_View.ShowCellToolTips = false;
            this.data_View.ShowEditingIcon = false;
            this.data_View.ShowRowErrors = false;
            this.data_View.Size = new System.Drawing.Size(1144, 482);
            this.data_View.TabIndex = 2;
            this.data_View.Tag = "Table";
            this.data_View.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.data_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.BackColor = System.Drawing.Color.White;
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
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.info_Label);
            this.gunaPanel4.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(10, 5);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(1144, 63);
            this.gunaPanel4.TabIndex = 8;
            // 
            // info_Label
            // 
            this.info_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_Label.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.info_Label.Location = new System.Drawing.Point(626, 0);
            this.info_Label.Margin = new System.Windows.Forms.Padding(0);
            this.info_Label.Name = "info_Label";
            this.info_Label.Size = new System.Drawing.Size(518, 63);
            this.info_Label.TabIndex = 0;
            this.info_Label.Text = "\r\n";
            this.info_Label.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PRIS_Search);
            this.flowLayoutPanel1.Controls.Add(this.refresh_Btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(626, 63);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PRIS_Search
            // 
            this.PRIS_Search.Location = new System.Drawing.Point(3, 3);
            this.PRIS_Search.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.PRIS_Search.Name = "PRIS_Search";
            this.PRIS_Search.Search_Text = "";
            this.PRIS_Search.Size = new System.Drawing.Size(550, 60);
            this.PRIS_Search.TabIndex = 3;
            // 
            // refresh_Btn
            // 
            this.refresh_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.refresh_Btn.Location = new System.Drawing.Point(558, 5);
            this.refresh_Btn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 8);
            this.refresh_Btn.Name = "refresh_Btn";
            this.refresh_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.refresh_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh_Btn.OnHoverImage = null;
            this.refresh_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.refresh_Btn.Radius = 6;
            this.refresh_Btn.Size = new System.Drawing.Size(55, 55);
            this.refresh_Btn.TabIndex = 4;
            this.refresh_Btn.Click += new System.EventHandler(this.refresh_Btn_Click);
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.Controls.Add(this.create_Btn);
            this.gunaPanel6.Controls.Add(this.cancel_Btn);
            this.gunaPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel6.Location = new System.Drawing.Point(10, 558);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.gunaPanel6.Size = new System.Drawing.Size(1144, 63);
            this.gunaPanel6.TabIndex = 7;
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
            this.create_Btn.Image = null;
            this.create_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.create_Btn.Location = new System.Drawing.Point(1034, 8);
            this.create_Btn.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.create_Btn.Name = "create_Btn";
            this.create_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.create_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.create_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.create_Btn.OnHoverImage = null;
            this.create_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.create_Btn.Radius = 8;
            this.create_Btn.Size = new System.Drawing.Size(110, 55);
            this.create_Btn.TabIndex = 10;
            this.create_Btn.Text = "Restore";
            this.create_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.cancel_Btn.Image = null;
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
            this.cancel_Btn.Size = new System.Drawing.Size(93, 55);
            this.cancel_Btn.TabIndex = 9;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(10, 65);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1164, 5);
            this.gunaPanel2.TabIndex = 4;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.selector_Title);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(10, 10);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1164, 55);
            this.gunaPanel1.TabIndex = 3;
            // 
            // selector_Title
            // 
            this.selector_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.selector_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.selector_Title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selector_Title.ForeColor = System.Drawing.Color.White;
            this.selector_Title.Location = new System.Drawing.Point(0, 0);
            this.selector_Title.Name = "selector_Title";
            this.selector_Title.Size = new System.Drawing.Size(250, 55);
            this.selector_Title.TabIndex = 0;
            this.selector_Title.Text = "Trash";
            this.selector_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.data_View;
            // 
            // Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Trash";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Trash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trash_FormClosing);
            this.Load += new System.EventHandler(this.Trash_Load);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gunaPanel6.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaDataGridView data_View;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaLabel info_Label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControlUtil.PRIS_UserControl.PRIS_Search_DropBox PRIS_Search;
        private Guna.UI.WinForms.GunaButton refresh_Btn;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaButton create_Btn;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel selector_Title;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}