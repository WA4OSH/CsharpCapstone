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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet = new CDCatalogWF.CDCatalogDataSet();
            this.albumViewTableAdapter = new CDCatalogWF.CDCatalogDataSetTableAdapters.AlbumViewTableAdapter();
            this.albumPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.songPictureBox = new System.Windows.Forms.PictureBox();
            this.songDeleteButton = new System.Windows.Forms.Button();
            this.songEditButton = new System.Windows.Forms.Button();
            this.addSongButton = new System.Windows.Forms.Button();
            this.albumViewPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteAlbumButton = new System.Windows.Forms.Button();
            this.changeAlbumButton = new System.Windows.Forms.Button();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.cdCatalogPictureBox = new System.Windows.Forms.PictureBox();
            this.selectViewGroupBox = new System.Windows.Forms.GroupBox();
            this.songViewRadioButton = new System.Windows.Forms.RadioButton();
            this.albumViewButton = new System.Windows.Forms.RadioButton();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.playListGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cDCatalogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet1 = new CDCatalogWF.CDCatalogDataSet1();
            this.songViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songViewTableAdapter = new CDCatalogWF.CDCatalogDataSet1TableAdapters.SongViewTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet)).BeginInit();
            this.albumPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumViewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdCatalogPictureBox)).BeginInit();
            this.selectViewGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.playListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDataGridViewTextBoxColumn,
            this.albumTitleDataGridViewTextBoxColumn,
            this.albumYearDataGridViewTextBoxColumn,
            this.genreNameDataGridViewTextBoxColumn,
            this.albumRatingDataGridViewTextBoxColumn,
            this.artistIDDataGridViewTextBoxColumn,
            this.albumIDDataGridViewTextBoxColumn,
            this.genreIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.albumViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 304);
            this.dataGridView1.TabIndex = 0;
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
            // albumPanel
            // 
            this.albumPanel.Controls.Add(this.panel1);
            this.albumPanel.Controls.Add(this.albumViewPictureBox);
            this.albumPanel.Controls.Add(this.DeleteAlbumButton);
            this.albumPanel.Controls.Add(this.changeAlbumButton);
            this.albumPanel.Controls.Add(this.addAlbumButton);
            this.albumPanel.Controls.Add(this.dataGridView1);
            this.albumPanel.Location = new System.Drawing.Point(25, 111);
            this.albumPanel.Name = "albumPanel";
            this.albumPanel.Size = new System.Drawing.Size(853, 420);
            this.albumPanel.TabIndex = 1;
            this.albumPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.albumPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.songPictureBox);
            this.panel1.Controls.Add(this.songDeleteButton);
            this.panel1.Controls.Add(this.songEditButton);
            this.panel1.Controls.Add(this.addSongButton);
            this.panel1.Location = new System.Drawing.Point(-27, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 397);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView2.DataSource = this.songViewBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(27, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(840, 319);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // songPictureBox
            // 
            this.songPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("songPictureBox.Image")));
            this.songPictureBox.Location = new System.Drawing.Point(800, 0);
            this.songPictureBox.Name = "songPictureBox";
            this.songPictureBox.Size = new System.Drawing.Size(67, 19);
            this.songPictureBox.TabIndex = 3;
            this.songPictureBox.TabStop = false;
            // 
            // songDeleteButton
            // 
            this.songDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("songDeleteButton.Image")));
            this.songDeleteButton.Location = new System.Drawing.Point(186, -1);
            this.songDeleteButton.Name = "songDeleteButton";
            this.songDeleteButton.Size = new System.Drawing.Size(75, 61);
            this.songDeleteButton.TabIndex = 2;
            this.songDeleteButton.UseVisualStyleBackColor = true;
            // 
            // songEditButton
            // 
            this.songEditButton.Image = ((System.Drawing.Image)(resources.GetObject("songEditButton.Image")));
            this.songEditButton.Location = new System.Drawing.Point(108, -3);
            this.songEditButton.Name = "songEditButton";
            this.songEditButton.Size = new System.Drawing.Size(75, 62);
            this.songEditButton.TabIndex = 1;
            this.songEditButton.UseVisualStyleBackColor = true;
            // 
            // addSongButton
            // 
            this.addSongButton.Image = ((System.Drawing.Image)(resources.GetObject("addSongButton.Image")));
            this.addSongButton.Location = new System.Drawing.Point(27, -2);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(75, 61);
            this.addSongButton.TabIndex = 0;
            this.addSongButton.UseVisualStyleBackColor = true;
            // 
            // albumViewPictureBox
            // 
            this.albumViewPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("albumViewPictureBox.Image")));
            this.albumViewPictureBox.Location = new System.Drawing.Point(788, 3);
            this.albumViewPictureBox.Name = "albumViewPictureBox";
            this.albumViewPictureBox.Size = new System.Drawing.Size(64, 20);
            this.albumViewPictureBox.TabIndex = 4;
            this.albumViewPictureBox.TabStop = false;
            // 
            // DeleteAlbumButton
            // 
            this.DeleteAlbumButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAlbumButton.Image")));
            this.DeleteAlbumButton.Location = new System.Drawing.Point(171, 3);
            this.DeleteAlbumButton.Name = "DeleteAlbumButton";
            this.DeleteAlbumButton.Size = new System.Drawing.Size(75, 57);
            this.DeleteAlbumButton.TabIndex = 3;
            this.DeleteAlbumButton.Text = "Delete Album";
            this.DeleteAlbumButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteAlbumButton.UseVisualStyleBackColor = true;
            // 
            // changeAlbumButton
            // 
            this.changeAlbumButton.Image = ((System.Drawing.Image)(resources.GetObject("changeAlbumButton.Image")));
            this.changeAlbumButton.Location = new System.Drawing.Point(90, 3);
            this.changeAlbumButton.Name = "changeAlbumButton";
            this.changeAlbumButton.Size = new System.Drawing.Size(75, 57);
            this.changeAlbumButton.TabIndex = 2;
            this.changeAlbumButton.Text = "Edit Album";
            this.changeAlbumButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.changeAlbumButton.UseVisualStyleBackColor = true;
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Image = ((System.Drawing.Image)(resources.GetObject("addAlbumButton.Image")));
            this.addAlbumButton.Location = new System.Drawing.Point(12, 3);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(72, 58);
            this.addAlbumButton.TabIndex = 1;
            this.addAlbumButton.Text = "Add Album";
            this.addAlbumButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addAlbumButton.UseVisualStyleBackColor = true;
            // 
            // cdCatalogPictureBox
            // 
            this.cdCatalogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cdCatalogPictureBox.Image")));
            this.cdCatalogPictureBox.Location = new System.Drawing.Point(25, 12);
            this.cdCatalogPictureBox.Name = "cdCatalogPictureBox";
            this.cdCatalogPictureBox.Size = new System.Drawing.Size(234, 93);
            this.cdCatalogPictureBox.TabIndex = 2;
            this.cdCatalogPictureBox.TabStop = false;
            // 
            // selectViewGroupBox
            // 
            this.selectViewGroupBox.Controls.Add(this.songViewRadioButton);
            this.selectViewGroupBox.Controls.Add(this.albumViewButton);
            this.selectViewGroupBox.Location = new System.Drawing.Point(266, 12);
            this.selectViewGroupBox.Name = "selectViewGroupBox";
            this.selectViewGroupBox.Size = new System.Drawing.Size(178, 93);
            this.selectViewGroupBox.TabIndex = 3;
            this.selectViewGroupBox.TabStop = false;
            this.selectViewGroupBox.Text = "Select View";
            // 
            // songViewRadioButton
            // 
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
            this.searchGroupBox.Controls.Add(this.button1);
            this.searchGroupBox.Location = new System.Drawing.Point(450, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(209, 96);
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
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(128, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // playListGroupBox
            // 
            this.playListGroupBox.Controls.Add(this.button2);
            this.playListGroupBox.Controls.Add(this.timeLabel);
            this.playListGroupBox.Controls.Add(this.genreLabel);
            this.playListGroupBox.Controls.Add(this.comboBox1);
            this.playListGroupBox.Controls.Add(this.textBox3);
            this.playListGroupBox.Location = new System.Drawing.Point(665, 12);
            this.playListGroupBox.Name = "playListGroupBox";
            this.playListGroupBox.Size = new System.Drawing.Size(200, 96);
            this.playListGroupBox.TabIndex = 5;
            this.playListGroupBox.TabStop = false;
            this.playListGroupBox.Text = "Create Play List";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(125, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
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
            // cDCatalogDataSet1
            // 
            this.cDCatalogDataSet1.DataSetName = "CDCatalogDataSet1";
            this.cDCatalogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songViewBindingSource
            // 
            this.songViewBindingSource.DataMember = "SongView";
            this.songViewBindingSource.DataSource = this.cDCatalogDataSet1;
            // 
            // songViewTableAdapter
            // 
            this.songViewTableAdapter.ClearBeforeFill = true;
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
            this.ClientSize = new System.Drawing.Size(892, 538);
            this.Controls.Add(this.playListGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.selectViewGroupBox);
            this.Controls.Add(this.cdCatalogPictureBox);
            this.Controls.Add(this.albumPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet)).EndInit();
            this.albumPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumViewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdCatalogPictureBox)).EndInit();
            this.selectViewGroupBox.ResumeLayout(false);
            this.selectViewGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.playListGroupBox.ResumeLayout(false);
            this.playListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CDCatalogDataSet cDCatalogDataSet;
        private System.Windows.Forms.BindingSource albumViewBindingSource;
        private CDCatalogDataSetTableAdapters.AlbumViewTableAdapter albumViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel albumPanel;
        private System.Windows.Forms.Button changeAlbumButton;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button DeleteAlbumButton;
        private System.Windows.Forms.PictureBox cdCatalogPictureBox;
        private System.Windows.Forms.GroupBox selectViewGroupBox;
        private System.Windows.Forms.RadioButton songViewRadioButton;
        private System.Windows.Forms.RadioButton albumViewButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.GroupBox playListGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox songPictureBox;
        private System.Windows.Forms.Button songDeleteButton;
        private System.Windows.Forms.Button songEditButton;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.PictureBox albumViewPictureBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource cDCatalogDataSetBindingSource;
        private System.Windows.Forms.BindingSource cDCatalogDataSetBindingSource1;
        private CDCatalogDataSet1 cDCatalogDataSet1;
        private System.Windows.Forms.BindingSource songViewBindingSource;
        private CDCatalogDataSet1TableAdapters.SongViewTableAdapter songViewTableAdapter;
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