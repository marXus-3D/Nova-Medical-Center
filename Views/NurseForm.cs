using FontAwesome.Sharp;
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
    public partial class NurseForm : Form
    {
        IconButton current;
        Form currentForm;
        public NurseForm()
        {
            InitializeComponent();
            current = homeBtn;
            OpenChildForm(new DocHomeForm());
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            //doctorGridView.DataSource = LoginPage.employees;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DocHomeForm());
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DocUpdateForm());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DocUpdateForm());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ActivateButton(object sender)
        {
            if (current != null) {
                current.BackColor = Color.White;
            }

            ((IconButton)sender).BackColor = Color.FromArgb(224, 224, 224);
            line.Location = new Point(((IconButton)sender).Bounds.X, 50);
            current = (IconButton)sender;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            deskPanel.Controls.Add(childForm);
            deskPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }
    }
}
