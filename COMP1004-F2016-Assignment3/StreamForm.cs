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
    public partial class StreamForm : Form
    {
        // PRIVATE INSTANCE VARIABLES ---------------------------------------------------
        private double _grandTotal;

        // PUBLIC CONSTRUCTOR -----------------------------------------------------------
        public StreamForm(double grandTotal)
        {
            InitializeComponent();
            this._grandTotal = grandTotal;
        }

        // PRIVATE EVENT HANDLERS -------------------------------------------------------

        /// <summary>
        /// Update final form with grand total cost and desired movie title.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamForm_Load(object sender, EventArgs e)
        {
            // Update form labels to display information
            CostLabel.Text = this._grandTotal.ToString("C2");
            MovieTitleLabel.Text = Program.movieList.CurrentMovie.Title;
        }

        /// <summary>
        /// Close application when OK button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
