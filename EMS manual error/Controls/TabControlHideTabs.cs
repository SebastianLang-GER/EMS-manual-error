using System.ComponentModel;

namespace EMSME.Controls
{
    public partial class TabControlHideTabs : TabControl
    {
        private bool _showTabs = true;

        [Category("Appearance")]
        [Description("Determines whether the tab headers are displayed.")]
        [DefaultValue(true)]
        public bool ShowTabs
        {
            get => _showTabs;
            set
            {
                if (_showTabs != value)
                {
                    _showTabs = value;
                    RecreateHandle();
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int TCM_ADJUSTRECT = 0x1328; // TCM_ADJUSTRECT

            if (!_showTabs && m.Msg == TCM_ADJUSTRECT)
            {
                m.Result = (IntPtr)1;
                return;
            }

            base.WndProc(ref m);
        }
    }
}