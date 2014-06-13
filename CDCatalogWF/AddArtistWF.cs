﻿using System;
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
    public partial class AddArtistWF : Form
    {
        public AddArtistWF()
        {
            InitializeComponent();
        }

        private void AddArtist_Load(object sender, EventArgs e)
        {

        }

        private void artistTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Text = artistTxtBox.Text;
            int artistId = CDCatalogEF.Artist.AddArtist(this.Text);
            string msg = artistId.ToString();
            MessageBox.Show(msg);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
        }


    }
}