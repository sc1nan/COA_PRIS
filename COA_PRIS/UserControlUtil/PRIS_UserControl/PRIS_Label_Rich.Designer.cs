﻿namespace COA_PRIS.UserControlUtil.PRIS_UserControl
{
    partial class PRIS_Label_Rich
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
            this.entry_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.entry = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.entry_Panel.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.entry_Panel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 150);
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
            // entry_Panel
            // 
            this.entry_Panel.BackColor = System.Drawing.Color.Transparent;
            this.entry_Panel.BaseColor = System.Drawing.Color.LightGray;
            this.entry_Panel.Controls.Add(this.gunaElipsePanel2);
            this.entry_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry_Panel.Location = new System.Drawing.Point(3, 43);
            this.entry_Panel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.entry_Panel.Name = "entry_Panel";
            this.entry_Panel.Padding = new System.Windows.Forms.Padding(3);
            this.entry_Panel.Size = new System.Drawing.Size(377, 104);
            this.entry_Panel.TabIndex = 1;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.entry);
            this.gunaElipsePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel2.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Padding = new System.Windows.Forms.Padding(4);
            this.gunaElipsePanel2.Radius = 4;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(371, 98);
            this.gunaElipsePanel2.TabIndex = 0;
            // 
            // entry
            // 
            this.entry.BackColor = System.Drawing.Color.White;
            this.entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry.Location = new System.Drawing.Point(4, 4);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(363, 90);
            this.entry.TabIndex = 0;
            this.entry.Text = "";
            this.entry.Enter += new System.EventHandler(this.entry_Enter);
            this.entry.Leave += new System.EventHandler(this.entry_Leave);
            // 
            // PRIS_Label_Rich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PRIS_Label_Rich";
            this.Size = new System.Drawing.Size(400, 150);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.entry_Panel.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaElipsePanel entry_Panel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.RichTextBox entry;
    }
}
