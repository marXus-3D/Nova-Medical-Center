namespace Nova_Medical_Center.Views
{
    partial class RoomForm
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
            this.roomFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.loadPanel = new System.Windows.Forms.Panel();
            this.nurseBar = new CircularProgressBar.CircularProgressBar();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbb = new System.Windows.Forms.GroupBox();
            this.addBtn = new Nova_Medical_Center.Views.Controls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPediatrics = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioMaternity = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioCardio = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioNeurology = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioOncology = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioDelivery = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioSurgery = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioVip = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioIcu = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.radioNormal = new Nova_Medical_Center.Views.Controls.RJRadioButton();
            this.roomFlowPanel.SuspendLayout();
            this.loadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomFlowPanel
            // 
            this.roomFlowPanel.AutoScroll = true;
            this.roomFlowPanel.Controls.Add(this.loadPanel);
            this.roomFlowPanel.Location = new System.Drawing.Point(12, 12);
            this.roomFlowPanel.Name = "roomFlowPanel";
            this.roomFlowPanel.Size = new System.Drawing.Size(932, 631);
            this.roomFlowPanel.TabIndex = 0;
            // 
            // loadPanel
            // 
            this.loadPanel.Controls.Add(this.nurseBar);
            this.loadPanel.Controls.Add(this.errorLabel);
            this.loadPanel.Controls.Add(this.pictureBox1);
            this.loadPanel.Location = new System.Drawing.Point(3, 3);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(459, 228);
            this.loadPanel.TabIndex = 2;
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
            this.nurseBar.Location = new System.Drawing.Point(455, 411);
            this.nurseBar.MarqueeAnimationSpeed = 2000;
            this.nurseBar.Name = "nurseBar";
            this.nurseBar.OuterColor = System.Drawing.Color.Gray;
            this.nurseBar.OuterMargin = -25;
            this.nurseBar.OuterWidth = 15;
            this.nurseBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.nurseBar.ProgressWidth = 20;
            this.nurseBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.nurseBar.Size = new System.Drawing.Size(65, 65);
            this.nurseBar.StartAngle = 270;
            this.nurseBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.nurseBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nurseBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.nurseBar.SubscriptText = "";
            this.nurseBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nurseBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.nurseBar.SuperscriptText = "";
            this.nurseBar.TabIndex = 5;
            this.nurseBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.nurseBar.Value = 68;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Location = new System.Drawing.Point(298, 479);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(388, 25);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.Text = "Error While Loading Rooms Please Try Again.";
            this.errorLabel.Visible = false;
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
            // gbb
            // 
            this.gbb.Controls.Add(this.radioDelivery);
            this.gbb.Controls.Add(this.radioSurgery);
            this.gbb.Controls.Add(this.radioVip);
            this.gbb.Controls.Add(this.radioIcu);
            this.gbb.Controls.Add(this.radioNormal);
            this.gbb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbb.Location = new System.Drawing.Point(950, 61);
            this.gbb.Name = "gbb";
            this.gbb.Size = new System.Drawing.Size(92, 172);
            this.gbb.TabIndex = 2;
            this.gbb.TabStop = false;
            this.gbb.Text = "Types";
            this.gbb.Visible = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.addBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.addBtn.BorderRadius = 8;
            this.addBtn.BorderSize = 1;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(950, 15);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(92, 40);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.TextColor = System.Drawing.Color.Black;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPediatrics);
            this.groupBox1.Controls.Add(this.radioMaternity);
            this.groupBox1.Controls.Add(this.radioCardio);
            this.groupBox1.Controls.Add(this.radioNeurology);
            this.groupBox1.Controls.Add(this.radioOncology);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(950, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wards";
            this.groupBox1.Visible = false;
            // 
            // radioPediatrics
            // 
            this.radioPediatrics.AutoSize = true;
            this.radioPediatrics.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioPediatrics.Location = new System.Drawing.Point(0, 105);
            this.radioPediatrics.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioPediatrics.Name = "radioPediatrics";
            this.radioPediatrics.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioPediatrics.Size = new System.Drawing.Size(94, 21);
            this.radioPediatrics.TabIndex = 4;
            this.radioPediatrics.Text = "Pediatrics";
            this.radioPediatrics.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioPediatrics.UseVisualStyleBackColor = true;
            this.radioPediatrics.Click += new System.EventHandler(this.rjRadioButton5_Click);
            // 
            // radioMaternity
            // 
            this.radioMaternity.AutoSize = true;
            this.radioMaternity.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioMaternity.Location = new System.Drawing.Point(0, 132);
            this.radioMaternity.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioMaternity.Name = "radioMaternity";
            this.radioMaternity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioMaternity.Size = new System.Drawing.Size(84, 21);
            this.radioMaternity.TabIndex = 3;
            this.radioMaternity.Text = "Maternity";
            this.radioMaternity.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioMaternity.UseVisualStyleBackColor = true;
            this.radioMaternity.Click += new System.EventHandler(this.rjRadioButton5_Click);
            // 
            // radioCardio
            // 
            this.radioCardio.AutoSize = true;
            this.radioCardio.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioCardio.Location = new System.Drawing.Point(0, 51);
            this.radioCardio.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioCardio.Name = "radioCardio";
            this.radioCardio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioCardio.Size = new System.Drawing.Size(101, 21);
            this.radioCardio.TabIndex = 2;
            this.radioCardio.Text = "Cardiology";
            this.radioCardio.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioCardio.UseVisualStyleBackColor = true;
            this.radioCardio.Click += new System.EventHandler(this.rjRadioButton5_Click);
            // 
            // radioNeurology
            // 
            this.radioNeurology.AutoSize = true;
            this.radioNeurology.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioNeurology.Location = new System.Drawing.Point(0, 78);
            this.radioNeurology.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioNeurology.Name = "radioNeurology";
            this.radioNeurology.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioNeurology.Size = new System.Drawing.Size(100, 21);
            this.radioNeurology.TabIndex = 1;
            this.radioNeurology.Text = "Neurology";
            this.radioNeurology.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioNeurology.UseVisualStyleBackColor = true;
            this.radioNeurology.Click += new System.EventHandler(this.rjRadioButton5_Click);
            // 
            // radioOncology
            // 
            this.radioOncology.AutoSize = true;
            this.radioOncology.Checked = true;
            this.radioOncology.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioOncology.Location = new System.Drawing.Point(0, 24);
            this.radioOncology.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioOncology.Name = "radioOncology";
            this.radioOncology.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioOncology.Size = new System.Drawing.Size(94, 21);
            this.radioOncology.TabIndex = 0;
            this.radioOncology.TabStop = true;
            this.radioOncology.Text = "Oncology";
            this.radioOncology.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioOncology.UseVisualStyleBackColor = true;
            this.radioOncology.Click += new System.EventHandler(this.rjRadioButton5_Click);
            // 
            // radioDelivery
            // 
            this.radioDelivery.AutoSize = true;
            this.radioDelivery.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioDelivery.Location = new System.Drawing.Point(0, 105);
            this.radioDelivery.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioDelivery.Name = "radioDelivery";
            this.radioDelivery.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioDelivery.Size = new System.Drawing.Size(85, 21);
            this.radioDelivery.TabIndex = 4;
            this.radioDelivery.Text = "Delivery";
            this.radioDelivery.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioDelivery.UseVisualStyleBackColor = true;
            this.radioDelivery.Click += new System.EventHandler(this.radioNormal_CheckedChanged);
            // 
            // radioSurgery
            // 
            this.radioSurgery.AutoSize = true;
            this.radioSurgery.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioSurgery.Location = new System.Drawing.Point(0, 132);
            this.radioSurgery.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioSurgery.Name = "radioSurgery";
            this.radioSurgery.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioSurgery.Size = new System.Drawing.Size(84, 21);
            this.radioSurgery.TabIndex = 3;
            this.radioSurgery.Text = "Surgery";
            this.radioSurgery.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioSurgery.UseVisualStyleBackColor = true;
            this.radioSurgery.Click += new System.EventHandler(this.radioNormal_CheckedChanged);
            // 
            // radioVip
            // 
            this.radioVip.AutoSize = true;
            this.radioVip.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioVip.Location = new System.Drawing.Point(0, 51);
            this.radioVip.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioVip.Name = "radioVip";
            this.radioVip.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioVip.Size = new System.Drawing.Size(56, 21);
            this.radioVip.TabIndex = 2;
            this.radioVip.Text = "VIP";
            this.radioVip.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioVip.UseVisualStyleBackColor = true;
            this.radioVip.Click += new System.EventHandler(this.radioNormal_CheckedChanged);
            // 
            // radioIcu
            // 
            this.radioIcu.AutoSize = true;
            this.radioIcu.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioIcu.Location = new System.Drawing.Point(0, 78);
            this.radioIcu.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioIcu.Name = "radioIcu";
            this.radioIcu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioIcu.Size = new System.Drawing.Size(57, 21);
            this.radioIcu.TabIndex = 1;
            this.radioIcu.Text = "ICU";
            this.radioIcu.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioIcu.UseVisualStyleBackColor = true;
            this.radioIcu.Click += new System.EventHandler(this.radioNormal_CheckedChanged);
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Checked = true;
            this.radioNormal.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.radioNormal.Location = new System.Drawing.Point(0, 24);
            this.radioNormal.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioNormal.Size = new System.Drawing.Size(81, 21);
            this.radioNormal.TabIndex = 0;
            this.radioNormal.TabStop = true;
            this.radioNormal.Text = "Normal";
            this.radioNormal.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioNormal.UseVisualStyleBackColor = true;
            this.radioNormal.Click += new System.EventHandler(this.radioNormal_CheckedChanged);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbb);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.roomFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.roomFlowPanel.ResumeLayout(false);
            this.loadPanel.ResumeLayout(false);
            this.loadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbb.ResumeLayout(false);
            this.gbb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel roomFlowPanel;
        private System.Windows.Forms.Panel loadPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar nurseBar;
        private Controls.RJButton addBtn;
        private System.Windows.Forms.GroupBox gbb;
        private Controls.RJRadioButton radioDelivery;
        private Controls.RJRadioButton radioSurgery;
        private Controls.RJRadioButton radioVip;
        private Controls.RJRadioButton radioIcu;
        private Controls.RJRadioButton radioNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.RJRadioButton radioPediatrics;
        private Controls.RJRadioButton radioMaternity;
        private Controls.RJRadioButton radioCardio;
        private Controls.RJRadioButton radioNeurology;
        private Controls.RJRadioButton radioOncology;
    }
}