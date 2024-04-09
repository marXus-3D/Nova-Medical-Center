namespace Nova_Medical_Center.Views.Static
{
    partial class PasswordDialogBox
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
            this.passwordField = new MaterialSkin.Controls.MaterialTextBox();
            this.confirmField = new MaterialSkin.Controls.MaterialTextBox();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // passwordField
            // 
            this.passwordField.AnimateReadOnly = false;
            this.passwordField.BackColor = System.Drawing.Color.White;
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Depth = 0;
            this.passwordField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordField.Hint = "Password";
            this.passwordField.LeadingIcon = null;
            this.passwordField.LeaveOnEnterKey = true;
            this.passwordField.Location = new System.Drawing.Point(128, 86);
            this.passwordField.MaxLength = 50;
            this.passwordField.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordField.Multiline = false;
            this.passwordField.Name = "passwordField";
            this.passwordField.Password = true;
            this.passwordField.Size = new System.Drawing.Size(208, 36);
            this.passwordField.TabIndex = 0;
            this.passwordField.Text = "";
            this.passwordField.TrailingIcon = null;
            this.passwordField.UseAccent = false;
            this.passwordField.UseTallSize = false;
            // 
            // confirmField
            // 
            this.confirmField.AnimateReadOnly = false;
            this.confirmField.BackColor = System.Drawing.Color.White;
            this.confirmField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmField.Depth = 0;
            this.confirmField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.confirmField.Hint = "Confrim Password";
            this.confirmField.LeadingIcon = null;
            this.confirmField.LeaveOnEnterKey = true;
            this.confirmField.Location = new System.Drawing.Point(128, 154);
            this.confirmField.MaxLength = 50;
            this.confirmField.MouseState = MaterialSkin.MouseState.OUT;
            this.confirmField.Multiline = false;
            this.confirmField.Name = "confirmField";
            this.confirmField.Password = true;
            this.confirmField.Size = new System.Drawing.Size(214, 36);
            this.confirmField.TabIndex = 1;
            this.confirmField.Text = "";
            this.confirmField.TrailingIcon = null;
            this.confirmField.UseAccent = false;
            this.confirmField.UseTallSize = false;
            this.confirmField.TextChanged += new System.EventHandler(this.confirmField_TextChanged);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.editBtn.Enabled = false;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.editBtn.IconColor = System.Drawing.Color.White;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.IconSize = 32;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(163, 255);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(142, 53);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Reset";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // PasswordDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.confirmField);
            this.Controls.Add(this.passwordField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordDialogBox";
            this.Text = "DialogBox";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox passwordField;
        private MaterialSkin.Controls.MaterialTextBox confirmField;
        private FontAwesome.Sharp.IconButton editBtn;
    }
}