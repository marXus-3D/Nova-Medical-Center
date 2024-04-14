using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova_Medical_Center.Scripts
{
    internal class Generator
    {
        static Random random = new Random(DateTime.Now.Millisecond);
        private static int lastId = 10000;
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string GeneratePatientID() 
        {
            if (lastId <= 10000)
            {
                try {
                     int.TryParse(Data.Data.patients.Last().Id.Substring(8), out lastId);
                }catch(Exception)
                {
                    lastId = 10000;
                }
                
            }
            string str = "PAT-" + chars[random.Next(chars.Length)] + chars[random.Next(chars.Length)] + chars[random.Next(chars.Length)] + "-" + ++lastId; 
            return str;
        }
    }
}
