namespace COMP1004_F2016_Assignment3
{
    partial class SelectForm
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
            this.BoldInstructionLabel = new System.Windows.Forms.Label();
            this.AvailableMoviesListBox = new System.Windows.Forms.ListBox();
            this.CurrentMovieLabel = new System.Windows.Forms.Label();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectionPictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BoldInstructionLabel
            // 
            this.BoldInstructionLabel.AutoSize = true;
            this.BoldInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldInstructionLabel.Location = new System.Drawing.Point(3, 9);
            this.BoldInstructionLabel.Name = "BoldInstructionLabel";
            this.BoldInstructionLabel.Size = new System.Drawing.Size(338, 13);
            this.BoldInstructionLabel.TabIndex = 0;
            this.BoldInstructionLabel.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // AvailableMoviesListBox
            // 
            this.AvailableMoviesListBox.FormattingEnabled = true;
            this.AvailableMoviesListBox.Location = new System.Drawing.Point(12, 65);
            this.AvailableMoviesListBox.Name = "AvailableMoviesListBox";
            this.AvailableMoviesListBox.Size = new System.Drawing.Size(120, 186);
            this.AvailableMoviesListBox.Sorted = true;
            this.AvailableMoviesListBox.TabIndex = 1;
            this.AvailableMoviesListBox.SelectedIndexChanged += new System.EventHandler(this.AvailableMoviesListBox_SelectedIndexChanged);
            // 
            // CurrentMovieLabel
            // 
            this.CurrentMovieLabel.AutoSize = true;
            this.CurrentMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMovieLabel.Location = new System.Drawing.Point(21, 47);
            this.CurrentMovieLabel.Name = "CurrentMovieLabel";
            this.CurrentMovieLabel.Size = new System.Drawing.Size(98, 15);
            this.CurrentMovieLabel.TabIndex = 2;
            this.CurrentMovieLabel.Text = "Available Movies";
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.CostTextBox);
            this.SelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionGroupBox.Controls.Add(this.CostLabel);
            this.SelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectionGroupBox.Controls.Add(this.TitleLabel);
            this.SelectionGroupBox.Controls.Add(this.SelectionPictureBox);
            this.SelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionGroupBox.Location = new System.Drawing.Point(138, 65);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(278, 146);
            this.SelectionGroupBox.TabIndex = 3;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(226, 115);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(46, 21);
            this.CostTextBox.TabIndex = 6;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(116, 115);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(90, 21);
            this.CategoryTextBox.TabIndex = 5;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(116, 40);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(136, 21);
            this.TitleTextBox.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(225, 97);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(31, 15);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(113, 97);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(55, 15);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(113, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 15);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // SelectionPictureBox
            // 
            this.SelectionPictureBox.Location = new System.Drawing.Point(7, 20);
            this.SelectionPictureBox.Name = "SelectionPictureBox";
            this.SelectionPictureBox.Size = new System.Drawing.Size(100, 120);
            this.SelectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectionPictureBox.TabIndex = 0;
            this.SelectionPictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(341, 228);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 263);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.CurrentMovieLabel);
            this.Controls.Add(this.AvailableMoviesListBox);
            this.Controls.Add(this.BoldInstructionLabel);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banana-Rama-Woah-Bama Movie Streaming Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BoldInstructionLabel;
        private System.Windows.Forms.ListBox AvailableMoviesListBox;
        private System.Windows.Forms.Label CurrentMovieLabel;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox SelectionPictureBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button NextButton;
    }
}

