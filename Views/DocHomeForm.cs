using FontAwesome.Sharp;
using Nova_Medical_Center.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class DocHomeForm : Form
    {
        public DocHomeForm()
        {
            InitializeComponent();
            Nova_Medical_Center.Scripts.Events.OnEmployeeLoad += LoadedEmployee;
        }
        private void LoadedEmployee(bool val)
        {
            if (val == true)
            {
                loadPanel.Visible = false;
                InsertionSort(Data.Data.employees["Doctors"], emp => emp.First_Name);
                doctorGridView.DataSource = Data.Data.employees["Doctors"];
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
        public static void InsertionSort<T>(List<T> list, Func<T, string> getProperty) where T : class
        {
            for (int i = 1; i < list.Count; i++)
            {
                T key = list[i];
                int j = i - 1;

                // Compare elements based on the property retrieved using the getProperty function
                while (j >= 0 && getProperty(list[j]).CompareTo(getProperty(key)) > 0)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                // Insert the current element at its correct position
                list[j + 1] = key;
            }
        }
    }
}
