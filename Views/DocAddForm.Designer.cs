namespace Nova_Medical_Center.Views
{
    partial class DocAddForm
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
            this.diagnosisField = new MaterialSkin.Controls.MaterialTextBox();
            this.medicationDate = new Nova_Medical_Center.Views.Controls.RJDatePicker();
            this.dobPicker = new Nova_Medical_Center.Views.Controls.RJDatePicker();
            this.maleRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.femalRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.medicationComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.medicationArea = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.medicationBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.historyBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.delBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nonRadio = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.semiRadio = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.criticalRadio = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.admitBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.vipCheck = new Nova_Medical_Center.Views.Controls.RJToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.lnameField.Location = new System.Drawing.Point(251, 58);
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
            // diagnosisField
            // 
            this.diagnosisField.AnimateReadOnly = false;
            this.diagnosisField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosisField.Depth = 0;
            this.diagnosisField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.diagnosisField.Hint = "Diagnosis Name";
            this.diagnosisField.LeadingIcon = null;
            this.diagnosisField.LeaveOnEnterKey = true;
            this.diagnosisField.Location = new System.Drawing.Point(12, 154);
            this.diagnosisField.MaxLength = 50;
            this.diagnosisField.MouseState = MaterialSkin.MouseState.OUT;
            this.diagnosisField.Multiline = false;
            this.diagnosisField.Name = "diagnosisField";
            this.diagnosisField.Size = new System.Drawing.Size(211, 36);
            this.diagnosisField.TabIndex = 4;
            this.diagnosisField.Text = "";
            this.diagnosisField.TrailingIcon = null;
            this.diagnosisField.UseAccent = false;
            this.diagnosisField.UseTallSize = false;
            // 
            // medicationDate
            // 
            this.medicationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.medicationDate.BorderSize = 1;
            this.medicationDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationDate.Location = new System.Drawing.Point(12, 213);
            this.medicationDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.medicationDate.Name = "medicationDate";
            this.medicationDate.Size = new System.Drawing.Size(211, 35);
            this.medicationDate.SkinColor = System.Drawing.SystemColors.Control;
            this.medicationDate.TabIndex = 5;
            this.medicationDate.TextColor = System.Drawing.Color.Black;
            // 
            // dobPicker
            // 
            this.dobPicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.dobPicker.BorderSize = 1;
            this.dobPicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Location = new System.Drawing.Point(488, 59);
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
            this.maleRadio.Location = new System.Drawing.Point(726, 58);
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
            this.femalRadio.Location = new System.Drawing.Point(814, 57);
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
            // medicationComboBox
            // 
            this.medicationComboBox.AutoResize = false;
            this.medicationComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.medicationComboBox.Depth = 0;
            this.medicationComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.medicationComboBox.DropDownHeight = 118;
            this.medicationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicationComboBox.DropDownWidth = 121;
            this.medicationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.medicationComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.medicationComboBox.FormattingEnabled = true;
            this.medicationComboBox.Hint = "Medications";
            this.medicationComboBox.IntegralHeight = false;
            this.medicationComboBox.ItemHeight = 29;
            this.medicationComboBox.Location = new System.Drawing.Point(12, 267);
            this.medicationComboBox.MaxDropDownItems = 4;
            this.medicationComboBox.MaxLength = 255;
            this.medicationComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.medicationComboBox.Name = "medicationComboBox";
            this.medicationComboBox.Size = new System.Drawing.Size(211, 35);
            this.medicationComboBox.StartIndex = 0;
            this.medicationComboBox.TabIndex = 9;
            this.medicationComboBox.UseAccent = false;
            this.medicationComboBox.UseTallSize = false;
            // 
            // medicationArea
            // 
            this.medicationArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.medicationArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicationArea.Depth = 0;
            this.medicationArea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.medicationArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.medicationArea.Location = new System.Drawing.Point(288, 152);
            this.medicationArea.MouseState = MaterialSkin.MouseState.HOVER;
            this.medicationArea.Name = "medicationArea";
            this.medicationArea.ReadOnly = true;
            this.medicationArea.Size = new System.Drawing.Size(746, 307);
            this.medicationArea.TabIndex = 10;
            this.medicationArea.Text = "";
            // 
            // medicationBtn
            // 
            this.medicationBtn.BackColor = System.Drawing.SystemColors.Control;
            this.medicationBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.medicationBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.medicationBtn.BorderRadius = 10;
            this.medicationBtn.BorderSize = 1;
            this.medicationBtn.FlatAppearance.BorderSize = 0;
            this.medicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicationBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationBtn.ForeColor = System.Drawing.Color.Black;
            this.medicationBtn.Location = new System.Drawing.Point(230, 267);
            this.medicationBtn.Name = "medicationBtn";
            this.medicationBtn.Size = new System.Drawing.Size(52, 34);
            this.medicationBtn.TabIndex = 11;
            this.medicationBtn.Text = "Add";
            this.medicationBtn.TextColor = System.Drawing.Color.Black;
            this.medicationBtn.UseVisualStyleBackColor = false;
            this.medicationBtn.Click += new System.EventHandler(this.medicationBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.historyBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.historyBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.historyBtn.BorderRadius = 10;
            this.historyBtn.BorderSize = 1;
            this.historyBtn.FlatAppearance.BorderSize = 0;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBtn.ForeColor = System.Drawing.Color.Black;
            this.historyBtn.Location = new System.Drawing.Point(12, 328);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(119, 34);
            this.historyBtn.TabIndex = 12;
            this.historyBtn.Text = "Add History";
            this.historyBtn.TextColor = System.Drawing.Color.Black;
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.Control;
            this.delBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.delBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.delBtn.BorderRadius = 10;
            this.delBtn.BorderSize = 1;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.Black;
            this.delBtn.Location = new System.Drawing.Point(163, 328);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(119, 34);
            this.delBtn.TabIndex = 13;
            this.delBtn.Text = "Delete History";
            this.delBtn.TextColor = System.Drawing.Color.Black;
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nonRadio);
            this.groupBox1.Controls.Add(this.semiRadio);
            this.groupBox1.Controls.Add(this.criticalRadio);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urgency Level";
            // 
            // nonRadio
            // 
            this.nonRadio.AutoSize = true;
            this.nonRadio.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.nonRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonRadio.Location = new System.Drawing.Point(6, 70);
            this.nonRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.nonRadio.Name = "nonRadio";
            this.nonRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.nonRadio.Size = new System.Drawing.Size(97, 21);
            this.nonRadio.TabIndex = 3;
            this.nonRadio.Text = "Non Critical";
            this.nonRadio.UnCheckedColor = System.Drawing.Color.Gray;
            this.nonRadio.UseVisualStyleBackColor = true;
            // 
            // semiRadio
            // 
            this.semiRadio.AutoSize = true;
            this.semiRadio.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.semiRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semiRadio.Location = new System.Drawing.Point(83, 28);
            this.semiRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.semiRadio.Name = "semiRadio";
            this.semiRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.semiRadio.Size = new System.Drawing.Size(101, 21);
            this.semiRadio.TabIndex = 2;
            this.semiRadio.Text = "Semi Critical";
            this.semiRadio.UnCheckedColor = System.Drawing.Color.Gray;
            this.semiRadio.UseVisualStyleBackColor = true;
            // 
            // criticalRadio
            // 
            this.criticalRadio.AutoSize = true;
            this.criticalRadio.Checked = true;
            this.criticalRadio.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.criticalRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticalRadio.Location = new System.Drawing.Point(6, 28);
            this.criticalRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.criticalRadio.Name = "criticalRadio";
            this.criticalRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.criticalRadio.Size = new System.Drawing.Size(71, 21);
            this.criticalRadio.TabIndex = 1;
            this.criticalRadio.TabStop = true;
            this.criticalRadio.Text = "Critical";
            this.criticalRadio.UnCheckedColor = System.Drawing.Color.Gray;
            this.criticalRadio.UseVisualStyleBackColor = true;
            // 
            // admitBtn
            // 
            this.admitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.admitBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.admitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.admitBtn.BorderRadius = 10;
            this.admitBtn.BorderSize = 1;
            this.admitBtn.FlatAppearance.BorderSize = 0;
            this.admitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admitBtn.ForeColor = System.Drawing.Color.Black;
            this.admitBtn.Location = new System.Drawing.Point(12, 508);
            this.admitBtn.Name = "admitBtn";
            this.admitBtn.Size = new System.Drawing.Size(270, 34);
            this.admitBtn.TabIndex = 15;
            this.admitBtn.Text = "Admit Patient";
            this.admitBtn.TextColor = System.Drawing.Color.Black;
            this.admitBtn.UseVisualStyleBackColor = false;
            this.admitBtn.Click += new System.EventHandler(this.admitBtn_Click);
            // 
            // vipCheck
            // 
            this.vipCheck.AutoSize = true;
            this.vipCheck.Location = new System.Drawing.Point(923, 65);
            this.vipCheck.MinimumSize = new System.Drawing.Size(45, 22);
            this.vipCheck.Name = "vipCheck";
            this.vipCheck.OffBackColor = System.Drawing.Color.Gray;
            this.vipCheck.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.vipCheck.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.vipCheck.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.vipCheck.Size = new System.Drawing.Size(45, 22);
            this.vipCheck.TabIndex = 16;
            this.vipCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(974, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "VIP";
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vipCheck);
            this.Controls.Add(this.admitBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.medicationBtn);
            this.Controls.Add(this.medicationArea);
            this.Controls.Add(this.medicationComboBox);
            this.Controls.Add(this.femalRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.medicationDate);
            this.Controls.Add(this.diagnosisField);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lnameField);
            this.Controls.Add(this.fnameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPatientForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.NewPatientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox fnameField;
        private MaterialSkin.Controls.MaterialTextBox lnameField;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox diagnosisField;
        private Controls.RJDatePicker medicationDate;
        private Controls.RJDatePicker dobPicker;
        private MaterialSkin.Controls.MaterialRadioButton maleRadio;
        private MaterialSkin.Controls.MaterialRadioButton femalRadio;
        private MaterialSkin.Controls.MaterialMultiLineTextBox medicationArea;
        private Controls.RJButton medicationBtn;
        private Controls.RJButton historyBtn;
        private Controls.RJButton delBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.RJRadioButton nonRadio;
        private Controls.RJRadioButton semiRadio;
        private Controls.RJRadioButton criticalRadio;
        private Controls.RJButton admitBtn;
        private Controls.RJToggleButton vipCheck;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox medicationComboBox;
    }
}