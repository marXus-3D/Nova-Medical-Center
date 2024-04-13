using Nova_Medical_Center.Models;
using Nova_Medical_Center.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views.Static
{
    public partial class QuestionDialog : Form
    {
        int idx;
        public QuestionDialog(string content, string title, ref int idx)
        {
            InitializeComponent();
            bodyLbl.Text = content;
            titleLabel.Text = title;
            this.idx = idx;
        }

        private void btnCrit_Click(object sender, EventArgs e)
        {
            Data.Data.patients[idx].UrgencyLevel = Urgency.Critical;
            this.Close();
        }

        private void BtnNon_Click(object sender, EventArgs e)
        {
            Data.Data.patients[idx].UrgencyLevel = Urgency.NonCritical;
            this.Close();
        }

        private void BtnSemi_Click(object sender, EventArgs e)
        {
            Data.Data.patients[idx].UrgencyLevel = Urgency.SemiCritical;
            this.Close();
        }
    }
}