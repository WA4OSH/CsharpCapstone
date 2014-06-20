namespace CDCatalogWF
{
    partial class AddAlbumWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlbumWF));
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistComboBox = new System.Windows.Forms.ComboBox();
            this.albumTitleLabel = new System.Windows.Forms.Label();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.albumYearLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.addArtistButton = new System.Windows.Forms.Button();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.addAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(82, 19);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 0;
            this.artistLabel.Text = "Artist";
            // 
            // artistComboBox
            // 
            this.artistComboBox.AllowDrop = true;
            this.artistComboBox.FormattingEnabled = true;
            this.artistComboBox.Location = new System.Drawing.Point(147, 16);
            this.artistComboBox.Name = "artistComboBox";
            this.artistComboBox.Size = new System.Drawing.Size(151, 21);
            this.artistComboBox.Sorted = true;
            this.artistComboBox.TabIndex = 1;
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Location = new System.Drawing.Point(82, 49);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(55, 13);
            this.albumTitleLabel.TabIndex = 2;
            this.albumTitleLabel.Text = "Album title";
            // 
            // albumTitleTextBox
            // 
            this.albumTitleTextBox.Location = new System.Drawing.Point(147, 46);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.Size = new System.Drawing.Size(151, 20);
            this.albumTitleTextBox.TabIndex = 3;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(147, 72);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(78, 20);
            this.yearTextBox.TabIndex = 4;
            // 
            // albumYearLabel
            // 
            this.albumYearLabel.AutoSize = true;
            this.albumYearLabel.Location = new System.Drawing.Point(82, 75);
            this.albumYearLabel.Name = "albumYearLabel";
            this.albumYearLabel.Size = new System.Drawing.Size(29, 13);
            this.albumYearLabel.TabIndex = 5;
            this.albumYearLabel.Text = "Year";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(147, 98);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(151, 21);
            this.genreComboBox.TabIndex = 6;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(82, 101);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre";
            // 
            // addArtistButton
            // 
            this.addArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("addArtistButton.Image")));
            this.addArtistButton.Location = new System.Drawing.Point(305, 16);
            this.addArtistButton.Name = "addArtistButton";
            this.addArtistButton.Size = new System.Drawing.Size(75, 23);
            this.addArtistButton.TabIndex = 8;
            this.addArtistButton.UseVisualStyleBackColor = true;
            this.addArtistButton.Click += new System.EventHandler(this.addArtistButton_Click);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Image = ((System.Drawing.Image)(resources.GetObject("addGenreButton.Image")));
            this.addGenreButton.Location = new System.Drawing.Point(305, 95);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(75, 23);
            this.addGenreButton.TabIndex = 9;
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(82, 127);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(38, 13);
            this.ratingLabel.TabIndex = 10;
            this.ratingLabel.Text = "Rating";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.AllowDrop = true;
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(147, 124);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(151, 21);
            this.ratingComboBox.TabIndex = 11;
            // 
            // addAlbumPictureBox
            // 
            this.addAlbumPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addAlbumPictureBox.Image")));
            this.addAlbumPictureBox.Location = new System.Drawing.Point(13, 13);
            this.addAlbumPictureBox.Name = "addAlbumPictureBox";
            this.addAlbumPictureBox.Size = new System.Drawing.Size(63, 53);
            this.addAlbumPictureBox.TabIndex = 12;
            this.addAlbumPictureBox.TabStop = false;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(223, 171);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 13;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(305, 171);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddAlbumWF
            // 
            this.AcceptButton = this.OkButton;
            this.AccessibleDescription = "Use this form to add an album";
            this.AccessibleName = "Add Album";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(393, 206);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.addAlbumPictureBox);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.addArtistButton);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.albumYearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.albumTitleLabel);
            this.Controls.Add(this.artistComboBox);
            this.Controls.Add(this.artistLabel);
            this.Name = "AddAlbumWF";
            this.Text = "AddAlbumWF";
            ((System.ComponentModel.ISupportInitialize)(this.addAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.ComboBox artistComboBox;
        private System.Windows.Forms.Label albumTitleLabel;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label albumYearLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button addArtistButton;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.PictureBox addAlbumPictureBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
    }
}