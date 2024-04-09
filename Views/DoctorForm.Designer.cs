namespace Nova_Medical_Center.Views
{
    partial class DoctorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Panel();
            this.deskPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 63);
            this.panel1.TabIndex = 1;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.line.Location = new System.Drawing.Point(12, 50);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(152, 6);
            this.line.TabIndex = 7;
            // 
            // deskPanel
            // 
            this.deskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskPanel.Location = new System.Drawing.Point(0, 63);
            this.deskPanel.Name = "deskPanel";
            this.deskPanel.Size = new System.Drawing.Size(1046, 612);
            this.deskPanel.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.deleteBtn.IconColor = System.Drawing.Color.Black;
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.IconSize = 32;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(504, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(152, 47);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.addBtn.IconColor = System.Drawing.Color.Black;
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 32;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(346, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(152, 47);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.updateBtn.IconColor = System.Drawing.Color.Black;
            this.updateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateBtn.IconSize = 32;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(188, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(152, 47);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.White;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.homeBtn.IconColor = System.Drawing.Color.Black;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 32;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(12, 3);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(152, 47);
            this.homeBtn.TabIndex = 3;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 675);
            this.Controls.Add(this.deskPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton homeBtn;
        private System.Windows.Forms.Panel line;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton addBtn;
        private FontAwesome.Sharp.IconButton updateBtn;
        private System.Windows.Forms.Panel deskPanel;
    }
}