namespace Nova_Medical_Center.Views
{
    partial class PatientRecordForm
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
            this.fnameField = new MaterialSkin.Controls.MaterialTextBox();
            this.lnameField = new MaterialSkin.Controls.MaterialTextBox();
            this.femalRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.maleRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ageField = new MaterialSkin.Controls.MaterialTextBox();
            this.medicationArea = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.roomPanel = new System.Windows.Forms.Panel();
            this.dobPicker = new Nova_Medical_Center.Views.Controls.RJDatePicker();
            this.vipCheck = new Nova_Medical_Center.Views.Controls.RJToggleButton();
            this.SuspendLayout();
            // 
            // fnameField
            // 
            this.fnameField.AnimateReadOnly = true;
            this.fnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameField.Depth = 0;
            this.fnameField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fnameField.Hint = "First Name";
            this.fnameField.LeadingIcon = null;
            this.fnameField.Location = new System.Drawing.Point(23, 23);
            this.fnameField.MaxLength = 50;
            this.fnameField.MouseState = MaterialSkin.MouseState.OUT;
            this.fnameField.Multiline = false;
            this.fnameField.Name = "fnameField";
            this.fnameField.ReadOnly = true;
            this.fnameField.Size = new System.Drawing.Size(163, 36);
            this.fnameField.TabIndex = 0;
            this.fnameField.Text = "";
            this.fnameField.TrailingIcon = null;
            this.fnameField.UseAccent = false;
            this.fnameField.UseTallSize = false;
            // 
            // lnameField
            // 
            this.lnameField.AnimateReadOnly = true;
            this.lnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameField.Depth = 0;
            this.lnameField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lnameField.Hint = "Last Name";
            this.lnameField.LeadingIcon = null;
            this.lnameField.Location = new System.Drawing.Point(235, 23);
            this.lnameField.MaxLength = 50;
            this.lnameField.MouseState = MaterialSkin.MouseState.OUT;
            this.lnameField.Multiline = false;
            this.lnameField.Name = "lnameField";
            this.lnameField.ReadOnly = true;
            this.lnameField.Size = new System.Drawing.Size(163, 36);
            this.lnameField.TabIndex = 1;
            this.lnameField.Text = "";
            this.lnameField.TrailingIcon = null;
            this.lnameField.UseAccent = false;
            this.lnameField.UseTallSize = false;
            // 
            // femalRadio
            // 
            this.femalRadio.AutoSize = true;
            this.femalRadio.Depth = 0;
            this.femalRadio.Enabled = false;
            this.femalRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalRadio.Location = new System.Drawing.Point(840, 23);
            this.femalRadio.Margin = new System.Windows.Forms.Padding(0);
            this.femalRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.femalRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.femalRadio.Name = "femalRadio";
            this.femalRadio.Ripple = true;
            this.femalRadio.Size = new System.Drawing.Size(87, 37);
            this.femalRadio.TabIndex = 10;
            this.femalRadio.TabStop = true;
            this.femalRadio.Text = "Female";
            this.femalRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Depth = 0;
            this.maleRadio.Enabled = false;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(752, 24);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.maleRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.maleRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Ripple = true;
            this.maleRadio.Size = new System.Drawing.Size(70, 37);
            this.maleRadio.TabIndex = 9;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1010, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "VIP";
            // 
            // ageField
            // 
            this.ageField.AnimateReadOnly = true;
            this.ageField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageField.Depth = 0;
            this.ageField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ageField.Hint = "Age";
            this.ageField.LeadingIcon = null;
            this.ageField.Location = new System.Drawing.Point(674, 23);
            this.ageField.MaxLength = 50;
            this.ageField.MouseState = MaterialSkin.MouseState.OUT;
            this.ageField.Multiline = false;
            this.ageField.Name = "ageField";
            this.ageField.ReadOnly = true;
            this.ageField.Size = new System.Drawing.Size(60, 36);
            this.ageField.TabIndex = 21;
            this.ageField.Text = "";
            this.ageField.TrailingIcon = null;
            this.ageField.UseAccent = false;
            this.ageField.UseTallSize = false;
            // 
            // medicationArea
            // 
            this.medicationArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.medicationArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicationArea.Depth = 0;
            this.medicationArea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.medicationArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.medicationArea.Location = new System.Drawing.Point(23, 80);
            this.medicationArea.MouseState = MaterialSkin.MouseState.HOVER;
            this.medicationArea.Name = "medicationArea";
            this.medicationArea.ReadOnly = true;
            this.medicationArea.Size = new System.Drawing.Size(746, 554);
            this.medicationArea.TabIndex = 22;
            this.medicationArea.Text = "";
            // 
            // roomPanel
            // 
            this.roomPanel.Location = new System.Drawing.Point(775, 80);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(259, 279);
            this.roomPanel.TabIndex = 23;
            // 
            // dobPicker
            // 
            this.dobPicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.dobPicker.BorderSize = 1;
            this.dobPicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Location = new System.Drawing.Point(441, 25);
            this.dobPicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(211, 35);
            this.dobPicker.SkinColor = System.Drawing.SystemColors.Control;
            this.dobPicker.TabIndex = 20;
            this.dobPicker.TextColor = System.Drawing.Color.Black;
            // 
            // vipCheck
            // 
            this.vipCheck.AutoSize = true;
            this.vipCheck.Enabled = false;
            this.vipCheck.Location = new System.Drawing.Point(959, 37);
            this.vipCheck.MinimumSize = new System.Drawing.Size(45, 22);
            this.vipCheck.Name = "vipCheck";
            this.vipCheck.OffBackColor = System.Drawing.Color.Gray;
            this.vipCheck.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.vipCheck.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.vipCheck.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.vipCheck.Size = new System.Drawing.Size(45, 22);
            this.vipCheck.TabIndex = 18;
            this.vipCheck.UseVisualStyleBackColor = true;
            // 
            // PatientRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1046, 675);
            this.Controls.Add(this.roomPanel);
            this.Controls.Add(this.medicationArea);
            this.Controls.Add(this.ageField);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vipCheck);
            this.Controls.Add(this.femalRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.lnameField);
            this.Controls.Add(this.fnameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientRecordForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.PatientRecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox fnameField;
        private MaterialSkin.Controls.MaterialTextBox lnameField;
        private MaterialSkin.Controls.MaterialRadioButton femalRadio;
        private MaterialSkin.Controls.MaterialRadioButton maleRadio;
        private System.Windows.Forms.Label label1;
        private Controls.RJToggleButton vipCheck;
        private Controls.RJDatePicker dobPicker;
        private MaterialSkin.Controls.MaterialTextBox ageField;
        private MaterialSkin.Controls.MaterialMultiLineTextBox medicationArea;
        private System.Windows.Forms.Panel roomPanel;
    }
}