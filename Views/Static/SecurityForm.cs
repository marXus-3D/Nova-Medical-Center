using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views.Static
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
        }
        public SecurityForm(string str): this()
        {
            
            label1.Text = str;
        }
    }
}
