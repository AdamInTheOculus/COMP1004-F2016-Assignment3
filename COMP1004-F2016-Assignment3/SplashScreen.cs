/*
 * App Name: Movie Bonanza Selector
 * App Description: This app allows users to select from a list of movies, and stream them.
 *                  There is also an option to purchase a DVD for an extra $9.99.
 *                  
 * Creation Date: October 29th 2016
 * Author's Name: Adam Sinclair
 * Student ID #: 200321984
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment3
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            // Load movies from text file and store in a list
            Program.movieList.GenerateMovieList();
        }

        /// <summary>
        /// When the timer "ticks" 3 seconds have passed.
        /// Create new form and hide this splash screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            // Create instance of next form to load
            SelectForm selectForm = new SelectForm();
            selectForm.Show();

            // Turn of timer to prevent infinite loop of this method
            SplashScreenTimer.Stop();
            SplashScreenTimer.Enabled = false;

            // Hide this current form
            this.Hide();
        }
    }
}
