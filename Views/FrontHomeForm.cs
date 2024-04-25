using FontAwesome.Sharp;
using Nova_Medical_Center.Data;
using System;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class FrontHomeForm : Form
    {
        public FrontHomeForm()
        {
            InitializeComponent();
            Nova_Medical_Center.Scripts.Events.OnEmployeeLoad += LoadedEmployee;
        }
        private void LoadedEmployee(bool val)
        {
            if (val == true)
            {
                loadPanel.Visible = false;
                doctorGridView.DataSource = Data.Data.employees["Front Desks"];
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
