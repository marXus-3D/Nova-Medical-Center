using Nova_Medical_Center.Data;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Scripts.Events.OnEmployeeLoad += (val) =>
            {
                doctorBar.Value = Data.Data.employees["Doctors"].Count;
                nurseBar.Value = Data.Data.employees["Nurses"].Count;
                receptionBar.Value = Data.Data.employees["Front Desks"].Count;

                receptionBar.Maximum = nurseBar.Maximum = doctorBar.Maximum = doctorBar.Value + nurseBar.Value + receptionBar.Value;
            };
            Scripts.Events.OnRoomLoad += (val) => 
            {
                Populate();
            };
        }

        private async void Populate()
        {
            roomBar.Maximum = Data.Data.rooms.Count;
            var val = await Task.Run(() => {
                int[][] arr = { new int[]{0,0}, new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0,0 } };
                foreach (var item in Data.Data.rooms) // literally the worst code i've ever written
                {
                    switch (item.Type) 
                    {
                        case "Normal":
                            ++arr[0][1];
                            if (item.Occupied)
                                ++arr[0][0];
                            break;
                        case "Surgery":
                            ++arr[1][1];
                            if (item.Occupied)
                                ++arr[1][0];
                            break;
                        case "VIP":
                            ++arr[2][1];
                            if (item.Occupied)
                                ++arr[2][0];
                            break;
                        case "Delivery":
                            ++arr[3][1];
                            if (item.Occupied)
                                ++arr[3][0];
                            break;
                        case "ICU":
                            ++arr[4][1];
                            if (item.Occupied)
                                ++arr[4][0];
                            break;
                    }
                    _= item.Occupied ? ++arr[5][0] : 0;
                }

                return arr;
            });

            //Disgusting
            normalBar.Value = val[0][0];
            normalBar.Maximum = val[0][1];
            normalBar.Text = normalBar.Maximum.ToString();
            surgeryBar.Value = val[1][0];
            surgeryBar.Maximum = val[1][1];
            surgeryBar.Text = surgeryBar.Maximum.ToString();
            vipBar.Value = val[2][0];
            vipBar.Maximum = val[2][1];
            vipBar.Text = vipBar.Maximum.ToString();
            deliveryBar.Value = val[3][0];
            deliveryBar.Maximum = val[3][1];
            deliveryBar.Text = deliveryBar.Maximum.ToString();
            icuBar.Value = val[4][0];
            icuBar.Maximum = val[4][1];
            icuBar.Text = icuBar.Maximum.ToString();

            roomBar.Value = val[5][0];
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            doctorBar.Value = nurseBar.Value = receptionBar.Value = roomBar.Value = normalBar.Value = icuBar.Value = surgeryBar.Value = deliveryBar.Value = vipBar.Value = 0;

            if (Data.Data.employees == null)
                DataLoader.LoadEmployees();
            else
            {
                doctorBar.Value = Data.Data.employees["Doctors"].Count;
            }
            if (Data.Data.rooms == null)
                await DataLoader.LoadRooms();
            else
                Populate();
        }
    }
}
