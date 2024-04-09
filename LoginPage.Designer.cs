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
            this.loginBtn = new MaterialSkin.Controls.MaterialButton();
            this.passwordField = new MaterialSkin.Controls.MaterialTextBox();
            this.usernameField = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginBtn.Depth = 0;
            this.loginBtn.HighEmphasis = true;
            this.loginBtn.Icon = null;
            this.loginBtn.Location = new System.Drawing.Point(202, 275);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginBtn.Size = new System.Drawing.Size(96, 36);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginBtn.UseAccentColor = false;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
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
            this.passwordField.Location = new System.Drawing.Point(95, 203);
            this.passwordField.MaxLength = 50;
            this.passwordField.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordField.Multiline = false;
            this.passwordField.Name = "passwordField";
            this.passwordField.Password = true;
            this.passwordField.Size = new System.Drawing.Size(327, 36);
            this.passwordField.TabIndex = 3;
            this.passwordField.Text = "";
            this.passwordField.TrailingIcon = null;
            this.passwordField.UseAccent = false;
            this.passwordField.UseTallSize = false;
            // 
            // usernameField
            // 
            this.usernameField.AnimateReadOnly = false;
            this.usernameField.BackColor = System.Drawing.Color.White;
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameField.Depth = 0;
            this.usernameField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameField.Hint = "Enter Password";
            this.usernameField.LeadingIcon = global::Nova_Medical_Center.Properties.Resources.icons8_user_100;
            this.usernameField.LeaveOnEnterKey = true;
            this.usernameField.Location = new System.Drawing.Point(95, 141);
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
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 320);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginBtn);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton loginBtn;
        private MaterialSkin.Controls.MaterialTextBox passwordField;
        private MaterialSkin.Controls.MaterialTextBox usernameField;
    }
}