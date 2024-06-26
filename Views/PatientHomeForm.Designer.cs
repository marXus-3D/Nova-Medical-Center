﻿namespace Nova_Medical_Center.Views
{
    partial class PatientHomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loadPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shareBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.admitButton = new Nova_Medical_Center.Views.Controls.RJButton();
            this.doctorGridView = new System.Windows.Forms.DataGridView();
            this.recordBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.loadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadPanel
            // 
            this.loadPanel.Controls.Add(this.errorLabel);
            this.loadPanel.Controls.Add(this.pictureBox1);
            this.loadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPanel.Location = new System.Drawing.Point(0, 0);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(1046, 612);
            this.loadPanel.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Location = new System.Drawing.Point(324, 458);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(398, 25);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "Error While Loading Patients Please Try Again.";
            this.errorLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nova_Medical_Center.Properties.Resources.Cube_1x_1_0s_200px_200px;
            this.pictureBox1.Location = new System.Drawing.Point(364, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recordBtn);
            this.panel1.Controls.Add(this.shareBtn);
            this.panel1.Controls.Add(this.admitButton);
            this.panel1.Controls.Add(this.doctorGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 612);
            this.panel1.TabIndex = 3;
            // 
            // shareBtn
            // 
            this.shareBtn.BackColor = System.Drawing.SystemColors.Control;
            this.shareBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.shareBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.shareBtn.BorderRadius = 6;
            this.shareBtn.BorderSize = 1;
            this.shareBtn.Enabled = false;
            this.shareBtn.FlatAppearance.BorderSize = 0;
            this.shareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shareBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareBtn.ForeColor = System.Drawing.Color.Black;
            this.shareBtn.Location = new System.Drawing.Point(450, 540);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(95, 40);
            this.shareBtn.TabIndex = 4;
            this.shareBtn.Text = "Share";
            this.shareBtn.TextColor = System.Drawing.Color.Black;
            this.shareBtn.UseVisualStyleBackColor = false;
            this.shareBtn.Click += new System.EventHandler(this.shareBtn_Click);
            // 
            // admitButton
            // 
            this.admitButton.BackColor = System.Drawing.SystemColors.Control;
            this.admitButton.BackgroundColor = System.Drawing.SystemColors.Control;
            this.admitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.admitButton.BorderRadius = 6;
            this.admitButton.BorderSize = 1;
            this.admitButton.Enabled = false;
            this.admitButton.FlatAppearance.BorderSize = 0;
            this.admitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admitButton.ForeColor = System.Drawing.Color.Black;
            this.admitButton.Location = new System.Drawing.Point(323, 540);
            this.admitButton.Name = "admitButton";
            this.admitButton.Size = new System.Drawing.Size(95, 40);
            this.admitButton.TabIndex = 3;
            this.admitButton.Text = "Admit";
            this.admitButton.TextColor = System.Drawing.Color.Black;
            this.admitButton.UseVisualStyleBackColor = false;
            this.admitButton.Click += new System.EventHandler(this.admitButton_Click);
            // 
            // doctorGridView
            // 
            this.doctorGridView.AllowUserToAddRows = false;
            this.doctorGridView.AllowUserToDeleteRows = false;
            this.doctorGridView.AllowUserToResizeColumns = false;
            this.doctorGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.doctorGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.doctorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.doctorGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctorGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.doctorGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.doctorGridView.ColumnHeadersHeight = 30;
            this.doctorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.doctorGridView.EnableHeadersVisualStyles = false;
            this.doctorGridView.Location = new System.Drawing.Point(12, 21);
            this.doctorGridView.MultiSelect = false;
            this.doctorGridView.Name = "doctorGridView";
            this.doctorGridView.ReadOnly = true;
            this.doctorGridView.RowHeadersVisible = false;
            this.doctorGridView.RowTemplate.Height = 50;
            this.doctorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorGridView.Size = new System.Drawing.Size(1022, 501);
            this.doctorGridView.TabIndex = 1;
            this.doctorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorGridView_CellClick);
            // 
            // recordBtn
            // 
            this.recordBtn.BackColor = System.Drawing.SystemColors.Control;
            this.recordBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.recordBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.recordBtn.BorderRadius = 6;
            this.recordBtn.BorderSize = 1;
            this.recordBtn.Enabled = false;
            this.recordBtn.FlatAppearance.BorderSize = 0;
            this.recordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordBtn.ForeColor = System.Drawing.Color.Black;
            this.recordBtn.Location = new System.Drawing.Point(569, 540);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(95, 40);
            this.recordBtn.TabIndex = 5;
            this.recordBtn.Text = "Records";
            this.recordBtn.TextColor = System.Drawing.Color.Black;
            this.recordBtn.UseVisualStyleBackColor = false;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // PatientHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientHomeForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.PatientUpdateForm_Load);
            this.loadPanel.ResumeLayout(false);
            this.loadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loadPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Controls.RJButton admitButton;
        private System.Windows.Forms.DataGridView doctorGridView;
        private Controls.RJButton shareBtn;
        private Controls.RJButton recordBtn;
    }
}