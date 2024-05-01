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
    public partial class DocUpdateForm : Form
    {
        IconButton current;
        public DocUpdateForm()
        {
            InitializeComponent();
        }
        private void DoctorUpdateForm_Load(object sender, EventArgs e)
        {
            doctorGridView.DataSource = Data.Data.employees["Doctors"];
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = doctorGridView.SelectedRows[0];
            int selectedRowIndex = doctorGridView.Rows.IndexOf(selectedRow);

            CustomDialog.ShowDialog(Data.Data.employees["Doctors"][selectedRowIndex], ref selectedRowIndex);
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
            var emp = new Employee()
            {
                Id = selectedRow.Cells[0].Value.ToString(),
                First_Name = selectedRow.Cells[1].Value.ToString(),
                Last_Name = selectedRow.Cells[2].Value.ToString(),
                DoB = DateTime.Parse(selectedRow.Cells[3].Value.ToString()),
                Gender = selectedRow.Cells[4].Value.ToString()[0],
                Address = selectedRow.Cells[5].Value.ToString(),
                City = selectedRow.Cells[6].Value.ToString(),
                PhoneNumber = selectedRow.Cells[7].Value.ToString(),
                HiredDate = DateTime.Parse(selectedRow.Cells[8].Value.ToString()),
                Department = selectedRow.Cells[9].Value.ToString(),
                Position = selectedRow.Cells[10].Value.ToString(),
                Password = selectedRow.Cells[11].Value.ToString(),
            };

            CustomDialog.ShowPasswordDialog(Data.Data.employees[emp.Position + "s"][selectedRowIndex], ref selectedRowIndex);

            updateBtn.Enabled = false;
            resetButton.Enabled = false;
        }
    }
}
