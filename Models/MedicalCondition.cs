using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova_Medical_Center.Models
{
    internal class MedicalCondition
    {
        public string Name { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public List<string> Medications { get; set; }
    }
}
