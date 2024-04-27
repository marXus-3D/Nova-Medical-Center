﻿namespace Nova_Medical_Center.Views
{
    partial class DocHomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.doctorGridView = new System.Windows.Forms.DataGridView();
            this.loadPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchField = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).BeginInit();
            this.loadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorGridView
            // 
            this.doctorGridView.AllowUserToAddRows = false;
            this.doctorGridView.AllowUserToDeleteRows = false;
            this.doctorGridView.AllowUserToResizeColumns = false;
            this.doctorGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.doctorGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.doctorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.doctorGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctorGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.doctorGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.doctorGridView.ColumnHeadersHeight = 30;
            this.doctorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorGridView.DefaultCellStyle = dataGridViewCellStyle6;
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
            // 
            // loadPanel
            // 
            this.loadPanel.Controls.Add(this.errorLabel);
            this.loadPanel.Controls.Add(this.pictureBox1);
            this.loadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPanel.Location = new System.Drawing.Point(0, 0);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(1046, 612);
            this.loadPanel.TabIndex = 2;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Location = new System.Drawing.Point(298, 479);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(397, 25);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.Text = "Error While Loading Doctors Please Try Again.";
            this.errorLabel.Visible = false;
            // 
            // searchField
            // 
            this.searchField.AnimateReadOnly = false;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchField.Depth = 0;
            this.searchField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchField.Hint = "Search";
            this.searchField.LeadingIcon = global::Nova_Medical_Center.Properties.Resources.icons8_search_100;
            this.searchField.Location = new System.Drawing.Point(12, 550);
            this.searchField.MaxLength = 50;
            this.searchField.MouseState = MaterialSkin.MouseState.OUT;
            this.searchField.Multiline = false;
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(260, 36);
            this.searchField.TabIndex = 3;
            this.searchField.Text = "";
            this.searchField.TrailingIcon = null;
            this.searchField.UseAccent = false;
            this.searchField.UseTallSize = false;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nova_Medical_Center.Properties.Resources.Cube_1x_1_0s_200px_200px;
            this.pictureBox1.Location = new System.Drawing.Point(338, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DocHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 612);
            this.Controls.Add(this.loadPanel);
            this.Controls.Add(this.doctorGridView);
            this.Controls.Add(this.searchField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocHomeForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).EndInit();
            this.loadPanel.ResumeLayout(false);
            this.loadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorGridView;
        private System.Windows.Forms.Panel loadPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox searchField;
    }
}