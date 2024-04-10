﻿using Nova_Medical_Center.Models;
using Nova_Medical_Center.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views.Controls
{
    public partial class RoomControl : UserControl
    {
        private int idx;
        public RoomControl(Room room, ref int a)
        {
            this.idx = a;
            InitializeComponent();
            bedLbl.Text +=" " + room.Beds.Count;
            typeLbl.Text += " " + room.Type;
            numberLbl.Text += " " + room.Id;
            imageBox.Image = Resources.istockphoto_1415401589_612x612;
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Data.Data.rooms[idx].Beds.Add(new Bed()
            {
                Id = Data.Data.rooms[idx].Id + Data.Data.rooms[idx].Beds.Count,
                Available = true,
            });
        }
    }
}
