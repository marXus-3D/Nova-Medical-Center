using Nova_Medical_Center.Data;
using Nova_Medical_Center.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Nova_Medical_Center.Scripts
{
    public class CentralControler
    {
        public async static void AdmitPatient(int idx) 
        {
            var patient = Data.Data.patients[idx];

            var room = await CheckRooms();
            if (room != null) 
            {
                MessageBox.Show("Room " + room.Id);
                room.Occupied = true;
                patient.RoomOccupied = room;

                return;
            }
            switch (patient.UrgencyLevel)
            {
                case Urgency.Critical:
                    Data.Data.CriticalQueue.Enqueue(patient);
                break;
                case Urgency.NonCritical:
                    Data.Data.NonCriticalQueue.Enqueue(patient);
                break;
                case Urgency.SemiCritical:
                    Data.Data.SemiCriticalQueue.Enqueue(patient);
                break;
            }
        }

        private async static Task<Room> CheckRooms()
        {
            if (Data.Data.rooms == null)
                await DataLoader.LoadRooms();
            return Data.Data.rooms.Where(room => !room.Occupied).FirstOrDefault();
        }
    }
}
