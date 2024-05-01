namespace Nova_Medical_Center.Views
{
    partial class AboutForm
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
            this.normalBar = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryBar = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.icuBar = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.vipBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.surgeryBar = new CircularProgressBar.CircularProgressBar();
            this.line = new MaterialSkin.Controls.MaterialDivider();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorBar
            // 
            this.doctorBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.doctorBar.AnimationSpeed = 500;
            this.doctorBar.BackColor = System.Drawing.Color.Transparent;
            this.doctorBar.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.doctorBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doctorBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.doctorBar.InnerMargin = 2;
            this.doctorBar.InnerWidth = -1;
            this.doctorBar.Location = new System.Drawing.Point(128, 29);
            this.doctorBar.MarqueeAnimationSpeed = 2000;
            this.doctorBar.Name = "doctorBar";
            this.doctorBar.OuterColor = System.Drawing.Color.Gray;
            this.doctorBar.OuterMargin = -25;
            this.doctorBar.OuterWidth = 20;
            this.doctorBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.doctorBar.ProgressWidth = 10;
            this.doctorBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.doctorBar.Size = new System.Drawing.Size(165, 165);
            this.doctorBar.StartAngle = 270;
            this.doctorBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.doctorBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.doctorBar.SubscriptText = "";
            this.doctorBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.doctorBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.doctorBar.SuperscriptText = "";
            this.doctorBar.TabIndex = 0;
            this.doctorBar.Text = "Doctors";
            this.doctorBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 10, 8);
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
            this.roomBar.Location = new System.Drawing.Point(98, 303);
            this.roomBar.MarqueeAnimationSpeed = 2000;
            this.roomBar.Name = "roomBar";
            this.roomBar.OuterColor = System.Drawing.Color.Gray;
            this.roomBar.OuterMargin = -25;
            this.roomBar.OuterWidth = 20;
            this.roomBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.roomBar.ProgressWidth = 10;
            this.roomBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.roomBar.Size = new System.Drawing.Size(300, 300);
            this.roomBar.StartAngle = 270;
            this.roomBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.roomBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.roomBar.SubscriptText = "";
            this.roomBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.roomBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.roomBar.SuperscriptText = "";
            this.roomBar.TabIndex = 3;
            this.roomBar.Text = "Rooms";
            this.roomBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 8, 10);
            this.roomBar.Value = 68;
            // 
            // nurseBar
            // 
            this.nurseBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.nurseBar.AnimationSpeed = 500;
            this.nurseBar.BackColor = System.Drawing.Color.Transparent;
            this.nurseBar.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.nurseBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nurseBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nurseBar.InnerMargin = 2;
            this.nurseBar.InnerWidth = -1;
            this.nurseBar.Location = new System.Drawing.Point(440, 29);
            this.nurseBar.MarqueeAnimationSpeed = 2000;
            this.nurseBar.Name = "nurseBar";
            this.nurseBar.OuterColor = System.Drawing.Color.Gray;
            this.nurseBar.OuterMargin = -25;
            this.nurseBar.OuterWidth = 20;
            this.nurseBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.nurseBar.ProgressWidth = 10;
            this.nurseBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.nurseBar.Size = new System.Drawing.Size(165, 165);
            this.nurseBar.StartAngle = 270;
            this.nurseBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nurseBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.nurseBar.SubscriptText = "";
            this.nurseBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nurseBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.nurseBar.SuperscriptText = "";
            this.nurseBar.TabIndex = 4;
            this.nurseBar.Text = "Nurses";
            this.nurseBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 10, 8);
            this.nurseBar.Value = 68;
            // 
            // receptionBar
            // 
            this.receptionBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.receptionBar.AnimationSpeed = 500;
            this.receptionBar.BackColor = System.Drawing.Color.Transparent;
            this.receptionBar.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.receptionBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.receptionBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.receptionBar.InnerMargin = 2;
            this.receptionBar.InnerWidth = -1;
            this.receptionBar.Location = new System.Drawing.Point(718, 29);
            this.receptionBar.MarqueeAnimationSpeed = 2000;
            this.receptionBar.Name = "receptionBar";
            this.receptionBar.OuterColor = System.Drawing.Color.Gray;
            this.receptionBar.OuterMargin = -25;
            this.receptionBar.OuterWidth = 20;
            this.receptionBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.receptionBar.ProgressWidth = 10;
            this.receptionBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.receptionBar.Size = new System.Drawing.Size(165, 165);
            this.receptionBar.StartAngle = 270;
            this.receptionBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.receptionBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.receptionBar.SubscriptText = "";
            this.receptionBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.receptionBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.receptionBar.SuperscriptText = "";
            this.receptionBar.TabIndex = 5;
            this.receptionBar.Text = "Reception";
            this.receptionBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 10, 8);
            this.receptionBar.Value = 68;
            // 
            // normalBar
            // 
            this.normalBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.normalBar.AnimationSpeed = 500;
            this.normalBar.BackColor = System.Drawing.Color.Transparent;
            this.normalBar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.normalBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.normalBar.InnerMargin = 2;
            this.normalBar.InnerWidth = -1;
            this.normalBar.Location = new System.Drawing.Point(80, 28);
            this.normalBar.MarqueeAnimationSpeed = 2000;
            this.normalBar.Name = "normalBar";
            this.normalBar.OuterColor = System.Drawing.Color.Gray;
            this.normalBar.OuterMargin = -25;
            this.normalBar.OuterWidth = 20;
            this.normalBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.normalBar.ProgressWidth = 15;
            this.normalBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.normalBar.Size = new System.Drawing.Size(100, 100);
            this.normalBar.StartAngle = 270;
            this.normalBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.normalBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.normalBar.SubscriptText = "";
            this.normalBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.normalBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.normalBar.SuperscriptText = "";
            this.normalBar.TabIndex = 6;
            this.normalBar.Text = "44";
            this.normalBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 10, 10);
            this.normalBar.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Normal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.deliveryBar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.icuBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.vipBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.surgeryBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.normalBar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(531, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 328);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Types";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delivery:";
            // 
            // deliveryBar
            // 
            this.deliveryBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.deliveryBar.AnimationSpeed = 500;
            this.deliveryBar.BackColor = System.Drawing.Color.Transparent;
            this.deliveryBar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.deliveryBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deliveryBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deliveryBar.InnerMargin = 2;
            this.deliveryBar.InnerWidth = -1;
            this.deliveryBar.Location = new System.Drawing.Point(175, 228);
            this.deliveryBar.MarqueeAnimationSpeed = 2000;
            this.deliveryBar.Name = "deliveryBar";
            this.deliveryBar.OuterColor = System.Drawing.Color.Gray;
            this.deliveryBar.OuterMargin = -25;
            this.deliveryBar.OuterWidth = 20;
            this.deliveryBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.deliveryBar.ProgressWidth = 15;
            this.deliveryBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.deliveryBar.Size = new System.Drawing.Size(100, 100);
            this.deliveryBar.StartAngle = 270;
            this.deliveryBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.deliveryBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.deliveryBar.SubscriptText = "";
            this.deliveryBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.deliveryBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.deliveryBar.SuperscriptText = "";
            this.deliveryBar.TabIndex = 14;
            this.deliveryBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 10, 10);
            this.deliveryBar.Value = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "ICU:";
            // 
            // icuBar
            // 
            this.icuBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.icuBar.AnimationSpeed = 500;
            this.icuBar.BackColor = System.Drawing.Color.Transparent;
            this.icuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.icuBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.icuBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.icuBar.InnerMargin = 2;
            this.icuBar.InnerWidth = -1;
            this.icuBar.Location = new System.Drawing.Point(312, 134);
            this.icuBar.MarqueeAnimationSpeed = 2000;
            this.icuBar.Name = "icuBar";
            this.icuBar.OuterColor = System.Drawing.Color.Gray;
            this.icuBar.OuterMargin = -25;
            this.icuBar.OuterWidth = 20;
            this.icuBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.icuBar.ProgressWidth = 15;
            this.icuBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.icuBar.Size = new System.Drawing.Size(100, 100);
            this.icuBar.StartAngle = 270;
            this.icuBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.icuBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.icuBar.SubscriptText = "";
            this.icuBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.icuBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.icuBar.SuperscriptText = "";
            this.icuBar.TabIndex = 12;
            this.icuBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 10, 10);
            this.icuBar.Value = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "VIP:";
            // 
            // vipBar
            // 
            this.vipBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.vipBar.AnimationSpeed = 500;
            this.vipBar.BackColor = System.Drawing.Color.Transparent;
            this.vipBar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.vipBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vipBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vipBar.InnerMargin = 2;
            this.vipBar.InnerWidth = -1;
            this.vipBar.Location = new System.Drawing.Point(312, 28);
            this.vipBar.MarqueeAnimationSpeed = 2000;
            this.vipBar.Name = "vipBar";
            this.vipBar.OuterColor = System.Drawing.Color.Gray;
            this.vipBar.OuterMargin = -25;
            this.vipBar.OuterWidth = 20;
            this.vipBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.vipBar.ProgressWidth = 15;
            this.vipBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.vipBar.Size = new System.Drawing.Size(100, 100);
            this.vipBar.StartAngle = 270;
            this.vipBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.vipBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.vipBar.SubscriptText = "";
            this.vipBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.vipBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.vipBar.SuperscriptText = "";
            this.vipBar.TabIndex = 10;
            this.vipBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 10, 10);
            this.vipBar.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surgery:";
            // 
            // surgeryBar
            // 
            this.surgeryBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.surgeryBar.AnimationSpeed = 500;
            this.surgeryBar.BackColor = System.Drawing.Color.Transparent;
            this.surgeryBar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.surgeryBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surgeryBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.surgeryBar.InnerMargin = 2;
            this.surgeryBar.InnerWidth = -1;
            this.surgeryBar.Location = new System.Drawing.Point(80, 134);
            this.surgeryBar.MarqueeAnimationSpeed = 2000;
            this.surgeryBar.Name = "surgeryBar";
            this.surgeryBar.OuterColor = System.Drawing.Color.Gray;
            this.surgeryBar.OuterMargin = -25;
            this.surgeryBar.OuterWidth = 20;
            this.surgeryBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.surgeryBar.ProgressWidth = 15;
            this.surgeryBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.surgeryBar.Size = new System.Drawing.Size(100, 100);
            this.surgeryBar.StartAngle = 270;
            this.surgeryBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.surgeryBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.surgeryBar.SubscriptText = "";
            this.surgeryBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.surgeryBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.surgeryBar.SuperscriptText = "";
            this.surgeryBar.TabIndex = 8;
            this.surgeryBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 10, 10);
            this.surgeryBar.Value = 68;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.line.Depth = 0;
            this.line.Location = new System.Drawing.Point(22, 232);
            this.line.MouseState = MaterialSkin.MouseState.HOVER;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(984, 4);
            this.line.TabIndex = 9;
            this.line.Text = "materialDivider1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 675);
            this.Controls.Add(this.line);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.receptionBar);
            this.Controls.Add(this.nurseBar);
            this.Controls.Add(this.roomBar);
            this.Controls.Add(this.doctorBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar doctorBar;
        private CircularProgressBar.CircularProgressBar roomBar;
        private CircularProgressBar.CircularProgressBar nurseBar;
        private CircularProgressBar.CircularProgressBar receptionBar;
        private CircularProgressBar.CircularProgressBar normalBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar icuBar;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar vipBar;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar surgeryBar;
        private System.Windows.Forms.Label label5;
        private CircularProgressBar.CircularProgressBar deliveryBar;
        private MaterialSkin.Controls.MaterialDivider line;
    }
}