using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDCatalogDA;

namespace CDCatalogWF
{
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

        private void addArtistButton_Click(object sender, EventArgs e)
        {
            // In the AddAlbum form, the user clicked the AddArtist button
            // this opens the AddArtist pop-up
            DialogResult dr = new DialogResult();
            AddArtistWF frm = new AddArtistWF();
            
            // When the AddArtist pop-is closed, determine why.
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Acknowledge the change 
                MessageBox.Show("User clicked OK button");  // todo: artistName added
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
            }
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            // In the AddAlbum form, the user clicked the AddGenre button
            // this opens the AddGenre pop-up
            DialogResult dr = new DialogResult();
            AddGenreWF frm = new AddGenreWF();

            // When the AddGenre pop-is closed, determine why.
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Acknowledge the change
                MessageBox.Show("User clicked OK button"); // todo: genreName added
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
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

            //todo: validation


            int AlbumId = Album.AddAlbum(albumYear, artistId, albumTitle, albumRating, genreId);
            string msg = "AlbumID=" + AlbumId.ToString();
            MessageBox.Show(msg);

            // Close the AddAlbum form
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close the AddAlbum form
            this.Close();
        }
    }
}
