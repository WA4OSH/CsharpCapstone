namespace CDCatalogWF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.albumViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet = new CDCatalogWF.CDCatalogDataSet();
            this.albumViewTableAdapter = new CDCatalogWF.CDCatalogDataSetTableAdapters.AlbumViewTableAdapter();
            this.songViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet1 = new CDCatalogWF.CDCatalogDataSet1();
            this.deleteAlbumButton = new System.Windows.Forms.Button();
            this.changeAlbumButton = new System.Windows.Forms.Button();
            this.deleteSongButton = new System.Windows.Forms.Button();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.changeSongButton = new System.Windows.Forms.Button();
            this.addSongButton = new System.Windows.Forms.Button();
            this.cdCatalogPictureBox = new System.Windows.Forms.PictureBox();
            this.selectViewGroupBox = new System.Windows.Forms.GroupBox();
            this.songViewRadioButton = new System.Windows.Forms.RadioButton();
            this.albumViewButton = new System.Windows.Forms.RadioButton();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.playListGroupBox = new System.Windows.Forms.GroupBox();
            this.playListButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cDCatalogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.songViewTableAdapter = new CDCatalogWF.CDCatalogDataSet1TableAdapters.SongViewTableAdapter();
            this.addArtistButton = new System.Windows.Forms.Button();
            this.changeArtistButton = new System.Windows.Forms.Button();
            this.deleteArtistButton = new System.Windows.Forms.Button();
            this.genreAddButton = new System.Windows.Forms.Button();
            this.genreChangeButton = new System.Windows.Forms.Button();
            this.genreDeleteButton = new System.Windows.Forms.Button();
            this.smallAlbumPanel = new System.Windows.Forms.Panel();
            this.albumDataGridView = new System.Windows.Forms.DataGridView();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songDataGridView = new System.Windows.Forms.DataGridView();
            this.artistNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songTrackNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songTrackLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumTitleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.albumViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdCatalogPictureBox)).BeginInit();
            this.selectViewGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.playListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSetBindingSource1)).BeginInit();
            this.smallAlbumPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // albumViewBindingSource
            // 
            this.albumViewBindingSource.DataMember = "AlbumView";
            this.albumViewBindingSource.DataSource = this.cDCatalogDataSet;
            // 
            // cDCatalogDataSet
            // 
            this.cDCatalogDataSet.DataSetName = "CDCatalogDataSet";
            this.cDCatalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumViewTableAdapter
            // 
            this.albumViewTableAdapter.ClearBeforeFill = true;
            // 
            // songViewBindingSource
            // 
            this.songViewBindingSource.DataMember = "SongView";
            this.songViewBindingSource.DataSource = this.cDCatalogDataSet1;
            // 
            // cDCatalogDataSet1
            // 
            this.cDCatalogDataSet1.DataSetName = "CDCatalogDataSet1";
            this.cDCatalogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteAlbumButton
            // 
            this.deleteAlbumButton.AccessibleDescription = "Delete Album Button";
            this.deleteAlbumButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteAlbumButton.Image")));
            this.deleteAlbumButton.Location = new System.Drawing.Point(162, 0);
            this.deleteAlbumButton.Name = "deleteAlbumButton";
            this.deleteAlbumButton.Size = new System.Drawing.Size(75, 60);
            this.deleteAlbumButton.TabIndex = 3;
            this.deleteAlbumButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteAlbumButton.UseVisualStyleBackColor = true;
            this.deleteAlbumButton.Click += new System.EventHandler(this.DeleteAlbumButton_Click);
            // 
            // changeAlbumButton
            // 
            this.changeAlbumButton.AccessibleDescription = "Change Album Radio Button";
            this.changeAlbumButton.Image = ((System.Drawing.Image)(resources.GetObject("changeAlbumButton.Image")));
            this.changeAlbumButton.Location = new System.Drawing.Point(81, 0);
            this.changeAlbumButton.Name = "changeAlbumButton";
            this.changeAlbumButton.Size = new System.Drawing.Size(75, 60);
            this.changeAlbumButton.TabIndex = 2;
            this.changeAlbumButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.changeAlbumButton.UseVisualStyleBackColor = true;
            this.changeAlbumButton.Click += new System.EventHandler(this.changeAlbumButton_Click);
            // 
            // deleteSongButton
            // 
            this.deleteSongButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteSongButton.Image")));
            this.deleteSongButton.Location = new System.Drawing.Point(187, 108);
            this.deleteSongButton.Name = "deleteSongButton";
            this.deleteSongButton.Size = new System.Drawing.Size(75, 60);
            this.deleteSongButton.TabIndex = 2;
            this.deleteSongButton.UseVisualStyleBackColor = true;
            this.deleteSongButton.Click += new System.EventHandler(this.songDeleteButton_Click);
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.AccessibleDescription = "Add Album Radio Button";
            this.addAlbumButton.Image = ((System.Drawing.Image)(resources.GetObject("addAlbumButton.Image")));
            this.addAlbumButton.Location = new System.Drawing.Point(0, 0);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(75, 60);
            this.addAlbumButton.TabIndex = 1;
            this.addAlbumButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // changeSongButton
            // 
            this.changeSongButton.Image = ((System.Drawing.Image)(resources.GetObject("changeSongButton.Image")));
            this.changeSongButton.Location = new System.Drawing.Point(106, 108);
            this.changeSongButton.Name = "changeSongButton";
            this.changeSongButton.Size = new System.Drawing.Size(75, 60);
            this.changeSongButton.TabIndex = 1;
            this.changeSongButton.UseVisualStyleBackColor = true;
            this.changeSongButton.Click += new System.EventHandler(this.songEditButton_Click);
            // 
            // addSongButton
            // 
            this.addSongButton.Image = ((System.Drawing.Image)(resources.GetObject("addSongButton.Image")));
            this.addSongButton.Location = new System.Drawing.Point(25, 108);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(75, 60);
            this.addSongButton.TabIndex = 0;
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // cdCatalogPictureBox
            // 
            this.cdCatalogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cdCatalogPictureBox.Image")));
            this.cdCatalogPictureBox.Location = new System.Drawing.Point(25, 12);
            this.cdCatalogPictureBox.Name = "cdCatalogPictureBox";
            this.cdCatalogPictureBox.Size = new System.Drawing.Size(237, 90);
            this.cdCatalogPictureBox.TabIndex = 2;
            this.cdCatalogPictureBox.TabStop = false;
            // 
            // selectViewGroupBox
            // 
            this.selectViewGroupBox.Controls.Add(this.songViewRadioButton);
            this.selectViewGroupBox.Controls.Add(this.albumViewButton);
            this.selectViewGroupBox.Location = new System.Drawing.Point(268, 9);
            this.selectViewGroupBox.Name = "selectViewGroupBox";
            this.selectViewGroupBox.Size = new System.Drawing.Size(184, 93);
            this.selectViewGroupBox.TabIndex = 3;
            this.selectViewGroupBox.TabStop = false;
            this.selectViewGroupBox.Text = "Select View";
            // 
            // songViewRadioButton
            // 
            this.songViewRadioButton.AccessibleDescription = "Song View Radio Button";
            this.songViewRadioButton.AutoSize = true;
            this.songViewRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("songViewRadioButton.Image")));
            this.songViewRadioButton.Location = new System.Drawing.Point(89, 21);
            this.songViewRadioButton.Name = "songViewRadioButton";
            this.songViewRadioButton.Size = new System.Drawing.Size(77, 55);
            this.songViewRadioButton.TabIndex = 1;
            this.songViewRadioButton.TabStop = true;
            this.songViewRadioButton.Text = "Song";
            this.songViewRadioButton.UseVisualStyleBackColor = true;
            this.songViewRadioButton.CheckedChanged += new System.EventHandler(this.songViewRadioButton_CheckedChanged);
            // 
            // albumViewButton
            // 
            this.albumViewButton.AccessibleDescription = "albumViewRadio Button";
            this.albumViewButton.AutoSize = true;
            this.albumViewButton.Image = ((System.Drawing.Image)(resources.GetObject("albumViewButton.Image")));
            this.albumViewButton.Location = new System.Drawing.Point(6, 21);
            this.albumViewButton.Name = "albumViewButton";
            this.albumViewButton.Size = new System.Drawing.Size(77, 55);
            this.albumViewButton.TabIndex = 0;
            this.albumViewButton.TabStop = true;
            this.albumViewButton.Text = "Album";
            this.albumViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.albumViewButton.UseVisualStyleBackColor = true;
            this.albumViewButton.CheckedChanged += new System.EventHandler(this.albumViewButton_CheckedChanged);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.textBox1);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Location = new System.Drawing.Point(458, 9);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(209, 93);
            this.searchGroupBox.TabIndex = 4;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search in View";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Search Words";
            // 
            // searchButton
            // 
            this.searchButton.AccessibleDescription = "Search Button";
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(128, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 65);
            this.searchButton.TabIndex = 0;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // playListGroupBox
            // 
            this.playListGroupBox.Controls.Add(this.playListButton);
            this.playListGroupBox.Controls.Add(this.timeLabel);
            this.playListGroupBox.Controls.Add(this.genreLabel);
            this.playListGroupBox.Controls.Add(this.comboBox1);
            this.playListGroupBox.Controls.Add(this.textBox3);
            this.playListGroupBox.Location = new System.Drawing.Point(673, 9);
            this.playListGroupBox.Name = "playListGroupBox";
            this.playListGroupBox.Size = new System.Drawing.Size(203, 93);
            this.playListGroupBox.TabIndex = 5;
            this.playListGroupBox.TabStop = false;
            this.playListGroupBox.Text = "Create Play List";
            // 
            // playListButton
            // 
            this.playListButton.Image = ((System.Drawing.Image)(resources.GetObject("playListButton.Image")));
            this.playListButton.Location = new System.Drawing.Point(125, 21);
            this.playListButton.Name = "playListButton";
            this.playListButton.Size = new System.Drawing.Size(75, 60);
            this.playListButton.TabIndex = 7;
            this.playListButton.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(6, 58);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(6, 21);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 5;
            this.genreLabel.Text = "Genre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 20);
            this.textBox3.TabIndex = 2;
            // 
            // cDCatalogDataSetBindingSource
            // 
            this.cDCatalogDataSetBindingSource.DataSource = this.cDCatalogDataSet;
            this.cDCatalogDataSetBindingSource.Position = 0;
            // 
            // cDCatalogDataSetBindingSource1
            // 
            this.cDCatalogDataSetBindingSource1.DataSource = this.cDCatalogDataSet;
            this.cDCatalogDataSetBindingSource1.Position = 0;
            // 
            // songViewTableAdapter
            // 
            this.songViewTableAdapter.ClearBeforeFill = true;
            // 
            // addArtistButton
            // 
            this.addArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("addArtistButton.Image")));
            this.addArtistButton.Location = new System.Drawing.Point(268, 108);
            this.addArtistButton.Name = "addArtistButton";
            this.addArtistButton.Size = new System.Drawing.Size(75, 60);
            this.addArtistButton.TabIndex = 4;
            this.addArtistButton.UseVisualStyleBackColor = true;
            this.addArtistButton.Click += new System.EventHandler(this.artistAddButton_Click);
            // 
            // changeArtistButton
            // 
            this.changeArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("changeArtistButton.Image")));
            this.changeArtistButton.Location = new System.Drawing.Point(349, 108);
            this.changeArtistButton.Name = "changeArtistButton";
            this.changeArtistButton.Size = new System.Drawing.Size(75, 60);
            this.changeArtistButton.TabIndex = 5;
            this.changeArtistButton.UseVisualStyleBackColor = true;
            this.changeArtistButton.Click += new System.EventHandler(this.artistChangeButton_Click);
            // 
            // deleteArtistButton
            // 
            this.deleteArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteArtistButton.Image")));
            this.deleteArtistButton.Location = new System.Drawing.Point(430, 108);
            this.deleteArtistButton.Name = "deleteArtistButton";
            this.deleteArtistButton.Size = new System.Drawing.Size(75, 60);
            this.deleteArtistButton.TabIndex = 6;
            this.deleteArtistButton.UseVisualStyleBackColor = true;
            this.deleteArtistButton.Click += new System.EventHandler(this.artistDeleteButton_Click);
            // 
            // genreAddButton
            // 
            this.genreAddButton.Image = ((System.Drawing.Image)(resources.GetObject("genreAddButton.Image")));
            this.genreAddButton.Location = new System.Drawing.Point(511, 108);
            this.genreAddButton.Name = "genreAddButton";
            this.genreAddButton.Size = new System.Drawing.Size(75, 60);
            this.genreAddButton.TabIndex = 7;
            this.genreAddButton.UseVisualStyleBackColor = true;
            this.genreAddButton.Click += new System.EventHandler(this.GenreAddButton_Click);
            // 
            // genreChangeButton
            // 
            this.genreChangeButton.Image = ((System.Drawing.Image)(resources.GetObject("genreChangeButton.Image")));
            this.genreChangeButton.Location = new System.Drawing.Point(592, 108);
            this.genreChangeButton.Name = "genreChangeButton";
            this.genreChangeButton.Size = new System.Drawing.Size(75, 60);
            this.genreChangeButton.TabIndex = 8;
            this.genreChangeButton.UseVisualStyleBackColor = true;
            this.genreChangeButton.Click += new System.EventHandler(this.genreChangeButton_Click);
            // 
            // genreDeleteButton
            // 
            this.genreDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("genreDeleteButton.Image")));
            this.genreDeleteButton.Location = new System.Drawing.Point(673, 108);
            this.genreDeleteButton.Name = "genreDeleteButton";
            this.genreDeleteButton.Size = new System.Drawing.Size(75, 60);
            this.genreDeleteButton.TabIndex = 9;
            this.genreDeleteButton.UseVisualStyleBackColor = true;
            this.genreDeleteButton.Click += new System.EventHandler(this.genreDeleteButton_Click);
            // 
            // smallAlbumPanel
            // 
            this.smallAlbumPanel.BackColor = System.Drawing.SystemColors.Control;
            this.smallAlbumPanel.Controls.Add(this.changeAlbumButton);
            this.smallAlbumPanel.Controls.Add(this.deleteAlbumButton);
            this.smallAlbumPanel.Controls.Add(this.addAlbumButton);
            this.smallAlbumPanel.Location = new System.Drawing.Point(25, 108);
            this.smallAlbumPanel.Name = "smallAlbumPanel";
            this.smallAlbumPanel.Size = new System.Drawing.Size(237, 62);
            this.smallAlbumPanel.TabIndex = 10;
            // 
            // albumDataGridView
            // 
            this.albumDataGridView.AutoGenerateColumns = false;
            this.albumDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.albumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDataGridViewTextBoxColumn,
            this.albumTitleDataGridViewTextBoxColumn,
            this.albumYearDataGridViewTextBoxColumn,
            this.genreNameDataGridViewTextBoxColumn,
            this.albumRatingDataGridViewTextBoxColumn,
            this.artistIDDataGridViewTextBoxColumn,
            this.albumIDDataGridViewTextBoxColumn,
            this.genreIDDataGridViewTextBoxColumn});
            this.albumDataGridView.DataSource = this.albumViewBindingSource;
            this.albumDataGridView.Location = new System.Drawing.Point(25, 176);
            this.albumDataGridView.Name = "albumDataGridView";
            this.albumDataGridView.Size = new System.Drawing.Size(851, 350);
            this.albumDataGridView.TabIndex = 0;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            // 
            // albumTitleDataGridViewTextBoxColumn
            // 
            this.albumTitleDataGridViewTextBoxColumn.DataPropertyName = "AlbumTitle";
            this.albumTitleDataGridViewTextBoxColumn.HeaderText = "AlbumTitle";
            this.albumTitleDataGridViewTextBoxColumn.Name = "albumTitleDataGridViewTextBoxColumn";
            // 
            // albumYearDataGridViewTextBoxColumn
            // 
            this.albumYearDataGridViewTextBoxColumn.DataPropertyName = "AlbumYear";
            this.albumYearDataGridViewTextBoxColumn.HeaderText = "AlbumYear";
            this.albumYearDataGridViewTextBoxColumn.Name = "albumYearDataGridViewTextBoxColumn";
            // 
            // genreNameDataGridViewTextBoxColumn
            // 
            this.genreNameDataGridViewTextBoxColumn.DataPropertyName = "GenreName";
            this.genreNameDataGridViewTextBoxColumn.HeaderText = "GenreName";
            this.genreNameDataGridViewTextBoxColumn.Name = "genreNameDataGridViewTextBoxColumn";
            // 
            // albumRatingDataGridViewTextBoxColumn
            // 
            this.albumRatingDataGridViewTextBoxColumn.DataPropertyName = "AlbumRating";
            this.albumRatingDataGridViewTextBoxColumn.HeaderText = "AlbumRating";
            this.albumRatingDataGridViewTextBoxColumn.Name = "albumRatingDataGridViewTextBoxColumn";
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            // 
            // albumIDDataGridViewTextBoxColumn
            // 
            this.albumIDDataGridViewTextBoxColumn.DataPropertyName = "AlbumID";
            this.albumIDDataGridViewTextBoxColumn.HeaderText = "AlbumID";
            this.albumIDDataGridViewTextBoxColumn.Name = "albumIDDataGridViewTextBoxColumn";
            // 
            // genreIDDataGridViewTextBoxColumn
            // 
            this.genreIDDataGridViewTextBoxColumn.DataPropertyName = "GenreID";
            this.genreIDDataGridViewTextBoxColumn.HeaderText = "GenreID";
            this.genreIDDataGridViewTextBoxColumn.Name = "genreIDDataGridViewTextBoxColumn";
            // 
            // songDataGridView
            // 
            this.songDataGridView.AutoGenerateColumns = false;
            this.songDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.songDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDataGridViewTextBoxColumn1,
            this.songTitleDataGridViewTextBoxColumn,
            this.songTrackNumberDataGridViewTextBoxColumn,
            this.genreNameDataGridViewTextBoxColumn1,
            this.songTrackLengthDataGridViewTextBoxColumn,
            this.songRatingDataGridViewTextBoxColumn,
            this.albumTitleDataGridViewTextBoxColumn1,
            this.albumIDDataGridViewTextBoxColumn1,
            this.artistIDDataGridViewTextBoxColumn1,
            this.genreIDDataGridViewTextBoxColumn1,
            this.songIDDataGridViewTextBoxColumn});
            this.songDataGridView.DataSource = this.songViewBindingSource;
            this.songDataGridView.Location = new System.Drawing.Point(25, 176);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.Size = new System.Drawing.Size(851, 350);
            this.songDataGridView.TabIndex = 4;
            // 
            // artistNameDataGridViewTextBoxColumn1
            // 
            this.artistNameDataGridViewTextBoxColumn1.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn1.HeaderText = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn1.Name = "artistNameDataGridViewTextBoxColumn1";
            // 
            // songTitleDataGridViewTextBoxColumn
            // 
            this.songTitleDataGridViewTextBoxColumn.DataPropertyName = "SongTitle";
            this.songTitleDataGridViewTextBoxColumn.HeaderText = "SongTitle";
            this.songTitleDataGridViewTextBoxColumn.Name = "songTitleDataGridViewTextBoxColumn";
            // 
            // songTrackNumberDataGridViewTextBoxColumn
            // 
            this.songTrackNumberDataGridViewTextBoxColumn.DataPropertyName = "SongTrackNumber";
            this.songTrackNumberDataGridViewTextBoxColumn.HeaderText = "SongTrackNumber";
            this.songTrackNumberDataGridViewTextBoxColumn.Name = "songTrackNumberDataGridViewTextBoxColumn";
            // 
            // genreNameDataGridViewTextBoxColumn1
            // 
            this.genreNameDataGridViewTextBoxColumn1.DataPropertyName = "GenreName";
            this.genreNameDataGridViewTextBoxColumn1.HeaderText = "GenreName";
            this.genreNameDataGridViewTextBoxColumn1.Name = "genreNameDataGridViewTextBoxColumn1";
            // 
            // songTrackLengthDataGridViewTextBoxColumn
            // 
            this.songTrackLengthDataGridViewTextBoxColumn.DataPropertyName = "SongTrackLength";
            this.songTrackLengthDataGridViewTextBoxColumn.HeaderText = "SongTrackLength";
            this.songTrackLengthDataGridViewTextBoxColumn.Name = "songTrackLengthDataGridViewTextBoxColumn";
            // 
            // songRatingDataGridViewTextBoxColumn
            // 
            this.songRatingDataGridViewTextBoxColumn.DataPropertyName = "SongRating";
            this.songRatingDataGridViewTextBoxColumn.HeaderText = "SongRating";
            this.songRatingDataGridViewTextBoxColumn.Name = "songRatingDataGridViewTextBoxColumn";
            // 
            // albumTitleDataGridViewTextBoxColumn1
            // 
            this.albumTitleDataGridViewTextBoxColumn1.DataPropertyName = "AlbumTitle";
            this.albumTitleDataGridViewTextBoxColumn1.HeaderText = "AlbumTitle";
            this.albumTitleDataGridViewTextBoxColumn1.Name = "albumTitleDataGridViewTextBoxColumn1";
            // 
            // albumIDDataGridViewTextBoxColumn1
            // 
            this.albumIDDataGridViewTextBoxColumn1.DataPropertyName = "AlbumID";
            this.albumIDDataGridViewTextBoxColumn1.HeaderText = "AlbumID";
            this.albumIDDataGridViewTextBoxColumn1.Name = "albumIDDataGridViewTextBoxColumn1";
            // 
            // artistIDDataGridViewTextBoxColumn1
            // 
            this.artistIDDataGridViewTextBoxColumn1.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn1.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn1.Name = "artistIDDataGridViewTextBoxColumn1";
            // 
            // genreIDDataGridViewTextBoxColumn1
            // 
            this.genreIDDataGridViewTextBoxColumn1.DataPropertyName = "GenreID";
            this.genreIDDataGridViewTextBoxColumn1.HeaderText = "GenreID";
            this.genreIDDataGridViewTextBoxColumn1.Name = "genreIDDataGridViewTextBoxColumn1";
            // 
            // songIDDataGridViewTextBoxColumn
            // 
            this.songIDDataGridViewTextBoxColumn.DataPropertyName = "SongID";
            this.songIDDataGridViewTextBoxColumn.HeaderText = "SongID";
            this.songIDDataGridViewTextBoxColumn.Name = "songIDDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 538);
            this.Controls.Add(this.albumDataGridView);
            this.Controls.Add(this.genreDeleteButton);
            this.Controls.Add(this.songDataGridView);
            this.Controls.Add(this.smallAlbumPanel);
            this.Controls.Add(this.deleteSongButton);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.changeSongButton);
            this.Controls.Add(this.genreChangeButton);
            this.Controls.Add(this.genreAddButton);
            this.Controls.Add(this.deleteArtistButton);
            this.Controls.Add(this.changeArtistButton);
            this.Controls.Add(this.addArtistButton);
            this.Controls.Add(this.playListGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.selectViewGroupBox);
            this.Controls.Add(this.cdCatalogPictureBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdCatalogPictureBox)).EndInit();
            this.selectViewGroupBox.ResumeLayout(false);
            this.selectViewGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.playListGroupBox.ResumeLayout(false);
            this.playListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSetBindingSource1)).EndInit();
            this.smallAlbumPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CDCatalogDataSet cDCatalogDataSet;
        private System.Windows.Forms.BindingSource albumViewBindingSource;
        private CDCatalogDataSetTableAdapters.AlbumViewTableAdapter albumViewTableAdapter;
        private System.Windows.Forms.Button changeAlbumButton;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button deleteAlbumButton;
        private System.Windows.Forms.PictureBox cdCatalogPictureBox;
        private System.Windows.Forms.GroupBox selectViewGroupBox;
        private System.Windows.Forms.RadioButton songViewRadioButton;
        private System.Windows.Forms.RadioButton albumViewButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.GroupBox playListGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button playListButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button deleteSongButton;
        private System.Windows.Forms.Button changeSongButton;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.BindingSource cDCatalogDataSetBindingSource;
        private System.Windows.Forms.BindingSource cDCatalogDataSetBindingSource1;
        private CDCatalogDataSet1 cDCatalogDataSet1;
        private System.Windows.Forms.BindingSource songViewBindingSource;
        private CDCatalogDataSet1TableAdapters.SongViewTableAdapter songViewTableAdapter;
        private System.Windows.Forms.Panel smallAlbumPanel;
        private System.Windows.Forms.Button genreDeleteButton;
        private System.Windows.Forms.Button addArtistButton;
        private System.Windows.Forms.Button changeArtistButton;
        private System.Windows.Forms.Button deleteArtistButton;
        private System.Windows.Forms.Button genreAddButton;
        private System.Windows.Forms.Button genreChangeButton;
        private System.Windows.Forms.DataGridView albumDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView songDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTrackNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTrackLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumTitleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIDDataGridViewTextBoxColumn;


    }
}