using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// fills out the selection details whenever the selection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = MoviesComboBox.Text;
            CheckCategory();
            CheckCost();
            string imageString = Regex.Replace(TitleTextBox.Text, @"\s+", "");
            YourSelectionPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageString);
            YourSelectionPictureBox.Refresh();
            NextButton.Enabled = true;
        }

        /// <summary>
        /// assigns the proper category to the movie selected
        /// </summary>
        private void CheckCategory()
        {
            String[] SciFi = { "Season of the Witch", "I am Number Four" };
            String[] Action = { "Death Race 2", "Sanctum", "The Eagle", "The Green Hornet", "The Mechanic", "The Other Woman" };
            String[] Comedy = { "The Dilemma", "No Strings Attached", "Cedar Rapids", "Just Go With It" };
            String[] Drama = { "Company Men", "The Way Back", "Waiting for Forever" };
            String[] Family = { "Gnomeo and Juliet" };
            String[] Horror = { "The Rite" };
            String[] Thriller = { "The Roommate" };
            String[] NewRelease = { "Footloose", "Real Steel" };

            if (SciFi.Contains(TitleTextBox.Text))
            {
                CategoryTextBox.Text = "Sci-Fi";
            }
            else if (Action.Contains(TitleTextBox.Text))
            {
                CategoryTextBox.Text = "Action";
            }
            else if (Comedy.Contains(TitleTextBox.Text))
            {
                CategoryTextBox.Text = "Comedy";
            }
            else if (Drama.Contains(TitleTextBox.Text))
            {
                CategoryTextBox.Text = "Drama";
            }
            else if (Family.Contains(TitleTextBox.Text))
            {
                CategoryTextBox.Text = "Family";
            }
            else if (Horror.Contains(TitleTextBox.Text))
            {
                CategoryTextBox.Text = "Horror";
            }
            else if (Thriller.Contains(TitleTextBox.Text))
            {
                CategoryTextBox.Text = "Thriller";
            }
            else if (NewRelease.Contains(TitleTextBox.Text))
            {
                CategoryTextBox.Text = "New Release";
            }
        }

        /// <summary>
        /// assigns the proper cost based on a given category
        /// </summary>
        private void CheckCost()
        {
            String[] OneDollar = { "Family" };
            String[] TwoDollar = { "Comedy", "Drama", "Thriller" };
            String[] ThreeDollar = { "Action", "SciFi", "Horror" };
            String[] FiveDollar = { "New Release" };

            if (OneDollar.Contains(CategoryTextBox.Text))
            {
                CostTextBox.Text = "$0.99";
            }
            else if (TwoDollar.Contains(CategoryTextBox.Text))
            {
                CostTextBox.Text = "$1.99";
            }
            else if (ThreeDollar.Contains(CategoryTextBox.Text))
            {
                CostTextBox.Text = "$2.99";
            }
            else if (FiveDollar.Contains(CategoryTextBox.Text))
            {
                CostTextBox.Text = "$4.99";
            }
        }

        /// <summary>
        /// checks if a movie has been previously selected and displays its details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionForm_Load(object sender, EventArgs e)
        {
            String[] movie = Program.movie;

            if (movie[0] == null)
            {
                NextButton.Enabled = false;
            }
            else
            {
                TitleTextBox.Text = movie[0];
                CategoryTextBox.Text = movie[1];
                CostTextBox.Text = movie[2];
                string imageString = Regex.Replace(TitleTextBox.Text, @"\s+", "");
                YourSelectionPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageString);
                YourSelectionPictureBox.Refresh();
                NextButton.Enabled = true;
            }
        }

        /// <summary>
        /// saves the selection details and moves to the order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            String[] movie = Program.movie;
            movie.SetValue(TitleTextBox.Text, 0);
            movie.SetValue(CategoryTextBox.Text, 1);
            movie.SetValue(CostTextBox.Text, 2);

            this.Hide();
            OrderForm OrderForm = new OrderForm();
            OrderForm.previousForm = this;
            OrderForm.Show();
        }
    }
}
