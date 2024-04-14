using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Nova_Medical_Center.Models
{
    public class MedicalCondition
    {
        public string Name { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public List<string> Medications { get; set; }

        public override string ToString()
        {
            string str = "";

            foreach (var item in Medications)
            {
                str += "\n";
                str += "\t- " + item;
            }
            return "Medication Name: " + Name + "\nDiagnosis Date: " + DiagnosisDate + "\nMedications: " + str + "\n-----------------------------------------------------------------------------------------------------------------------------------------------------------------------";
        }
    }
}
