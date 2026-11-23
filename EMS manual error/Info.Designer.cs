namespace KoKi_Remote
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            pictureBox_Icon = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_CompanyValue = new Label();
            label_Company = new Label();
            label_DeveloperValue = new Label();
            label_VersionValue = new Label();
            label_ProductNameValue = new Label();
            label_Description = new Label();
            label_Developer = new Label();
            label_Version = new Label();
            label_ProductName = new Label();
            textBox_Description = new TextBox();
            button_Contact = new Button();
            button_Close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Icon).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_Icon
            // 
            pictureBox_Icon.Image = (Image)resources.GetObject("pictureBox_Icon.Image");
            pictureBox_Icon.Location = new Point(12, 12);
            pictureBox_Icon.Name = "pictureBox_Icon";
            pictureBox_Icon.Size = new Size(80, 80);
            pictureBox_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Icon.TabIndex = 0;
            pictureBox_Icon.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label_CompanyValue, 1, 2);
            tableLayoutPanel1.Controls.Add(label_Company, 0, 2);
            tableLayoutPanel1.Controls.Add(label_DeveloperValue, 1, 3);
            tableLayoutPanel1.Controls.Add(label_VersionValue, 1, 1);
            tableLayoutPanel1.Controls.Add(label_ProductNameValue, 1, 0);
            tableLayoutPanel1.Controls.Add(label_Description, 0, 4);
            tableLayoutPanel1.Controls.Add(label_Developer, 0, 3);
            tableLayoutPanel1.Controls.Add(label_Version, 0, 1);
            tableLayoutPanel1.Controls.Add(label_ProductName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_Description, 1, 4);
            tableLayoutPanel1.Location = new Point(98, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(374, 253);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label_CompanyValue
            // 
            label_CompanyValue.AutoSize = true;
            label_CompanyValue.Dock = DockStyle.Fill;
            label_CompanyValue.Font = new Font("Segoe UI", 9F);
            label_CompanyValue.Location = new Point(94, 40);
            label_CompanyValue.Name = "label_CompanyValue";
            label_CompanyValue.Size = new Size(277, 20);
            label_CompanyValue.TabIndex = 11;
            label_CompanyValue.Text = "Company";
            // 
            // label_Company
            // 
            label_Company.AutoSize = true;
            label_Company.Dock = DockStyle.Fill;
            label_Company.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label_Company.Location = new Point(3, 40);
            label_Company.Name = "label_Company";
            label_Company.Size = new Size(85, 20);
            label_Company.TabIndex = 10;
            label_Company.Text = "Company:";
            // 
            // label_DeveloperValue
            // 
            label_DeveloperValue.AutoSize = true;
            label_DeveloperValue.Dock = DockStyle.Fill;
            label_DeveloperValue.Font = new Font("Segoe UI", 9F);
            label_DeveloperValue.Location = new Point(94, 60);
            label_DeveloperValue.Name = "label_DeveloperValue";
            label_DeveloperValue.Size = new Size(277, 20);
            label_DeveloperValue.TabIndex = 7;
            label_DeveloperValue.Text = "Developer";
            // 
            // label_VersionValue
            // 
            label_VersionValue.AutoSize = true;
            label_VersionValue.Dock = DockStyle.Fill;
            label_VersionValue.Font = new Font("Segoe UI", 9F);
            label_VersionValue.Location = new Point(94, 20);
            label_VersionValue.Name = "label_VersionValue";
            label_VersionValue.Size = new Size(277, 20);
            label_VersionValue.TabIndex = 6;
            label_VersionValue.Text = "Version";
            // 
            // label_ProductNameValue
            // 
            label_ProductNameValue.AutoSize = true;
            label_ProductNameValue.Dock = DockStyle.Fill;
            label_ProductNameValue.Font = new Font("Segoe UI", 9F);
            label_ProductNameValue.Location = new Point(94, 0);
            label_ProductNameValue.Name = "label_ProductNameValue";
            label_ProductNameValue.Size = new Size(277, 20);
            label_ProductNameValue.TabIndex = 5;
            label_ProductNameValue.Text = "Product Name";
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Dock = DockStyle.Fill;
            label_Description.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label_Description.Location = new Point(3, 80);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(85, 173);
            label_Description.TabIndex = 4;
            label_Description.Text = "Description:";
            // 
            // label_Developer
            // 
            label_Developer.AutoSize = true;
            label_Developer.Dock = DockStyle.Fill;
            label_Developer.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label_Developer.Location = new Point(3, 60);
            label_Developer.Name = "label_Developer";
            label_Developer.Size = new Size(85, 20);
            label_Developer.TabIndex = 2;
            label_Developer.Text = "Developer:";
            // 
            // label_Version
            // 
            label_Version.AutoSize = true;
            label_Version.Dock = DockStyle.Fill;
            label_Version.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label_Version.Location = new Point(3, 20);
            label_Version.Name = "label_Version";
            label_Version.Size = new Size(85, 20);
            label_Version.TabIndex = 1;
            label_Version.Text = "Version:";
            // 
            // label_ProductName
            // 
            label_ProductName.AutoSize = true;
            label_ProductName.Dock = DockStyle.Fill;
            label_ProductName.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label_ProductName.Location = new Point(3, 0);
            label_ProductName.Name = "label_ProductName";
            label_ProductName.Size = new Size(85, 20);
            label_ProductName.TabIndex = 0;
            label_ProductName.Text = "Product Name:";
            // 
            // textBox_Description
            // 
            textBox_Description.Dock = DockStyle.Fill;
            textBox_Description.Location = new Point(94, 83);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.PlaceholderText = "Description";
            textBox_Description.ReadOnly = true;
            textBox_Description.ScrollBars = ScrollBars.Vertical;
            textBox_Description.Size = new Size(277, 167);
            textBox_Description.TabIndex = 9;
            // 
            // button_Contact
            // 
            button_Contact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Contact.ImageAlign = ContentAlignment.MiddleRight;
            button_Contact.Location = new Point(12, 271);
            button_Contact.Name = "button_Contact";
            button_Contact.Size = new Size(90, 28);
            button_Contact.TabIndex = 2;
            button_Contact.Text = "Contact";
            button_Contact.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Contact.UseVisualStyleBackColor = true;
            button_Contact.Click += button_Contact_Click;
            // 
            // button_Close
            // 
            button_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Close.DialogResult = DialogResult.OK;
            button_Close.Location = new Point(382, 271);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(90, 28);
            button_Close.TabIndex = 3;
            button_Close.Text = "Close";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            // 
            // Info
            // 
            AcceptButton = button_Close;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Close;
            ClientSize = new Size(484, 311);
            Controls.Add(button_Close);
            Controls.Add(button_Contact);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox_Icon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Info";
            Text = "Info";
            Load += Info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Icon).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_Icon;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_Contact;
        private Button button_Close;
        private Label label_Version;
        private Label label_ProductName;
        private Label label_Developer;
        private Label label_DeveloperValue;
        private Label label_VersionValue;
        private Label label_ProductNameValue;
        private Label label_CompanyValue;
        private Label label_Company;
        private Label label_Description;
        private TextBox textBox_Description;
    }
}