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
    /// <summary>
    /// The add artist wf.
    /// </summary>
    public partial class AddArtistWF : Form
    {
        /// <summary>
        /// Initializes a new instance of the AddGenreWF class.
        /// </summary>
        public AddArtistWF()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The add artist_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AddArtist_Load(object sender, EventArgs e)
        {

        }

        private void artistTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method handles the "OK" button click on the AddArtist form.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void OkButtonClick(object sender, EventArgs e)
        {
            // Add the artist in the textbox, error checking will be done in AddArtist
            int artistId = Artist.AddArtist(this.artistTxtBox.Text.Trim());

            // Save the new genreID that was created in the tag
            this.Tag = artistId;

            // Display a deug message box
            // string msg = "ArtistID=" + artistId.ToString();
            // MessageBox.Show(msg);

            // Close the genre pop-up form
            this.Close();
        }

        /// <summary>
        /// This method handles the "Cancel" button click on the AddArtist form.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            // set the tag to zero, an invalid artistID
            this.Tag = 0;

            // Close the genre pop-up form
            this.Close();

        }
    }
}
