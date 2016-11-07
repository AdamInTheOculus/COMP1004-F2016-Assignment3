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
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment3
{
    public partial class OrderForm : Form
    {

        // Perform financial math operations
        private double subtotal = 0f, taxTotal = 0f, grandTotal = 0f;

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
            DialogResult result = (MessageBox.Show("Are you sure you want to cancel and exit?", "Cancel and Exit?", MessageBoxButtons.YesNo));
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Build information string and present in a MessageBox
            String about = "";
            about += "Title:\tMovie Bananza Selection\n";
            about += "Version: 1.4\n";
            about += "By:\tAdam Sinclair - moviebonanza.ca \n";
            about += "Contact:\t705-123-4567";
            MessageBox.Show(about, "About Us", MessageBoxButtons.OK);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // PrintDocument allows us to send output to a printer
            PrintDocument doc = new PrintDocument();

            // PrintPreviewDialog is a dialog box showing the page preview.
            // Set our size, location, and name.
            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            printDialog.ClientSize = new Size(400, 500);
            printDialog.DesktopLocation = new Point(100, 100);
            printDialog.Name = "Print Preview - OrderForm";

            // Associate custom print event with PrintPageHandler
            doc.PrintPage += new PrintPageEventHandler(doc_PrintPage);
            printDialog.Document = doc;

            // Display PrintDialog window
            printDialog.Show();
        }

        // PRIVATE PRINT EVENT HANDLER --------------------------------------------------
        private void doc_PrintPage(Object sender, PrintPageEventArgs e)
        {
            // Create and place message on PrintDialog
            String message = this.ToString();
            Font printFont = new Font("Arial", 25, FontStyle.Regular);
            e.Graphics.DrawString(message, printFont, Brushes.Black, 0, 0);
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            // Show new form
            StreamForm newStreamForm = new StreamForm(grandTotal);
            newStreamForm.Show();

            // Hide current form
            this.Hide();
        }

        // PRIVATE UTILITY METHODS ------------------------------------------------------
        /// <summary>
        /// Performs math calculations and converts to String. Fills in OrderForm 'Your Order' text boxes.
        /// </summary>
        private void UpdateCostTextFields()
        {
            // User selected DVD option so we add 9.99
            if (DVDCheckBox.Checked)
            {
                subtotal += 9.99f;
            }

            // Cost calculations
            subtotal += Program.movieList.CurrentMovie.Cost;
            taxTotal = subtotal * 0.13;
            grandTotal = subtotal + taxTotal;

            // Update financial text boxes
            CostTextBox.Text = Program.movieList.CurrentMovie.GetCostAsFormattedString();
            SubtotalTextBox.Text = subtotal.ToString("C2");
            SalesTaxTextBox.Text = taxTotal.ToString("C2");
            GrandTotalTextBox.Text = grandTotal.ToString("C2");
        }

        // PUBLIC ToString --------------------------------------------------------------
        override
        public String ToString()
        {
            String str = "";

            // Title and date
            str += "OrderForm Print Preview @ " + DateTime.Today.ToString() + "\n\n";

            // 'Movie Selected'
            str += "Movie Selected:\n";
            str += Program.movieList.CurrentMovie.ToString() + "\n";

            // 'Your Order'
            str += "Your Order:\n";
            str += "\tMovie cost: " + Program.movieList.CurrentMovie.GetCostAsFormattedString() + "\n";
            str += "\tSubtotal: " + subtotal.ToString("C2") + "\n";
            str += "\tSales Tax (13%): " + taxTotal.ToString("C2") + "\n";
            str += "\tGrand Total: " + grandTotal.ToString("C2") + "\n";

            return str;
        }
    }
}
