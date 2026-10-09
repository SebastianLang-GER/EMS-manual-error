namespace EMSME
{
    partial class Button
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Button));
            errorButton = new System.Windows.Forms.Button();
            animationTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // errorButton
            // 
            errorButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            errorButton.BackColor = Color.Red;
            errorButton.Cursor = Cursors.Hand;
            errorButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            errorButton.ForeColor = Color.White;
            errorButton.Location = new Point(12, 12);
            errorButton.Name = "errorButton";
            errorButton.Size = new Size(76, 51);
            errorButton.TabIndex = 0;
            errorButton.Text = "EUT\r\nerror";
            errorButton.UseVisualStyleBackColor = false;
            errorButton.Click += errorButton_Click;
            // 
            // animationTimer
            // 
            animationTimer.Interval = 5;
            animationTimer.Tick += animationTimer_Tick;
            // 
            // Button
            // 
            AcceptButton = errorButton;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(100, 75);
            ControlBox = false;
            Controls.Add(errorButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Button";
            Opacity = 0D;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            Text = "EMS manual error";
            TopMost = true;
            Shown += Button_Shown;
            MouseDown += Button_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button errorButton;
        private System.Windows.Forms.Timer animationTimer;
    }
}