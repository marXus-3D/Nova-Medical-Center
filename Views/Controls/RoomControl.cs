using Nova_Medical_Center.Models;
using Nova_Medical_Center.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views.Controls
{
    public partial class RoomControl : UserControl
    {
        public RoomControl(Room room)
        {
            InitializeComponent();
            //bedLbl.Text +=" " + room.Beds.Count;
            typeLbl.Text += " " + room.Type;
            numberLbl.Text += " " + room.Id;
            checkBox.Checked = room.Occupied;
            imageBox.Image = Resources.istockphoto_1415401589_612x612;
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            //Data.Data.rooms[idx].Beds.Add(new Bed()
            //{
            //    Id = Data.Data.rooms[idx].Id + Data.Data.rooms[idx].Beds.Count,
            //    Available = true,
            //});
        }
    }
}
