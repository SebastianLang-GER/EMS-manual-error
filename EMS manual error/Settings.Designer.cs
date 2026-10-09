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
            tabControlSettings = new TabControl();
            tabPageGeneralSettings = new TabPage();
            tabPageServerSettings = new TabPage();
            tabControlSettings.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlSettings
            // 
            tabControlSettings.Controls.Add(tabPageGeneralSettings);
            tabControlSettings.Controls.Add(tabPageServerSettings);
            tabControlSettings.Dock = DockStyle.Fill;
            tabControlSettings.Location = new Point(0, 0);
            tabControlSettings.Name = "tabControlSettings";
            tabControlSettings.SelectedIndex = 0;
            tabControlSettings.Size = new Size(800, 450);
            tabControlSettings.TabIndex = 0;
            // 
            // tabPageGeneralSettings
            // 
            tabPageGeneralSettings.Location = new Point(4, 24);
            tabPageGeneralSettings.Name = "tabPageGeneralSettings";
            tabPageGeneralSettings.Padding = new Padding(3);
            tabPageGeneralSettings.Size = new Size(792, 422);
            tabPageGeneralSettings.TabIndex = 0;
            tabPageGeneralSettings.Text = "General";
            tabPageGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageServerSettings
            // 
            tabPageServerSettings.Location = new Point(4, 24);
            tabPageServerSettings.Name = "tabPageServerSettings";
            tabPageServerSettings.Padding = new Padding(3);
            tabPageServerSettings.Size = new Size(792, 422);
            tabPageServerSettings.TabIndex = 1;
            tabPageServerSettings.Text = "Server";
            tabPageServerSettings.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlSettings);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            tabControlSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlSettings;
        private TabPage tabPageGeneralSettings;
        private TabPage tabPageServerSettings;
    }
}
