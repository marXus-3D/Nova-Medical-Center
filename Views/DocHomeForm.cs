﻿using FontAwesome.Sharp;
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
    public partial class DocHomeForm : Form
    {
        IconButton current;
        public DocHomeForm()
        {
            InitializeComponent();
        }
        private void DoctorUpdateForm_Load(object sender, EventArgs e)
        {
            doctorGridView.DataSource = LoginPage.employees;
        }
    }
}
