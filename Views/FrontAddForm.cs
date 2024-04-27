using Newtonsoft.Json;
using Nova_Medical_Center.Models;
using Nova_Medical_Center.Scripts;
using Nova_Medical_Center.Views.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class FrontAddForm : Form
    {
        public FrontAddForm()
        {
            InitializeComponent();
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            departmentComboBox.DataSource = new List<string>()
            {
                "Managment"
            }; ;
        }

        private void admitBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                var emp = new Employee()
                {
                    First_Name = fnameField.Text,
                    Last_Name = lnameField.Text,
                    Gender = maleRadio.Checked ? 'M' : 'F',
                    DoB = dobPicker.Value.Date,
                    Address = addressField.Text,
                    City = cityField.Text,
                    PhoneNumber = "251-" + phoneField.Text,
                    HiredDate = DateTime.Now.Date,
                    Department = departmentComboBox.SelectedItem.ToString(),
                    Position = "Front Desk",
                    Password = passField.Text,
                };
                Generator.GenerateEmployeeID(ref emp);
                Data.Data.employees["Front Desks"].Add(emp);

                MessageBox.Show("Task Successfull");
            }
        }

        bool CheckForm() 
        {
            if(fnameField.Text == "" || fnameField.Text.Contains(" ") || lnameField.Text == "" || lnameField.Text.Contains(" ") || addressField.Text == "" || cityField.Text == "" || phoneField.Text.Contains(" ") || passField.Texts == "" || passField.Texts.Contains(" ") || confirmField.Texts == "" || confirmField.Texts.Contains(" ")) 
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

        private void confirmField_Click(object sender, EventArgs e)
        {
            ((RJTextBox)sender).Texts = "";
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && components != null)
        //    {
        //        components.Dispose(); // Dispose of all components on the form
        //    }
        //    base.Dispose(disposing);
        //}

        //private void DocAddForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    this.Dispose(true);
        //}
    }
}
