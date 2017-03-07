namespace Sharp_Movie_Bonanza
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesComboBox = new System.Windows.Forms.ComboBox();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.YourSelectionPictureBox = new System.Windows.Forms.PictureBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.MoviesLabel = new System.Windows.Forms.Label();
            this.YourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourSelectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesComboBox
            // 
            this.MoviesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MoviesComboBox.FormattingEnabled = true;
            this.MoviesComboBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.MoviesComboBox.Location = new System.Drawing.Point(230, 32);
            this.MoviesComboBox.Name = "MoviesComboBox";
            this.MoviesComboBox.Size = new System.Drawing.Size(121, 21);
            this.MoviesComboBox.Sorted = true;
            this.MoviesComboBox.TabIndex = 0;
            this.MoviesComboBox.SelectedIndexChanged += new System.EventHandler(this.MoviesComboBox_SelectedIndexChanged);
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.YourSelectionPictureBox);
            this.YourSelectionGroupBox.Controls.Add(this.CostTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CostLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.YourSelectionGroupBox.Controls.Add(this.TitleLabel);
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(193, 293);
            this.YourSelectionGroupBox.TabIndex = 1;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // YourSelectionPictureBox
            // 
            this.YourSelectionPictureBox.Location = new System.Drawing.Point(22, 112);
            this.YourSelectionPictureBox.Name = "YourSelectionPictureBox";
            this.YourSelectionPictureBox.Size = new System.Drawing.Size(150, 175);
            this.YourSelectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YourSelectionPictureBox.TabIndex = 6;
            this.YourSelectionPictureBox.TabStop = false;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(71, 74);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(116, 20);
            this.CostTextBox.TabIndex = 5;
            this.CostTextBox.Text = "$0.00";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(71, 47);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(116, 20);
            this.CategoryTextBox.TabIndex = 4;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(71, 20);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(116, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(7, 77);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(6, 50);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(7, 23);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(256, 282);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MoviesLabel
            // 
            this.MoviesLabel.AutoSize = true;
            this.MoviesLabel.Location = new System.Drawing.Point(244, 12);
            this.MoviesLabel.Name = "MoviesLabel";
            this.MoviesLabel.Size = new System.Drawing.Size(87, 13);
            this.MoviesLabel.TabIndex = 3;
            this.MoviesLabel.Text = "Available Movies";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 317);
            this.ControlBox = false;
            this.Controls.Add(this.MoviesLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.MoviesComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza - Select a Movie";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourSelectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MoviesComboBox;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.PictureBox YourSelectionPictureBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label MoviesLabel;
    }
}

