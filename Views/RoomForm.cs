using Nova_Medical_Center.Data;
using Nova_Medical_Center.Models;
using Nova_Medical_Center.Views.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            Nova_Medical_Center.Scripts.Events.OnRoomLoad += LoadedRooms;
            InitializeComponent();
        }

        private void LoadedRooms(bool val)
        {
            MessageBox.Show("Loaded");
            if (val == true)
            {
                loadPanel.Visible = false;
                for (int i = 0; i < Data.Data.rooms.Count; i++)
                {
                    roomFlowPanel.Controls.Add(new RoomControl(Data.Data.rooms[i], ref i));
                }
            }
            else
                errorLabel.Visible = true;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            if(Data.Data.rooms == null)
                DataLoader.LoadRooms();
        }
    }
}
