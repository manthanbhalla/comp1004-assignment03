namespace Sharp_Movie_Bonanza
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.YourSelectionPictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.DVDCheckBox = new System.Windows.Forms.CheckBox();
            this.DVDTextBox = new System.Windows.Forms.TextBox();
            this.DVDLabel = new System.Windows.Forms.Label();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.DividerLabel = new System.Windows.Forms.Label();
            this.OrderMenuStrip.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourSelectionPictureBox)).BeginInit();
            this.YourOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(391, 24);
            this.OrderMenuStrip.TabIndex = 0;
            this.OrderMenuStrip.Text = "OrderMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.streamToolStripMenuItem.Text = "Strea&m";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cancelToolStripMenuItem.Text = "Canc&el";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(66, 323);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(250, 322);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(75, 23);
            this.StreamButton.TabIndex = 2;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.YourSelectionPictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(13, 28);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(169, 278);
            this.MovieSelectedGroupBox.TabIndex = 3;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // YourSelectionPictureBox
            // 
            this.YourSelectionPictureBox.InitialImage = null;
            this.YourSelectionPictureBox.Location = new System.Drawing.Point(9, 95);
            this.YourSelectionPictureBox.Name = "YourSelectionPictureBox";
            this.YourSelectionPictureBox.Size = new System.Drawing.Size(150, 175);
            this.YourSelectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YourSelectionPictureBox.TabIndex = 11;
            this.YourSelectionPictureBox.TabStop = false;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(9, 69);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(116, 20);
            this.CategoryTextBox.TabIndex = 10;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(6, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Title";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(6, 53);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(9, 30);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(116, 20);
            this.TitleTextBox.TabIndex = 9;
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.DividerLabel);
            this.YourOrderGroupBox.Controls.Add(this.DVDCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.DVDTextBox);
            this.YourOrderGroupBox.Controls.Add(this.DVDLabel);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.SubtotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SubtotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.CostTextBox);
            this.YourOrderGroupBox.Controls.Add(this.CostLabel);
            this.YourOrderGroupBox.Location = new System.Drawing.Point(188, 28);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Size = new System.Drawing.Size(191, 224);
            this.YourOrderGroupBox.TabIndex = 4;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // DVDCheckBox
            // 
            this.DVDCheckBox.AutoSize = true;
            this.DVDCheckBox.Location = new System.Drawing.Point(10, 190);
            this.DVDCheckBox.Name = "DVDCheckBox";
            this.DVDCheckBox.Size = new System.Drawing.Size(180, 17);
            this.DVDCheckBox.TabIndex = 16;
            this.DVDCheckBox.Text = "Order the DVD for only $10 extra";
            this.DVDCheckBox.UseVisualStyleBackColor = true;
            this.DVDCheckBox.CheckedChanged += new System.EventHandler(this.DVDCheckBox_CheckedChanged);
            // 
            // DVDTextBox
            // 
            this.DVDTextBox.Location = new System.Drawing.Point(114, 46);
            this.DVDTextBox.Name = "DVDTextBox";
            this.DVDTextBox.Size = new System.Drawing.Size(70, 20);
            this.DVDTextBox.TabIndex = 15;
            this.DVDTextBox.Text = "$10.00";
            this.DVDTextBox.Visible = false;
            // 
            // DVDLabel
            // 
            this.DVDLabel.AutoSize = true;
            this.DVDLabel.Location = new System.Drawing.Point(7, 49);
            this.DVDLabel.Name = "DVDLabel";
            this.DVDLabel.Size = new System.Drawing.Size(57, 13);
            this.DVDLabel.TabIndex = 14;
            this.DVDLabel.Text = "DVD Price";
            this.DVDLabel.Visible = false;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(114, 138);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(70, 20);
            this.GrandTotalTextBox.TabIndex = 13;
            this.GrandTotalTextBox.Text = "0.00";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(7, 141);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.GrandTotalLabel.TabIndex = 12;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(114, 109);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(70, 20);
            this.SalesTaxTextBox.TabIndex = 11;
            this.SalesTaxTextBox.Text = "0.00";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(7, 112);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(83, 13);
            this.SalesTaxLabel.TabIndex = 10;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Location = new System.Drawing.Point(114, 73);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(70, 20);
            this.SubtotalTextBox.TabIndex = 9;
            this.SubtotalTextBox.Text = "0.00";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(7, 76);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.SubtotalLabel.TabIndex = 8;
            this.SubtotalLabel.Text = "Subtotal";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(114, 19);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(70, 20);
            this.CostTextBox.TabIndex = 7;
            this.CostTextBox.Text = "$0.00";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(7, 22);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(55, 13);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Base Cost";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(157, 323);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderPrintPreviewDialog
            // 
            this.OrderPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.OrderPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.OrderPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.OrderPrintPreviewDialog.Enabled = true;
            this.OrderPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("OrderPrintPreviewDialog.Icon")));
            this.OrderPrintPreviewDialog.MainMenuStrip = this.OrderMenuStrip;
            this.OrderPrintPreviewDialog.Name = "OrderPrintPreviewDialog";
            this.OrderPrintPreviewDialog.ShowIcon = false;
            this.OrderPrintPreviewDialog.Visible = false;
            // 
            // DividerLabel
            // 
            this.DividerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DividerLabel.Location = new System.Drawing.Point(9, 100);
            this.DividerLabel.Name = "DividerLabel";
            this.DividerLabel.Size = new System.Drawing.Size(174, 2);
            this.DividerLabel.TabIndex = 17;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 358);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderMenuStrip);
            this.MainMenuStrip = this.OrderMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourSelectionPictureBox)).EndInit();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.PictureBox YourSelectionPictureBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox DVDTextBox;
        private System.Windows.Forms.Label DVDLabel;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.CheckBox DVDCheckBox;
        private System.Windows.Forms.PrintPreviewDialog OrderPrintPreviewDialog;
        private System.Windows.Forms.Label DividerLabel;
    }
}