using Newtonsoft.Json;
using Nova_Medical_Center.Models;
using Nova_Medical_Center.Scripts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class DocAddForm : Form
    {
        public DocAddForm()
        {
            InitializeComponent();
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            departmentComboBox.DataSource = new List<string>() 
            {
                "Cardiology",
                "Neurology",
                "Orthopedics",
                "Oncology",
                "Pediatrics",
                "Gynecology",
                "Dermatology",
                "Urology",
                "Ophthalmology",
                "Psychiatry",
                "Radiology",
                "Emergency Medicine",
                "Anesthesiology",
                "Pathology",
                "Physical Therapy",
                "Respiratory Therapy",
                "Nutrition and Dietetics",
                "Pharmacy",
                "Laboratory Medicine",
                "Patient Services"
            };
        }

        private void admitBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Data.Data.employees["Doctors"].Add(new Employee()
                {
                    Id = Generator.GeneratePatientID(),
                    First_Name = fnameField.Text,
                    Last_Name = lnameField.Text,
                    Gender = maleRadio.Checked ? 'M' : 'F',
                    DoB = dobPicker.Value,
                    Address = addressField.Text,
                    City = cityField.Text,
                    PhoneNumber = "251-" + phoneField.Text,
                    HiredDate = DateTime.Now,
                    Department = departmentComboBox.SelectedItem.ToString(),
                    Position = "Doctor",
                    Password = passField.Text,
                });
            }
        }

        bool CheckForm() 
        {
            if(fnameField.Text == "" || fnameField.Text.Contains(" ") || lnameField.Text == "" || lnameField.Text.Contains(" ") || addressField.Text == "" || cityField.Text == "" || phoneField.Text.Contains(" ") || passField.Text == "" || passField.Text.Contains(" ") || confirmField.Text == "" || confirmField.Text.Contains(" ")) 
            {
                MessageBox.Show("Please make sure you've filled the form correctlly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!passField.Text.Equals(confirmField.Text)) 
            {
                MessageBox.Show("Make sure the passwords match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
