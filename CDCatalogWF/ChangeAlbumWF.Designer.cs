namespace CDCatalogWF
{
    partial class ChangeAlbumWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeAlbumWF));
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.changeAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.changeGenreButton = new System.Windows.Forms.Button();
            this.changeArtistButton = new System.Windows.Forms.Button();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.albumYearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.albumTitleLabel = new System.Windows.Forms.Label();
            this.artistComboBox = new System.Windows.Forms.ComboBox();
            this.artistLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.changeAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(304, 170);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(222, 170);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 28;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // changeAlbumPictureBox
            // 
            this.changeAlbumPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("changeAlbumPictureBox.Image")));
            this.changeAlbumPictureBox.Location = new System.Drawing.Point(12, 12);
            this.changeAlbumPictureBox.Name = "changeAlbumPictureBox";
            this.changeAlbumPictureBox.Size = new System.Drawing.Size(63, 53);
            this.changeAlbumPictureBox.TabIndex = 27;
            this.changeAlbumPictureBox.TabStop = false;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.AllowDrop = true;
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(146, 123);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(151, 21);
            this.ratingComboBox.TabIndex = 26;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(81, 126);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(38, 13);
            this.ratingLabel.TabIndex = 25;
            this.ratingLabel.Text = "Rating";
            // 
            // changeGenreButton
            // 
            this.changeGenreButton.Image = ((System.Drawing.Image)(resources.GetObject("changeGenreButton.Image")));
            this.changeGenreButton.Location = new System.Drawing.Point(304, 94);
            this.changeGenreButton.Name = "changeGenreButton";
            this.changeGenreButton.Size = new System.Drawing.Size(75, 23);
            this.changeGenreButton.TabIndex = 24;
            this.changeGenreButton.UseVisualStyleBackColor = true;
            this.changeGenreButton.Click += new System.EventHandler(this.changeGenreButton_Click);
            // 
            // changeArtistButton
            // 
            this.changeArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("changeArtistButton.Image")));
            this.changeArtistButton.Location = new System.Drawing.Point(304, 15);
            this.changeArtistButton.Name = "changeArtistButton";
            this.changeArtistButton.Size = new System.Drawing.Size(75, 23);
            this.changeArtistButton.TabIndex = 23;
            this.changeArtistButton.UseVisualStyleBackColor = true;
            this.changeArtistButton.Click += new System.EventHandler(this.changeArtistButton_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(81, 100);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 22;
            this.genreLabel.Text = "Genre";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(146, 97);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(151, 21);
            this.genreComboBox.TabIndex = 21;
            // 
            // albumYearLabel
            // 
            this.albumYearLabel.AutoSize = true;
            this.albumYearLabel.Location = new System.Drawing.Point(81, 74);
            this.albumYearLabel.Name = "albumYearLabel";
            this.albumYearLabel.Size = new System.Drawing.Size(29, 13);
            this.albumYearLabel.TabIndex = 20;
            this.albumYearLabel.Text = "Year";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(146, 71);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(78, 20);
            this.yearTextBox.TabIndex = 19;
            // 
            // albumTitleTextBox
            // 
            this.albumTitleTextBox.Location = new System.Drawing.Point(146, 45);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.Size = new System.Drawing.Size(151, 20);
            this.albumTitleTextBox.TabIndex = 18;
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Location = new System.Drawing.Point(81, 48);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(55, 13);
            this.albumTitleLabel.TabIndex = 17;
            this.albumTitleLabel.Text = "Album title";
            // 
            // artistComboBox
            // 
            this.artistComboBox.AllowDrop = true;
            this.artistComboBox.FormattingEnabled = true;
            this.artistComboBox.Location = new System.Drawing.Point(146, 15);
            this.artistComboBox.Name = "artistComboBox";
            this.artistComboBox.Size = new System.Drawing.Size(151, 21);
            this.artistComboBox.Sorted = true;
            this.artistComboBox.TabIndex = 16;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(81, 18);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 15;
            this.artistLabel.Text = "Artist";
            // 
            // ChangeAlbumWF
            // 
            this.AcceptButton = this.OkButton;
            this.AccessibleDescription = "Use this form to change an album";
            this.AccessibleName = "Change Album";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(395, 209);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.changeAlbumPictureBox);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.changeGenreButton);
            this.Controls.Add(this.changeArtistButton);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.albumYearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.albumTitleLabel);
            this.Controls.Add(this.artistComboBox);
            this.Controls.Add(this.artistLabel);
            this.Name = "ChangeAlbumWF";
            this.Text = "ChangeAlbumWF";
            ((System.ComponentModel.ISupportInitialize)(this.changeAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox changeAlbumPictureBox;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button changeGenreButton;
        private System.Windows.Forms.Button changeArtistButton;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label albumYearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.Label albumTitleLabel;
        private System.Windows.Forms.ComboBox artistComboBox;
        private System.Windows.Forms.Label artistLabel;
    }
}