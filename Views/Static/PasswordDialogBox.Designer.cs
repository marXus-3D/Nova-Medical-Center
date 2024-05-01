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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordDialogBox));
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.confirmField = new Nova_Medical_Center.Views.Controls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordField = new Nova_Medical_Center.Views.Controls.RJTextBox();
            this.SuspendLayout();
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
            // confirmField
            // 
            this.confirmField.BackColor = System.Drawing.SystemColors.Control;
            this.confirmField.BorderColor = System.Drawing.Color.Gray;
            this.confirmField.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.confirmField.BorderSize = 2;
            this.confirmField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmField.ForeColor = System.Drawing.Color.Black;
            this.confirmField.Location = new System.Drawing.Point(163, 155);
            this.confirmField.Margin = new System.Windows.Forms.Padding(4);
            this.confirmField.Multiline = false;
            this.confirmField.Name = "confirmField";
            this.confirmField.Padding = new System.Windows.Forms.Padding(7);
            this.confirmField.PasswordChar = true;
            this.confirmField.Size = new System.Drawing.Size(214, 31);
            this.confirmField.TabIndex = 25;
            this.confirmField.Texts = "Password";
            this.confirmField.UnderlinedStyle = true;
            this.confirmField._TextChanged += new System.EventHandler(this.confirmField__TextChanged);
            this.confirmField.Click += new System.EventHandler(this.passField_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(49, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(96, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password:";
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.SystemColors.Control;
            this.passwordField.BorderColor = System.Drawing.Color.Gray;
            this.passwordField.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.passwordField.BorderSize = 2;
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.ForeColor = System.Drawing.Color.Black;
            this.passwordField.Location = new System.Drawing.Point(163, 100);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordField.Multiline = false;
            this.passwordField.Name = "passwordField";
            this.passwordField.Padding = new System.Windows.Forms.Padding(7);
            this.passwordField.PasswordChar = true;
            this.passwordField.Size = new System.Drawing.Size(214, 31);
            this.passwordField.TabIndex = 27;
            this.passwordField.Texts = "Password";
            this.passwordField.UnderlinedStyle = true;
            this.passwordField.Click += new System.EventHandler(this.passField_Click);
            // 
            // PasswordDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmField);
            this.Controls.Add(this.editBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton editBtn;
        private Controls.RJTextBox confirmField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.RJTextBox passwordField;
    }
}