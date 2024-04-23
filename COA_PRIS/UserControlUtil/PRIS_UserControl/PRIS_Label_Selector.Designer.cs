namespace COA_PRIS.UserControlUtil
{
    partial class PRIS_Label_Selector
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
            this.entry = new Guna.UI.WinForms.GunaTextBox();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.search = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.entry, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.search, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Tag = "Entry";
            // 
            // entry
            // 
            this.entry.BackColor = System.Drawing.Color.Transparent;
            this.entry.BaseColor = System.Drawing.Color.White;
            this.entry.BorderColor = System.Drawing.Color.Silver;
            this.entry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry.FocusedBaseColor = System.Drawing.Color.White;
            this.entry.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.Location = new System.Drawing.Point(3, 43);
            this.entry.MaxLength = 64;
            this.entry.Name = "entry";
            this.entry.PasswordChar = '\0';
            this.entry.Radius = 6;
            this.entry.ReadOnly = true;
            this.entry.SelectedText = "";
            this.entry.Size = new System.Drawing.Size(320, 54);
            this.entry.TabIndex = 2;
            this.entry.Tag = "req!";
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
            // search
            // 
            this.search.AnimationHoverSpeed = 0.07F;
            this.search.AnimationSpeed = 0.03F;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.search.BorderColor = System.Drawing.Color.Black;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.search.Dock = System.Windows.Forms.DockStyle.Left;
            this.search.FocusedColor = System.Drawing.Color.Empty;
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Image = global::COA_PRIS.Properties.Resources.magnifying_glass;
            this.search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.ImageSize = new System.Drawing.Size(25, 25);
            this.search.Location = new System.Drawing.Point(326, 43);
            this.search.Margin = new System.Windows.Forms.Padding(0, 3, 20, 3);
            this.search.Name = "search";
            this.search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.search.OnHoverForeColor = System.Drawing.Color.White;
            this.search.OnHoverImage = null;
            this.search.OnPressedColor = System.Drawing.Color.Black;
            this.search.Radius = 8;
            this.search.Size = new System.Drawing.Size(54, 54);
            this.search.TabIndex = 3;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // PRIS_Label_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PRIS_Label_Selector";
            this.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaTextBox entry;
        private Guna.UI.WinForms.GunaButton search;
    }
}
