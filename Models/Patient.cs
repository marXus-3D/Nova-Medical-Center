using Newtonsoft.Json;
using Nova_Medical_Center.Scripts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Models
{
    internal class Patient
    {
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set;}
        public List<MedicalCondition> MedicalHistory { get; set; }
        public DateTime AdmissionDate { get; set; }
        public Urgency UrgencyLevel { get; set; }
        public Room RoomOccupied { get; set; }
        public int BedId { get; set; }

        public static void SerializePatients(List<Patient> patients)
        {
            string jsonString = JsonConvert.SerializeObject(patients, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("patients.json", jsonString, Encoding.UTF8);
        }

        public static async Task<List<Patient>> DeserializePatients()
        {
            List<Patient> patients;
            try
            {
                string jsonString = await Task.Run(() => File.ReadAllText("patients.json", Encoding.UTF8));
                #region Deserialization approach
                patients = await Task.Run(() => JsonConvert.DeserializeObject<List<Patient>>(jsonString));

                #endregion
                Events.OnPatientLoad.Invoke(true);
                return patients;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                Events.OnPatientLoad.Invoke(false);
                return null;
            }
        }
    }
}
