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
    public partial class PatientDischargeForm : Form
    {
        int selectedIdx;
        public PatientDischargeForm()
        {
            InitializeComponent();
            loadPanel.BringToFront();
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
            if (Data.Data.patients == null)
            {
                DataLoader.LoadPatient();
                return;
            }

            LoadedPatients(true);
        }

        private void admitButton_Click(object sender, EventArgs e)
        {
            CustomDialog.ShowDischargeDialog(ref selectedIdx);
        }

        private void doctorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIdx = doctorGridView.SelectedRows[0].Index;
            if (Data.Data.patients[selectedIdx].RoomOccupied != null)
                admitButton.Enabled = true;
            else 
                admitButton.Enabled = false;
        }
    }
}
