namespace COA_PRIS
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.Loginbtn = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Password = new Guna.UI.WinForms.GunaLineTextBox();
            this.Username = new Guna.UI.WinForms.GunaLineTextBox();
            this.logo = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel4.SuspendLayout();
            this.gunaElipsePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Loginbtn.AnimationHoverSpeed = 0.07F;
            this.Loginbtn.AnimationSpeed = 0.03F;
            this.Loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.Loginbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            this.Loginbtn.BorderColor = System.Drawing.Color.Black;
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Loginbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Loginbtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Image = null;
            this.Loginbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Loginbtn.Location = new System.Drawing.Point(146, 440);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Loginbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Loginbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Loginbtn.OnHoverImage = null;
            this.Loginbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Loginbtn.Radius = 10;
            this.Loginbtn.Size = new System.Drawing.Size(123, 45);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            this.gunaElipsePanel4.Controls.Add(this.gunaElipsePanel5);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(450, 50);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Radius = 20;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(431, 580);
            this.gunaElipsePanel4.TabIndex = 2;
            // 
            // gunaElipsePanel5
            // 
            this.gunaElipsePanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gunaElipsePanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel5.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel5.Controls.Add(this.Password);
            this.gunaElipsePanel5.Controls.Add(this.Username);
            this.gunaElipsePanel5.Controls.Add(this.logo);
            this.gunaElipsePanel5.Controls.Add(this.Loginbtn);
            this.gunaElipsePanel5.Location = new System.Drawing.Point(10, 11);
            this.gunaElipsePanel5.Name = "gunaElipsePanel5";
            this.gunaElipsePanel5.Radius = 20;
            this.gunaElipsePanel5.Size = new System.Drawing.Size(409, 556);
            this.gunaElipsePanel5.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.Password.LineSize = 2;
            this.Password.Location = new System.Drawing.Point(55, 373);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(291, 30);
            this.Password.TabIndex = 10;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Username.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.Username.LineSize = 2;
            this.Username.Location = new System.Drawing.Point(55, 296);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.SelectedText = "";
            this.Username.Size = new System.Drawing.Size(291, 30);
            this.Username.TabIndex = 9;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.logo.BaseColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(135, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(143, 145);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            this.logo.UseTransfarantBackground = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.gunaElipsePanel4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(450, 650);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.gunaElipsePanel4.ResumeLayout(false);
            this.gunaElipsePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton Loginbtn;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel5;
        private Guna.UI.WinForms.GunaLineTextBox Username;
        private Guna.UI.WinForms.GunaLineTextBox Password;
        private Guna.UI.WinForms.GunaCirclePictureBox logo;
    }
}