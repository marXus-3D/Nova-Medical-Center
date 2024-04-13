using FontAwesome.Sharp;
using Nova_Medical_Center.Data;
using Nova_Medical_Center.Scripts;
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
    public partial class PatientAdmitForm : Form
    {
        public PatientAdmitForm()
        {
            InitializeComponent();
            Nova_Medical_Center.Scripts.Events.OnPatientLoad += LoadedPatients;
        }

        private void LoadedPatients(bool val)
        {
            if (val == true)
            {
                loadPanel.Visible = false;
                doctorGridView.DataSource = Data.Data.patients;
            }
            else
                errorLabel.Visible = true;
        }

        private void PatientUpdateForm_Load(object sender, EventArgs e)
        {
            DataLoader.LoadPatient();
        }
    }
}
