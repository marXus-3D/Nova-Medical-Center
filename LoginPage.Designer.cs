namespace Nova_Medical_Center
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.loginBtn = new MaterialSkin.Controls.MaterialButton();
            this.empBox = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameField = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordField = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginBtn.Depth = 0;
            this.loginBtn.HighEmphasis = true;
            this.loginBtn.Icon = null;
            this.loginBtn.Location = new System.Drawing.Point(226, 275);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginBtn.Size = new System.Drawing.Size(64, 36);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginBtn.UseAccentColor = false;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // empBox
            // 
            this.empBox.AutoResize = false;
            this.empBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.empBox.Depth = 0;
            this.empBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.empBox.DropDownHeight = 118;
            this.empBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empBox.DropDownWidth = 121;
            this.empBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.empBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.empBox.FormattingEnabled = true;
            this.empBox.IntegralHeight = false;
            this.empBox.ItemHeight = 29;
            this.empBox.Location = new System.Drawing.Point(6, 164);
            this.empBox.MaxDropDownItems = 4;
            this.empBox.MouseState = MaterialSkin.MouseState.OUT;
            this.empBox.Name = "empBox";
            this.empBox.Size = new System.Drawing.Size(83, 35);
            this.empBox.StartIndex = 0;
            this.empBox.TabIndex = 9;
            this.empBox.UseAccent = false;
            this.empBox.UseTallSize = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::Nova_Medical_Center.Properties.Resources.nova1;
            this.pictureBox2.Location = new System.Drawing.Point(190, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 50);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Nova_Medical_Center.Properties.Resources.novalogo;
            this.pictureBox1.Location = new System.Drawing.Point(190, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // usernameField
            // 
            this.usernameField.AnimateReadOnly = false;
            this.usernameField.BackColor = System.Drawing.Color.White;
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameField.Depth = 0;
            this.usernameField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameField.Hint = "Enter Username";
            this.usernameField.LeadingIcon = global::Nova_Medical_Center.Properties.Resources.icons8_user_100;
            this.usernameField.LeaveOnEnterKey = true;
            this.usernameField.Location = new System.Drawing.Point(95, 163);
            this.usernameField.MaxLength = 50;
            this.usernameField.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameField.Multiline = false;
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(327, 36);
            this.usernameField.TabIndex = 6;
            this.usernameField.Text = "";
            this.usernameField.TrailingIcon = null;
            this.usernameField.UseAccent = false;
            this.usernameField.UseTallSize = false;
            // 
            // passwordField
            // 
            this.passwordField.AnimateReadOnly = false;
            this.passwordField.BackColor = System.Drawing.Color.White;
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Depth = 0;
            this.passwordField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordField.Hint = "Enter Password";
            this.passwordField.LeadingIcon = global::Nova_Medical_Center.Properties.Resources.icons8_password_100;
            this.passwordField.LeaveOnEnterKey = true;
            this.passwordField.Location = new System.Drawing.Point(95, 225);
            this.passwordField.MaxLength = 50;
            this.passwordField.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordField.Multiline = false;
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(327, 36);
            this.passwordField.TabIndex = 3;
            this.passwordField.Text = "";
            this.passwordField.TrailingIcon = null;
            this.passwordField.UseAccent = false;
            this.passwordField.UseTallSize = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 320);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.empBox);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginBtn);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton loginBtn;
        private MaterialSkin.Controls.MaterialTextBox passwordField;
        private MaterialSkin.Controls.MaterialTextBox usernameField;
        private MaterialSkin.Controls.MaterialComboBox empBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}