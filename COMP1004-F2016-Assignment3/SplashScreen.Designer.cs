namespace COMP1004_F2016_Assignment3
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.SplashScreenLabel = new System.Windows.Forms.Label();
            this.SplashScreenTitle = new System.Windows.Forms.Label();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashScreenLabel
            // 
            resources.ApplyResources(this.SplashScreenLabel, "SplashScreenLabel");
            this.SplashScreenLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.SplashScreenLabel.Name = "SplashScreenLabel";
            // 
            // SplashScreenTitle
            // 
            resources.ApplyResources(this.SplashScreenTitle, "SplashScreenTitle");
            this.SplashScreenTitle.ForeColor = System.Drawing.Color.LawnGreen;
            this.SplashScreenTitle.Name = "SplashScreenTitle";
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Enabled = true;
            this.SplashScreenTimer.Interval = 3000;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.SplashScreenTitle);
            this.Controls.Add(this.SplashScreenLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SplashScreenLabel;
        private System.Windows.Forms.Label SplashScreenTitle;
        private System.Windows.Forms.Timer SplashScreenTimer;
    }
}