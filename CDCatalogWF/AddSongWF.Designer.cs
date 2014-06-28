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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSongWF));
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistComboBox = new System.Windows.Forms.ComboBox();
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet2 = new CDCatalogWF.CDCatalogDataSet2();
            this.addArtistButton = new System.Windows.Forms.Button();
            this.songNameTextBox = new System.Windows.Forms.TextBox();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet3 = new CDCatalogWF.CDCatalogDataSet3();
            this.genreLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.songTrackLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.trackNumberLabel = new System.Windows.Forms.Label();
            this.songTrackNumberTextBox = new System.Windows.Forms.TextBox();
            this.artistTableAdapter = new CDCatalogWF.CDCatalogDataSet2TableAdapters.ArtistTableAdapter();
            this.genreTableAdapter = new CDCatalogWF.CDCatalogDataSet3TableAdapters.GenreTableAdapter();
            this.albumTitleComboBox = new System.Windows.Forms.ComboBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogAlbum = new CDCatalogWF.CDCatalogAlbum();
            this.albumTitleLabel = new System.Windows.Forms.Label();
            this.addAlbumTitleButton = new System.Windows.Forms.Button();
            this.albumTableAdapter = new CDCatalogWF.CDCatalogAlbumTableAdapters.AlbumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(93, 25);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(59, 13);
            this.artistLabel.TabIndex = 1;
            this.artistLabel.Text = "Artist name";
            this.artistLabel.Click += new System.EventHandler(this.artistLabel_Click);
            // 
            // artistComboBox
            // 
            this.artistComboBox.AccessibleDescription = "This combo box allows the user to select from a list of artists names";
            this.artistComboBox.AccessibleName = "Artist Combo Box";
            this.artistComboBox.AllowDrop = true;
            this.artistComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.artistBindingSource, "ArtistID", true));
            this.artistComboBox.DataSource = this.artistBindingSource;
            this.artistComboBox.DisplayMember = "ArtistName";
            this.artistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.artistComboBox.FormattingEnabled = true;
            this.artistComboBox.Location = new System.Drawing.Point(172, 22);
            this.artistComboBox.Name = "artistComboBox";
            this.artistComboBox.Size = new System.Drawing.Size(151, 21);
            this.artistComboBox.TabIndex = 2;
            this.artistComboBox.ValueMember = "ArtistID";
            this.artistComboBox.SelectedIndexChanged += new System.EventHandler(this.artistComboBox_SelectedIndexChanged);
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataMember = "Artist";
            this.artistBindingSource.DataSource = this.cDCatalogDataSet2;
            // 
            // cDCatalogDataSet2
            // 
            this.cDCatalogDataSet2.DataSetName = "CDCatalogDataSet2";
            this.cDCatalogDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addArtistButton
            // 
            this.addArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("addArtistButton.Image")));
            this.addArtistButton.Location = new System.Drawing.Point(330, 20);
            this.addArtistButton.Name = "addArtistButton";
            this.addArtistButton.Size = new System.Drawing.Size(75, 23);
            this.addArtistButton.TabIndex = 9;
            this.addArtistButton.UseVisualStyleBackColor = true;
            this.addArtistButton.Click += new System.EventHandler(this.addArtistButton_Click);
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
            this.songNameLabel.Size = new System.Drawing.Size(51, 13);
            this.songNameLabel.TabIndex = 11;
            this.songNameLabel.Text = "Song title";
            // 
            // genreComboBox
            // 
            this.genreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genreBindingSource, "GenreID", true));
            this.genreComboBox.DataSource = this.genreBindingSource;
            this.genreComboBox.DisplayMember = "GenreName";
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(172, 157);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(151, 21);
            this.genreComboBox.TabIndex = 12;
            this.genreComboBox.ValueMember = "GenreID";
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.cDCatalogDataSet3BindingSource;
            // 
            // cDCatalogDataSet3BindingSource
            // 
            this.cDCatalogDataSet3BindingSource.DataSource = this.cDCatalogDataSet3;
            this.cDCatalogDataSet3BindingSource.Position = 0;
            // 
            // cDCatalogDataSet3
            // 
            this.cDCatalogDataSet3.DataSetName = "CDCatalogDataSet3";
            this.cDCatalogDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(93, 160);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 13;
            this.genreLabel.Text = "Genre";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(93, 187);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(61, 13);
            this.ratingLabel.TabIndex = 14;
            this.ratingLabel.Text = "Song rating";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.AllowDrop = true;
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "unrated",
            "*",
            "* *",
            "* * * ",
            "* * * * ",
            "* * * * *"});
            this.ratingComboBox.Location = new System.Drawing.Point(172, 184);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(151, 21);
            this.ratingComboBox.TabIndex = 15;
            this.ratingComboBox.SelectedIndexChanged += new System.EventHandler(this.ratingComboBox_SelectedIndexChanged);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Image = ((System.Drawing.Image)(resources.GetObject("addGenreButton.Image")));
            this.addGenreButton.Location = new System.Drawing.Point(330, 155);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(75, 23);
            this.addGenreButton.TabIndex = 16;
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // songTrackLengthTextBox
            // 
            this.songTrackLengthTextBox.Location = new System.Drawing.Point(172, 131);
            this.songTrackLengthTextBox.Name = "songTrackLengthTextBox";
            this.songTrackLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.songTrackLengthTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Track length";
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
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(330, 232);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(248, 232);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 20;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // trackNumberLabel
            // 
            this.trackNumberLabel.AutoSize = true;
            this.trackNumberLabel.Location = new System.Drawing.Point(93, 108);
            this.trackNumberLabel.Name = "trackNumberLabel";
            this.trackNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.trackNumberLabel.TabIndex = 23;
            this.trackNumberLabel.Text = "Track number";
            // 
            // songTrackNumberTextBox
            // 
            this.songTrackNumberTextBox.Location = new System.Drawing.Point(172, 105);
            this.songTrackNumberTextBox.Name = "songTrackNumberTextBox";
            this.songTrackNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.songTrackNumberTextBox.TabIndex = 22;
            // 
            // artistTableAdapter
            // 
            this.artistTableAdapter.ClearBeforeFill = true;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // albumTitleComboBox
            // 
            this.albumTitleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.albumBindingSource, "AlbumID", true));
            this.albumTitleComboBox.DataSource = this.albumBindingSource;
            this.albumTitleComboBox.DisplayMember = "AlbumTitle";
            this.albumTitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumTitleComboBox.FormattingEnabled = true;
            this.albumTitleComboBox.Location = new System.Drawing.Point(172, 76);
            this.albumTitleComboBox.Name = "albumTitleComboBox";
            this.albumTitleComboBox.Size = new System.Drawing.Size(151, 21);
            this.albumTitleComboBox.TabIndex = 24;
            this.albumTitleComboBox.ValueMember = "AlbumID";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "Album";
            this.albumBindingSource.DataSource = this.cDCatalogAlbum;
            // 
            // cDCatalogAlbum
            // 
            this.cDCatalogAlbum.DataSetName = "CDCatalogAlbum";
            this.cDCatalogAlbum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Location = new System.Drawing.Point(93, 84);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(59, 13);
            this.albumTitleLabel.TabIndex = 25;
            this.albumTitleLabel.Text = "Album Title";
            // 
            // addAlbumTitleButton
            // 
            this.addAlbumTitleButton.Image = ((System.Drawing.Image)(resources.GetObject("addAlbumTitleButton.Image")));
            this.addAlbumTitleButton.Location = new System.Drawing.Point(329, 74);
            this.addAlbumTitleButton.Name = "addAlbumTitleButton";
            this.addAlbumTitleButton.Size = new System.Drawing.Size(75, 23);
            this.addAlbumTitleButton.TabIndex = 26;
            this.addAlbumTitleButton.UseVisualStyleBackColor = true;
            this.addAlbumTitleButton.Click += new System.EventHandler(this.addAlbumTitleButton_Click);
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // AddSongWF
            // 
            this.AcceptButton = this.OkButton;
            this.AccessibleDescription = "Use this form to add a song";
            this.AccessibleName = "Add Song";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(422, 278);
            this.Controls.Add(this.addAlbumTitleButton);
            this.Controls.Add(this.albumTitleLabel);
            this.Controls.Add(this.albumTitleComboBox);
            this.Controls.Add(this.trackNumberLabel);
            this.Controls.Add(this.songTrackNumberTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songTrackLengthTextBox);
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
            this.Load += new System.EventHandler(this.AddSongWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogAlbum)).EndInit();
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
        private System.Windows.Forms.TextBox songTrackLengthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label trackNumberLabel;
        private System.Windows.Forms.TextBox songTrackNumberTextBox;
        private CDCatalogDataSet2 cDCatalogDataSet2;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private CDCatalogDataSet2TableAdapters.ArtistTableAdapter artistTableAdapter;
        private System.Windows.Forms.BindingSource cDCatalogDataSet3BindingSource;
        private CDCatalogDataSet3 cDCatalogDataSet3;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private CDCatalogDataSet3TableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.ComboBox albumTitleComboBox;
        private System.Windows.Forms.Label albumTitleLabel;
        private System.Windows.Forms.Button addAlbumTitleButton;
        private CDCatalogAlbum cDCatalogAlbum;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private CDCatalogAlbumTableAdapters.AlbumTableAdapter albumTableAdapter;
    }
}