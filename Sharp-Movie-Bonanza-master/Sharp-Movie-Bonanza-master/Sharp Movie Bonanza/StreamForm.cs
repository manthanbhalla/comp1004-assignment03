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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// exits application on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// inserts the selected movie title and order grand total into existing labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamForm_Load(object sender, EventArgs e)
        {
            String[] movie = Program.movie;
            ChargedCostLabel.Text += movie[2];
            StreamingLabel.Text = String.Concat(movie[0], StreamingLabel.Text);
        }
    }
}
