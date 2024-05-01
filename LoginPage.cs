using MaterialSkin.Controls;
using Nova_Medical_Center.Data;
using Nova_Medical_Center.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nova_Medical_Center
{
    public partial class LoginPage : MaterialForm
    {
        
        private bool loaded = false;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public LoginPage()
        {
            Scripts.Events.OnEmployeeLoad += (val) => loaded = val;
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Grey900, MaterialSkin.Accent.Amber400, MaterialSkin.TextShade.WHITE);

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            List<Employee> emps;
            if (loaded)
            {
                if (empBox.SelectedItem.ToString().Contains("DOC"))
                    emps = Data.Data.employees["Doctors"];
                else if (empBox.SelectedItem.ToString().Contains("NRS"))
                    emps = Data.Data.employees["Nurses"];
                else
                    emps = Data.Data.employees["Front Desks"];
                foreach (var emp in emps)
                {
                    if (emp.Id == empBox.SelectedItem.ToString()+'-'+usernameField.Text)
                    {
                        MessageBox.Show(emp.Password);
                        MessageBox.Show(Employee.HashPassword(passwordField.Text));
                        MessageBox.Show(Employee.HashPassword(Employee.HashPassword(passwordField.Text)));
                        if (emp.Password.Equals(Employee.HashPassword(passwordField.Text)))
                        {
                            Data.Data.currentUser = emp;
                            this.Hide();
                            new HomePage().Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                            break;
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Wrong Username");
                        break;
                    }
                }
            }else
            MessageBox.Show("Loading Employees wait a min then try again.");
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            DataLoader.LoadEmployees();
            empBox.DataSource = new List<String>() {
                "DOC",
                "NRS",
                "FDK"
            };
        }
    }
}
