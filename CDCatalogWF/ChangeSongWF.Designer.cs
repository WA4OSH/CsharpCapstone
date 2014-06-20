namespace CDCatalogWF
{
    partial class ChangeSongWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSongWF));
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.changeSongPictureBox = new System.Windows.Forms.PictureBox();
            this.trackLengthLabel = new System.Windows.Forms.Label();
            this.trackLengthTextBox = new System.Windows.Forms.TextBox();
            this.changeGenreButton = new System.Windows.Forms.Button();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.songTitleLabel = new System.Windows.Forms.Label();
            this.songNameTextBox = new System.Windows.Forms.TextBox();
            this.changeArtistButton = new System.Windows.Forms.Button();
            this.artistComboBox = new System.Windows.Forms.ComboBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.trackNumberLabel = new System.Windows.Forms.Label();
            this.trackNumberTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.changeSongPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(329, 205);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 36;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(247, 205);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 35;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // changeSongPictureBox
            // 
            this.changeSongPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("changeSongPictureBox.Image")));
            this.changeSongPictureBox.Location = new System.Drawing.Point(12, 12);
            this.changeSongPictureBox.Name = "changeSongPictureBox";
            this.changeSongPictureBox.Size = new System.Drawing.Size(64, 56);
            this.changeSongPictureBox.TabIndex = 34;
            this.changeSongPictureBox.TabStop = false;
            // 
            // trackLengthLabel
            // 
            this.trackLengthLabel.AutoSize = true;
            this.trackLengthLabel.Location = new System.Drawing.Point(92, 105);
            this.trackLengthLabel.Name = "trackLengthLabel";
            this.trackLengthLabel.Size = new System.Drawing.Size(67, 13);
            this.trackLengthLabel.TabIndex = 33;
            this.trackLengthLabel.Text = "Track length";
            // 
            // trackLengthTextBox
            // 
            this.trackLengthTextBox.Location = new System.Drawing.Point(171, 102);
            this.trackLengthTextBox.Name = "trackLengthTextBox";
            this.trackLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.trackLengthTextBox.TabIndex = 32;
            // 
            // changeGenreButton
            // 
            this.changeGenreButton.Image = ((System.Drawing.Image)(resources.GetObject("changeGenreButton.Image")));
            this.changeGenreButton.Location = new System.Drawing.Point(329, 126);
            this.changeGenreButton.Name = "changeGenreButton";
            this.changeGenreButton.Size = new System.Drawing.Size(75, 23);
            this.changeGenreButton.TabIndex = 31;
            this.changeGenreButton.UseVisualStyleBackColor = true;
            this.changeGenreButton.Click += new System.EventHandler(this.changeGenreButton_Click);
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.AllowDrop = true;
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(171, 157);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(151, 21);
            this.ratingComboBox.TabIndex = 30;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(92, 160);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(61, 13);
            this.ratingLabel.TabIndex = 29;
            this.ratingLabel.Text = "Song rating";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(92, 131);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 28;
            this.genreLabel.Text = "Genre";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(171, 128);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(151, 21);
            this.genreComboBox.TabIndex = 27;
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AutoSize = true;
            this.songTitleLabel.Location = new System.Drawing.Point(92, 51);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(51, 13);
            this.songTitleLabel.TabIndex = 26;
            this.songTitleLabel.Text = "Song title";
            // 
            // songNameTextBox
            // 
            this.songNameTextBox.Location = new System.Drawing.Point(171, 48);
            this.songNameTextBox.Name = "songNameTextBox";
            this.songNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.songNameTextBox.TabIndex = 25;
            // 
            // changeArtistButton
            // 
            this.changeArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("changeArtistButton.Image")));
            this.changeArtistButton.Location = new System.Drawing.Point(329, 19);
            this.changeArtistButton.Name = "changeArtistButton";
            this.changeArtistButton.Size = new System.Drawing.Size(75, 23);
            this.changeArtistButton.TabIndex = 24;
            this.changeArtistButton.UseVisualStyleBackColor = true;
            this.changeArtistButton.Click += new System.EventHandler(this.changeArtistButton_Click);
            // 
            // artistComboBox
            // 
            this.artistComboBox.AllowDrop = true;
            this.artistComboBox.FormattingEnabled = true;
            this.artistComboBox.Location = new System.Drawing.Point(171, 21);
            this.artistComboBox.Name = "artistComboBox";
            this.artistComboBox.Size = new System.Drawing.Size(151, 21);
            this.artistComboBox.Sorted = true;
            this.artistComboBox.TabIndex = 23;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(92, 24);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(59, 13);
            this.artistLabel.TabIndex = 22;
            this.artistLabel.Text = "Artist name";
            // 
            // trackNumberLabel
            // 
            this.trackNumberLabel.AutoSize = true;
            this.trackNumberLabel.Location = new System.Drawing.Point(92, 79);
            this.trackNumberLabel.Name = "trackNumberLabel";
            this.trackNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.trackNumberLabel.TabIndex = 38;
            this.trackNumberLabel.Text = "Track number";
            // 
            // trackNumberTextBox
            // 
            this.trackNumberTextBox.Location = new System.Drawing.Point(171, 76);
            this.trackNumberTextBox.Name = "trackNumberTextBox";
            this.trackNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.trackNumberTextBox.TabIndex = 37;
            // 
            // ChangeSongWF
            // 
            this.AcceptButton = this.OkButton;
            this.AccessibleDescription = "Use this form to change a song";
            this.AccessibleName = "Change Song";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(427, 258);
            this.Controls.Add(this.trackNumberLabel);
            this.Controls.Add(this.trackNumberTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.changeSongPictureBox);
            this.Controls.Add(this.trackLengthLabel);
            this.Controls.Add(this.trackLengthTextBox);
            this.Controls.Add(this.changeGenreButton);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.songTitleLabel);
            this.Controls.Add(this.songNameTextBox);
            this.Controls.Add(this.changeArtistButton);
            this.Controls.Add(this.artistComboBox);
            this.Controls.Add(this.artistLabel);
            this.Name = "ChangeSongWF";
            this.Text = "ChangeSongWF";
            ((System.ComponentModel.ISupportInitialize)(this.changeSongPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox changeSongPictureBox;
        private System.Windows.Forms.Label trackLengthLabel;
        private System.Windows.Forms.TextBox trackLengthTextBox;
        private System.Windows.Forms.Button changeGenreButton;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label songTitleLabel;
        private System.Windows.Forms.TextBox songNameTextBox;
        private System.Windows.Forms.Button changeArtistButton;
        private System.Windows.Forms.ComboBox artistComboBox;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label trackNumberLabel;
        private System.Windows.Forms.TextBox trackNumberTextBox;
    }
}