namespace COA_PRIS.Screens
{
    partial class Createboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Createboard));
            this.Createbtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // Createbtn
            // 
            this.Createbtn.AnimationHoverSpeed = 0.07F;
            this.Createbtn.AnimationSpeed = 0.03F;
            this.Createbtn.BackColor = System.Drawing.Color.Transparent;
            this.Createbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.Createbtn.BorderColor = System.Drawing.Color.Black;
            this.Createbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Createbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Createbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.ForeColor = System.Drawing.Color.White;
            this.Createbtn.Image = ((System.Drawing.Image)(resources.GetObject("Createbtn.Image")));
            this.Createbtn.ImageOffsetX = 5;
            this.Createbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.Createbtn.Location = new System.Drawing.Point(1461, 31);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Createbtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Createbtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.Createbtn.OnHoverImage = null;
            this.Createbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Createbtn.Radius = 10;
            this.Createbtn.Size = new System.Drawing.Size(115, 42);
            this.Createbtn.TabIndex = 1;
            this.Createbtn.Text = "Create";
            this.Createbtn.TextOffsetX = 2;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // Createboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 914);
            this.Controls.Add(this.Createbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Createboard";
            this.Text = "Createboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton Createbtn;
    }
}