using FontAwesome.Sharp;
using Nova_Medical_Center.Data;
using Nova_Medical_Center.Scripts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class DocHomeForm : Form
    {
        public DocHomeForm()
        {
            InitializeComponent();
            Nova_Medical_Center.Scripts.Events.OnEmployeeLoad += LoadedEmployee;
        }
        private void LoadedEmployee(bool val)
        {
            if (val == true)
            {
                loadPanel.Visible = false;
                CentralControler.InsertionSort(Data.Data.employees["Doctors"], emp => emp.First_Name);
                doctorGridView.DataSource = Data.Data.employees["Doctors"];
            }
            else
                errorLabel.Visible = true;
        }
        private void DoctorUpdateForm_Load(object sender, EventArgs e)
        {
            if (Data.Data.employees != null)
            {
                LoadedEmployee(true);
                return;
            }
            DataLoader.LoadEmployees();
        }

        private async void searchField_TextChanged(object sender, EventArgs e)
        {
            doctorGridView.DataSource = null;
            if (searchField.Text=="")
            {
                doctorGridView.DataSource = Data.Data.employees["Doctors"];
                return;
            }

            doctorGridView.DataSource = null;
            doctorGridView.DataSource = await CentralControler.SearchList(list: Data.Data.employees["Doctors"], searchTerm: searchField.Text);
        }
    }
}
