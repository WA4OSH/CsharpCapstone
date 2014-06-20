﻿using System;
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
        private int _artistID;
        private int _genreID;

        public AddAlbumWF()
        {
            InitializeComponent();
        }

        private void addArtistButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddArtistWF frm = new AddArtistWF();
            //_artistID = AddArtistWF.artistID;  //todo: need to add property
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
            _genreID = AddGenreWF.genreID;
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int albumYear = int.Parse(this.yearTextBox.Text);
            int artistId = _artistID;
            string albumTitle = this.albumTitleTextBox.Text;
            //int albumRating = this.ratingComboBox;  //todo: change to int <- textbox
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
