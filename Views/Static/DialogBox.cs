using Nova_Medical_Center.Models;
using Nova_Medical_Center.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views.Static
{
    public partial class DialogBox : Form
    {
        bool edited = false, nameEdited = false;
        Employee employee;
        public DialogBox(ref Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            fnameField.Text = employee.First_Name;
            lnameField.Text = employee.Last_Name;
            addressField.Text = employee.Address;
            cityField.Text = employee.City;
            phoneField.Text = employee.PhoneNumber;
            deptField.Text = employee.Department;
            posField.Text = employee.Position;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            flipForm();
            if (!edited)
            {
                editBtn.Text = "Update";
                edited = true;
            }
            else
            {
                if (nameEdited)
                {
                   employee.First_Name = fnameField.Text;
                   employee.Last_Name = lnameField.Text;
                   employee.Address = addressField.Text;
                   employee.City = cityField.Text;
                   employee.PhoneNumber = phoneField.Text;
                   employee.Department = deptField.Text;
                   employee.Position = posField.Text;
                }
                else 
                {
                    GenerateID(ref employee);
                    employee.First_Name = fnameField.Text;
                    employee.Last_Name = lnameField.Text;
                    employee.Address = addressField.Text;
                    employee.City = cityField.Text;
                    employee.PhoneNumber = phoneField.Text;
                    employee.Department = deptField.Text;
                    employee.Position = posField.Text;
                }

                CustomDialog.OnEmployeeUpdate.Invoke(true);
                this.Close();
            }
        }

        void GenerateID(ref Employee emp)
        {
            emp.Id = emp.First_Name.ToUpper().Substring(0, 3) + "-" + emp.Last_Name.ToUpper().Substring(0, 3) + "-" + new Random().Next(100, 999);
        }

        private void flipForm()
        {
            fnameField.ReadOnly = !fnameField.ReadOnly;
            lnameField.ReadOnly = !lnameField.ReadOnly;
            addressField.ReadOnly = !addressField.ReadOnly;
            cityField.ReadOnly = !cityField.ReadOnly;
            phoneField.ReadOnly = !phoneField.ReadOnly;
            deptField.ReadOnly = !deptField.ReadOnly;
            posField.ReadOnly = !posField.ReadOnly;
        }

        private void fnameField_TextChanged(object sender, EventArgs e)
        {
            if (!nameEdited)
                nameEdited = true;
        }

        private void lnameField_TextChanged(object sender, EventArgs e)
        {
            if (!nameEdited)
                nameEdited = true;
        }
    }
}