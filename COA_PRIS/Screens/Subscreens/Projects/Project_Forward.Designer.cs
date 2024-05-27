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
            this.cancel_Btn = new Guna.UI.WinForms.GunaButton();
            this.save_Btn = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.content_Panel = new Guna.UI.WinForms.GunaPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.parent_Panel = new Guna.UI.WinForms.GunaPanel();
            this.title_Panel = new Guna.UI.WinForms.GunaPanel();
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
            this.bottom_Panel.Controls.Add(this.cancel_Btn);
            this.bottom_Panel.Controls.Add(this.save_Btn);
            this.bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_Panel.Location = new System.Drawing.Point(10, 838);
            this.bottom_Panel.Name = "bottom_Panel";
            this.bottom_Panel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 8);
            this.bottom_Panel.Size = new System.Drawing.Size(1164, 63);
            this.bottom_Panel.TabIndex = 2;
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.AnimationHoverSpeed = 0.07F;
            this.cancel_Btn.AnimationSpeed = 0.03F;
            this.cancel_Btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.cancel_Btn.BorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancel_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.cancel_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Image = global::COA_PRIS.Properties.Resources.close;
            this.cancel_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.cancel_Btn.Location = new System.Drawing.Point(10, 0);
            this.cancel_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.cancel_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancel_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancel_Btn.OnHoverImage = null;
            this.cancel_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.cancel_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_Btn.Radius = 8;
            this.cancel_Btn.Size = new System.Drawing.Size(130, 55);
            this.cancel_Btn.TabIndex = 11;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // save_Btn
            // 
            this.save_Btn.AnimationHoverSpeed = 0.07F;
            this.save_Btn.AnimationSpeed = 0.03F;
            this.save_Btn.BackColor = System.Drawing.Color.Transparent;
            this.save_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.save_Btn.BorderColor = System.Drawing.Color.Black;
            this.save_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.save_Btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Btn.ForeColor = System.Drawing.Color.White;
            this.save_Btn.Image = null;
            this.save_Btn.ImageSize = new System.Drawing.Size(20, 20);
            this.save_Btn.Location = new System.Drawing.Point(976, 0);
            this.save_Btn.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.save_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.save_Btn.OnHoverImage = null;
            this.save_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.save_Btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.save_Btn.Radius = 8;
            this.save_Btn.Size = new System.Drawing.Size(178, 55);
            this.save_Btn.TabIndex = 10;
            this.save_Btn.Text = "Confirm Forward";
            this.save_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_Btn.Click += new System.EventHandler(this.proceed_Btn_Click);
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
            this.content_Panel.Size = new System.Drawing.Size(1164, 763);
            this.content_Panel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.parent_Panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.title_Panel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 743);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // parent_Panel
            // 
            this.parent_Panel.BackColor = System.Drawing.Color.White;
            this.parent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent_Panel.Location = new System.Drawing.Point(0, 130);
            this.parent_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.parent_Panel.Name = "parent_Panel";
            this.parent_Panel.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.parent_Panel.Size = new System.Drawing.Size(1144, 613);
            this.parent_Panel.TabIndex = 2;
            // 
            // title_Panel
            // 
            this.title_Panel.BackColor = System.Drawing.Color.White;
            this.title_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.title_Panel.Location = new System.Drawing.Point(0, 0);
            this.title_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.title_Panel.Name = "title_Panel";
            this.title_Panel.Padding = new System.Windows.Forms.Padding(10, 0, 5, 5);
            this.title_Panel.Size = new System.Drawing.Size(550, 120);
            this.title_Panel.TabIndex = 0;
            // 
            // gunaElipse
            // 
            this.gunaElipse.Radius = 6;
            this.gunaElipse.TargetControl = this.title_Panel;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.parent_Panel;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Project_Forward_FormClosing);
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
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaPanel title_Panel;
        private Guna.UI.WinForms.GunaPanel parent_Panel;
        private Guna.UI.WinForms.GunaButton cancel_Btn;
        private Guna.UI.WinForms.GunaButton save_Btn;
    }
}