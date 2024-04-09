namespace Nova_Medical_Center.Views
{
    partial class DocUpdateForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.doctorGridView = new System.Windows.Forms.DataGridView();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.resetButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorGridView
            // 
            this.doctorGridView.AllowUserToAddRows = false;
            this.doctorGridView.AllowUserToDeleteRows = false;
            this.doctorGridView.AllowUserToResizeColumns = false;
            this.doctorGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.doctorGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.doctorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.doctorGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctorGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.doctorGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.doctorGridView.ColumnHeadersHeight = 30;
            this.doctorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.doctorGridView.EnableHeadersVisualStyles = false;
            this.doctorGridView.Location = new System.Drawing.Point(12, 12);
            this.doctorGridView.MultiSelect = false;
            this.doctorGridView.Name = "doctorGridView";
            this.doctorGridView.ReadOnly = true;
            this.doctorGridView.RowHeadersVisible = false;
            this.doctorGridView.RowTemplate.Height = 50;
            this.doctorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorGridView.Size = new System.Drawing.Size(1022, 501);
            this.doctorGridView.TabIndex = 0;
            this.doctorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorGridView_CellClick);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.updateBtn.Enabled = false;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.updateBtn.IconColor = System.Drawing.Color.White;
            this.updateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateBtn.IconSize = 32;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(343, 547);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(142, 53);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.resetButton.Enabled = false;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.resetButton.IconColor = System.Drawing.Color.White;
            this.resetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.resetButton.IconSize = 32;
            this.resetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetButton.Location = new System.Drawing.Point(514, 547);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(195, 53);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset Password";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // DocUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 612);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.doctorGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocUpdateForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorGridView;
        private FontAwesome.Sharp.IconButton updateBtn;
        private FontAwesome.Sharp.IconButton resetButton;
    }
}