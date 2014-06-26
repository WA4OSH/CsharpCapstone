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
        private static int _genreID;

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
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddGenreWF frm = new AddGenreWF();
            _genreID = AddGenreWF.GenreID;
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int albumYear = int.Parse(this.yearTextBox.Text);   // todo: unhandled exception
            
            string title = this.songNameTextBox.Text;
            int artistId = _artistID;
            int albumId = 0;
            int trackNumber = 0;
            int songRating = 0;
            int trackLength = 150;
            int genreId = _genreID;

            //todo: validation
            
            int SongId = Album.AddSong( title, artistId, albumId, trackNumber, songRating, trackLength, genreId);
            string msg = "SongID=" + SongId.ToString();
            MessageBox.Show(msg);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }


    }
}
