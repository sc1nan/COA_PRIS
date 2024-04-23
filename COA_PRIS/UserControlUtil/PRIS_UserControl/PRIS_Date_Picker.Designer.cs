namespace COA_PRIS.UserControlUtil.PRIS_UserControl
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
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.date, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Tag = "Entry";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(57, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Label";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.BaseColor = System.Drawing.Color.White;
            this.date.BorderColor = System.Drawing.Color.Silver;
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.CustomFormat = null;
            this.date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.date.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.date.Location = new System.Drawing.Point(3, 43);
            this.date.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(2024, 4, 18, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.OnHoverBaseColor = System.Drawing.Color.White;
            this.date.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.date.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.date.OnPressedColor = System.Drawing.Color.Black;
            this.date.Radius = 6;
            this.date.Size = new System.Drawing.Size(377, 54);
            this.date.TabIndex = 1;
            this.date.Text = "Monday, April 22, 2024";
            this.date.Value = new System.DateTime(2024, 4, 22, 0, 0, 0, 0);
            // 
            // PRIS_Date_Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PRIS_Date_Picker";
            this.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaDateTimePicker date;
    }
}
