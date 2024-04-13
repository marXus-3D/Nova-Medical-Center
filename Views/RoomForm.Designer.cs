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
    }
}