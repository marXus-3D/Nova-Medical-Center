namespace Nova_Medical_Center.Views
{
    partial class NurseAddForm
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.addressField = new MaterialSkin.Controls.MaterialTextBox();
            this.dobPicker = new Nova_Medical_Center.Views.Controls.RJDatePicker();
            this.maleRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.femalRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.hireBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.phoneField = new MaterialSkin.Controls.MaterialTextBox2();
            this.cityField = new MaterialSkin.Controls.MaterialTextBox();
            this.departmentComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.confirmField = new Nova_Medical_Center.Views.Controls.RJTextBox();
            this.passField = new Nova_Medical_Center.Views.Controls.RJTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fnameField
            // 
            this.fnameField.AnimateReadOnly = false;
            this.fnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameField.Depth = 0;
            this.fnameField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fnameField.Hint = "First Name";
            this.fnameField.LeadingIcon = null;
            this.fnameField.LeaveOnEnterKey = true;
            this.fnameField.Location = new System.Drawing.Point(12, 58);
            this.fnameField.MaxLength = 50;
            this.fnameField.MouseState = MaterialSkin.MouseState.OUT;
            this.fnameField.Multiline = false;
            this.fnameField.Name = "fnameField";
            this.fnameField.Size = new System.Drawing.Size(211, 36);
            this.fnameField.TabIndex = 0;
            this.fnameField.Text = "";
            this.fnameField.TrailingIcon = null;
            this.fnameField.UseAccent = false;
            this.fnameField.UseTallSize = false;
            // 
            // lnameField
            // 
            this.lnameField.AnimateReadOnly = false;
            this.lnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameField.Depth = 0;
            this.lnameField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lnameField.Hint = "Last Name";
            this.lnameField.LeadingIcon = null;
            this.lnameField.LeaveOnEnterKey = true;
            this.lnameField.Location = new System.Drawing.Point(288, 58);
            this.lnameField.MaxLength = 50;
            this.lnameField.MouseState = MaterialSkin.MouseState.OUT;
            this.lnameField.Multiline = false;
            this.lnameField.Name = "lnameField";
            this.lnameField.Size = new System.Drawing.Size(211, 36);
            this.lnameField.TabIndex = 2;
            this.lnameField.Text = "";
            this.lnameField.TrailingIcon = null;
            this.lnameField.UseAccent = false;
            this.lnameField.UseTallSize = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Black;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 100);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1022, 6);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // addressField
            // 
            this.addressField.AnimateReadOnly = false;
            this.addressField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressField.Depth = 0;
            this.addressField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressField.Hint = "Address";
            this.addressField.LeadingIcon = null;
            this.addressField.LeaveOnEnterKey = true;
            this.addressField.Location = new System.Drawing.Point(6, 28);
            this.addressField.MaxLength = 50;
            this.addressField.MouseState = MaterialSkin.MouseState.OUT;
            this.addressField.Multiline = false;
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(211, 36);
            this.addressField.TabIndex = 4;
            this.addressField.Text = "";
            this.addressField.TrailingIcon = null;
            this.addressField.UseAccent = false;
            this.addressField.UseTallSize = false;
            // 
            // dobPicker
            // 
            this.dobPicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.dobPicker.BorderSize = 1;
            this.dobPicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Location = new System.Drawing.Point(577, 59);
            this.dobPicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(211, 35);
            this.dobPicker.SkinColor = System.Drawing.SystemColors.Control;
            this.dobPicker.TabIndex = 6;
            this.dobPicker.TextColor = System.Drawing.Color.Black;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Depth = 0;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(859, 59);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.maleRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.maleRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Ripple = true;
            this.maleRadio.Size = new System.Drawing.Size(70, 37);
            this.maleRadio.TabIndex = 7;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femalRadio
            // 
            this.femalRadio.AutoSize = true;
            this.femalRadio.Depth = 0;
            this.femalRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalRadio.Location = new System.Drawing.Point(947, 58);
            this.femalRadio.Margin = new System.Windows.Forms.Padding(0);
            this.femalRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.femalRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.femalRadio.Name = "femalRadio";
            this.femalRadio.Ripple = true;
            this.femalRadio.Size = new System.Drawing.Size(87, 37);
            this.femalRadio.TabIndex = 8;
            this.femalRadio.TabStop = true;
            this.femalRadio.Text = "Female";
            this.femalRadio.UseVisualStyleBackColor = true;
            // 
            // hireBtn
            // 
            this.hireBtn.BackColor = System.Drawing.SystemColors.Control;
            this.hireBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.hireBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.hireBtn.BorderRadius = 10;
            this.hireBtn.BorderSize = 1;
            this.hireBtn.FlatAppearance.BorderSize = 0;
            this.hireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hireBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireBtn.ForeColor = System.Drawing.Color.Black;
            this.hireBtn.Location = new System.Drawing.Point(387, 566);
            this.hireBtn.Name = "hireBtn";
            this.hireBtn.Size = new System.Drawing.Size(270, 34);
            this.hireBtn.TabIndex = 15;
            this.hireBtn.Text = "Hire Employee";
            this.hireBtn.TextColor = System.Drawing.Color.Black;
            this.hireBtn.UseVisualStyleBackColor = false;
            this.hireBtn.Click += new System.EventHandler(this.admitBtn_Click);
            // 
            // phoneField
            // 
            this.phoneField.AnimateReadOnly = false;
            this.phoneField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.phoneField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneField.Depth = 0;
            this.phoneField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneField.HideSelection = true;
            this.phoneField.Hint = "Phone Number";
            this.phoneField.LeadingIcon = null;
            this.phoneField.LeaveOnEnterKey = true;
            this.phoneField.Location = new System.Drawing.Point(6, 161);
            this.phoneField.MaxLength = 32767;
            this.phoneField.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneField.Name = "phoneField";
            this.phoneField.PasswordChar = '\0';
            this.phoneField.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.phoneField.PrefixSuffixText = "251";
            this.phoneField.ReadOnly = false;
            this.phoneField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneField.SelectedText = "";
            this.phoneField.SelectionLength = 0;
            this.phoneField.SelectionStart = 0;
            this.phoneField.ShortcutsEnabled = true;
            this.phoneField.ShowAssistiveText = true;
            this.phoneField.Size = new System.Drawing.Size(211, 52);
            this.phoneField.TabIndex = 17;
            this.phoneField.TabStop = false;
            this.phoneField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneField.TrailingIcon = null;
            this.phoneField.UseAccent = false;
            this.phoneField.UseSystemPasswordChar = false;
            this.phoneField.UseTallSize = false;
            // 
            // cityField
            // 
            this.cityField.AnimateReadOnly = false;
            this.cityField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityField.Depth = 0;
            this.cityField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cityField.Hint = "City";
            this.cityField.LeadingIcon = null;
            this.cityField.LeaveOnEnterKey = true;
            this.cityField.Location = new System.Drawing.Point(6, 92);
            this.cityField.MaxLength = 50;
            this.cityField.MouseState = MaterialSkin.MouseState.OUT;
            this.cityField.Multiline = false;
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(211, 36);
            this.cityField.TabIndex = 18;
            this.cityField.Text = "";
            this.cityField.TrailingIcon = null;
            this.cityField.UseAccent = false;
            this.cityField.UseTallSize = false;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.AutoResize = false;
            this.departmentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.departmentComboBox.Depth = 0;
            this.departmentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.departmentComboBox.DropDownHeight = 118;
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.DropDownWidth = 121;
            this.departmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Hint = "Department";
            this.departmentComboBox.IntegralHeight = false;
            this.departmentComboBox.ItemHeight = 29;
            this.departmentComboBox.Location = new System.Drawing.Point(53, 28);
            this.departmentComboBox.MaxDropDownItems = 4;
            this.departmentComboBox.MaxLength = 255;
            this.departmentComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(211, 35);
            this.departmentComboBox.StartIndex = 0;
            this.departmentComboBox.TabIndex = 21;
            this.departmentComboBox.UseAccent = false;
            this.departmentComboBox.UseTallSize = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addressField);
            this.groupBox2.Controls.Add(this.cityField);
            this.groupBox2.Controls.Add(this.phoneField);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 202);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.confirmField);
            this.groupBox3.Controls.Add(this.passField);
            this.groupBox3.Controls.Add(this.departmentComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(764, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 202);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Work Info";
            // 
            // confirmField
            // 
            this.confirmField.BackColor = System.Drawing.SystemColors.Control;
            this.confirmField.BorderColor = System.Drawing.Color.Gray;
            this.confirmField.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.confirmField.BorderSize = 2;
            this.confirmField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmField.ForeColor = System.Drawing.Color.Black;
            this.confirmField.Location = new System.Drawing.Point(53, 161);
            this.confirmField.Margin = new System.Windows.Forms.Padding(4);
            this.confirmField.Multiline = false;
            this.confirmField.Name = "confirmField";
            this.confirmField.Padding = new System.Windows.Forms.Padding(7);
            this.confirmField.PasswordChar = true;
            this.confirmField.Size = new System.Drawing.Size(210, 31);
            this.confirmField.TabIndex = 25;
            this.confirmField.Texts = "Confrim Password";
            this.confirmField.UnderlinedStyle = true;
            this.confirmField.Click += new System.EventHandler(this.confirmField_Click);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.SystemColors.Control;
            this.passField.BorderColor = System.Drawing.Color.Gray;
            this.passField.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.passField.BorderSize = 2;
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.ForeColor = System.Drawing.Color.Black;
            this.passField.Location = new System.Drawing.Point(53, 92);
            this.passField.Margin = new System.Windows.Forms.Padding(4);
            this.passField.Multiline = false;
            this.passField.Name = "passField";
            this.passField.Padding = new System.Windows.Forms.Padding(7);
            this.passField.PasswordChar = true;
            this.passField.Size = new System.Drawing.Size(210, 31);
            this.passField.TabIndex = 24;
            this.passField.Texts = "Password";
            this.passField.UnderlinedStyle = true;
            this.passField.Click += new System.EventHandler(this.confirmField_Click);
            // 
            // DocAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.hireBtn);
            this.Controls.Add(this.femalRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lnameField);
            this.Controls.Add(this.fnameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocAddForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.NewPatientForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox fnameField;
        private MaterialSkin.Controls.MaterialTextBox lnameField;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox addressField;
        private Controls.RJDatePicker dobPicker;
        private MaterialSkin.Controls.MaterialRadioButton maleRadio;
        private MaterialSkin.Controls.MaterialRadioButton femalRadio;
        private Controls.RJButton hireBtn;
        private MaterialSkin.Controls.MaterialTextBox2 phoneField;
        private MaterialSkin.Controls.MaterialTextBox cityField;
        private MaterialSkin.Controls.MaterialComboBox departmentComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Controls.RJTextBox passField;
        private Controls.RJTextBox confirmField;
    }
}