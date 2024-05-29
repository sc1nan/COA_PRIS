namespace COA_PRIS.UserControlUtil
{
    partial class DateFilter
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
            this.from_DateTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.to_DateTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.65018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.34982F));
            this.tableLayoutPanel1.Controls.Add(this.from_DateTimePicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunaLabel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.to_DateTimePicker, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 60);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // from_DateTimePicker
            // 
            this.from_DateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.from_DateTimePicker.BaseColor = System.Drawing.Color.White;
            this.from_DateTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.from_DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.from_DateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.from_DateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.from_DateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.from_DateTimePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.from_DateTimePicker.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_DateTimePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.from_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_DateTimePicker.Location = new System.Drawing.Point(70, 3);
            this.from_DateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.from_DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.from_DateTimePicker.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.from_DateTimePicker.Name = "from_DateTimePicker";
            this.from_DateTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.from_DateTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.from_DateTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.from_DateTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.from_DateTimePicker.Radius = 6;
            this.from_DateTimePicker.Size = new System.Drawing.Size(256, 54);
            this.from_DateTimePicker.TabIndex = 6;
            this.from_DateTimePicker.Text = "April 22, 2024";
            this.from_DateTimePicker.Value = new System.DateTime(2024, 4, 22, 0, 0, 0, 0);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaLabel1.Location = new System.Drawing.Point(329, 18);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(37, 23);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "To :";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Location = new System.Drawing.Point(6, 18);
            this.title.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(64, 23);
            this.title.TabIndex = 4;
            this.title.Text = "From :";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // to_DateTimePicker
            // 
            this.to_DateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.to_DateTimePicker.BaseColor = System.Drawing.Color.White;
            this.to_DateTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.to_DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_DateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.to_DateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.to_DateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.to_DateTimePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.to_DateTimePicker.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_DateTimePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.to_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to_DateTimePicker.Location = new System.Drawing.Point(366, 3);
            this.to_DateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.to_DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.to_DateTimePicker.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.to_DateTimePicker.Name = "to_DateTimePicker";
            this.to_DateTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.to_DateTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.to_DateTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.to_DateTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.to_DateTimePicker.Radius = 6;
            this.to_DateTimePicker.Size = new System.Drawing.Size(231, 54);
            this.to_DateTimePicker.TabIndex = 3;
            this.to_DateTimePicker.Text = "April 22, 2024";
            this.to_DateTimePicker.Value = new System.DateTime(2024, 4, 22, 0, 0, 0, 0);
            // 
            // DateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DateFilter";
            this.Size = new System.Drawing.Size(600, 60);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaDateTimePicker to_DateTimePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaDateTimePicker from_DateTimePicker;
    }
}
