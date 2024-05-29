namespace COA_PRIS.UserControlUtil
{
    partial class SearchBar
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
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.search_box = new Guna.UI.WinForms.GunaTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.search_box, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunaPictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::COA_PRIS.Properties.Resources.search1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(3, 6);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(48, 48);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 15;
            this.gunaPictureBox1.TabStop = false;
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.Color.Transparent;
            this.search_box.BaseColor = System.Drawing.Color.White;
            this.search_box.BorderColor = System.Drawing.Color.Silver;
            this.search_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_box.FocusedBaseColor = System.Drawing.Color.White;
            this.search_box.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.search_box.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.search_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.search_box.Location = new System.Drawing.Point(60, 2);
            this.search_box.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.search_box.MaxLength = 64;
            this.search_box.Name = "search_box";
            this.search_box.PasswordChar = '\0';
            this.search_box.Radius = 6;
            this.search_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.search_box.SelectedText = "";
            this.search_box.Size = new System.Drawing.Size(434, 56);
            this.search_box.TabIndex = 16;
            this.search_box.Tag = "";
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(500, 60);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTextBox search_box;
    }
}
