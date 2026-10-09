using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EMSME
{
    public partial class Button : Form
    {
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HTCAPTION = 0x0002;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public Color ButtonColorDefault = Color.FromArgb(255, 66, 8);
        public Color ButtonColorFading = Color.FromArgb(72, 39, 175);
        private bool FadeDirection = false;

        public Button()
        {
            InitializeComponent();
            errorButton.BackColor = ButtonColorDefault;

            // Attach to events
            Program.PropertyChanged += Program_PropertyChanged;
        }

        private void Button_Shown(object sender, EventArgs e)
        {
            // Correct width
            Width = 100;
            
            // Set location
            Rectangle area = Screen.PrimaryScreen!.WorkingArea;
            Location = new Point(area.Right - Width, area.Bottom - Height);

            // Show window
            Opacity = 1;
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Detach from events
            Program.PropertyChanged -= Program_PropertyChanged;
            base.OnFormClosed(e);
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            // Handle form moving
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.SizeAll;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
                Cursor = Cursors.Default;
            }
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            // Set error state
            Program.Error = !Program.Error;
        }

        private void Program_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Program.Error))
            {
                // Enable animation
                animationTimer.Enabled = Program.Error;
                if (!animationTimer.Enabled)
                    errorButton.BackColor = ButtonColorDefault;
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (FadeDirection)
            {
                if (errorButton.BackColor == ButtonColorFading)
                {
                    FadeDirection = !FadeDirection;
                }
                else
                {
                    byte red = (byte)(errorButton.BackColor.R + (errorButton.BackColor.R == ButtonColorFading.R ? 0 : (errorButton.BackColor.R < ButtonColorFading.R ? 1 : -1)));
                    byte green = (byte)(errorButton.BackColor.G + (errorButton.BackColor.G == ButtonColorFading.G ? 0 : (errorButton.BackColor.G < ButtonColorFading.G ? 1 : -1)));
                    byte blue = (byte)(errorButton.BackColor.B + (errorButton.BackColor.B == ButtonColorFading.B ? 0 : (errorButton.BackColor.B < ButtonColorFading.B ? 1 : -1)));
                    errorButton.BackColor = Color.FromArgb(red, green, blue);
                }
            }
            else
            {
                if (errorButton.BackColor == ButtonColorDefault)
                {
                    FadeDirection = !FadeDirection;
                }
                else
                {
                    byte red = (byte)(errorButton.BackColor.R + (errorButton.BackColor.R == ButtonColorDefault.R ? 0 : (errorButton.BackColor.R < ButtonColorDefault.R ? 1 : -1)));
                    byte green = (byte)(errorButton.BackColor.G + (errorButton.BackColor.G == ButtonColorDefault.G ? 0 : (errorButton.BackColor.G < ButtonColorDefault.G ? 1 : -1)));
                    byte blue = (byte)(errorButton.BackColor.B + (errorButton.BackColor.B == ButtonColorDefault.B ? 0 : (errorButton.BackColor.B < ButtonColorDefault.B ? 1 : -1)));
                    errorButton.BackColor = Color.FromArgb(red, green, blue);
                }
            }
        }
    }
}
