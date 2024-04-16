namespace Nova_Medical_Center
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.titleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMaximize = new FontAwesome.Sharp.IconButton();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.hamBurgerMenu = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.patientsBtn = new FontAwesome.Sharp.IconButton();
            this.roomBtn = new FontAwesome.Sharp.IconButton();
            this.employeePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.empBtn = new FontAwesome.Sharp.IconButton();
            this.doctorButton = new FontAwesome.Sharp.IconButton();
            this.nurseButton = new FontAwesome.Sharp.IconButton();
            this.deskBtn = new FontAwesome.Sharp.IconButton();
            this.settingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.settingBtn = new FontAwesome.Sharp.IconButton();
            this.accountBtn = new FontAwesome.Sharp.IconButton();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.settingTransition = new System.Windows.Forms.Timer(this.components);
            this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.employeeTransition = new System.Windows.Forms.Timer(this.components);
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamBurgerMenu)).BeginInit();
            this.sideBar.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.White;
            this.titleBar.Controls.Add(this.buttonMinimize);
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.buttonMaximize);
            this.titleBar.Controls.Add(this.buttonExit);
            this.titleBar.Controls.Add(this.hamBurgerMenu);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1280, 45);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.buttonMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMinimize.IconSize = 32;
            this.buttonMinimize.Location = new System.Drawing.Point(1183, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(27, 28);
            this.buttonMinimize.TabIndex = 7;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nova Medical Center";
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.buttonMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMaximize.IconSize = 32;
            this.buttonMaximize.Location = new System.Drawing.Point(1216, 4);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(27, 28);
            this.buttonMaximize.TabIndex = 6;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.buttonExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonExit.IconSize = 32;
            this.buttonExit.Location = new System.Drawing.Point(1249, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 28);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // hamBurgerMenu
            // 
            this.hamBurgerMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamBurgerMenu.Image = global::Nova_Medical_Center.Properties.Resources.icons8_hamburger_500;
            this.hamBurgerMenu.Location = new System.Drawing.Point(3, 3);
            this.hamBurgerMenu.Name = "hamBurgerMenu";
            this.hamBurgerMenu.Size = new System.Drawing.Size(40, 40);
            this.hamBurgerMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamBurgerMenu.TabIndex = 0;
            this.hamBurgerMenu.TabStop = false;
            this.hamBurgerMenu.Click += new System.EventHandler(this.hamBurgerMenu_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sideBar.Controls.Add(this.dashboardBtn);
            this.sideBar.Controls.Add(this.patientsBtn);
            this.sideBar.Controls.Add(this.roomBtn);
            this.sideBar.Controls.Add(this.employeePanel);
            this.sideBar.Controls.Add(this.settingPanel);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBar.Location = new System.Drawing.Point(0, 45);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(234, 675);
            this.sideBar.TabIndex = 1;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.dashboardBtn.IconColor = System.Drawing.Color.White;
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.IconSize = 32;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(3, 3);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(231, 53);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Text = "Home";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // patientsBtn
            // 
            this.patientsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.patientsBtn.FlatAppearance.BorderSize = 0;
            this.patientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsBtn.ForeColor = System.Drawing.Color.White;
            this.patientsBtn.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.patientsBtn.IconColor = System.Drawing.Color.White;
            this.patientsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.patientsBtn.IconSize = 32;
            this.patientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.Location = new System.Drawing.Point(3, 62);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Size = new System.Drawing.Size(231, 53);
            this.patientsBtn.TabIndex = 3;
            this.patientsBtn.Text = "Patients";
            this.patientsBtn.UseVisualStyleBackColor = false;
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click);
            // 
            // roomBtn
            // 
            this.roomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.roomBtn.FlatAppearance.BorderSize = 0;
            this.roomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBtn.ForeColor = System.Drawing.Color.White;
            this.roomBtn.IconChar = FontAwesome.Sharp.IconChar.HospitalWide;
            this.roomBtn.IconColor = System.Drawing.Color.White;
            this.roomBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomBtn.IconSize = 32;
            this.roomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBtn.Location = new System.Drawing.Point(3, 121);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Size = new System.Drawing.Size(231, 53);
            this.roomBtn.TabIndex = 4;
            this.roomBtn.Text = "Rooms";
            this.roomBtn.UseVisualStyleBackColor = false;
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // employeePanel
            // 
            this.employeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.employeePanel.Controls.Add(this.empBtn);
            this.employeePanel.Controls.Add(this.doctorButton);
            this.employeePanel.Controls.Add(this.nurseButton);
            this.employeePanel.Controls.Add(this.deskBtn);
            this.employeePanel.Location = new System.Drawing.Point(3, 180);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(235, 60);
            this.employeePanel.TabIndex = 5;
            // 
            // empBtn
            // 
            this.empBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.empBtn.FlatAppearance.BorderSize = 0;
            this.empBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBtn.ForeColor = System.Drawing.Color.White;
            this.empBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.empBtn.IconColor = System.Drawing.Color.White;
            this.empBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.empBtn.IconSize = 32;
            this.empBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empBtn.Location = new System.Drawing.Point(3, 3);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(231, 53);
            this.empBtn.TabIndex = 3;
            this.empBtn.Text = "Employees";
            this.empBtn.UseVisualStyleBackColor = false;
            this.empBtn.Click += new System.EventHandler(this.empBtn_Click);
            // 
            // doctorButton
            // 
            this.doctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.doctorButton.FlatAppearance.BorderSize = 0;
            this.doctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorButton.ForeColor = System.Drawing.Color.White;
            this.doctorButton.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.doctorButton.IconColor = System.Drawing.Color.White;
            this.doctorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.doctorButton.IconSize = 32;
            this.doctorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorButton.Location = new System.Drawing.Point(3, 62);
            this.doctorButton.Name = "doctorButton";
            this.doctorButton.Size = new System.Drawing.Size(231, 53);
            this.doctorButton.TabIndex = 4;
            this.doctorButton.Text = "Doctors";
            this.doctorButton.UseVisualStyleBackColor = false;
            this.doctorButton.Click += new System.EventHandler(this.doctorButton_Click);
            // 
            // nurseButton
            // 
            this.nurseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.nurseButton.FlatAppearance.BorderSize = 0;
            this.nurseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nurseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseButton.ForeColor = System.Drawing.Color.White;
            this.nurseButton.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.nurseButton.IconColor = System.Drawing.Color.White;
            this.nurseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nurseButton.IconSize = 32;
            this.nurseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nurseButton.Location = new System.Drawing.Point(3, 121);
            this.nurseButton.Name = "nurseButton";
            this.nurseButton.Size = new System.Drawing.Size(231, 53);
            this.nurseButton.TabIndex = 5;
            this.nurseButton.Text = "Nurses";
            this.nurseButton.UseVisualStyleBackColor = false;
            this.nurseButton.Click += new System.EventHandler(this.nurseButton_Click);
            // 
            // deskBtn
            // 
            this.deskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.deskBtn.FlatAppearance.BorderSize = 0;
            this.deskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deskBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskBtn.ForeColor = System.Drawing.Color.White;
            this.deskBtn.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.deskBtn.IconColor = System.Drawing.Color.White;
            this.deskBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deskBtn.IconSize = 32;
            this.deskBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deskBtn.Location = new System.Drawing.Point(3, 180);
            this.deskBtn.Name = "deskBtn";
            this.deskBtn.Size = new System.Drawing.Size(231, 53);
            this.deskBtn.TabIndex = 6;
            this.deskBtn.Text = "Front Desk";
            this.deskBtn.UseVisualStyleBackColor = false;
            this.deskBtn.Click += new System.EventHandler(this.deskBtn_Click);
            // 
            // settingPanel
            // 
            this.settingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.settingPanel.Controls.Add(this.settingBtn);
            this.settingPanel.Controls.Add(this.accountBtn);
            this.settingPanel.Controls.Add(this.logoutBtn);
            this.settingPanel.Location = new System.Drawing.Point(3, 246);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(235, 60);
            this.settingPanel.TabIndex = 2;
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.settingBtn.IconColor = System.Drawing.Color.White;
            this.settingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingBtn.IconSize = 32;
            this.settingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.Location = new System.Drawing.Point(3, 3);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(231, 53);
            this.settingBtn.TabIndex = 3;
            this.settingBtn.Text = "Settings";
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBtn.ForeColor = System.Drawing.Color.White;
            this.accountBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.accountBtn.IconColor = System.Drawing.Color.White;
            this.accountBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountBtn.IconSize = 32;
            this.accountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.Location = new System.Drawing.Point(3, 62);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(231, 53);
            this.accountBtn.TabIndex = 4;
            this.accountBtn.Text = "Account";
            this.accountBtn.UseVisualStyleBackColor = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutBtn.IconColor = System.Drawing.Color.White;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 32;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(3, 121);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(231, 53);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // settingTransition
            // 
            this.settingTransition.Interval = 50;
            this.settingTransition.Tick += new System.EventHandler(this.settingTransition_Tick);
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 25;
            this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(234, 45);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1046, 675);
            this.panelDesktop.TabIndex = 2;
            // 
            // employeeTransition
            // 
            this.employeeTransition.Interval = 40;
            this.employeeTransition.Tick += new System.EventHandler(this.employeeTransition_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "Form1";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamBurgerMenu)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.employeePanel.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox hamBurgerMenu;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel settingPanel;
        private FontAwesome.Sharp.IconButton settingBtn;
        private FontAwesome.Sharp.IconButton accountBtn;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private System.Windows.Forms.Timer settingTransition;
        private FontAwesome.Sharp.IconButton patientsBtn;
        private FontAwesome.Sharp.IconButton roomBtn;
        private System.Windows.Forms.Timer sideBarTransition;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private FontAwesome.Sharp.IconButton buttonMaximize;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.FlowLayoutPanel employeePanel;
        private FontAwesome.Sharp.IconButton empBtn;
        private FontAwesome.Sharp.IconButton doctorButton;
        private FontAwesome.Sharp.IconButton nurseButton;
        private FontAwesome.Sharp.IconButton deskBtn;
        private System.Windows.Forms.Timer employeeTransition;
    }
}

