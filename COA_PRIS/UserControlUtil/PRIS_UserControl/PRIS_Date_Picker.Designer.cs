﻿namespace COA_PRIS.UserControlUtil.PRIS_UserControl
{
    partial class PRIS_Date_Picker
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.message = new Guna.UI.WinForms.GunaLabel();
            this.control_Panel = new Guna.UI.WinForms.GunaPanel();
            this.date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.readOnly_Entry = new Guna.UI.WinForms.GunaTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.control_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.control_Panel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Tag = "Entry";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.message, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 40);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(57, 40);
            this.title.TabIndex = 2;
            this.title.Text = "Label";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Gray;
            this.message.Location = new System.Drawing.Point(60, 18);
            this.message.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 19);
            this.message.TabIndex = 3;
            this.message.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // control_Panel
            // 
            this.control_Panel.Controls.Add(this.date);
            this.control_Panel.Controls.Add(this.readOnly_Entry);
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(0, 40);
            this.control_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Padding = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.control_Panel.Size = new System.Drawing.Size(400, 60);
            this.control_Panel.TabIndex = 1;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.BaseColor = System.Drawing.Color.White;
            this.date.BorderColor = System.Drawing.Color.Silver;
            this.date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date.CustomFormat = null;
            this.date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.date.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.date.Location = new System.Drawing.Point(3, 3);
            this.date.Margin = new System.Windows.Forms.Padding(0);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.OnHoverBaseColor = System.Drawing.Color.White;
            this.date.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.date.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.date.OnPressedColor = System.Drawing.Color.Black;
            this.date.Radius = 6;
            this.date.Size = new System.Drawing.Size(377, 54);
            this.date.TabIndex = 2;
            this.date.Text = "Monday, April 22, 2024";
            this.date.Value = new System.DateTime(2024, 4, 22, 0, 0, 0, 0);
            // 
            // readOnly_Entry
            // 
            this.readOnly_Entry.BackColor = System.Drawing.Color.Transparent;
            this.readOnly_Entry.BaseColor = System.Drawing.Color.White;
            this.readOnly_Entry.BorderColor = System.Drawing.Color.Silver;
            this.readOnly_Entry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.readOnly_Entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readOnly_Entry.FocusedBaseColor = System.Drawing.Color.White;
            this.readOnly_Entry.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnly_Entry.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnly_Entry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnly_Entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.readOnly_Entry.Location = new System.Drawing.Point(3, 3);
            this.readOnly_Entry.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.readOnly_Entry.MaxLength = 64;
            this.readOnly_Entry.Name = "readOnly_Entry";
            this.readOnly_Entry.PasswordChar = '\0';
            this.readOnly_Entry.Radius = 6;
            this.readOnly_Entry.ReadOnly = true;
            this.readOnly_Entry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.readOnly_Entry.SelectedText = "";
            this.readOnly_Entry.Size = new System.Drawing.Size(377, 54);
            this.readOnly_Entry.TabIndex = 8;
            this.readOnly_Entry.Tag = "";
            // 
            // PRIS_Date_Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PRIS_Date_Picker";
            this.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.control_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel control_Panel;
        private Guna.UI.WinForms.GunaDateTimePicker date;
        private Guna.UI.WinForms.GunaTextBox readOnly_Entry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaLabel message;
    }
}
