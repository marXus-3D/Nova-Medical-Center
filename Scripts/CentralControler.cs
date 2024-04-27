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

            var room = await CheckRooms(patient);
            if (room != null) 
            {
                MessageBox.Show("Room " + room.Id);
                room.Occupied = true;
                patient.RoomOccupied = room;

                return;
            }
            if (patient.Vip) 
            {
                Data.Data.VipQueue.Enqueue(patient);
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

        private async static Task<Room> CheckRooms(Patient patient)
        {
            if (Data.Data.rooms == null)
                await DataLoader.LoadRooms();
            switch (patient.Vip) 
            {
                case true:
                    return Data.Data.rooms.Where(room => !room.Occupied && room.Type.Equals("VIP")).FirstOrDefault();
                    break;
                case false:
                    switch (patient.UrgencyLevel) 
                    {
                        case Urgency.Critical:
                            Room tmp = null;
                            Room searchedRoom = Data.Data.rooms.Where(room =>
                            {
                                if (!room.Occupied)
                                {
                                    if(room.Type.Equals("ICU"))
                                        return true;
                                    tmp = room.Type.Equals("Normal")? room: null;

                                    return !(room == null);
                                } else
                                    return false;
                            }).FirstOrDefault();
                            if (searchedRoom == null)
                                return tmp;
                            return searchedRoom;
                            break;
                        case Urgency.SemiCritical:
                            return Data.Data.rooms.Where(room => !room.Occupied && room.Type.Equals("Normal") || room.Type.Equals("ICU")).FirstOrDefault();
                            break;
                        case Urgency.NonCritical:
                            return Data.Data.rooms.Where(room => !room.Occupied && room.Type.Equals("Normal")).FirstOrDefault();
                            break;
                    }
                    break;
            }

            return null;
        }
    
        public static void RoomUpdate(int roomIdx) 
        {
            if (Data.Data.VipQueue?.Count > 0 && Data.Data.rooms[roomIdx].Type.Equals("VIP"))
            {
                var patient = Data.Data.VipQueue.Dequeue();

                Data.Data.rooms[roomIdx].Occupied = true;
                patient.RoomOccupied = Data.Data.rooms[roomIdx];

                if (Data.Data.patients.IndexOf(patient) == -1)
                {
                    Data.Data.patients.Add(patient);
                }

                return;
            }
            if (Data.Data.CriticalQueue?.Count > 0)
            {
                var patient = Data.Data.CriticalQueue.Dequeue();

                Data.Data.rooms[roomIdx].Occupied = true;
                patient.RoomOccupied = Data.Data.rooms[roomIdx];

                if (Data.Data.patients.IndexOf(patient) == -1)
                {
                    Data.Data.patients.Add(patient);
                }
            }
            else if(Data.Data.SemiCriticalQueue?.Count > 0)
            {
                var patient = Data.Data.SemiCriticalQueue.Dequeue();

                Data.Data.rooms[roomIdx].Occupied = true;
                patient.RoomOccupied = Data.Data.rooms[roomIdx];

                if (Data.Data.patients.IndexOf(patient) == -1)
                {
                    Data.Data.patients.Add(patient);
                }
            }
            else if (Data.Data.NonCriticalQueue?.Count > 0)
            {
                var patient = Data.Data.NonCriticalQueue.Dequeue();

                Data.Data.rooms[roomIdx].Occupied = true;
                patient.RoomOccupied = Data.Data.rooms[roomIdx];

                if (Data.Data.patients.IndexOf(patient) == -1)
                {
                    Data.Data.patients.Add(patient);
                }
            }
        }
    }
}
