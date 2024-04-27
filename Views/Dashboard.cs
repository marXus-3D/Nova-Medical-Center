using Nova_Medical_Center.Data;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Scripts.Events.OnEmployeeLoad += (val) =>
            {
                doctorBar.Value = Data.Data.employees["Doctors"].Count;
                nurseBar.Value = Data.Data.employees["Nurses"].Count;
                receptionBar.Value = Data.Data.employees["Front Desks"].Count;

                receptionBar.Value = nurseBar.Maximum = doctorBar.Maximum = doctorBar.Value + nurseBar.Value + receptionBar.Value;
            };
            Scripts.Events.OnRoomLoad += (val) => 
            {
                roomBar.Maximum = Data.Data.rooms.Count;
                roomBar.Value = Data.Data.rooms.Where(r => r.Occupied).Count();
            };
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            if (Data.Data.employees == null)
                DataLoader.LoadEmployees();
            else
            {
                doctorBar.Value = Data.Data.employees["Doctors"].Count;
            }

            await DataLoader.LoadRooms();
        }
    }
}
