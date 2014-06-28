using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalogWF
{
    using CDCatalogDA;

    using Artist = CDCatalogEF.Artist;
    using Genre = CDCatalogEF.Genre;

    public partial class AddSongWF : Form
    {
        // These variables hold the ArtistID and GenreID while the data for
        // adding the song is being built.
        private static int _artistID;
        private static string _artistName;
        private static int _genreID;
        private static string _songGenre;

        public AddSongWF()
        {
            InitializeComponent();
        }

        private void AddSongWF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDCatalogAlbum.Album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.cDCatalogAlbum.Album);
            // TODO: This line of code loads data into the 'cDCatalogDataSet3.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.cDCatalogDataSet3.Genre);
            // TODO: This line of code loads data into the 'cDCatalogDataSet2.Artist' table. You can move, or remove it, as needed.
            this.artistTableAdapter.Fill(this.cDCatalogDataSet2.Artist);

            ratingComboBox.SelectedIndex = 0;  //default is unrated
        }

        private void artistLabel_Click(object sender, EventArgs e)
        {

        }

        private void addArtistButton_Click(object sender, EventArgs e)
        {
            // The user clicked the addArtistButton on the AddArtist form.
            // this creates an AddArtist pop-up.
            AddArtistWF frm = new AddArtistWF();
            DialogResult dr = frm.ShowDialog(this);

            // If the user clicked the OK button on the AddArtist pop-up
            if (dr == DialogResult.OK)
            {
                // MessageBox.Show("User clicked OK button. Artist Name = " + _artistName );
                // Get the newly created genre object
                CDCatalogEF.Artist artist = (Artist)this.addArtistButton.Tag;

                // Refresh the combo box with the artist that was just added
                this.artistTableAdapter.Fill(this.cDCatalogDataSet2.Artist);

                int index = artistComboBox.FindStringExact(artist.ArtistName);  // unhandled exception ArtistName = null
                artistComboBox.SelectedIndex = index;
            }
            // if the Cancel button or the X was clicked on the AddArtist pop-up...
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
            }
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            // The user clicked the addGenreButton on the AddSong form.
            // this creates an AddGenre pop-up.
            AddGenreWF frm = new AddGenreWF();
            DialogResult dr = frm.ShowDialog(this);
            
            // If the user clicked the OK button on the AddGenre pop-up
            if (dr == DialogResult.OK)
            {
                // MessageBox.Show("User clicked OK button");
                // Get the newly created genre object
                CDCatalogEF.Genre genre = (Genre)this.addGenreButton.Tag;

                // Show updated list in the combo box
                this.genreTableAdapter.Fill(this.cDCatalogDataSet3.Genre);

                //Show the selected item
                this.genreComboBox.SelectedIndex = this.genreComboBox.FindString(genre.GenreName);

            }
            // if the Cancel button or the X was clicked on the AddGenre pop-up...
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
            }
        }

        private void artistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "ComboBox text = " +  artistComboBox.Text;
            MessageBox.Show(msg);
            int index = artistComboBox.FindStringExact(artistComboBox.Text);
            artistComboBox.SelectedIndex = index;
            // 
            // _artistID = int.Parse(artistComboBox.ValueMember);  // unhandled exception
        }

        private void addAlbumTitleButton_Click(object sender, EventArgs e)
        {
            string msg = "ComboBox text = " + albumTitleComboBox.Text;
            MessageBox.Show(msg);
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "ComboBox text = " + genreComboBox.Text;
            MessageBox.Show(msg);
        }

        private void ratingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "ComboBox text = " + ratingComboBox.Text;
            MessageBox.Show(msg);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // The user clicked on the AddSong OK button.
            string title = this.songNameTextBox.Text;
            int artistId;
            int.TryParse(artistComboBox.SelectedValue.ToString(), out artistId);
            int albumId;
            int.TryParse(albumTitleComboBox.SelectedValue.ToString(), out albumId);
            int trackNumber;
            int.TryParse(songTrackNumberTextBox.Text, out trackNumber);
            int songRating = ratingComboBox.SelectedIndex;  //the index corresponds to 0-5
            int trackLength;  // seconds
            int.TryParse(songTrackLengthTextBox.Text, out trackLength);
            int genreId;
            int.TryParse(genreComboBox.SelectedValue.ToString(), out genreId);
            
            //todo: validation

            int SongId = Song.AddSong(title, artistId, albumId, trackNumber, songRating, trackLength, genreId);
            string msg = "SongID=" + SongId.ToString();
            MessageBox.Show(msg);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }


    }
}
