using Nova_Medical_Center.Models;
using System.Collections.Generic;

namespace Nova_Medical_Center.Data
{
    internal class Data
    {
        public static Dictionary<string,List<Employee>> employees;
        public static List<Patient> patients;
        public static List<Room> rooms;

        public static Dictionary<int, string> medications;

        public static Employee currentUser;

        public static Queue<Patient> NonCriticalQueue;
        public static Queue<Patient> CriticalQueue;
        public static Queue<Patient> SemiCriticalQueue;
        public static Queue<Patient> VipQueue;
    }
}
