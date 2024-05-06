using FontAwesome.Sharp;
using Nova_Medical_Center.Models;
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
    public partial class NurseUpdateForm : Form
    {
        IconButton current;
        public NurseUpdateForm()
        {
            InitializeComponent();
        }
        private void DoctorUpdateForm_Load(object sender, EventArgs e)
        {
            doctorGridView.DataSource = Data.Data.employees["Nurses"];
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = doctorGridView.SelectedRows[0];
            int selectedRowIndex = doctorGridView.Rows.IndexOf(selectedRow);

            CustomDialog.ShowDialog(Data.Data.employees[selectedRow.Cells[10].Value.ToString() + "s"][selectedRowIndex], ref selectedRowIndex);
            updateBtn.Enabled = false;
            resetButton.Enabled = false;
        }

        private void doctorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBtn.Enabled = true;
            resetButton.Enabled = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = doctorGridView.SelectedRows[0];
            int selectedRowIndex = doctorGridView.Rows.IndexOf(selectedRow);

            CustomDialog.ShowPasswordDialog(Data.Data.employees["Nurses"][selectedRowIndex], ref selectedRowIndex);

            updateBtn.Enabled = false;
            resetButton.Enabled = false;
        }
    }
}
