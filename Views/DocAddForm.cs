using FontAwesome.Sharp;
using Newtonsoft.Json;
using Nova_Medical_Center.Data;
using Nova_Medical_Center.Models;
using Nova_Medical_Center.Scripts;
using Nova_Medical_Center.Views.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class DocAddForm : Form
    {
        List<String> medicationList = new List<string>();
        List<MedicalCondition> medicalConditions = new List<MedicalCondition>();
        public DocAddForm()
        {
            InitializeComponent();
        }

        private async void NewPatientForm_Load(object sender, EventArgs e)
        {
            string jsonString = await Task.Run(() => File.ReadAllText("medications.json", Encoding.UTF8));
            Data.Data.medications = await Task.Run(() => JsonConvert.DeserializeObject<Dictionary<int,string>>(jsonString));
            medicationComboBox.DataSource = Data.Data.medications.Values.ToList();
        }

        private void admitBtn_Click(object sender, EventArgs e)
        {
            Data.Data.patients.Add(new Patient() 
            {
                Id = Generator.GeneratePatientID(),
                First_Name = fnameField.Text,
                Last_Name = lnameField.Text,
                Gender = maleRadio.Checked? 'M':'F',
                DoB = dobPicker.Value,
                AdmissionDate = DateTime.Now,
                UrgencyLevel = criticalRadio.Checked ? Urgency.Critical: nonRadio.Checked? Urgency.NonCritical : Urgency.SemiCritical,
                Vip = vipCheck.Checked,
                MedicalHistory = medicalConditions,
            });
            CentralControler.AdmitPatient(Data.Data.patients.Count-1);
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            medicalConditions.Add(new MedicalCondition()
            {
                Name = diagnosisField.Text,
                DiagnosisDate = medicationDate.Value,
                Medications = medicationList,
            });

            medicationArea.Text += "\n" + medicalConditions.Last().ToString();
            medicationList = new List<string>();
        }

        private void medicationBtn_Click(object sender, EventArgs e)
        {
            medicationList.Add(medicationComboBox.SelectedItem.ToString());
        }
    }
}
