﻿namespace COA_PRIS.Screens.Subscreens.Employees
{
    partial class Employee_Submodule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bottom_Panel = new Guna.UI.WinForms.GunaPanel();
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PRIS_Seachbox = new COA_PRIS.UserControlUtil.PRIS_UserControl.PRIS_Search_DropBox();
            this.refresh_Btn = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.add_Record = new Guna.UI.WinForms.GunaButton();
            this.view_Record = new Guna.UI.WinForms.GunaButton();
            this.container_subPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.data_View = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.top_Panel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.container_subPanel.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).BeginInit();
            this.SuspendLayout();
            // 
            // bottom_Panel
            // 
            this.bottom_Panel.BackColor = System.Drawing.Color.Transparent;
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_Panel.Location = new System.Drawing.Point(0, 762);
            this.bottom_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Size = new System.Drawing.Size(1567, 55);
            this.bottom_Panel.TabIndex = 4;
            // 
            // top_Panel
            // 
            this.top_Panel.BackColor = System.Drawing.Color.Transparent;
            this.top_Panel.Controls.Add(this.flowLayoutPanel2);
            this.top_Panel.Controls.Add(this.flowLayoutPanel1);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1567, 60);
            this.top_Panel.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.PRIS_Seachbox);
            this.flowLayoutPanel2.Controls.Add(this.refresh_Btn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1311, 60);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // PRIS_Seachbox
            // 
            this.PRIS_Seachbox.Location = new System.Drawing.Point(3, 3);
            this.PRIS_Seachbox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.PRIS_Seachbox.Name = "PRIS_Seachbox";
            this.PRIS_Seachbox.Search_Text = "";
            this.PRIS_Seachbox.Size = new System.Drawing.Size(620, 60);
            this.PRIS_Seachbox.TabIndex = 5;
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
            this.refresh_Btn.Location = new System.Drawing.Point(631, 5);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.add_Record);
            this.flowLayoutPanel1.Controls.Add(this.view_Record);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1311, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 60);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // add_Record
            // 
            this.add_Record.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Record.AnimationHoverSpeed = 0.07F;
            this.add_Record.AnimationSpeed = 0.03F;
            this.add_Record.BackColor = System.Drawing.Color.Transparent;
            this.add_Record.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.add_Record.BorderColor = System.Drawing.Color.Black;
            this.add_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Record.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_Record.FocusedColor = System.Drawing.Color.Empty;
            this.add_Record.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_Record.ForeColor = System.Drawing.Color.White;
            this.add_Record.Image = global::COA_PRIS.Properties.Resources.add_file;
            this.add_Record.ImageOffsetX = 8;
            this.add_Record.ImageSize = new System.Drawing.Size(35, 35);
            this.add_Record.Location = new System.Drawing.Point(8, 5);
            this.add_Record.Margin = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.add_Record.Name = "add_Record";
            this.add_Record.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.add_Record.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_Record.OnHoverForeColor = System.Drawing.Color.White;
            this.add_Record.OnHoverImage = null;
            this.add_Record.OnPressedColor = System.Drawing.Color.Black;
            this.add_Record.Radius = 6;
            this.add_Record.Size = new System.Drawing.Size(120, 55);
            this.add_Record.TabIndex = 7;
            this.add_Record.Tag = "AddRecord";
            this.add_Record.Text = "Add";
            this.add_Record.Click += new System.EventHandler(this.add_RecordBtn_Click);
            // 
            // view_Record
            // 
            this.view_Record.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_Record.AnimationHoverSpeed = 0.07F;
            this.view_Record.AnimationSpeed = 0.03F;
            this.view_Record.BackColor = System.Drawing.Color.Transparent;
            this.view_Record.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.view_Record.BorderColor = System.Drawing.Color.Black;
            this.view_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_Record.DialogResult = System.Windows.Forms.DialogResult.None;
            this.view_Record.FocusedColor = System.Drawing.Color.Empty;
            this.view_Record.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.view_Record.ForeColor = System.Drawing.Color.White;
            this.view_Record.Image = global::COA_PRIS.Properties.Resources.view_file;
            this.view_Record.ImageOffsetX = 8;
            this.view_Record.ImageSize = new System.Drawing.Size(35, 35);
            this.view_Record.Location = new System.Drawing.Point(136, 5);
            this.view_Record.Margin = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.view_Record.Name = "view_Record";
            this.view_Record.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(99)))), ((int)(((byte)(75)))));
            this.view_Record.OnHoverBorderColor = System.Drawing.Color.Black;
            this.view_Record.OnHoverForeColor = System.Drawing.Color.White;
            this.view_Record.OnHoverImage = null;
            this.view_Record.OnPressedColor = System.Drawing.Color.Black;
            this.view_Record.Radius = 6;
            this.view_Record.Size = new System.Drawing.Size(120, 55);
            this.view_Record.TabIndex = 8;
            this.view_Record.Tag = "ViewRecord";
            this.view_Record.Text = "View";
            this.view_Record.Click += new System.EventHandler(this.view_RecordBtn_Click);
            // 
            // container_subPanel
            // 
            this.container_subPanel.BackColor = System.Drawing.Color.Transparent;
            this.container_subPanel.Controls.Add(this.gunaPanel3);
            this.container_subPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_subPanel.Location = new System.Drawing.Point(0, 60);
            this.container_subPanel.Margin = new System.Windows.Forms.Padding(0);
            this.container_subPanel.Name = "container_subPanel";
            this.container_subPanel.Size = new System.Drawing.Size(1567, 702);
            this.container_subPanel.TabIndex = 5;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.White;
            this.gunaPanel3.Controls.Add(this.data_View);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Margin = new System.Windows.Forms.Padding(8);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.gunaPanel3.Size = new System.Drawing.Size(1567, 702);
            this.gunaPanel3.TabIndex = 0;
            // 
            // data_View
            // 
            this.data_View.AllowUserToAddRows = false;
            this.data_View.AllowUserToDeleteRows = false;
            this.data_View.AllowUserToResizeColumns = false;
            this.data_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.data_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_View.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_View.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.data_View.Size = new System.Drawing.Size(1567, 686);
            this.data_View.TabIndex = 1;
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
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.data_View;
            // 
            // Employee_Submodule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1567, 817);
            this.Controls.Add(this.container_subPanel);
            this.Controls.Add(this.bottom_Panel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Submodule";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employee_Submodule_Load);
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.container_subPanel.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaPanel bottom_Panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel container_subPanel;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaDataGridView data_View;
        private Guna.UI.WinForms.GunaButton add_Record;
        private Guna.UI.WinForms.GunaButton view_Record;
        private UserControlUtil.PRIS_UserControl.PRIS_Search_DropBox PRIS_Seachbox;
        private Guna.UI.WinForms.GunaButton refresh_Btn;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}