using MaterialSkin.Controls;
using Nova_Medical_Center.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center
{
    public partial class LoginPage : MaterialForm
    {
        
        private bool loaded = false;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public static Action<bool> OnEmployeeLoad; 
        public LoginPage()
        {
            OnEmployeeLoad += (val) => loaded = val;
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Grey900, MaterialSkin.Accent.Amber400, MaterialSkin.TextShade.WHITE);

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                foreach (var emp in Data.Data.employees)
                {
                    if (emp.Id == usernameField.Text)
                    {
                        if (emp.Password.Equals(Employee.HashPassword(Employee.HashPassword(passwordField.Text))))
                        {
                            this.Hide();
                            new HomePage().Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                        }
                    }
                    else MessageBox.Show("Wrong Username");
                }
            }else
            MessageBox.Show("Not Loaded");
        }

        private async void LoginPage_Load(object sender, EventArgs e)
        {
            await LoadEmployee();
        }

        private async Task LoadEmployee()
        {
            Data.Data.employees = await Employee.DeserializeEmployees();
            
        }
    }
}
