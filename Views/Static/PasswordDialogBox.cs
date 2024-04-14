﻿using Nova_Medical_Center.Models;
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
    public partial class PasswordDialogBox : Form
    {
        Employee employee;
        public PasswordDialogBox(ref Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
                FlipForm();
                if (!passwordField.Text.Equals(confirmField.Text))
                {
                    MessageBox.Show("Password's don't match");
                    FlipForm();
                    return;
                }
                if (employee.Password.Equals(Employee.HashPassword(Employee.HashPassword(passwordField.Text)))) 
                {
                    MessageBox.Show("This Password is already in use");
                    FlipForm();
                    return;
                }
                
                employee.Password = passwordField.Text;
                CustomDialog.OnEmployeeUpdate.Invoke(true);
                this.Close();
        }

        private void FlipForm()
        {
            passwordField.ReadOnly = !passwordField.ReadOnly;
            confirmField.ReadOnly = !confirmField.ReadOnly;
        }

        private void confirmField_TextChanged(object sender, EventArgs e)
        {
            if(!(confirmField.Text == "") && !(passwordField.Text == "") && !(confirmField.Text.Contains(" ") || passwordField.Text.Contains(" "))) 
                editBtn.Enabled = true;
        }
    }
}