﻿using FontAwesome.Sharp;
using Nova_Medical_Center.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center
{
    public partial class HomePage : Form
    {
        bool settingExpanded = false, employeeExpanded = false, sideBarExpanded = true;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public HomePage()
        {
            InitializeComponent();
            ActivateButton(dashboardBtn, RGBColors.color1);
            OpenChildForm(new Dashboard());
        }

        private void hamBurgerMenu_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Drag Event
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (!sideBarExpanded)
            {
                sideBar.Width += 15;
                if (sideBar.Width >= 235)
                {
                    sideBarTransition.Stop();
                    sideBarExpanded = true;
                }
            }
            else
            {
                sideBar.Width -= 15;
                if (sideBar.Width <= 55)
                {
                    sideBarTransition.Stop();
                    sideBarExpanded = false;
                }
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //if (employeeExpanded)
                //    employeeTransition.Start();
                //else if(settingExpanded)
                //    settingTransition.Start();
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(32, 33, 36);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //Left border btn // Todo Turn to panel
                /* leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y + 1);
                leftBorderBtn.Visible = true; 
                leftBorderBtn.BringToFront(); */

                //Icon Current Child Form
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(23, 24, 29);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(241, 23, 18);
            public static Color color8 = Color.FromArgb(0, 210, 255);
        }

        #region Click Events
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Dashboard());
        }
        private void patientsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new PatientForm());
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new RoomForm());
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            employeeTransition.Start();
        }

        private void doctorButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new DoctorForm());
        }

        private void nurseButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new NurseForm());
        }

        private void deskBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FrontDeskForm());
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            settingTransition.Start();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new AboutForm());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Data.Data.currentUser = null;
            Scripts.Events.OnChange?.Invoke();
            this.Close();
            LoginPage.LogOut?.Invoke();
        }

        private void settingTransition_Tick(object sender, EventArgs e)
        {
            if (!settingExpanded)
            {
                settingPanel.Height += 10;
                if (settingPanel.Height >= 180)
                {
                    settingTransition.Stop();
                    settingExpanded = true;
                }
            }
            else
            {
                settingPanel.Height -= 10;
                if (settingPanel.Height <= 60)
                {
                    settingTransition.Stop();
                    settingExpanded = false;
                }
            }
        }

        private void employeeTransition_Tick(object sender, EventArgs e)
        {
            if (!employeeExpanded)
            {
                employeePanel.Height += 10;
                if (employeePanel.Height >= 250)
                {
                    employeeTransition.Stop();
                    employeeExpanded = true;
                }
            }
            else
            {
                employeePanel.Height -= 10;
                if (employeePanel.Height <= 60)
                {
                    employeeTransition.Stop();
                    employeeExpanded = false;
                }
            }
        }

        #endregion
    }
}
