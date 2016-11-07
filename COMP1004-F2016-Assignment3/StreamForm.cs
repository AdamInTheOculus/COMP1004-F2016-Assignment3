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
        private double _grandTotal;

        public StreamForm(double grandTotal)
        {
            InitializeComponent();
            this._grandTotal = grandTotal;
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            // Update form labels to display information
            CostLabel.Text = this._grandTotal.ToString("C2");
            MovieTitleLabel.Text = Program.movieList.CurrentMovie.Title;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
