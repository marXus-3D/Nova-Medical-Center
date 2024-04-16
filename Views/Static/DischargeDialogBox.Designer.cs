namespace Nova_Medical_Center.Views.Static
{
    partial class DischargeDialogBox
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
            this.diagnosisField = new MaterialSkin.Controls.MaterialTextBox();
            this.medicationCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.spinnerField = new MaterialSkin.Controls.MaterialTextBox();
            this.minusBtn = new FontAwesome.Sharp.IconButton();
            this.plusBtn = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.medicationDate = new Nova_Medical_Center.Views.Controls.RJDatePicker();
            this.medicationBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.SuspendLayout();
            // 
            // diagnosisField
            // 
            this.diagnosisField.AnimateReadOnly = false;
            this.diagnosisField.BackColor = System.Drawing.Color.White;
            this.diagnosisField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosisField.Depth = 0;
            this.diagnosisField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.diagnosisField.Hint = "Diagnosis Name";
            this.diagnosisField.LeadingIcon = null;
            this.diagnosisField.LeaveOnEnterKey = true;
            this.diagnosisField.Location = new System.Drawing.Point(12, 12);
            this.diagnosisField.MaxLength = 50;
            this.diagnosisField.MouseState = MaterialSkin.MouseState.OUT;
            this.diagnosisField.Multiline = false;
            this.diagnosisField.Name = "diagnosisField";
            this.diagnosisField.Size = new System.Drawing.Size(339, 36);
            this.diagnosisField.TabIndex = 0;
            this.diagnosisField.Text = "";
            this.diagnosisField.TrailingIcon = null;
            this.diagnosisField.UseAccent = false;
            this.diagnosisField.UseTallSize = false;
            // 
            // medicationCombobox
            // 
            this.medicationCombobox.AutoResize = false;
            this.medicationCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.medicationCombobox.Depth = 0;
            this.medicationCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.medicationCombobox.DropDownHeight = 118;
            this.medicationCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicationCombobox.DropDownWidth = 121;
            this.medicationCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.medicationCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.medicationCombobox.FormattingEnabled = true;
            this.medicationCombobox.Hint = "Medications";
            this.medicationCombobox.IntegralHeight = false;
            this.medicationCombobox.ItemHeight = 29;
            this.medicationCombobox.Location = new System.Drawing.Point(12, 79);
            this.medicationCombobox.MaxDropDownItems = 4;
            this.medicationCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.medicationCombobox.Name = "medicationCombobox";
            this.medicationCombobox.Size = new System.Drawing.Size(217, 35);
            this.medicationCombobox.StartIndex = 0;
            this.medicationCombobox.TabIndex = 9;
            this.medicationCombobox.UseAccent = false;
            this.medicationCombobox.UseTallSize = false;
            // 
            // spinnerField
            // 
            this.spinnerField.AnimateReadOnly = true;
            this.spinnerField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spinnerField.Depth = 0;
            this.spinnerField.Font = new System.Drawing.Font("Roboto", 12F);
            this.spinnerField.Hint = "1.5 ml";
            this.spinnerField.LeadingIcon = null;
            this.spinnerField.Location = new System.Drawing.Point(59, 162);
            this.spinnerField.MaxLength = 50;
            this.spinnerField.MouseState = MaterialSkin.MouseState.OUT;
            this.spinnerField.Multiline = false;
            this.spinnerField.Name = "spinnerField";
            this.spinnerField.ReadOnly = true;
            this.spinnerField.Size = new System.Drawing.Size(76, 36);
            this.spinnerField.TabIndex = 13;
            this.spinnerField.Text = "1.5 ml";
            this.spinnerField.TrailingIcon = null;
            this.spinnerField.UseAccent = false;
            this.spinnerField.UseTallSize = false;
            // 
            // minusBtn
            // 
            this.minusBtn.FlatAppearance.BorderSize = 0;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minusBtn.IconColor = System.Drawing.Color.Black;
            this.minusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minusBtn.IconSize = 34;
            this.minusBtn.Location = new System.Drawing.Point(12, 162);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(29, 33);
            this.minusBtn.TabIndex = 15;
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.plusBtn.IconColor = System.Drawing.Color.Black;
            this.plusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.plusBtn.IconSize = 34;
            this.plusBtn.Location = new System.Drawing.Point(163, 162);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(29, 33);
            this.plusBtn.TabIndex = 14;
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.Control;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.editBtn.FlatAppearance.BorderSize = 2;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.editBtn.IconColor = System.Drawing.Color.Black;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.IconSize = 32;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(181, 255);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 53);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Discharge";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // medicationDate
            // 
            this.medicationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.medicationDate.BorderSize = 1;
            this.medicationDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationDate.Location = new System.Drawing.Point(257, 162);
            this.medicationDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.medicationDate.Name = "medicationDate";
            this.medicationDate.Size = new System.Drawing.Size(211, 35);
            this.medicationDate.SkinColor = System.Drawing.SystemColors.Control;
            this.medicationDate.TabIndex = 16;
            this.medicationDate.TextColor = System.Drawing.Color.Black;
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
            this.medicationBtn.Location = new System.Drawing.Point(257, 80);
            this.medicationBtn.Name = "medicationBtn";
            this.medicationBtn.Size = new System.Drawing.Size(52, 34);
            this.medicationBtn.TabIndex = 17;
            this.medicationBtn.Text = "Add";
            this.medicationBtn.TextColor = System.Drawing.Color.Black;
            this.medicationBtn.UseVisualStyleBackColor = false;
            this.medicationBtn.Click += new System.EventHandler(this.medicationBtn_Click);
            // 
            // DischargeDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.medicationBtn);
            this.Controls.Add(this.medicationDate);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.spinnerField);
            this.Controls.Add(this.medicationCombobox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.diagnosisField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DischargeDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogBox";
            this.Load += new System.EventHandler(this.DischargeDialogBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox diagnosisField;
        private FontAwesome.Sharp.IconButton editBtn;
        private MaterialSkin.Controls.MaterialComboBox medicationCombobox;
        private MaterialSkin.Controls.MaterialTextBox spinnerField;
        private FontAwesome.Sharp.IconButton plusBtn;
        private FontAwesome.Sharp.IconButton minusBtn;
        private Controls.RJDatePicker medicationDate;
        private Controls.RJButton medicationBtn;
    }
}