namespace Nova_Medical_Center.Views
{
    partial class PatientForm
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
            this.newBtn = new FontAwesome.Sharp.IconButton();
            this.dischargeBtn = new FontAwesome.Sharp.IconButton();
            this.admitBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.deskPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.newBtn);
            this.panel1.Controls.Add(this.dischargeBtn);
            this.panel1.Controls.Add(this.admitBtn);
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
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.White;
            this.newBtn.FlatAppearance.BorderSize = 0;
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ForeColor = System.Drawing.Color.Black;
            this.newBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.newBtn.IconColor = System.Drawing.Color.Black;
            this.newBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.newBtn.IconSize = 32;
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtn.Location = new System.Drawing.Point(504, 3);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(152, 47);
            this.newBtn.TabIndex = 6;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dischargeBtn
            // 
            this.dischargeBtn.BackColor = System.Drawing.Color.White;
            this.dischargeBtn.FlatAppearance.BorderSize = 0;
            this.dischargeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dischargeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischargeBtn.ForeColor = System.Drawing.Color.Black;
            this.dischargeBtn.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.dischargeBtn.IconColor = System.Drawing.Color.Black;
            this.dischargeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dischargeBtn.IconSize = 32;
            this.dischargeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dischargeBtn.Location = new System.Drawing.Point(346, 3);
            this.dischargeBtn.Name = "dischargeBtn";
            this.dischargeBtn.Size = new System.Drawing.Size(152, 47);
            this.dischargeBtn.TabIndex = 5;
            this.dischargeBtn.Text = "Discharge";
            this.dischargeBtn.UseVisualStyleBackColor = false;
            this.dischargeBtn.Click += new System.EventHandler(this.dischargeBtn_Click);
            // 
            // admitBtn
            // 
            this.admitBtn.BackColor = System.Drawing.Color.White;
            this.admitBtn.FlatAppearance.BorderSize = 0;
            this.admitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admitBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admitBtn.ForeColor = System.Drawing.Color.Black;
            this.admitBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.admitBtn.IconColor = System.Drawing.Color.Black;
            this.admitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.admitBtn.IconSize = 32;
            this.admitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admitBtn.Location = new System.Drawing.Point(188, 3);
            this.admitBtn.Name = "admitBtn";
            this.admitBtn.Size = new System.Drawing.Size(152, 47);
            this.admitBtn.TabIndex = 4;
            this.admitBtn.Text = "Admit";
            this.admitBtn.UseVisualStyleBackColor = false;
            this.admitBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.White;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
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
            // deskPanel
            // 
            this.deskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskPanel.Location = new System.Drawing.Point(0, 63);
            this.deskPanel.Name = "deskPanel";
            this.deskPanel.Size = new System.Drawing.Size(1046, 612);
            this.deskPanel.TabIndex = 2;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 675);
            this.Controls.Add(this.deskPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton homeBtn;
        private System.Windows.Forms.Panel line;
        private FontAwesome.Sharp.IconButton newBtn;
        private FontAwesome.Sharp.IconButton dischargeBtn;
        private FontAwesome.Sharp.IconButton admitBtn;
        private System.Windows.Forms.Panel deskPanel;
    }
}