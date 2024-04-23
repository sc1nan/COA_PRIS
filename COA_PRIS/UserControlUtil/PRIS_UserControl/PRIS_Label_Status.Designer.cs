namespace COA_PRIS.UserControlUtil.PRIS_UserControl
{
    partial class PRIS_Label_Status
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
            this.entry = new Guna.UI.WinForms.GunaComboBox();
            this.icon = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.icon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.entry, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(79, 50);
            this.title.TabIndex = 1;
            this.title.Text = "Status : ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entry
            // 
            this.entry.BackColor = System.Drawing.Color.Transparent;
            this.entry.BaseColor = System.Drawing.Color.White;
            this.entry.BorderColor = System.Drawing.Color.Silver;
            this.entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.entry.DropDownHeight = 120;
            this.entry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entry.FocusedColor = System.Drawing.Color.Empty;
            this.entry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry.ForeColor = System.Drawing.Color.Black;
            this.entry.FormattingEnabled = true;
            this.entry.IntegralHeight = false;
            this.entry.ItemHeight = 38;
            this.entry.Location = new System.Drawing.Point(138, 3);
            this.entry.MaxDropDownItems = 10;
            this.entry.Name = "entry";
            this.entry.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.entry.OnHoverItemForeColor = System.Drawing.Color.White;
            this.entry.Radius = 10;
            this.entry.Size = new System.Drawing.Size(209, 44);
            this.entry.TabIndex = 3;
            this.entry.TextChanged += new System.EventHandler(this.entry_TextChanged);
            // 
            // icon
            // 
            this.icon.BaseColor = System.Drawing.Color.DarkGray;
            this.icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icon.Image = global::COA_PRIS.Properties.Resources.active;
            this.icon.Location = new System.Drawing.Point(90, 5);
            this.icon.Margin = new System.Windows.Forms.Padding(5);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(40, 40);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 2;
            this.icon.TabStop = false;
            this.icon.UseTransfarantBackground = false;
            // 
            // PRIS_Label_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PRIS_Label_Status";
            this.Size = new System.Drawing.Size(350, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaComboBox entry;
        private Guna.UI.WinForms.GunaCirclePictureBox icon;
    }
}
