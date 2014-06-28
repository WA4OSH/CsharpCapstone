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
            // TODO: This line of code loads data into the 'cDCatalogDataSet3.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.cDCatalogDataSet3.Genre);
            // TODO: This line of code loads data into the 'cDCatalogDataSet2.Artist' table. You can move, or remove it, as needed.
            this.artistTableAdapter.Fill(this.cDCatalogDataSet2.Artist);

        }

        private void addArtistButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddArtistWF frm = new AddArtistWF();
            
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
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int albumYear = int.Parse(this.yearTextBox.Text);   // todo: unhandled exception
            int artistId = _artistID;
            string albumTitle = this.albumTitleTextBox.Text;
            int albumRating = 5;                                //todo: change to int <- textbox
            int genreId = _genreID;

            //todo: validation


            int AlbumId = Album.AddAlbum(albumYear, artistId, albumTitle, albumRating, genreId);
            string msg = "AlbumID=" + AlbumId.ToString();
            MessageBox.Show(msg);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }


    }
}
