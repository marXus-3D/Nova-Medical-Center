namespace Nova_Medical_Center.Views.Controls
{
    partial class RoomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeLbl = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.numberLbl = new System.Windows.Forms.Label();
            this.bedLbl = new System.Windows.Forms.Label();
            this.checkBox = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(3, 172);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(43, 17);
            this.typeLbl.TabIndex = 0;
            this.typeLbl.Text = "Type: ";
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(3, 3);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(215, 133);
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(3, 139);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(66, 17);
            this.numberLbl.TabIndex = 6;
            this.numberLbl.Text = "Number: ";
            // 
            // bedLbl
            // 
            this.bedLbl.AutoSize = true;
            this.bedLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedLbl.Location = new System.Drawing.Point(3, 205);
            this.bedLbl.Name = "bedLbl";
            this.bedLbl.Size = new System.Drawing.Size(64, 17);
            this.bedLbl.TabIndex = 1;
            this.bedLbl.Text = "Occupied";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Depth = 0;
            this.checkBox.Enabled = false;
            this.checkBox.Location = new System.Drawing.Point(70, 197);
            this.checkBox.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox.Name = "checkBox";
            this.checkBox.ReadOnly = false;
            this.checkBox.Ripple = true;
            this.checkBox.Size = new System.Drawing.Size(35, 37);
            this.checkBox.TabIndex = 7;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // RoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.bedLbl);
            this.Controls.Add(this.typeLbl);
            this.Name = "RoomControl";
            this.Size = new System.Drawing.Size(221, 260);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label bedLbl;
        private MaterialSkin.Controls.MaterialCheckbox checkBox;
    }
}
