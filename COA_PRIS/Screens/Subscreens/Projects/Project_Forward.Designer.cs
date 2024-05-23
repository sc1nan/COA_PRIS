namespace COA_PRIS.Screens.Subscreens.Projects
{
    partial class Project_Forward
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
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.project_id = new Guna.UI.WinForms.GunaLabel();
            this.bottom_Panel = new Guna.UI.WinForms.GunaPanel();
            this.proceed_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.parent_Panel = new Guna.UI.WinForms.GunaPanel();
            this.selection_Panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.top_Panel.SuspendLayout();
            this.bottom_Panel.SuspendLayout();
            this.content_Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.flowLayoutPanel1);
            this.top_Panel.Controls.Add(this.project_id);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(10, 10);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1164, 60);
            this.top_Panel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(220, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(944, 60);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // project_id
            // 
            this.project_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.project_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.project_id.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_id.ForeColor = System.Drawing.Color.White;
            this.project_id.Location = new System.Drawing.Point(0, 0);
            this.project_id.Name = "project_id";
            this.project_id.Size = new System.Drawing.Size(220, 60);
            this.project_id.TabIndex = 1;
            this.project_id.Text = "PRJ000000001";
            this.project_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottom_Panel
            // 
            this.bottom_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottom_Panel.Controls.Add(this.proceed_Btn);
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_Panel.Location = new System.Drawing.Point(10, 841);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 8);
            this.bottom_Panel.Size = new System.Drawing.Size(1164, 60);
            this.bottom_Panel.TabIndex = 2;
            // 
            // proceed_Btn
            // 
            this.proceed_Btn.AnimationHoverSpeed = 0.07F;
            this.proceed_Btn.AnimationSpeed = 0.03F;
            this.proceed_Btn.BackColor = System.Drawing.Color.Transparent;
            this.proceed_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.proceed_Btn.BorderColor = System.Drawing.Color.Black;
            this.proceed_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.proceed_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.proceed_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.proceed_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_Btn.ForeColor = System.Drawing.Color.White;
            this.proceed_Btn.Image = null;
            this.proceed_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.proceed_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.proceed_Btn.Location = new System.Drawing.Point(1044, 0);
            this.proceed_Btn.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.proceed_Btn.Name = "proceed_Btn";
            this.proceed_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.proceed_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.proceed_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.proceed_Btn.OnHoverImage = null;
            this.proceed_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.proceed_Btn.Radius = 5;
            this.proceed_Btn.Size = new System.Drawing.Size(110, 52);
            this.proceed_Btn.TabIndex = 13;
            this.proceed_Btn.Text = "Proceed";
            this.proceed_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.proceed_Btn.Click += new System.EventHandler(this.proceed_Btn_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(10, 70);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1164, 5);
            this.gunaLinePanel1.TabIndex = 3;
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.content_Panel.Controls.Add(this.tableLayoutPanel1);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(10, 75);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.content_Panel.Size = new System.Drawing.Size(1164, 766);
            this.content_Panel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.parent_Panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.selection_Panel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 746);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // parent_Panel
            // 
            this.parent_Panel.BackColor = System.Drawing.Color.White;
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(0, 0);
            this.parent_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Padding = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.parent_Panel.Size = new System.Drawing.Size(1144, 646);
            this.parent_Panel.TabIndex = 1;
            // 
            // selection_Panel
            // 
            this.selection_Panel.BackColor = System.Drawing.Color.White;
            this.selection_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selection_Panel.Location = new System.Drawing.Point(0, 656);
            this.selection_Panel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.selection_Panel.Name = "selection_Panel";
            this.selection_Panel.Padding = new System.Windows.Forms.Padding(5);
            this.selection_Panel.Size = new System.Drawing.Size(1144, 90);
            this.selection_Panel.TabIndex = 2;
            // 
            // gunaElipse
            // 
            this.gunaElipse.Radius = 6;
            this.gunaElipse.TargetControl = this.parent_Panel;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.selection_Panel;
            // 
            // Project_Forward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.content_Panel);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.bottom_Panel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Project_Forward";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project_Forward";
            this.top_Panel.ResumeLayout(false);
            this.bottom_Panel.ResumeLayout(false);
            this.content_Panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel top_Panel;
        private Guna.UI.WinForms.GunaPanel bottom_Panel;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaPanel content_Panel;
        private Guna.UI.WinForms.GunaLabel project_id;
        private Guna.UI.WinForms.GunaElipse gunaElipse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton proceed_Btn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel parent_Panel;
        private Guna.UI.WinForms.GunaPanel selection_Panel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}