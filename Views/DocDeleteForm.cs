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
    public partial class DocDeleteForm : Form
    {
        IconButton current;
        public DocDeleteForm()
        {
            InitializeComponent();
        }
        private void DoctorUpdateForm_Load(object sender, EventArgs e)
        {
            doctorGridView.DataSource = Data.Data.employees["Doctors"];
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = doctorGridView.SelectedRows[0];
            int selectedRowIndex = doctorGridView.Rows.IndexOf(selectedRow);
            if(MessageBox.Show("Are you sure you want to remove this employee", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (MessageBox.Show("Are you really sure this is an irreversible action", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    rmvBtn.Enabled = false;
                    Data.Data.employees["Doctors"].RemoveAt(selectedRowIndex);
                    Scripts.Events.OnChange?.Invoke();
                    MessageBox.Show("Successfully removed employee");
                }
        }

        private void doctorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rmvBtn.Enabled = true;
        }
    }
}
