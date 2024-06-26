﻿using MaterialSkin.Controls;
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

            Events.OnChange?.Invoke();
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
            Scripts.Events.OnChange?.Invoke();
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

        public static async Task<List<Employee>> SearchList(List<Employee> list, string searchTerm) //where T : Employee
        {
            return await Task.Run(() =>
            {
                List<Employee> res = new List<Employee>();
                if (list.Last().First_Name.ToLower()[0] < searchTerm.ToLower()[0])
                    return null;

                foreach (var emp in list)
                {
                    if (emp.First_Name.ToLower().First() > searchTerm.ToLower().First())
                        break;

                    if(emp.First_Name.ToLower().StartsWith(searchTerm.ToLower()))
                        res.Add(emp);
                }

                return res;
            });
        }

        public static async void SaveChanges() 
        {
            await Task.Run(() =>
            {
                if (Data.Data.patients != null)
                    Patient.SerializePatients(Data.Data.patients);
                if (Data.Data.employees != null)
                    Employee.SerializeEmployees(Data.Data.employees);
                if(Data.Data.rooms != null)
                    Room.SerializeRooms(Data.Data.rooms);
            });
        }
    }
}
