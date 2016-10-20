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
        }

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
