using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CDCatalogDA;

namespace CDCatalogWF
{
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize both datagrids -- SongView and AlbumView
            this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
            this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);

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
            }
            else if (dr == DialogResult.Cancel)
            {
                // The user clicked the Cancel button
                MessageBox.Show("Main: AddAlbum: User clicked Cancel button");
            }
        }

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
            }
            else
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: ChangeAlbum: User clicked Cancel button");
            }
        }

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
            }
            else
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: DeleteAlbum: User clicked Cancel button");
            }
                
        }

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
                    repeat = true;
                }
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Main: AddSong: User clicked OK button");
                    this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
                    repeat = false;
                }
                else if (dr == DialogResult.Cancel)
                {
                    MessageBox.Show("Main: AddSong: User clicked Cancel button");
                    repeat = false;
                }
            }
        }

        private void ChangeSongButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeSongWF frm = new ChangeSongWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: ChangeSong: User clicked OK button");
                this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: ChangeSong: User clicked Cancel button");
            }
        }

        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteSongWF frm = new DeleteSongWF();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Main: DeleteSong: User clicked OK button");
                this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Main: DeleteSong: User clicked Cancel button");
            }
        }

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

        private void albumDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("User clicked in AlbumDataGridView");
        }

        private void songDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("User clicked in SongDataGridView");
        }

        private void ratingOkButton_Click(object sender, EventArgs e)
        {
            int selectedRating = ratingComboBox.SelectedIndex;

            switch (_gridViewState)
            {
                case (int)gridViewSt.Album:
                    // update album
                    string msg = "update album rating =" + selectedRating.ToString();
                    MessageBox.Show(msg);
                    break;
                case (int)gridViewSt.Song:
                    // update song
                    msg = "update song rating =" + selectedRating.ToString();
                    MessageBox.Show(msg);
                    break;
            }
        }

        private void ratingCancelButton_Click(object sender, EventArgs e)
        {

        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedSearchType = searchComboBox.SelectedIndex;
            MessageBox.Show("search type = " + selectedSearchType.ToString());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // The user has clicked the search button

            string searchValueText = searchValueTextBox.Text.ToLower();

            switch (searchComboBox.SelectedIndex)
            {
                case (int)searchSt.Album:
                    break;
                case (int)searchSt.Song:
                    break;
                case (int)searchSt.Genre:
                    break;

            }
        }


    }
}
