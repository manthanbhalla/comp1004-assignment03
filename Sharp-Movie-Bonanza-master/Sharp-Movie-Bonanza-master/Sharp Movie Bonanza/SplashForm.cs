using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Sharp movie Bonanza
/// Created by Manthan Bhalla
/// Student # 200331757
/// Created on march 06th 2017
///a simple form that allows the user to order the movie and watch it
/// </summary>
namespace Sharp_Movie_Bonanza
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// moves to the selection form after 3 seconds and disables the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            SelectionForm SelectionForm = new SelectionForm();
            SelectionForm.Show();
            SplashTimer.Enabled = false;
        }
    }
}
