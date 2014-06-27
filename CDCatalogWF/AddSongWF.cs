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
            // TODO: This line of code loads data into the 'cDCatalogDataSet3.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.cDCatalogDataSet3.Genre);
            // TODO: This line of code loads data into the 'cDCatalogDataSet2.Artist' table. You can move, or remove it, as needed.
            this.artistTableAdapter.Fill(this.cDCatalogDataSet2.Artist);

        }

        private void artistLabel_Click(object sender, EventArgs e)
        {

        }

        private void addArtistButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddArtistWF frm = new AddArtistWF();
            _artistID = AddArtistWF.ArtistID;
            _artistName = AddArtistWF.ArtistName;
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show(_artistName + "User clicked OK button");
                this.artistTableAdapter.Fill(this.cDCatalogDataSet2.Artist);
                artistComboBox.FindStringExact("_artistName");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
            }
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddGenreWF frm = new AddGenreWF();
            _genreID = AddGenreWF.GenreID;
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.genreTableAdapter.Fill(this.cDCatalogDataSet3.Genre);

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
            }
        }

        private void artistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "ComboBox text = " +  artistComboBox.Text;
            MessageBox.Show(msg);
            // 
            // _artistID = int.Parse(artistComboBox.ValueMember);  // unhandled exception
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "ComboBox text = " + genreComboBox.Text;
            MessageBox.Show(msg);
            // _genreID = int.Parse(genreComboBox.ValueMember);  // unhandled exception
        }

        private void ratingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string title = this.songNameTextBox.Text;
            int artistId = _artistID;
            int albumId = 0;  // where do we get this?
            int trackNumber = 0;
            // int.TryParse(this.songTrackNumberTextBox.ToString(), out trackNumber);  // unhandled exception
            int songRating = ratingComboBox.SelectedIndex;
            int trackLength = 0;  // seconds

            // int.Parse(this.songTrackLengthTextBox.ToString(), trackLength);

            int genreId = _genreID;

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
