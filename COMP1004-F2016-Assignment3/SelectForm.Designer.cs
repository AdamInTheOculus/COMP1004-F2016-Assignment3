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
            this.SelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionGroupBox.Location = new System.Drawing.Point(157, 65);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(259, 113);
            this.SelectionGroupBox.TabIndex = 3;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 263);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.CurrentMovieLabel);
            this.Controls.Add(this.AvailableMoviesListBox);
            this.Controls.Add(this.BoldInstructionLabel);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banana-Rama-Woah-Bama Movie Streaming Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BoldInstructionLabel;
        private System.Windows.Forms.ListBox AvailableMoviesListBox;
        private System.Windows.Forms.Label CurrentMovieLabel;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
    }
}

