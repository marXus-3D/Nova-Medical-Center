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
    public class Room
    {
        public int Id { get; set; }
        public string Ward { get; set; }
        public bool Occupied { get; set; }
        public string Type { get; set; }
        public List<Bed> Beds { get; set; }

        public static void SerializeRooms(List<Room> rooms)
        {
            string jsonString = JsonConvert.SerializeObject(rooms, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("rooms.json", jsonString, Encoding.UTF8);
        }

        public static async Task<List<Room>> DeserializeRoomsAsync()
        {
            List<Room> rooms;
            try
            {
                string jsonString = await Task.Run(() => File.ReadAllText("rooms.json", Encoding.UTF8));
                #region Deserialization approach
                rooms = await Task.Run(() => JsonConvert.DeserializeObject<List<Room>>(jsonString));

                #endregion

                return rooms;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                Events.OnRoomLoad.Invoke(false);
                return null;
            }
        }
    }
}
