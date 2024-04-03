namespace COA_PRIS.UserControlUtil
{
    partial class Label_Drop
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
            this.dropbox = new Guna.UI.WinForms.GunaComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dropbox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.TabIndex = 1;
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
            // dropbox
            // 
            this.dropbox.BackColor = System.Drawing.Color.Transparent;
            this.dropbox.BaseColor = System.Drawing.Color.White;
            this.dropbox.BorderColor = System.Drawing.Color.Silver;
            this.dropbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropbox.FocusedColor = System.Drawing.Color.Empty;
            this.dropbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.dropbox.FormattingEnabled = true;
            this.dropbox.ItemHeight = 40;
            this.dropbox.Location = new System.Drawing.Point(3, 43);
            this.dropbox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dropbox.Name = "dropbox";
            this.dropbox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.dropbox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.dropbox.Radius = 8;
            this.dropbox.Size = new System.Drawing.Size(377, 46);
            this.dropbox.TabIndex = 1;
            this.dropbox.TextChanged += new System.EventHandler(this.dropbox_TextChanged);
            // 
            // Label_Drop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Label_Drop";
            this.Size = new System.Drawing.Size(400, 100);
            this.Load += new System.EventHandler(this.Label_Drop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaComboBox dropbox;
    }
}
