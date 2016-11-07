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
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Terminate application if user presses 'X' in corner
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // Load movie titles in ListBox
            foreach(Movie movie in Program.movieList.Movies)
            {
                AvailableMoviesListBox.Items.Add(movie.Title);
            }

            // If movie is selected, auto select the movie
            if(AvailableMoviesListBox.SelectedItem != null)
            {
                AvailableMoviesListBox.SelectedItem = Program.movieList.CurrentMovie.Title;
                NextButton.Enabled = true;
            }
            else
            {
                NextButton.Enabled = false;
            }
            
        }

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
