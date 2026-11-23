using EMSME.Properties;

namespace EMSME
{
    internal class TrayIconApp : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public TrayIconApp()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.Icon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items =
                    {
                        new ToolStripMenuItem("Show button", Resources.Open, Show_Click, "toolStripMenuItemOpen")
                        {
                            ShortcutKeys = Keys.Control | Keys.O,
                            Font = new Font(Control.DefaultFont,FontStyle.Bold),
                            DropDownItems =
                            {
                                new ToolStripMenuItem("Hide button", null, Hide_Click, "toolStripMenuItemHide")
                                {
                                    Font = Control.DefaultFont
                                },
                                new ToolStripSeparator(),
                                new ToolStripMenuItem("Always on top", null, TopMost_Click, "toolStripMenuItemTopMost")
                                {
                                    CheckOnClick = true,
                                    Font = Control.DefaultFont
                                }
                            }
                        },
                        new ToolStripSeparator(),
                        new ToolStripMenuItem("Settings", Resources.Settings, Settings_Click, "toolStripMenuItemSettings"),
                        new ToolStripMenuItem("About", Resources.About, About_Click, "toolStripMenuItemAbout"),
                        new ToolStripSeparator(),
                        new ToolStripMenuItem("Exit", Resources.Exit, Exit_Click, "toolStripMenuItemExit")
                        {
                            ShortcutKeys = Keys.Alt | Keys.F4
                        }
                    }
                },
                Visible = true
            };

            trayIcon.MouseClick += TrayIcon_MouseClick;
            trayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            trayIcon.ContextMenuStrip.Opening += ContextMenuStrip_Opening;
        }

        private void ContextMenuStrip_Opening(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            Button? button = Application.OpenForms.OfType<Button>().FirstOrDefault();
            if (button != null)
            {
                ToolStripMenuItem? toolStripMenuItemOpen = (ToolStripMenuItem?)trayIcon.ContextMenuStrip!.Items["toolStripMenuItemOpen"];
                if (toolStripMenuItemOpen != null)
                {
                    // Enable drop down items
                    foreach (var item in toolStripMenuItemOpen.DropDownItems)
                    {
                        if (item is ToolStripMenuItem toolStripMenuItemOpenChild)
                        {
                            toolStripMenuItemOpenChild.Enabled = true;
                        }
                    }
                    // Sync top most property
                    ToolStripMenuItem? toolStripMenuItemTopMost = (ToolStripMenuItem?)toolStripMenuItemOpen.DropDownItems["toolStripMenuItemTopMost"];
                    if (toolStripMenuItemTopMost != null)
                    {
                        toolStripMenuItemTopMost.Checked = button.TopMost;
                    }
                }
            }
            else
            {
                ToolStripMenuItem? toolStripMenuItemOpen = (ToolStripMenuItem?)trayIcon.ContextMenuStrip!.Items["toolStripMenuItemOpen"];
                if (toolStripMenuItemOpen != null)
                {
                    // Disable drop down items
                    foreach (var item in toolStripMenuItemOpen.DropDownItems)
                    {
                        if (item is ToolStripMenuItem toolStripMenuItemOpenChild)
                        {
                            toolStripMenuItemOpenChild.Enabled = false;
                        }
                    }
                }
            }
        }

        private void Show_Click(object? sender, EventArgs e)
        {
            Button? button = Application.OpenForms.OfType<Button>().FirstOrDefault();
            if (button != null)
            {
                button.Activate();
                button.Focus();
            }
            else
            {
                new Button().ShowAsync();
            }
        }

        private void Hide_Click(object? sender, EventArgs e)
        {
            Button? button = Application.OpenForms.OfType<Button>().FirstOrDefault();
            if (button != null)
            {
                button.Close();
            }
        }

        private void TopMost_Click(object? sender, EventArgs e)
        {
            ToolStripMenuItem? toolStripMenuItemTopMost = (ToolStripMenuItem)sender!;
            Button? button = Application.OpenForms.OfType<Button>().FirstOrDefault();
            if (button != null && toolStripMenuItemTopMost != null)
            {
                button.TopMost = toolStripMenuItemTopMost.Checked;
            }
        }

        private void About_Click(object? sender, EventArgs e)
        {
            new About().ShowDialogAsync();
        }

        private void Settings_Click(object? sender, EventArgs e)
        {
            new Settings().ShowDialogAsync();
        }

        private void Exit_Click(object? sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void TrayIcon_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.Clicks == 1)
            {
                trayIcon.ContextMenuStrip?.Show(e.Location);
            }
        }

        private void TrayIcon_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            Show_Click(sender, e);
        }
    }
}