namespace CDCatalogWF
{
    partial class AddSongWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSongWF));
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistComboBox = new System.Windows.Forms.ComboBox();
            this.addArtistButton = new System.Windows.Forms.Button();
            this.songNameTextBox = new System.Windows.Forms.TextBox();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(93, 25);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 1;
            this.artistLabel.Text = "Artist";
            // 
            // artistComboBox
            // 
            this.artistComboBox.AllowDrop = true;
            this.artistComboBox.FormattingEnabled = true;
            this.artistComboBox.Location = new System.Drawing.Point(172, 22);
            this.artistComboBox.Name = "artistComboBox";
            this.artistComboBox.Size = new System.Drawing.Size(151, 21);
            this.artistComboBox.Sorted = true;
            this.artistComboBox.TabIndex = 2;
            // 
            // addArtistButton
            // 
            this.addArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("addArtistButton.Image")));
            this.addArtistButton.Location = new System.Drawing.Point(330, 20);
            this.addArtistButton.Name = "addArtistButton";
            this.addArtistButton.Size = new System.Drawing.Size(75, 23);
            this.addArtistButton.TabIndex = 9;
            this.addArtistButton.UseVisualStyleBackColor = true;
            // 
            // songNameTextBox
            // 
            this.songNameTextBox.Location = new System.Drawing.Point(172, 49);
            this.songNameTextBox.Name = "songNameTextBox";
            this.songNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.songNameTextBox.TabIndex = 10;
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Location = new System.Drawing.Point(93, 52);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(63, 13);
            this.songNameLabel.TabIndex = 11;
            this.songNameLabel.Text = "Song Name";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(172, 102);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(151, 21);
            this.genreComboBox.TabIndex = 12;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(93, 105);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 13;
            this.genreLabel.Text = "Genre";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(93, 134);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(38, 13);
            this.ratingLabel.TabIndex = 14;
            this.ratingLabel.Text = "Rating";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.AllowDrop = true;
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(172, 131);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(151, 21);
            this.ratingComboBox.TabIndex = 15;
            // 
            // addGenreButton
            // 
            this.addGenreButton.Image = ((System.Drawing.Image)(resources.GetObject("addGenreButton.Image")));
            this.addGenreButton.Location = new System.Drawing.Point(330, 100);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(75, 23);
            this.addGenreButton.TabIndex = 16;
            this.addGenreButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Track Length";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 56);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(330, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(248, 179);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 20;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // AddSongWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 212);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.songNameTextBox);
            this.Controls.Add(this.addArtistButton);
            this.Controls.Add(this.artistComboBox);
            this.Controls.Add(this.artistLabel);
            this.Name = "AddSongWF";
            this.Text = "AddSongWF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.ComboBox artistComboBox;
        private System.Windows.Forms.Button addArtistButton;
        private System.Windows.Forms.TextBox songNameTextBox;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}