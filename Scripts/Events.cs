using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova_Medical_Center.Scripts
{
    public class Events
    {
        public static Action<bool> OnPatientLoad;
        public static Action<bool> OnRoomLoad;
        public static Action<bool> OnEmployeeLoad;
        public static Action OnDischarge;
    }
}
