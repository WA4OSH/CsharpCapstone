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
            this.songDataGridView = new System.Windows.Forms.DataGridView();
            this.artistNameDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songTitleDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumTitleDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackNumberDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songTrackLengthDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songRatingDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIdDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songIdDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // songDataGridView
            // 
            this.songDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDG,
            this.songTitleDG,
            this.albumTitleDG,
            this.trackNumberDG,
            this.genreNameDG,
            this.songTrackLengthDG,
            this.songRatingDG,
            this.artistIdDG,
            this.songIdDG,
            this.genreIdDG});
            this.songDataGridView.Location = new System.Drawing.Point(12, 128);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.Size = new System.Drawing.Size(856, 311);
            this.songDataGridView.TabIndex = 0;
            // 
            // artistNameDG
            // 
            this.artistNameDG.HeaderText = "Artist Name";
            this.artistNameDG.Name = "artistNameDG";
            // 
            // songTitleDG
            // 
            this.songTitleDG.HeaderText = "Song Title";
            this.songTitleDG.Name = "songTitleDG";
            // 
            // albumTitleDG
            // 
            this.albumTitleDG.HeaderText = "Album Title";
            this.albumTitleDG.Name = "albumTitleDG";
            // 
            // trackNumberDG
            // 
            this.trackNumberDG.HeaderText = "Track Number";
            this.trackNumberDG.Name = "trackNumberDG";
            // 
            // genreNameDG
            // 
            this.genreNameDG.HeaderText = "Genre Name";
            this.genreNameDG.Name = "genreNameDG";
            // 
            // songTrackLengthDG
            // 
            this.songTrackLengthDG.HeaderText = "MM:SS";
            this.songTrackLengthDG.Name = "songTrackLengthDG";
            // 
            // songRatingDG
            // 
            this.songRatingDG.HeaderText = "Rating";
            this.songRatingDG.Name = "songRatingDG";
            // 
            // artistIdDG
            // 
            this.artistIdDG.HeaderText = "Artist ID";
            this.artistIdDG.Name = "artistIdDG";
            // 
            // songIdDG
            // 
            this.songIdDG.HeaderText = "Song ID";
            this.songIdDG.Name = "songIdDG";
            // 
            // genreIdDG
            // 
            this.genreIdDG.HeaderText = "Genre ID";
            this.genreIdDG.Name = "genreIdDG";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 451);
            this.Controls.Add(this.songDataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView songDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTitleDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumTitleDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackNumberDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreNameDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTrackLengthDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn songRatingDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDG;
    }
}