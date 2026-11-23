using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Reflection;
using System.Web;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;

namespace KoKi_Remote
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            label_ProductNameValue.Text = Application.ProductName;
            label_VersionValue.Text = Application.ProductVersion;
            label_CompanyValue.Text = Application.CompanyName;
            label_DeveloperValue.Text = "Sebastian Lang";
            textBox_Description.Text = "Cinema system remote control application for multiple multimedia players, ESC/VP21 based projectors and OSC based PTZ cameras.\r\n\r\nCredits:\r\nSilk icon set by Mark James (famfamfam.com)";
            textBox_Description.SelectionStart = textBox_Description.Text.Length;
        }

        private void button_Contact_Click(object sender, EventArgs e)
        {
            const string eMail = "software@sebastianlang.net";
            Process.Start(new ProcessStartInfo($"mailto:{eMail}?subject={HttpUtility.UrlPathEncode(Application.ProductName)}")
            {
                UseShellExecute = true
            });
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}