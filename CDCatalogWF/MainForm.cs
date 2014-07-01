namespace CDCatalogWF
{
    using CDCatalogDA;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;
 
    /// <summary>
    /// 
    /// </summary>
    public partial class MainForm : Form
    {
        private enum gridViewSt { Album, Song };

        private static int _gridViewState;  // 0=default(Album) 1=Album 2=Song

        public static int gridViewState
        {
            get { return _gridViewState; }
            set { _gridViewState = (int)gridViewSt.Album; } 
        }

        private enum searchSt { Album, Song, Genre };

        private static DataGridViewRow albumRow;

        private static DataGridViewRow songRow;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize both datagrids -- SongView and AlbumView
            
            this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
            this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);

            // the following did not work with selecting a row and did not fill the entire grid (of course): 
            // List<CDCatalogEF.Album> albumList = Album.GetAllAlbums();
            // this.albumDataGridView.DataSource = albumList;

            // List<CDCatalogEF.Song> songList = Song.GetAllSongs();
            // this.songDataGridView.DataSource = songList;

            // the albumViewButton radiobutton is selected first
            albumViewButton.Checked = true;
            _gridViewState = (int)gridViewSt.Album;
            searchComboBox.SelectedIndex = (int)gridViewSt.Album; 
            songOrAlbumRatingLabel.Text = "Album";

            // Show albumDataGridView as default
            albumDataGridView.Visible = true;
            songDataGridView.Visible = false;

            // albumGroupBox hides songGroupBox
            albumGroupBox.Visible = true;
            songGroupBox.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void albumViewButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set the current state
            _gridViewState = (int)gridViewSt.Album;
            songOrAlbumRatingLabel.Text = "Album";
            searchComboBox.SelectedIndex = (int)gridViewSt.Album;

            // Show songDataGridView
            albumDataGridView.Visible = true;
            songDataGridView.Visible = false;

            // albumGroupBox hides songGroupBox
            albumGroupBox.Visible = true;
            songGroupBox.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void songViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set the current state
            _gridViewState = (int)gridViewSt.Song;
            songOrAlbumRatingLabel.Text = "Song";
            searchComboBox.SelectedIndex = (int)gridViewSt.Song;

            // Show songDataGridView
            albumDataGridView.Visible = false;
            songDataGridView.Visible = true;

            // AlbumGroupBox reveals songGroupBox
            albumGroupBox.Visible = false;
            songGroupBox.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAlbumButton_Click(object sender, EventArgs e)
        {
            // In the main form, the user clicked the AddAlbum button
            // this causes an AddAlbum form to pop-up
            DialogResult dr = new DialogResult();
            AddAlbumWF frm = new AddAlbumWF();
            
            // After the AddAlbum form has been closed, determine why
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // The user clicked the OK button
                MessageBox.Show("Main: AddAlbum: User clicked OK button");
                // Refresh the datagrid
                this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);

                // the following did not work with selecting a row and did not fill the entire grid (of course): 
                // List<CDCatalogEF.Album> albumList = Album.GetAllAlbums();
                // this.albumDataGridView.DataSource = albumList;
            }
            else if (dr == DialogResult.Cancel)
            {
                // The user clicked the Cancel button
                MessageBox.Show("Main: AddAlbum: User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAlbumButton_Click(object sender, EventArgs e)
        {
            // In the main form, the user clicked the ChangeAlbum button
            // this causes an ChangeAlbum form to pop-up
            DialogResult dr = new DialogResult();
            ChangeAlbumWF frm = new ChangeAlbumWF();

            // After the ChangeAlbum form has been closed, determine why
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: ChangeAlbum: User clicked OK button");
                // Refresh the datagrid
                this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);

                // the following did not work with selecting a row and did not fill the entire grid (of course): 
                // List<CDCatalogEF.Album> albumList = Album.GetAllAlbums();
                // this.albumDataGridView.DataSource = albumList;
            }
            else
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: ChangeAlbum: User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAlbumButton_Click(object sender, EventArgs e)
        {
            // In the main form, the user clicked the DeleteAlbum button
            // this causes an DeleteAlbum form to pop-up
            DialogResult dr = new DialogResult();
            DeleteAlbumWF frm = new DeleteAlbumWF();

            // After the DeleteAlbum form has been closed, determine why
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: DeleteAlbum: User clicked OK button");
                // Refresh the datagrid
                this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);

                // the following did not work with selecting a row and did not fill the entire grid (of course): 
                // List<CDCatalogEF.Album> albumList = Album.GetAllAlbums();
                // this.albumDataGridView.DataSource = albumList;
            }
            else
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: DeleteAlbum: User clicked Cancel button");
            }
                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSongButton_Click(object sender, EventArgs e)
        {
            bool repeat = true;
            while (repeat)
            {
                DialogResult dr = new DialogResult();
                AddSongWF frm = new AddSongWF();

                dr = frm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Main: AddSong: User clicked YES button");
                    this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);

                    // the following did not work with selecting a row and did not fill the entire grid (of course): 
                    // List<CDCatalogEF.Song> songList = Song.GetAllSongs();
                    // this.songDataGridView.DataSource = songList;
                    repeat = true;
                }
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Main: AddSong: User clicked OK button");
                    this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);

                    // the following did not work with selecting a row and did not fill the entire grid (of course): 
                    // List<CDCatalogEF.Song> songList = Song.GetAllSongs();
                    // this.songDataGridView.DataSource = songList;
                    repeat = false;
                }
                else if (dr == DialogResult.Cancel)
                {
                    MessageBox.Show("Main: AddSong: User clicked Cancel button");
                    repeat = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSongButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeSongWF frm = new ChangeSongWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: ChangeSong: User clicked OK button");
                this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);

                // the following did not work with selecting a row and did not fill the entire grid (of course): 
                // List<CDCatalogEF.Song> songList = Song.GetAllSongs();
                // this.songDataGridView.DataSource = songList;
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: ChangeSong: User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteSongWF frm = new DeleteSongWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: DeleteSong: User clicked OK button");
                this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);

                // the following did not work with selecting a row and did not fill the entire grid (of course): 
                // List<CDCatalogEF.Song> songList = Song.GetAllSongs();
                // this.songDataGridView.DataSource = songList;
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: DeleteSong: User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddArtistButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddArtistWF frm = new AddArtistWF();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: AddArtist User clicked OK button");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: AddArtist User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeArtistButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeArtistWF frm = new ChangeArtistWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: ChangeArtist User clicked OK button");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: ChangeArtist User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteArtistButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteArtistWF frm = new DeleteArtistWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: DeleteArtist User clicked OK button");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: DeleteArtist User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddGenreWF frm = new AddGenreWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: AddGenre User clicked OK button");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: AddGenre User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeGenreButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult(); 
            ChangeGenreWF frm = new ChangeGenreWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: ChangeGenre User clicked OK button");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: ChangeGenre User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteGenreButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteGenreWF frm = new DeleteGenreWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: DeleteGenre User clicked OK button");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: DeleteGenre User clicked Cancel button");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void albumDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.albumDataGridView.SelectedRows.Count > 0)
            {
                albumRow = albumDataGridView.CurrentRow;
                string msg = "albumRow selected";
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void songDataGridView_CellContentClick(object sender, EventArgs e)
        {
            if (this.songDataGridView.SelectedRows.Count > 0)
            {
                songRow = songDataGridView.CurrentRow;
                string msg = "songRow selected";
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ratingOkButton_Click(object sender, EventArgs e)
        {
            int selectedRating = ratingComboBox.SelectedIndex;

            switch (_gridViewState)
            {
                case (int)gridViewSt.Album:
                    if (albumRow == null)
                    {
                        string msg = "no album row selected";
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        // update album
                        // albumRow was set in albumDataGridView_CellContentClick
                        int albumId = 1000;
                        int.TryParse(albumRow.Cells["AlbumID"].Value.ToString(), out albumId);
                        int albumYear;
                        int.TryParse(albumRow.Cells["AlbumYear"].Value.ToString(), out albumYear);
                        int artistId;
                        int.TryParse(albumRow.Cells["ArtistID"].Value.ToString(), out artistId);
                        string albumTitle = albumRow.Cells["AlbumTitle"].Value.ToString();
                        int albumRating = selectedRating;
                        int genreId;
                        int.TryParse(albumRow.Cells["GenreID"].Value.ToString(), out genreId);

                        bool res = Album.ChangeAlbum(albumId, albumYear, artistId, albumTitle, albumRating, genreId);

                        string msg = "update album rating =" + selectedRating.ToString();
                        MessageBox.Show(msg);
                    }
                    break;
                case (int)gridViewSt.Song:
                    if (albumRow == null)
                    {
                        string msg = "no song row selected";
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        // update song
                        // songRow was set in songDataGridView_CellContentClick
                        int songId;
                        int.TryParse(songRow.Cells["SongID"].Value.ToString(), out songId);  // unhandled exception? why not 0?
                        string title = songRow.Cells["SongTitle"].Value.ToString();
                        int artistId;
                        int.TryParse(songRow.Cells["ArtistID"].Value.ToString(), out artistId);
                        int albumId;
                        int.TryParse(songRow.Cells["AlbumID"].Value.ToString(), out albumId);
                        int trackNumber;
                        int.TryParse(songRow.Cells["SongTrackNumber"].Value.ToString(), out trackNumber);
                        int songRating = selectedRating; //the index corresponds to 0-5
                        int trackLength; // seconds
                        int.TryParse(songRow.Cells["SongTrackLength"].Value.ToString(), out trackLength);
                        int genreId;
                        int.TryParse(songRow.Cells["GenreID"].Value.ToString(), out genreId);

                        //todo: validation

                        bool res = Song.UpdateSong(
                            songId,
                            title,
                            artistId,
                            albumId,
                            trackNumber,
                            songRating,
                            trackLength,
                            genreId);
                        string msg = "SongID=" + songId.ToString();

                        msg = "update song rating =" + selectedRating.ToString();
                        MessageBox.Show(msg);
                    }
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedSearchType = searchComboBox.SelectedIndex;
            MessageBox.Show("search type = " + selectedSearchType.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            // The user has clicked the search button

            string searchValueText = searchValueTextBox.Text.ToLower();

            switch (searchComboBox.SelectedIndex)
            {
                case (int)searchSt.Album:
                    // Refresh the datagrid
                    this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);

                    // Select a whole row
                    this.albumDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        // loop through all AlbumView table rows
                        foreach (DataGridViewRow row in this.albumDataGridView.Rows)
                        {
                            // Search in ArtistName, AlbumTitle, and GenreName

                            if (row.Cells[0].Value.Equals(string.Empty) || row.Cells[0].Value.Equals(null) ||
                                row.Cells[1].Value.Equals(string.Empty) || row.Cells[1].Value.Equals(null) ||
                                row.Cells[3].Value.Equals(string.Empty) || row.Cells[3].Value.Equals(null))
                            {
                                row.Selected = false;
                            }

                            // select those rows that have the search text in the rows
                            else if (row.Cells[0].Value.ToString().ToLower().Equals(searchValueText) ||
                                row.Cells[1].Value.ToString().ToLower().Equals(searchValueText) ||
                                row.Cells[3].Value.ToString().ToLower().Equals(searchValueText))
                            {
                                row.Selected = true;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    
                    break;
                case (int)searchSt.Song:
                    // Refresh the datagrid
                    this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
                    
                    // Select whole rows
                    this.songDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        // loop through all SongView table rows
                        foreach (DataGridViewRow row in this.songDataGridView.Rows)
                        {
                            // skip rows that have bad data in them
                            if (row.Cells[0].Value.Equals(string.Empty) || row.Cells[0].Value.Equals(null) ||
                                row.Cells[1].Value.Equals(string.Empty) || row.Cells[1].Value.Equals(null) ||
                                row.Cells[3].Value.Equals(string.Empty) || row.Cells[3].Value.Equals(null) ||
                                row.Cells[6].Value.Equals(string.Empty) || row.Cells[6].Value.Equals(null))
                            {
                                row.Selected = false;
                            }

                            // select those rows that have the search text in the rows
                            else if (row.Cells[0].Value.ToString().Equals(searchValueText) ||
                                row.Cells[1].Value.ToString().Equals(searchValueText) ||
                                row.Cells[3].Value.ToString().Equals(searchValueText) ||
                                row.Cells[6].Value.ToString().Equals(searchValueText))
                            {
                                row.Selected = true;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    
                    break;
                case (int)searchSt.Genre:

                    break;
            }
        }
    }
}
