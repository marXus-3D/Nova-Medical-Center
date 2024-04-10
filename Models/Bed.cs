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
    public class Bed
    {
        public int Id { get; set; }
        //public string Location { get; set; }
        public bool Available { get; set; }
        //public List<string> Equipment { get; set; }

        public static void SerializeBeds(List<Bed> beds)
        {
            string jsonString = JsonConvert.SerializeObject(beds, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("beds.json", jsonString, Encoding.UTF8);
        }

        public static async Task<List<Bed>> DeserializeBedsAsync()
        {
            List<Bed> beds;
            try
            {
                string jsonString = await Task.Run(() => File.ReadAllText("beds.json", Encoding.UTF8));
                #region Deserialization approach
                beds = await Task.Run(() => JsonConvert.DeserializeObject<List<Bed>>(jsonString));

                #endregion
                Events.OnPatientLoad.Invoke(true);
                return beds;
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
