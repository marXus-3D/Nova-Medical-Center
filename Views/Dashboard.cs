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

                receptionBar.Value = nurseBar.Maximum = doctorBar.Maximum = doctorBar.Value + nurseBar.Value + receptionBar.Value;
            };
            Scripts.Events.OnRoomLoad += (val) => 
            {
                Populate();
            };
        }

        private async void Populate()
        {
            roomBar.Maximum = Data.Data.rooms.Count;
            roomBar.Value = Data.Data.rooms.Where(r => r.Occupied).Count();
            var val = await Task.Run(() => {
                int[][] arr = { new int[]{0,0}, new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0, 0 } };
                foreach (var item in Data.Data.rooms) // literally the worst code i've ever written
                {
                    if (item.Type.Equals("Normal"))
                    {
                        ++arr[0][1];
                        if (item.Occupied)
                            ++arr[0][0];
                    }
                    else if (item.Type.Equals("Surgery"))
                    {
                        ++arr[1][1];
                        if (item.Occupied)
                            ++arr[1][0];
                    }
                    else if (item.Type.Equals("VIP"))
                    {
                        ++arr[2][1];
                        if (item.Occupied)
                            ++arr[2][0];
                    }
                    else if (item.Type.Equals("Delivery"))
                    {
                        ++arr[3][1];
                        if (item.Occupied)
                            ++arr[3][0];
                    }
                    else if (item.Type.Equals("ICU"))
                    { 
                        ++arr[4][1];
                        if (item.Occupied)
                            ++arr[4][0];
                    }
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
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
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
