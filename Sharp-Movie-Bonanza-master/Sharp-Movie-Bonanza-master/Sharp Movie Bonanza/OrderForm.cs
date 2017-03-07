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
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;

        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// retrieves selected movie, displays its details and calculates costs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            String[] movie = Program.movie;
            TitleTextBox.Text = movie[0];
            CategoryTextBox.Text = movie[1];
            CostTextBox.Text = movie[2];
            string imageString = Regex.Replace(TitleTextBox.Text, @"\s+", "");
            YourSelectionPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageString);
            YourSelectionPictureBox.Refresh();
            CalcTotal();
        }

        /// <summary>
        /// saves the finalized cost and opens the Stream form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            String[] movie = Program.movie;
            movie.SetValue(GrandTotalTextBox.Text, 2);

            this.Hide();
            StreamForm StreamForm = new StreamForm();
            StreamForm.Show();
        }

        /// <summary>
        /// returns to selection form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        /// <summary>
        /// closes application if user cancels order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// opens up a print preview of the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderPrintPreviewDialog.ShowDialog();
        }

        /// <summary>
        /// adds in or removes DVD price when checkbox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DVDLabel.Visible = !DVDLabel.Visible;
            DVDTextBox.Visible = DVDLabel.Visible;
            CalcTotal();
        }

        /// <summary>
        /// calculates and displays text for subtotal, sales tax and grand total
        /// </summary>
        private void CalcTotal()
        {
            double subtotal = Double.Parse(CostTextBox.Text.Substring(1));
            if (DVDTextBox.Visible)
            {
                subtotal += 10;
            }
            SubtotalTextBox.Text = subtotal.ToString("C2");

            double salesTax = subtotal * 0.13;
            SalesTaxTextBox.Text = salesTax.ToString("C2");

            double grandTotal = subtotal + salesTax;
            GrandTotalTextBox.Text = grandTotal.ToString("C2");
        }

        /// <summary>
        /// opens and locks focus on an about form without closing this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderAboutBox OrderAboutBox = new OrderAboutBox();
            OrderAboutBox.ShowDialog();
        }
    }
}
