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
    public partial class OrderForm : Form
    {

        public OrderForm()
        {
            InitializeComponent();
        }

        // PRIVATE EVENT HANDLERS -------------------------------------------------------
        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Load up 'Your Movie' and 'Your Order' fields.
            TitleTextBox.Text = Program.movieList.CurrentMovie.Title;
            CategoryTextBox.Text = Program.movieList.CurrentMovie.Category;
            MovieSelectedPictureBox.Image = Program.movieList.CurrentMovie.Image;

            UpdateCostTextFields();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Load up previous form
            SelectForm previousForm = new SelectForm();
            previousForm.Show();

            // Hide current form
            this.Hide();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Terminate application if user presses 'X' in corner
            Application.Exit();
        }

        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCostTextFields();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = (MessageBox.Show("Are you sure you want to cancel and exit?", "Cancel & Exit?", MessageBoxButtons.YesNo));
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // PRIVATE UTILITY METHODS ------------------------------------------------------
        /// <summary>
        /// Performs math calculations and converts to String. Fills in OrderForm 'Your Order' text boxes.
        /// </summary>
        private void UpdateCostTextFields()
        {
            // Perform financial math operations
            double subtotal = 0f, taxTotal = 0f, grandTotal = 0f;

            // User selected DVD option
            if (DVDCheckBox.Checked)
            {
                subtotal += 9.99f;
            }

            subtotal += Program.movieList.CurrentMovie.Cost;
            taxTotal = subtotal * 0.13;
            grandTotal = subtotal + taxTotal;

            // Update financial text boxes
            CostTextBox.Text = Program.movieList.CurrentMovie.GetCostAsFormattedString();
            SubtotalTextBox.Text = subtotal.ToString("C2");
            SalesTaxTextBox.Text = taxTotal.ToString("C2");
            GrandTotalTextBox.Text = grandTotal.ToString("C2");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String about = "";
            about += "Title:\tMovie Bananza Selection v1.4\n";
            about += "By:\tAdam Sinclair - ID#200321984 - adamsinclair.ca \n";
            about += "Contact:\t705-123-4567";
            MessageBox.Show(about, "About Us", MessageBoxButtons.OK);
        }
    }
}
