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
    using CDCatalogEF;

    using Album = CDCatalogDA.Album;
    using Artist = CDCatalogDA.Artist;

    public partial class AddAlbumWF : Form
    {
        private static int _artistID;
        private static int _genreID;

        public AddAlbumWF()
        {
            InitializeComponent();
        }

        private void AddAlbumWF_Load(object sender, EventArgs e)
        {
            // Pre-load the genre and artist combo boxes
            this.genreTableAdapter.Fill(this.cDCatalogDataSet3.Genre);
            this.artistTableAdapter.Fill(this.cDCatalogDataSet2.Artist);

            // Initialize the rating combo box
            ratingComboBox.SelectedIndex = 0; //unrated
        }

        private void AddArtistButton_Click(object sender, EventArgs e)
        {
            // In the AddAlbum form, the user clicked the AddArtist button
            // this opens the AddArtist pop-up
            DialogResult dr = new DialogResult();
            AddArtistWF frm = new AddArtistWF();
            
            // When the AddArtist pop-is closed, determie why.
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Acknowledge the change 
                MessageBox.Show("AddArtist: User clicked OK button");

                // Get the newly created genre object
                CDCatalogEF.Artist artist = (CDCatalogEF.Artist)this.addArtistButton.Tag;

                // Refresh the combo box with the artist that was just added
                this.artistTableAdapter.Fill(this.cDCatalogDataSet2.Artist);

                int index = artistComboBox.FindStringExact(artist.ArtistName);  //Exception here
                artistComboBox.SelectedIndex = index;

                this.Close();

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("AddArtist: User clicked Cancel button");
                this.Close();
            }
        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            // In the AddAlbum form, the user clicked the AddGenre button
            // this opens the AddGenre pop-up
            DialogResult dr = new DialogResult();
            AddGenreWF frm = new AddGenreWF();

            // When the AddGenre pop-is closed, determine why.
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // MessageBox.Show("User clicked OK button");
                // Get the newly created genre object
                CDCatalogEF.Genre genre = (Genre)this.addGenreButton.Tag;

                // Show updated list in the combo box
                this.genreTableAdapter.Fill(this.cDCatalogDataSet3.Genre);

                //Show the selected item
                this.genreComboBox.SelectedIndex = this.genreComboBox.FindString(genre.GenreName);

                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("AddGenre: User clicked Cancel button");
                this.Close();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // The user clicked on the AddAlbum OK button
            
            int albumYear;
            int.TryParse(this.yearTextBox.Text, out albumYear);  
            int artistId;
            int.TryParse(artistComboBox.SelectedValue.ToString(), out artistId);
            string albumTitle = this.albumTitleTextBox.Text;
            int albumRating = ratingComboBox.SelectedIndex;
            int genreId;
            int.TryParse(genreComboBox.SelectedValue.ToString(), out genreId);

            // todo: validation

            int AlbumId = Album.AddAlbum(albumYear, artistId, albumTitle, albumRating, genreId);
            string msg = "AlbumID=" + AlbumId.ToString();
            MessageBox.Show(msg);

            if (AlbumId > 0)
            {
                bool repeat = true;
                while (repeat)
                {
                    // This creates an AddSong pop-up.
                    AddSongWF frm = new AddSongWF();
                    DialogResult dr = frm.ShowDialog(this);

                    // If the user clicked the OK button on the AddSong pop-up
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("AddAlbum: AddSong - User clicked Yes button");
                        repeat = true;
                    }
                    else if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("AddAlbum: AddSong - User clicked OK button");
                        this.Close();
                        repeat = false;
                    }
                        // if the Cancel button or the X was clicked on the AddSong pop-up...
                    else if (dr == DialogResult.Cancel)
                    {
                        MessageBox.Show("AddAlbum: AddSong - User clicked Cancel button");
                        this.Close();
                        repeat = false;
                    }
                }
            }

            // Close the AddAlbum form
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the AddAlbum form
            this.Close();
        }
    }
}
