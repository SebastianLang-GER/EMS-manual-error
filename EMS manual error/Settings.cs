using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMSME
{
    public partial class Settings : Form
    {
        private const int HistoryLength = 5;
        private readonly Properties.Settings _settings = Properties.Settings.Default;
        private List<TreeNode> _treeNodesOverview = new();

        public Settings()
        {
            InitializeComponent();
            tabControlHideTabsSettings.ShowTabs = false;

            // Generate tree view nodes
            foreach (TabPage page in tabControlHideTabsSettings.TabPages)
            {
                TreeNode treeNode = new TreeNode(page.Text)
                {
                    Tag = page
                };
                FlowLayoutPanel? panel = page.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                if (panel != null)
                {
                    foreach (GroupBox groupBox in panel.Controls.OfType<GroupBox>())
                    {
                        treeNode.Nodes.Add(new TreeNode(groupBox.Text)
                        {
                            Tag = groupBox
                        });
                    }
                }
                _treeNodesOverview.Add(treeNode);
            }
            treeViewOverview.Nodes.Clear();
            foreach (TreeNode node in _treeNodesOverview)
            {
                treeViewOverview.Nodes.Add((TreeNode)node.Clone());
            }
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            AdjustSearchBoxWidth();
        }

        private void toolStripSearch_Resize(object sender, EventArgs e)
        {
            AdjustSearchBoxWidth();
        }

        private void AdjustSearchBoxWidth()
        {
            int availableWidth = toolStripSearch.ClientSize.Width;
            foreach (ToolStripItem item in toolStripSearch.Items)
            {
                if (item != toolStripComboBoxSearch)
                {
                    availableWidth -= item.Width;
                    availableWidth -= item.Margin.Horizontal;
                }
            }
            toolStripComboBoxSearch.Width = availableWidth - toolStripComboBoxSearch.Margin.Horizontal;
        }

        private void treeViewOverview_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Focus selected element
            if (e.Node?.Tag is TabPage page)
            {
                tabControlHideTabsSettings.SelectedTab = page;
                page.Focus();
            }
            else if (e.Node?.Tag is GroupBox groupBox)
            {
                TreeNode rootNode = e.Node;
                while (rootNode.Parent != null)
                {
                    rootNode = rootNode.Parent;
                }
                if (rootNode.Tag is TabPage parentPage)
                {
                    tabControlHideTabsSettings.SelectedTab = parentPage;
                }
                groupBox.Focus();
            }
        }

        private void toolStripComboBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void Search()
        {
            String searchText = toolStripComboBoxSearch.Text.Trim();
            if (searchText == string.Empty) return;

            toolStripSearch.UseWaitCursor = true;
            treeViewOverview.UseWaitCursor = true;
            treeViewOverview.BeginUpdate();

            if (toolStripComboBoxSearch.Items.IndexOf(searchText) < 0)
            {
                while (toolStripComboBoxSearch.Items.Count >= HistoryLength)
                {
                    toolStripComboBoxSearch.Items.RemoveAt(HistoryLength - 1);
                }
                toolStripComboBoxSearch.Items.Insert(0, searchText);
            }

            treeViewOverview.Nodes.Clear();
            foreach (TreeNode node in _treeNodesOverview)
            {
                TreeNode? filteredNode = FilterNode(node, searchText);
                if (filteredNode != null)
                {
                    treeViewOverview.Nodes.Add(filteredNode);
                }
            }

            treeViewOverview.ExpandAll();
            treeViewOverview.EndUpdate();
            treeViewOverview.UseWaitCursor = false;
            toolStripSearch.UseWaitCursor = false;
        }

        private TreeNode? FilterNode(TreeNode original, string searchText)
        {
            bool matches = original.Text.Contains(searchText, StringComparison.OrdinalIgnoreCase);

            TreeNode result = (TreeNode)original.Clone();

            result.Nodes.Clear();

            foreach (TreeNode child in original.Nodes)
            {
                TreeNode? filteredChild = FilterNode(child, searchText);

                if (filteredChild != null)
                {
                    result.Nodes.Add(filteredChild);
                }
            }

            if (matches || result.Nodes.Count > 0)
            {
                return result;
            }

            return null;
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            toolStripComboBoxSearch.Text = string.Empty;
            treeViewOverview.Nodes.Clear();
            foreach (TreeNode node in _treeNodesOverview)
            {
                treeViewOverview.Nodes.Add((TreeNode)node.Clone());
            }
        }

        private void toolStripSplitButtonSearch_ButtonClick(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripMenuItemDeleteHistory_Click(object sender, EventArgs e)
        {
            toolStripComboBoxSearch.Items.Clear();
            toolStripButtonClear.PerformClick();
        }

        private void toolStripComboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Default settings?", "Do you really want to restore default settings?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    _settings.Reset();
                    _settings.Reload();
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _settings.Save();
        }
    }
}
