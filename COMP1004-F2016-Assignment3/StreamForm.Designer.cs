namespace COMP1004_F2016_Assignment3
{
    partial class StreamForm
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
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.PlayMessageLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CreditCardLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.ForeColor = System.Drawing.Color.Lime;
            this.ThankYouLabel.Location = new System.Drawing.Point(34, 9);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(352, 20);
            this.ThankYouLabel.TabIndex = 0;
            this.ThankYouLabel.Text = "Thank you for choosing Movie Banana-Nanza!";
            // 
            // PlayMessageLabel
            // 
            this.PlayMessageLabel.AutoSize = true;
            this.PlayMessageLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayMessageLabel.ForeColor = System.Drawing.Color.White;
            this.PlayMessageLabel.Location = new System.Drawing.Point(188, 81);
            this.PlayMessageLabel.Name = "PlayMessageLabel";
            this.PlayMessageLabel.Size = new System.Drawing.Size(219, 20);
            this.PlayMessageLabel.TabIndex = 1;
            this.PlayMessageLabel.Text = "will begin streaming shortly.";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MovieTitleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MovieTitleLabel.Location = new System.Drawing.Point(23, 81);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(119, 20);
            this.MovieTitleLabel.TabIndex = 2;
            this.MovieTitleLabel.Text = "MOVIE TITLE";
            this.MovieTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CostLabel.Location = new System.Drawing.Point(275, 44);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(100, 20);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "X DOLLARS";
            // 
            // CreditCardLabel
            // 
            this.CreditCardLabel.AutoSize = true;
            this.CreditCardLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardLabel.ForeColor = System.Drawing.Color.Linen;
            this.CreditCardLabel.Location = new System.Drawing.Point(34, 44);
            this.CreditCardLabel.Name = "CreditCardLabel";
            this.CreditCardLabel.Size = new System.Drawing.Size(245, 20);
            this.CreditCardLabel.TabIndex = 4;
            this.CreditCardLabel.Text = "Your credit card will be charged:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(174, 122);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(419, 157);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CreditCardLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.PlayMessageLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your movie is about to start!";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label PlayMessageLabel;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.Button OKButton;
    }
}