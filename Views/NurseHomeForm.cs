using FontAwesome.Sharp;
using Nova_Medical_Center.Data;
using Nova_Medical_Center.Scripts;
using System;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class NurseHomeForm : Form
    {
        public NurseHomeForm()
        {
            InitializeComponent();
            Nova_Medical_Center.Scripts.Events.OnEmployeeLoad += LoadedEmployee;
        }
        private void LoadedEmployee(bool val)
        {
            if (val == true)
            {
                loadPanel.Visible = false;
                CentralControler.InsertionSort(Data.Data.employees["Nurses"], emp => emp.First_Name);
                doctorGridView.DataSource = Data.Data.employees["Nurses"];
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
    }
}
