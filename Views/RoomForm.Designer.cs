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
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nurseBar = new CircularProgressBar.CircularProgressBar();
            this.loadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomFlowPanel
            // 
            this.roomFlowPanel.AutoScroll = true;
            this.roomFlowPanel.Location = new System.Drawing.Point(12, 12);
            this.roomFlowPanel.Name = "roomFlowPanel";
            this.roomFlowPanel.Size = new System.Drawing.Size(1022, 631);
            this.roomFlowPanel.TabIndex = 0;
            // 
            // loadPanel
            // 
            this.loadPanel.Controls.Add(this.nurseBar);
            this.loadPanel.Controls.Add(this.errorLabel);
            this.loadPanel.Controls.Add(this.pictureBox1);
            this.loadPanel.Location = new System.Drawing.Point(3, 3);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(1046, 675);
            this.loadPanel.TabIndex = 2;
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
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 675);
            this.Controls.Add(this.loadPanel);
            this.Controls.Add(this.roomFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.loadPanel.ResumeLayout(false);
            this.loadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel roomFlowPanel;
        private System.Windows.Forms.Panel loadPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar nurseBar;
    }
}