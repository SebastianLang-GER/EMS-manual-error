using Microsoft.VisualBasic.Logging;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Web;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;

namespace EMSME
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            productNameValueLable.Text = Application.ProductName;
            versionValueLabel.Text = Application.ProductVersion;
            developerValueLabel.Text = Properties.Settings.Default.Developer;
            descriptionTextBox.Text = Properties.Settings.Default.Description;
            descriptionTextBox.SelectionStart = descriptionTextBox.Text.Length;
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(Properties.Settings.Default.Website)
            {
                UseShellExecute = true
            });
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"mailto:{Properties.Settings.Default.Contact}?subject={HttpUtility.UrlPathEncode(Application.ProductName)}")
            {
                UseShellExecute = true
            });
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}