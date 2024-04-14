using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views.Static
{
    public partial class PrescriptionForm : Form
    {
        Bitmap bmp;
        public PrescriptionForm(ref int idx, DateTime time, ref float dose)
        {
            InitializeComponent();
            var pat = Data.Data.patients[idx];
            nameLbl.Text = "Name: " + pat.First_Name + " " + pat.Last_Name;
            dateLbl.Text = "Date: " + DateTime.Now.ToString();
            diagnosisLbl.Text = "Diagnosis: " + pat.MedicalHistory.Last().Name;
            dosageLbl.Text = $"Dosage: {dose}ml";
            endLbl.Text = "End Date: " + time.ToShortDateString();
            medicationArea.Text = "Medications: \n" + pat.MedicalHistory.Last().ToString(true);

            preLbl.Text = "Prescribed By: Dr. " + Data.Data.currentUser.First_Name + " " + Data.Data.currentUser.Last_Name;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void print_Click(object sender, EventArgs e)
        {
            print.Visible = false;

            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

            MessageBox.Show("Close this window", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
