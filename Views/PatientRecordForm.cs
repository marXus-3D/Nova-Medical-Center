using Nova_Medical_Center.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class PatientRecordForm : Form
    {
        Patient patient;
        public PatientRecordForm(ref int idx)
        {
            patient = Data.Data.patients[idx];
            InitializeComponent();
        }

        private void PatientRecordForm_Load(object sender, EventArgs e)
        {
            fnameField.Text = patient.First_Name;
            lnameField.Text = patient.Last_Name;
            dobPicker.Value = patient.DoB;
            femalRadio.Checked = patient.Gender.Equals('F') ? true : false;
            ageField.Text = (DateTime.Now.Year - patient.DoB.Year).ToString();
            vipCheck.Text = "Vipa check";
            vipCheck.Checked = patient.Vip;
        }
    }
}
