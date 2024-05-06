using Newtonsoft.Json;
using Nova_Medical_Center.Models;
using Nova_Medical_Center.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views.Static
{
    public partial class DischargeDialogBox : Form
    {
        float ml = 1.5f;
        int idx;
        List<String> medications = new List<String>();
        public DischargeDialogBox(ref int idx)
        {
            InitializeComponent();
            this.idx = idx;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Data.Data.patients[idx].MedicalHistory.Add(new MedicalCondition() 
            { 
                Name = diagnosisField.Text,
                DiagnosisDate = DateTime.Now,
                Medications = medications,
            });
            int roomIdx = Data.Data.rooms.IndexOf(Data.Data.rooms.Where(r => r.Id == Data.Data.patients[idx].RoomOccupied.Id).First());
            Data.Data.rooms[roomIdx].Occupied = false;
            Data.Data.patients[idx].RoomOccupied = null;

            Scripts.Events.OnDischarge?.Invoke(roomIdx);
            Scripts.Events.OnChange?.Invoke();
            new PrescriptionForm(ref idx, medicationDate.Value, ref ml).ShowDialog();
            this.Close();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            ml += 0.5f;
            spinnerField.Text = ml.ToString() + " ml";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            ml -= 0.5f;
            spinnerField.Text = ml.ToString() + " ml";
        }

        private async void DischargeDialogBox_Load(object sender, EventArgs e)
        {
            if (Data.Data.medications == null)
            {
                string jsonString = await Task.Run(() => File.ReadAllText("medications.json", Encoding.UTF8));
                Data.Data.medications = await Task.Run(() => JsonConvert.DeserializeObject<Dictionary<int, string>>(jsonString));
            }
            medicationCombobox.DataSource = Data.Data.medications.Values.ToList();
        }

        private void medicationBtn_Click(object sender, EventArgs e)
        {
            medications.Add(medicationCombobox.SelectedItem.ToString());
        }
    }
}