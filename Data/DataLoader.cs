using Nova_Medical_Center.Models;
using Nova_Medical_Center.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Data
{
    internal class DataLoader
    {
        public static async void LoadPatient() 
        {
            Data.patients = await Patient.DeserializePatients();
            if (Data.patients != null)
                Events.OnPatientLoad.Invoke(true);
        }
        public static async void LoadRooms()
        {
            MessageBox.Show("Loading Rooms");
            Data.rooms = await Room.DeserializeRoomsAsync();
            if(Data.rooms != null)
                Events.OnRoomLoad.Invoke(true);
        }

        public static async void LoadEmployees() 
        {
            Data.employees = await Employee.DeserializeEmployees();
            if (Data.employees != null)
                Events.OnEmployeeLoad.Invoke(true);
        }
    }
}
