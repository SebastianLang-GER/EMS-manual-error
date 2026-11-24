using EMSME.Controls;

namespace EMSME
{
    partial class Settings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            TreeNode treeNode1 = new TreeNode("Autostart");
            TreeNode treeNode2 = new TreeNode("General", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Server");
            tabPageGeneralSettings = new TabPage();
            flowLayoutPanelGeneral = new FlowLayoutPanel();
            labelGeneral = new Label();
            groupBoxAutostart = new GroupBox();
            groupBox1 = new GroupBox();
            tabPageServerSettings = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelServer = new Label();
            groupBoxPort = new GroupBox();
            groupBox5 = new GroupBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonDefault = new System.Windows.Forms.Button();
            treeViewOverview = new TreeView();
            splitContainerSettings = new SplitContainer();
            toolStripSearch = new ToolStrip();
            toolStripSplitButtonSearch = new ToolStripSplitButton();
            toolStripMenuItemDeleteHistory = new ToolStripMenuItem();
            toolStripButtonClear = new ToolStripButton();
            toolStripComboBoxSearch = new ToolStripComboBox();
            tabControlHideTabsSettings = new TabControlHideTabs();
            tabPageButtonSettings = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelButton = new Label();
            groupBoxPosition = new GroupBox();
            groupBox3 = new GroupBox();
            tabPageGeneralSettings.SuspendLayout();
            flowLayoutPanelGeneral.SuspendLayout();
            tabPageServerSettings.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerSettings).BeginInit();
            splitContainerSettings.Panel1.SuspendLayout();
            splitContainerSettings.Panel2.SuspendLayout();
            splitContainerSettings.SuspendLayout();
            toolStripSearch.SuspendLayout();
            tabControlHideTabsSettings.SuspendLayout();
            tabPageButtonSettings.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageGeneralSettings
            // 
            tabPageGeneralSettings.AutoScroll = true;
            tabPageGeneralSettings.Controls.Add(flowLayoutPanelGeneral);
            tabPageGeneralSettings.Location = new Point(4, 24);
            tabPageGeneralSettings.Name = "tabPageGeneralSettings";
            tabPageGeneralSettings.Padding = new Padding(3);
            tabPageGeneralSettings.Size = new Size(391, 342);
            tabPageGeneralSettings.TabIndex = 0;
            tabPageGeneralSettings.Text = "General";
            tabPageGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelGeneral
            // 
            flowLayoutPanelGeneral.Controls.Add(labelGeneral);
            flowLayoutPanelGeneral.Controls.Add(groupBoxAutostart);
            flowLayoutPanelGeneral.Controls.Add(groupBox1);
            flowLayoutPanelGeneral.Dock = DockStyle.Fill;
            flowLayoutPanelGeneral.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelGeneral.Location = new Point(3, 3);
            flowLayoutPanelGeneral.Name = "flowLayoutPanelGeneral";
            flowLayoutPanelGeneral.Size = new Size(385, 336);
            flowLayoutPanelGeneral.TabIndex = 1;
            flowLayoutPanelGeneral.WrapContents = false;
            // 
            // labelGeneral
            // 
            labelGeneral.AutoSize = true;
            labelGeneral.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGeneral.Location = new Point(3, 3);
            labelGeneral.Margin = new Padding(3);
            labelGeneral.Name = "labelGeneral";
            labelGeneral.Size = new Size(66, 21);
            labelGeneral.TabIndex = 0;
            labelGeneral.Tag = "headline";
            labelGeneral.Text = "General";
            // 
            // groupBoxAutostart
            // 
            groupBoxAutostart.Location = new Point(3, 30);
            groupBoxAutostart.Name = "groupBoxAutostart";
            groupBoxAutostart.Size = new Size(379, 100);
            groupBoxAutostart.TabIndex = 1;
            groupBoxAutostart.TabStop = false;
            groupBoxAutostart.Text = "Autostart";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Test";
            // 
            // tabPageServerSettings
            // 
            tabPageServerSettings.Controls.Add(flowLayoutPanel2);
            tabPageServerSettings.Location = new Point(4, 24);
            tabPageServerSettings.Name = "tabPageServerSettings";
            tabPageServerSettings.Padding = new Padding(3);
            tabPageServerSettings.Size = new Size(391, 342);
            tabPageServerSettings.TabIndex = 1;
            tabPageServerSettings.Text = "Server";
            tabPageServerSettings.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(labelServer);
            flowLayoutPanel2.Controls.Add(groupBoxPort);
            flowLayoutPanel2.Controls.Add(groupBox5);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(385, 336);
            flowLayoutPanel2.TabIndex = 2;
            flowLayoutPanel2.WrapContents = false;
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServer.Location = new Point(3, 3);
            labelServer.Margin = new Padding(3);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(58, 21);
            labelServer.TabIndex = 0;
            labelServer.Tag = "headline";
            labelServer.Text = "Server";
            // 
            // groupBoxPort
            // 
            groupBoxPort.Location = new Point(3, 30);
            groupBoxPort.Name = "groupBoxPort";
            groupBoxPort.Size = new Size(379, 100);
            groupBoxPort.TabIndex = 1;
            groupBoxPort.TabStop = false;
            groupBoxPort.Text = "Port";
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(3, 136);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(379, 100);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Test";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleRight;
            buttonSave.Location = new Point(497, 376);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDefault
            // 
            buttonDefault.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDefault.Image = (Image)resources.GetObject("buttonDefault.Image");
            buttonDefault.ImageAlign = ContentAlignment.MiddleRight;
            buttonDefault.Location = new Point(12, 376);
            buttonDefault.Name = "buttonDefault";
            buttonDefault.Size = new Size(75, 23);
            buttonDefault.TabIndex = 2;
            buttonDefault.Text = "Default";
            buttonDefault.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDefault.UseVisualStyleBackColor = true;
            buttonDefault.Click += buttonDefault_Click;
            // 
            // treeViewOverview
            // 
            treeViewOverview.Dock = DockStyle.Fill;
            treeViewOverview.Location = new Point(0, 25);
            treeViewOverview.Name = "treeViewOverview";
            treeNode1.Name = "KnotAutostart";
            treeNode1.Text = "Autostart";
            treeNode2.Name = "KnotGeneral";
            treeNode2.Text = "General";
            treeNode3.Name = "KnotServer";
            treeNode3.Text = "Server";
            treeViewOverview.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode3 });
            treeViewOverview.Size = new Size(181, 345);
            treeViewOverview.TabIndex = 2;
            treeViewOverview.NodeMouseClick += treeViewOverview_NodeMouseClick;
            // 
            // splitContainerSettings
            // 
            splitContainerSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainerSettings.Location = new Point(0, 0);
            splitContainerSettings.Name = "splitContainerSettings";
            // 
            // splitContainerSettings.Panel1
            // 
            splitContainerSettings.Panel1.Controls.Add(treeViewOverview);
            splitContainerSettings.Panel1.Controls.Add(toolStripSearch);
            splitContainerSettings.Panel1MinSize = 150;
            // 
            // splitContainerSettings.Panel2
            // 
            splitContainerSettings.Panel2.Controls.Add(tabControlHideTabsSettings);
            splitContainerSettings.Panel2MinSize = 200;
            splitContainerSettings.Size = new Size(584, 370);
            splitContainerSettings.SplitterDistance = 181;
            splitContainerSettings.TabIndex = 3;
            // 
            // toolStripSearch
            // 
            toolStripSearch.AllowMerge = false;
            toolStripSearch.CanOverflow = false;
            toolStripSearch.GripMargin = new Padding(0);
            toolStripSearch.GripStyle = ToolStripGripStyle.Hidden;
            toolStripSearch.Items.AddRange(new ToolStripItem[] { toolStripSplitButtonSearch, toolStripButtonClear, toolStripComboBoxSearch });
            toolStripSearch.Location = new Point(0, 0);
            toolStripSearch.Name = "toolStripSearch";
            toolStripSearch.Size = new Size(181, 25);
            toolStripSearch.Stretch = true;
            toolStripSearch.TabIndex = 3;
            toolStripSearch.Text = "Search";
            toolStripSearch.Resize += toolStripSearch_Resize;
            // 
            // toolStripSplitButtonSearch
            // 
            toolStripSplitButtonSearch.Alignment = ToolStripItemAlignment.Right;
            toolStripSplitButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButtonSearch.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemDeleteHistory });
            toolStripSplitButtonSearch.Image = (Image)resources.GetObject("toolStripSplitButtonSearch.Image");
            toolStripSplitButtonSearch.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonSearch.Name = "toolStripSplitButtonSearch";
            toolStripSplitButtonSearch.Overflow = ToolStripItemOverflow.Never;
            toolStripSplitButtonSearch.Size = new Size(32, 22);
            toolStripSplitButtonSearch.Text = "Search";
            toolStripSplitButtonSearch.ToolTipText = "Search";
            toolStripSplitButtonSearch.ButtonClick += toolStripSplitButtonSearch_ButtonClick;
            // 
            // toolStripMenuItemDeleteHistory
            // 
            toolStripMenuItemDeleteHistory.Image = (Image)resources.GetObject("toolStripMenuItemDeleteHistory.Image");
            toolStripMenuItemDeleteHistory.Name = "toolStripMenuItemDeleteHistory";
            toolStripMenuItemDeleteHistory.Size = new Size(146, 22);
            toolStripMenuItemDeleteHistory.Text = "Delete history";
            toolStripMenuItemDeleteHistory.Click += toolStripMenuItemDeleteHistory_Click;
            // 
            // toolStripButtonClear
            // 
            toolStripButtonClear.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClear.Image = (Image)resources.GetObject("toolStripButtonClear.Image");
            toolStripButtonClear.ImageTransparentColor = Color.Magenta;
            toolStripButtonClear.Name = "toolStripButtonClear";
            toolStripButtonClear.Overflow = ToolStripItemOverflow.Never;
            toolStripButtonClear.Size = new Size(23, 22);
            toolStripButtonClear.Text = "Clear";
            toolStripButtonClear.ToolTipText = "Clear search box";
            toolStripButtonClear.Click += toolStripButtonClear_Click;
            // 
            // toolStripComboBoxSearch
            // 
            toolStripComboBoxSearch.AutoSize = false;
            toolStripComboBoxSearch.Name = "toolStripComboBoxSearch";
            toolStripComboBoxSearch.Overflow = ToolStripItemOverflow.Never;
            toolStripComboBoxSearch.Size = new Size(93, 25);
            toolStripComboBoxSearch.ToolTipText = "Search filter";
            toolStripComboBoxSearch.SelectedIndexChanged += toolStripComboBoxSearch_SelectedIndexChanged;
            toolStripComboBoxSearch.KeyDown += toolStripComboBoxSearch_KeyDown;
            // 
            // tabControlHideTabsSettings
            // 
            tabControlHideTabsSettings.Controls.Add(tabPageGeneralSettings);
            tabControlHideTabsSettings.Controls.Add(tabPageButtonSettings);
            tabControlHideTabsSettings.Controls.Add(tabPageServerSettings);
            tabControlHideTabsSettings.Dock = DockStyle.Fill;
            tabControlHideTabsSettings.Location = new Point(0, 0);
            tabControlHideTabsSettings.Name = "tabControlHideTabsSettings";
            tabControlHideTabsSettings.SelectedIndex = 0;
            tabControlHideTabsSettings.Size = new Size(399, 370);
            tabControlHideTabsSettings.TabIndex = 0;
            // 
            // tabPageButtonSettings
            // 
            tabPageButtonSettings.Controls.Add(flowLayoutPanel1);
            tabPageButtonSettings.Location = new Point(4, 24);
            tabPageButtonSettings.Name = "tabPageButtonSettings";
            tabPageButtonSettings.Padding = new Padding(3);
            tabPageButtonSettings.Size = new Size(391, 342);
            tabPageButtonSettings.TabIndex = 2;
            tabPageButtonSettings.Text = "Button";
            tabPageButtonSettings.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelButton);
            flowLayoutPanel1.Controls.Add(groupBoxPosition);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(385, 336);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // labelButton
            // 
            labelButton.AutoSize = true;
            labelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelButton.Location = new Point(3, 3);
            labelButton.Margin = new Padding(3);
            labelButton.Name = "labelButton";
            labelButton.Size = new Size(60, 21);
            labelButton.TabIndex = 0;
            labelButton.Tag = "headline";
            labelButton.Text = "Button";
            // 
            // groupBoxPosition
            // 
            groupBoxPosition.Location = new Point(3, 30);
            groupBoxPosition.Name = "groupBoxPosition";
            groupBoxPosition.Size = new Size(379, 100);
            groupBoxPosition.TabIndex = 1;
            groupBoxPosition.TabStop = false;
            groupBoxPosition.Text = "Position";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(3, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(379, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Test";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 411);
            Controls.Add(buttonSave);
            Controls.Add(splitContainerSettings);
            Controls.Add(buttonDefault);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(370, 200);
            Name = "Settings";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Shown += Settings_Shown;
            tabPageGeneralSettings.ResumeLayout(false);
            flowLayoutPanelGeneral.ResumeLayout(false);
            flowLayoutPanelGeneral.PerformLayout();
            tabPageServerSettings.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            splitContainerSettings.Panel1.ResumeLayout(false);
            splitContainerSettings.Panel1.PerformLayout();
            splitContainerSettings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerSettings).EndInit();
            splitContainerSettings.ResumeLayout(false);
            toolStripSearch.ResumeLayout(false);
            toolStripSearch.PerformLayout();
            tabControlHideTabsSettings.ResumeLayout(false);
            tabPageButtonSettings.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControlHideTabs tabControlHideTabsSettings;
        private TabPage tabPageGeneralSettings;
        private TabPage tabPageServerSettings;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDefault;
        private TreeView treeViewOverview;
        private SplitContainer splitContainerSettings;
        private ToolStrip toolStripSearch;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButtonClear;
        private ToolStripSplitButton toolStripSplitButtonSearch;
        private ToolStripMenuItem toolStripMenuItemDeleteHistory;
        private ToolStripComboBox toolStripComboBoxSearch;
        private Label labelGeneral;
        private FlowLayoutPanel flowLayoutPanelGeneral;
        private GroupBox groupBoxAutostart;
        private GroupBox groupBox1;
        private TabPage tabPageButtonSettings;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label labelServer;
        private GroupBox groupBoxPort;
        private GroupBox groupBox5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelButton;
        private GroupBox groupBoxPosition;
        private GroupBox groupBox3;
    }
}
