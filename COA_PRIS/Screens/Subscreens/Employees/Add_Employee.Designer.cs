﻿namespace COA_PRIS.Screens.Subscreens.Employees
{
    partial class Add_Employee
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
            this.parent_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.main_Panel = new Guna.UI.WinForms.GunaPanel();
            this.control_main_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.control_Panel = new Guna.UI.WinForms.GunaPanel();
            this.error_Panel = new Guna.UI.WinForms.GunaPanel();
            this.error_Message = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.button_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.save_Btn = new Guna.UI.WinForms.GunaButton();
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.control_top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.emp_id = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.error_Employee = new System.Windows.Forms.ErrorProvider(this.components);
            this.parent_Panel.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.main_Panel.SuspendLayout();
            this.control_main_Panel.SuspendLayout();
            this.error_Panel.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.button_Panel.SuspendLayout();
            this.control_top_Panel.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // parent_Panel
            // 
            this.parent_Panel.AutoSize = true;
            this.parent_Panel.BackColor = System.Drawing.Color.Transparent;
            this.parent_Panel.Controls.Add(this.gunaPanel4);
            this.parent_Panel.Controls.Add(this.gunaPanel3);
            this.parent_Panel.Controls.Add(this.top_Panel);
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(8, 8);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Size = new System.Drawing.Size(1088, 795);
            this.parent_Panel.TabIndex = 0;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel4.Controls.Add(this.main_Panel);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 60);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Padding = new System.Windows.Forms.Padding(8);
            this.gunaPanel4.Size = new System.Drawing.Size(1088, 735);
            this.gunaPanel4.TabIndex = 3;
            // 
            // main_Panel
            // 
            this.main_Panel.Controls.Add(this.control_main_Panel);
            this.main_Panel.Controls.Add(this.gunaPanel5);
            this.main_Panel.Controls.Add(this.control_top_Panel);
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(8, 8);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(1072, 719);
            this.main_Panel.TabIndex = 1;
            // 
            // control_main_Panel
            // 
            this.control_main_Panel.BackColor = System.Drawing.Color.Transparent;
            this.control_main_Panel.BaseColor = System.Drawing.Color.White;
            this.control_main_Panel.Controls.Add(this.control_Panel);
            this.control_main_Panel.Controls.Add(this.error_Panel);
            this.control_main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_main_Panel.Location = new System.Drawing.Point(0, 63);
            this.control_main_Panel.Name = "control_main_Panel";
            this.control_main_Panel.Padding = new System.Windows.Forms.Padding(15, 20, 15, 5);
            this.control_main_Panel.Size = new System.Drawing.Size(1072, 596);
            this.control_main_Panel.TabIndex = 3;
            // 
            // control_Panel
            // 
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(15, 20);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Size = new System.Drawing.Size(1042, 539);
            this.control_Panel.TabIndex = 1;
            // 
            // error_Panel
            // 
            this.error_Panel.Controls.Add(this.error_Message);
            this.error_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.error_Panel.Location = new System.Drawing.Point(15, 559);
            this.error_Panel.Name = "error_Panel";
            this.error_Panel.Size = new System.Drawing.Size(1042, 32);
            this.error_Panel.TabIndex = 0;
            // 
            // error_Message
            // 
            this.error_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.error_Message.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_Message.ForeColor = System.Drawing.Color.Red;
            this.error_Message.Location = new System.Drawing.Point(0, 0);
            this.error_Message.Margin = new System.Windows.Forms.Padding(3);
            this.error_Message.Name = "error_Message";
            this.error_Message.Padding = new System.Windows.Forms.Padding(5);
            this.error_Message.Size = new System.Drawing.Size(1042, 32);
            this.error_Message.TabIndex = 4;
            this.error_Message.Text = "Error Message";
            this.error_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_Message.Visible = false;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel5.Controls.Add(this.button_Panel);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 659);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(1072, 60);
            this.gunaPanel5.TabIndex = 2;
            // 
            // button_Panel
            // 
            this.button_Panel.BackColor = System.Drawing.Color.Transparent;
            this.button_Panel.ColumnCount = 2;
            this.button_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.button_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.button_Panel.Controls.Add(this.save_Btn, 0, 0);
            this.button_Panel.Controls.Add(this.cancel_Btn, 0, 0);
            this.button_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Panel.Location = new System.Drawing.Point(0, 0);
            this.button_Panel.Name = "button_Panel";
            this.button_Panel.RowCount = 1;
            this.button_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.button_Panel.Size = new System.Drawing.Size(1072, 60);
            this.button_Panel.TabIndex = 0;
            // 
            // save_Btn
            // 
            this.save_Btn.AnimationHoverSpeed = 0.07F;
            this.save_Btn.AnimationSpeed = 0.03F;
            this.save_Btn.BackColor = System.Drawing.Color.Transparent;
            this.save_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.save_Btn.BorderColor = System.Drawing.Color.Black;
            this.save_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.save_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Btn.ForeColor = System.Drawing.Color.White;
            this.save_Btn.Image = null;
            this.save_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.save_Btn.Location = new System.Drawing.Point(912, 8);
            this.save_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.save_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Btn.OnHoverImage = null;
            this.save_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.save_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.save_Btn.Radius = 8;
            this.save_Btn.Size = new System.Drawing.Size(160, 52);
            this.save_Btn.TabIndex = 3;
            this.save_Btn.Text = "Save Record";
            this.save_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.AnimationHoverSpeed = 0.07F;
            this.cancel_Btn.AnimationSpeed = 0.03F;
            this.cancel_Btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.cancel_Btn.BorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancel_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.cancel_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Image = null;
            this.cancel_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancel_Btn.Location = new System.Drawing.Point(0, 8);
            this.cancel_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cancel_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancel_Btn.OnHoverImage = null;
            this.cancel_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.cancel_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_Btn.Radius = 8;
            this.cancel_Btn.Size = new System.Drawing.Size(160, 52);
            this.cancel_Btn.TabIndex = 2;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // control_top_Panel
            // 
            this.control_top_Panel.BackColor = System.Drawing.Color.Transparent;
            this.control_top_Panel.Controls.Add(this.gunaElipsePanel1);
            this.control_top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.control_top_Panel.Location = new System.Drawing.Point(0, 0);
            this.control_top_Panel.Name = "control_top_Panel";
            this.control_top_Panel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.control_top_Panel.Size = new System.Drawing.Size(1072, 63);
            this.control_top_Panel.TabIndex = 1;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel1.Controls.Add(this.emp_id);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(230, 55);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // emp_id
            // 
            this.emp_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_id.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_id.Location = new System.Drawing.Point(0, 0);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(230, 55);
            this.emp_id.TabIndex = 1;
            this.emp_id.Text = "EmployeeID";
            this.emp_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 55);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1088, 5);
            this.gunaPanel3.TabIndex = 1;
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.gunaLabel1);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1088, 55);
            this.top_Panel.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(267, 55);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "New Employee Record";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error_Employee
            // 
            this.error_Employee.BlinkRate = 0;
            this.error_Employee.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_Employee.ContainerControl = this;
            // 
            // Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 811);
            this.Controls.Add(this.parent_Panel);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Employee";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIS Employee Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Employee_FormClosing);
            this.Load += new System.EventHandler(this.Add_Record_Load);
            this.parent_Panel.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.main_Panel.ResumeLayout(false);
            this.control_main_Panel.ResumeLayout(false);
            this.error_Panel.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            this.button_Panel.ResumeLayout(false);
            this.control_top_Panel.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.top_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel parent_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ErrorProvider error_Employee;
        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel emp_id;
        private Guna.UI.WinForms.GunaPanel main_Panel;
        private Guna.UI.WinForms.GunaPanel control_top_Panel;
        private Guna.UI.WinForms.GunaElipsePanel control_main_Panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private System.Windows.Forms.TableLayoutPanel button_Panel;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaButton save_Btn;
        private Guna.UI.WinForms.GunaPanel control_Panel;
        private Guna.UI.WinForms.GunaPanel error_Panel;
        private Guna.UI.WinForms.GunaLabel error_Message;
    }
}