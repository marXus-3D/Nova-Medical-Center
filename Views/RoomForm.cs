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

        private async void LoadedRooms(bool val)
        {
            if (val == true)
            {
                await Task.Run(() => {
                    Populate();
                });
                loadPanel.Visible = false;
            }
            else
                errorLabel.Visible = true;
        }

        void Populate() 
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            flowLayoutPanel.Name = "flowPanel";
            flowLayoutPanel.Size = new System.Drawing.Size(1022, 631);
            flowLayoutPanel.TabIndex = 0;

            for (int i = 0; i < Data.Data.rooms.Count; i++)
            {
                //this.Invoke(new MethodInvoker(delegate {
                //    roomFlowPanel.Controls.Add(new RoomControl(Data.Data.rooms[i], ref i));
                //}));
                Invoke(new Action(() =>
                {
                    roomFlowPanel.Controls.Add(new RoomControl(Data.Data.rooms[i]));//, ref i));
                }));
            }
        }

        private async void RoomForm_Load(object sender, EventArgs e)
        {
            if(Data.Data.rooms == null)
            {
                await DataLoader.LoadRooms();
                return;
            }

            LoadedRooms(true);
        }
    }
}
