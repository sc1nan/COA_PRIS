﻿namespace COA_PRIS.UserControlUtil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.page_count_textbox = new Guna.UI.WinForms.GunaTextBox();
            this.page_control_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.previous_button = new Guna.UI.WinForms.GunaButton();
            this.next_button = new Guna.UI.WinForms.GunaButton();
            this.bottom_panel = new System.Windows.Forms.TableLayoutPanel();
            this.data_table = new Guna.UI.WinForms.GunaDataGridView();
            this.top_panel = new System.Windows.Forms.TableLayoutPanel();
            this.date_table_panel = new Guna.UI.WinForms.GunaPanel();
            this.page_control_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            this.date_table_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // page_count_textbox
            // 
            this.page_count_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.page_count_textbox.BackColor = System.Drawing.Color.Transparent;
            this.page_count_textbox.BaseColor = System.Drawing.Color.Transparent;
            this.page_count_textbox.BorderColor = System.Drawing.Color.Transparent;
            this.page_count_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.page_count_textbox.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.page_count_textbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.page_count_textbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.page_count_textbox.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_count_textbox.Location = new System.Drawing.Point(59, 3);
            this.page_count_textbox.Name = "page_count_textbox";
            this.page_count_textbox.PasswordChar = '\0';
            this.page_count_textbox.SelectedText = "";
            this.page_count_textbox.Size = new System.Drawing.Size(64, 50);
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
            this.page_control_panel.BackColor = System.Drawing.Color.Transparent;
            this.page_control_panel.Controls.Add(this.previous_button);
            this.page_control_panel.Controls.Add(this.page_count_textbox);
            this.page_control_panel.Controls.Add(this.next_button);
            this.page_control_panel.Location = new System.Drawing.Point(389, 3);
            this.page_control_panel.Name = "page_control_panel";
            this.page_control_panel.Size = new System.Drawing.Size(182, 51);
            this.page_control_panel.TabIndex = 4;
            // 
            // previous_button
            // 
            this.previous_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.previous_button.AnimationHoverSpeed = 0.07F;
            this.previous_button.AnimationSpeed = 0.03F;
            this.previous_button.BackColor = System.Drawing.Color.Transparent;
            this.previous_button.BaseColor = System.Drawing.Color.Transparent;
            this.previous_button.BorderColor = System.Drawing.Color.Black;
            this.previous_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.previous_button.Enabled = false;
            this.previous_button.FocusedColor = System.Drawing.Color.Empty;
            this.previous_button.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold);
            this.previous_button.ForeColor = System.Drawing.Color.White;
            this.previous_button.Image = ((System.Drawing.Image)(resources.GetObject("previous_button.Image")));
            this.previous_button.ImageSize = new System.Drawing.Size(30, 30);
            this.previous_button.Location = new System.Drawing.Point(3, 3);
            this.previous_button.Name = "previous_button";
            this.previous_button.OnHoverBaseColor = System.Drawing.Color.White;
            this.previous_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.previous_button.OnHoverForeColor = System.Drawing.Color.White;
            this.previous_button.OnHoverImage = null;
            this.previous_button.OnPressedColor = System.Drawing.Color.Black;
            this.previous_button.Size = new System.Drawing.Size(50, 50);
            this.previous_button.TabIndex = 1;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // next_button
            // 
            this.next_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.next_button.AnimationHoverSpeed = 0.07F;
            this.next_button.AnimationSpeed = 0.03F;
            this.next_button.BackColor = System.Drawing.Color.Transparent;
            this.next_button.BaseColor = System.Drawing.Color.Transparent;
            this.next_button.BorderColor = System.Drawing.Color.Transparent;
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next_button.FocusedColor = System.Drawing.Color.Empty;
            this.next_button.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.ForeColor = System.Drawing.Color.White;
            this.next_button.Image = ((System.Drawing.Image)(resources.GetObject("next_button.Image")));
            this.next_button.ImageSize = new System.Drawing.Size(30, 30);
            this.next_button.Location = new System.Drawing.Point(129, 3);
            this.next_button.Name = "next_button";
            this.next_button.OnHoverBaseColor = System.Drawing.Color.White;
            this.next_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.next_button.OnHoverForeColor = System.Drawing.Color.White;
            this.next_button.OnHoverImage = null;
            this.next_button.OnPressedColor = System.Drawing.Color.Black;
            this.next_button.Size = new System.Drawing.Size(50, 50);
            this.next_button.TabIndex = 2;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.White;
            this.bottom_panel.ColumnCount = 1;
            this.bottom_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottom_panel.Controls.Add(this.page_control_panel, 0, 0);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 483);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.RowCount = 1;
            this.bottom_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottom_panel.Size = new System.Drawing.Size(960, 57);
            this.bottom_panel.TabIndex = 5;
            // 
            // data_table
            // 
            this.data_table.AllowUserToDeleteRows = false;
            this.data_table.AllowUserToResizeColumns = false;
            this.data_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.data_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_table.BackgroundColor = System.Drawing.Color.White;
            this.data_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_table.ColumnHeadersHeight = 20;
            this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_table.EnableHeadersVisualStyles = false;
            this.data_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_table.Location = new System.Drawing.Point(0, 0);
            this.data_table.Margin = new System.Windows.Forms.Padding(15);
            this.data_table.Name = "data_table";
            this.data_table.ReadOnly = true;
            this.data_table.RowHeadersVisible = false;
            this.data_table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_table.Size = new System.Drawing.Size(960, 443);
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
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.ColumnCount = 3;
            this.top_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.top_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.top_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.RowCount = 1;
            this.top_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.top_panel.Size = new System.Drawing.Size(960, 40);
            this.top_panel.TabIndex = 8;
            // 
            // date_table_panel
            // 
            this.date_table_panel.Controls.Add(this.data_table);
            this.date_table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_table_panel.Location = new System.Drawing.Point(0, 40);
            this.date_table_panel.Name = "date_table_panel";
            this.date_table_panel.Size = new System.Drawing.Size(960, 443);
            this.date_table_panel.TabIndex = 10;
            // 
            // DataTableMultiplePages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date_table_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.bottom_panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataTableMultiplePages";
            this.Size = new System.Drawing.Size(960, 540);
            this.page_control_panel.ResumeLayout(false);
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            this.date_table_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton previous_button;
        private Guna.UI.WinForms.GunaButton next_button;
        private Guna.UI.WinForms.GunaTextBox page_count_textbox;
        private System.Windows.Forms.FlowLayoutPanel page_control_panel;
        private System.Windows.Forms.TableLayoutPanel bottom_panel;
        private Guna.UI.WinForms.GunaDataGridView data_table;
        private System.Windows.Forms.TableLayoutPanel top_panel;
        private Guna.UI.WinForms.GunaPanel date_table_panel;
    }
}
