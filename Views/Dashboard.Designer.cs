namespace Nova_Medical_Center.Views
{
    partial class Dashboard
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
            this.doctorBar = new CircularProgressBar.CircularProgressBar();
            this.roomBar = new CircularProgressBar.CircularProgressBar();
            this.nurseBar = new CircularProgressBar.CircularProgressBar();
            this.receptionBar = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // doctorBar
            // 
            this.doctorBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.doctorBar.AnimationSpeed = 500;
            this.doctorBar.BackColor = System.Drawing.Color.Transparent;
            this.doctorBar.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doctorBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.doctorBar.InnerMargin = 2;
            this.doctorBar.InnerWidth = -1;
            this.doctorBar.Location = new System.Drawing.Point(22, 12);
            this.doctorBar.MarqueeAnimationSpeed = 2000;
            this.doctorBar.Name = "doctorBar";
            this.doctorBar.OuterColor = System.Drawing.Color.Gray;
            this.doctorBar.OuterMargin = -25;
            this.doctorBar.OuterWidth = 15;
            this.doctorBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.doctorBar.ProgressWidth = 20;
            this.doctorBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.doctorBar.Size = new System.Drawing.Size(200, 200);
            this.doctorBar.StartAngle = 270;
            this.doctorBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.doctorBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.doctorBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.doctorBar.SubscriptText = "";
            this.doctorBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.doctorBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.doctorBar.SuperscriptText = "";
            this.doctorBar.TabIndex = 0;
            this.doctorBar.Text = "Doctors";
            this.doctorBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.doctorBar.Value = 68;
            // 
            // roomBar
            // 
            this.roomBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.roomBar.AnimationSpeed = 500;
            this.roomBar.BackColor = System.Drawing.Color.Transparent;
            this.roomBar.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roomBar.InnerMargin = 2;
            this.roomBar.InnerWidth = -1;
            this.roomBar.Location = new System.Drawing.Point(804, 237);
            this.roomBar.MarqueeAnimationSpeed = 2000;
            this.roomBar.Name = "roomBar";
            this.roomBar.OuterColor = System.Drawing.Color.Gray;
            this.roomBar.OuterMargin = -25;
            this.roomBar.OuterWidth = 26;
            this.roomBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.roomBar.ProgressWidth = 25;
            this.roomBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.roomBar.Size = new System.Drawing.Size(200, 200);
            this.roomBar.StartAngle = 270;
            this.roomBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.roomBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.roomBar.SubscriptText = "";
            this.roomBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.roomBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.roomBar.SuperscriptText = "";
            this.roomBar.TabIndex = 3;
            this.roomBar.Text = "Rooms";
            this.roomBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.roomBar.Value = 68;
            // 
            // nurseBar
            // 
            this.nurseBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.nurseBar.AnimationSpeed = 500;
            this.nurseBar.BackColor = System.Drawing.Color.Transparent;
            this.nurseBar.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nurseBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nurseBar.InnerMargin = 2;
            this.nurseBar.InnerWidth = -1;
            this.nurseBar.Location = new System.Drawing.Point(22, 237);
            this.nurseBar.MarqueeAnimationSpeed = 2000;
            this.nurseBar.Name = "nurseBar";
            this.nurseBar.OuterColor = System.Drawing.Color.Gray;
            this.nurseBar.OuterMargin = -25;
            this.nurseBar.OuterWidth = 15;
            this.nurseBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.nurseBar.ProgressWidth = 20;
            this.nurseBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.nurseBar.Size = new System.Drawing.Size(200, 200);
            this.nurseBar.StartAngle = 270;
            this.nurseBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.nurseBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nurseBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.nurseBar.SubscriptText = "";
            this.nurseBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nurseBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.nurseBar.SuperscriptText = "";
            this.nurseBar.TabIndex = 4;
            this.nurseBar.Text = "Nurses";
            this.nurseBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.nurseBar.Value = 68;
            // 
            // receptionBar
            // 
            this.receptionBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.receptionBar.AnimationSpeed = 500;
            this.receptionBar.BackColor = System.Drawing.Color.Transparent;
            this.receptionBar.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receptionBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.receptionBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.receptionBar.InnerMargin = 2;
            this.receptionBar.InnerWidth = -1;
            this.receptionBar.Location = new System.Drawing.Point(22, 443);
            this.receptionBar.MarqueeAnimationSpeed = 2000;
            this.receptionBar.Name = "receptionBar";
            this.receptionBar.OuterColor = System.Drawing.Color.Gray;
            this.receptionBar.OuterMargin = -25;
            this.receptionBar.OuterWidth = 15;
            this.receptionBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.receptionBar.ProgressWidth = 20;
            this.receptionBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.receptionBar.Size = new System.Drawing.Size(200, 200);
            this.receptionBar.StartAngle = 270;
            this.receptionBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.receptionBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.receptionBar.SubscriptText = "";
            this.receptionBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.receptionBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.receptionBar.SuperscriptText = "";
            this.receptionBar.TabIndex = 5;
            this.receptionBar.Text = "Reception";
            this.receptionBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.receptionBar.Value = 68;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 675);
            this.Controls.Add(this.receptionBar);
            this.Controls.Add(this.nurseBar);
            this.Controls.Add(this.roomBar);
            this.Controls.Add(this.doctorBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar doctorBar;
        private CircularProgressBar.CircularProgressBar roomBar;
        private CircularProgressBar.CircularProgressBar nurseBar;
        private CircularProgressBar.CircularProgressBar receptionBar;
    }
}