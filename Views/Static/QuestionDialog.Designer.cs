namespace Nova_Medical_Center.Views.Static
{
    partial class QuestionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionDialog));
            this.titleLabel = new System.Windows.Forms.Label();
            this.bodyLbl = new System.Windows.Forms.RichTextBox();
            this.btnCrit = new Nova_Medical_Center.Views.Controls.RJButton();
            this.BtnNon = new Nova_Medical_Center.Views.Controls.RJButton();
            this.BtnSemi = new Nova_Medical_Center.Views.Controls.RJButton();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(135, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "This an Example Title";
            // 
            // bodyLbl
            // 
            this.bodyLbl.BackColor = System.Drawing.SystemColors.Control;
            this.bodyLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bodyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLbl.Location = new System.Drawing.Point(15, 49);
            this.bodyLbl.Name = "bodyLbl";
            this.bodyLbl.ReadOnly = true;
            this.bodyLbl.Size = new System.Drawing.Size(453, 179);
            this.bodyLbl.TabIndex = 1;
            this.bodyLbl.Text = resources.GetString("bodyLbl.Text");
            // 
            // btnCrit
            // 
            this.btnCrit.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnCrit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnCrit.BorderRadius = 9;
            this.btnCrit.BorderSize = 2;
            this.btnCrit.FlatAppearance.BorderSize = 0;
            this.btnCrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrit.ForeColor = System.Drawing.Color.Black;
            this.btnCrit.Location = new System.Drawing.Point(15, 268);
            this.btnCrit.Name = "btnCrit";
            this.btnCrit.Size = new System.Drawing.Size(120, 40);
            this.btnCrit.TabIndex = 2;
            this.btnCrit.Text = "Critical";
            this.btnCrit.TextColor = System.Drawing.Color.Black;
            this.btnCrit.UseVisualStyleBackColor = false;
            this.btnCrit.Click += new System.EventHandler(this.btnCrit_Click);
            // 
            // BtnNon
            // 
            this.BtnNon.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BtnNon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtnNon.BorderRadius = 9;
            this.BtnNon.BorderSize = 2;
            this.BtnNon.FlatAppearance.BorderSize = 0;
            this.BtnNon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNon.ForeColor = System.Drawing.Color.Black;
            this.BtnNon.Location = new System.Drawing.Point(166, 268);
            this.BtnNon.Name = "BtnNon";
            this.BtnNon.Size = new System.Drawing.Size(120, 40);
            this.BtnNon.TabIndex = 3;
            this.BtnNon.Text = "Non Critical";
            this.BtnNon.TextColor = System.Drawing.Color.Black;
            this.BtnNon.UseVisualStyleBackColor = false;
            this.BtnNon.Click += new System.EventHandler(this.BtnNon_Click);
            // 
            // BtnSemi
            // 
            this.BtnSemi.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSemi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BtnSemi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtnSemi.BorderRadius = 9;
            this.BtnSemi.BorderSize = 2;
            this.BtnSemi.FlatAppearance.BorderSize = 0;
            this.BtnSemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSemi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSemi.ForeColor = System.Drawing.Color.Black;
            this.BtnSemi.Location = new System.Drawing.Point(326, 268);
            this.BtnSemi.Name = "BtnSemi";
            this.BtnSemi.Size = new System.Drawing.Size(120, 40);
            this.BtnSemi.TabIndex = 4;
            this.BtnSemi.Text = "Semi Critical";
            this.BtnSemi.TextColor = System.Drawing.Color.Black;
            this.BtnSemi.UseVisualStyleBackColor = false;
            this.BtnSemi.Click += new System.EventHandler(this.BtnSemi_Click);
            // 
            // QuestionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.BtnSemi);
            this.Controls.Add(this.BtnNon);
            this.Controls.Add(this.btnCrit);
            this.Controls.Add(this.bodyLbl);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox bodyLbl;
        private Controls.RJButton btnCrit;
        private Controls.RJButton BtnNon;
        private Controls.RJButton BtnSemi;
    }
}