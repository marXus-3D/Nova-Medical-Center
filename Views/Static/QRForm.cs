using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Medical_Center.Views.Static
{
    public partial class QRForm : Form
    {
        public QRForm(ref int idx)
        {
            InitializeComponent();
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(MinifyJson(JsonConvert.SerializeObject(Data.Data.patients[idx])), QRCodeGenerator.ECCLevel.L);
            QRCode code = new QRCode(data);
            qrBox.Image = code.GetGraphic(10);
            qrBox.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string MinifyJson(string json)
        {
            // Regex patterns for whitespace and comments
            const string whitespacePattern = @"\s+";
            const string commentPattern = @"(?s://.*)|(?s:/\*.*?\*/)";

            // Replace whitespace and comments with empty string
            return Regex.Replace(Regex.Replace(json, whitespacePattern, ""), commentPattern, "", RegexOptions.Singleline);

        }
    }
}
