using Nova_Medical_Center.Data;
using Nova_Medical_Center.Scripts;
using System;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class PatientHomeForm : Form
    {
        int selectedIdx;
        public PatientHomeForm()
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
            CustomDialog.ShowQuestionDialog(ref selectedIdx);
            CentralControler.AdmitPatient(selectedIdx);
            Scripts.Events.OnChange?.Invoke();
        }

        private void doctorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            shareBtn.Enabled = true;
            recordBtn.Enabled = true;

            selectedIdx = doctorGridView.SelectedRows[0].Index;
            if (Data.Data.patients[selectedIdx].RoomOccupied == null)
                admitButton.Enabled = true;
            else 
                admitButton.Enabled = false;
        }

        private void shareBtn_Click(object sender, EventArgs e)
        {
            CustomDialog.ShowQrDialog(ref selectedIdx);
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            PatientForm.OnRecord?.Invoke(selectedIdx);
        }
    }
}
