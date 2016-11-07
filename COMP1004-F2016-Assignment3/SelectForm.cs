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
    public partial class SelectForm : Form
    {
        // CONSTRUCTOR ------------------------------------------------------------------
        public SelectForm()
        {
            InitializeComponent();
        }

        // PRIVATE EVENT HANDLERS -------------------------------------------------------
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Terminate application if user presses 'X' in corner
            Application.Exit();
        }

        /// <summary>
        /// When form loads, all movie titles are added into ListBox.
        /// The user cannot progress if a movie is not selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // Load all movies into ListBox
            foreach(Movie movie in Program.movieList.Movies)
            {
                AvailableMoviesListBox.Items.Add(movie.Title);
            }

            // If movie is selected, auto select the movie
            if(Program.movieList.CurrentMovie != null)
            {
                AvailableMoviesListBox.SelectedItem = Program.movieList.CurrentMovie.Title;
                NextButton.Enabled = true;
            }
            else
            {
                NextButton.Enabled = false;
            }
            
        }

        /// <summary>
        /// After a new movie is selected, update the TextBoxes with new information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AvailableMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Search for Movie object using ListBox movie title
            Program.movieList.CurrentMovie = Program.movieList.GetMovieByTitle(AvailableMoviesListBox.SelectedItem.ToString());

            // Populate form fields with newly assigned movie
            SelectionPictureBox.Image = Program.movieList.CurrentMovie.Image;
            TitleTextBox.Text = Program.movieList.CurrentMovie.Title;
            CategoryTextBox.Text = Program.movieList.CurrentMovie.Category;
            CostTextBox.Text = Program.movieList.CurrentMovie.GetCostAsFormattedString();

            // Enable next button
            NextButton.Enabled = true;
        }

        /// <summary>
        /// Open next form and hide this current form to allow user to move onto next form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Ensure movie is selected before moving on.
            if(Program.movieList.CurrentMovie != null)
            {
                // Load up next form and hide this one.
                OrderForm nextForm = new OrderForm();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a movie first before continuing.", "No Movie Selected", MessageBoxButtons.OK);
            }
        }
    }
}