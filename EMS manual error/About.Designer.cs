namespace EMSME
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            iconPictureBox = new PictureBox();
            tableLayoutPanelAbout = new TableLayoutPanel();
            developerValueLabel = new Label();
            versionValueLabel = new Label();
            productNameValueLable = new Label();
            developerLabel = new Label();
            versionLabel = new Label();
            productNameLabel = new Label();
            contactButton = new System.Windows.Forms.Button();
            closeButton = new System.Windows.Forms.Button();
            websiteButton = new System.Windows.Forms.Button();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            tableLayoutPanelAbout.SuspendLayout();
            SuspendLayout();
            // 
            // iconPictureBox
            // 
            iconPictureBox.Image = (Image)resources.GetObject("iconPictureBox.Image");
            iconPictureBox.Location = new Point(12, 12);
            iconPictureBox.Name = "iconPictureBox";
            iconPictureBox.Size = new Size(80, 80);
            iconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox.TabIndex = 0;
            iconPictureBox.TabStop = false;
            // 
            // tableLayoutPanelAbout
            // 
            tableLayoutPanelAbout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAbout.ColumnCount = 2;
            tableLayoutPanelAbout.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAbout.Controls.Add(developerValueLabel, 1, 2);
            tableLayoutPanelAbout.Controls.Add(versionValueLabel, 1, 1);
            tableLayoutPanelAbout.Controls.Add(productNameValueLable, 1, 0);
            tableLayoutPanelAbout.Controls.Add(descriptionLabel, 0, 3);
            tableLayoutPanelAbout.Controls.Add(developerLabel, 0, 2);
            tableLayoutPanelAbout.Controls.Add(versionLabel, 0, 1);
            tableLayoutPanelAbout.Controls.Add(productNameLabel, 0, 0);
            tableLayoutPanelAbout.Controls.Add(descriptionTextBox, 1, 3);
            tableLayoutPanelAbout.Location = new Point(98, 12);
            tableLayoutPanelAbout.Name = "tableLayoutPanelAbout";
            tableLayoutPanelAbout.RowCount = 4;
            tableLayoutPanelAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelAbout.Size = new Size(374, 253);
            tableLayoutPanelAbout.TabIndex = 1;
            // 
            // developerValueLabel
            // 
            developerValueLabel.AutoSize = true;
            developerValueLabel.Dock = DockStyle.Fill;
            developerValueLabel.Font = new Font("Segoe UI", 9F);
            developerValueLabel.Location = new Point(94, 40);
            developerValueLabel.Name = "developerValueLabel";
            developerValueLabel.Size = new Size(277, 20);
            developerValueLabel.TabIndex = 7;
            developerValueLabel.Text = "Developer";
            // 
            // versionValueLabel
            // 
            versionValueLabel.AutoSize = true;
            versionValueLabel.Dock = DockStyle.Fill;
            versionValueLabel.Font = new Font("Segoe UI", 9F);
            versionValueLabel.Location = new Point(94, 20);
            versionValueLabel.Name = "versionValueLabel";
            versionValueLabel.Size = new Size(277, 20);
            versionValueLabel.TabIndex = 6;
            versionValueLabel.Text = "Version";
            // 
            // productNameValueLable
            // 
            productNameValueLable.AutoSize = true;
            productNameValueLable.Dock = DockStyle.Fill;
            productNameValueLable.Font = new Font("Segoe UI", 9F);
            productNameValueLable.Location = new Point(94, 0);
            productNameValueLable.Name = "productNameValueLable";
            productNameValueLable.Size = new Size(277, 20);
            productNameValueLable.TabIndex = 5;
            productNameValueLable.Text = "Product Name";
            // 
            // developerLabel
            // 
            developerLabel.AutoSize = true;
            developerLabel.Dock = DockStyle.Fill;
            developerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            developerLabel.Location = new Point(3, 40);
            developerLabel.Name = "developerLabel";
            developerLabel.Size = new Size(85, 20);
            developerLabel.TabIndex = 2;
            developerLabel.Text = "Developer:";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Dock = DockStyle.Fill;
            versionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            versionLabel.Location = new Point(3, 20);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(85, 20);
            versionLabel.TabIndex = 1;
            versionLabel.Text = "Version:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Dock = DockStyle.Fill;
            productNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            productNameLabel.Location = new Point(3, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(85, 20);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Product Name:";
            // 
            // contactButton
            // 
            contactButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            contactButton.Location = new Point(98, 271);
            contactButton.Name = "contactButton";
            contactButton.Size = new Size(80, 28);
            contactButton.TabIndex = 3;
            contactButton.Text = "Contact";
            contactButton.Click += contactButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.DialogResult = DialogResult.OK;
            closeButton.Location = new Point(392, 271);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(80, 28);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.Click += closeButton_Click;
            // 
            // websiteButton
            // 
            websiteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            websiteButton.Location = new Point(12, 271);
            websiteButton.Name = "websiteButton";
            websiteButton.Size = new Size(80, 28);
            websiteButton.TabIndex = 2;
            websiteButton.Text = "Website";
            websiteButton.Click += websiteButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Location = new Point(94, 63);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Description";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(277, 187);
            descriptionTextBox.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = DockStyle.Fill;
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            descriptionLabel.Location = new Point(3, 60);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 193);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // About
            // 
            AcceptButton = closeButton;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = closeButton;
            ClientSize = new Size(484, 311);
            Controls.Add(websiteButton);
            Controls.Add(closeButton);
            Controls.Add(contactButton);
            Controls.Add(tableLayoutPanelAbout);
            Controls.Add(iconPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            tableLayoutPanelAbout.ResumeLayout(false);
            tableLayoutPanelAbout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconPictureBox;
        private TableLayoutPanel tableLayoutPanelAbout;
        private System.Windows.Forms.Button websiteButton;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button closeButton;
        private Label versionLabel;
        private Label productNameLabel;
        private Label developerLabel;
        private Label developerValueLabel;
        private Label versionValueLabel;
        private Label productNameValueLable;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
    }
}