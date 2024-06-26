﻿using Nova_Medical_Center.Scripts;
using Nova_Medical_Center.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Events.OnDischarge += CentralControler.RoomUpdate;
            Events.OnChange += CentralControler.SaveChanges;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
    }
}
