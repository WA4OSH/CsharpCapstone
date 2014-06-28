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
    /// The add genre Web Form
    /// </summary>
    public partial class AddGenreWF : Form
    {
        /// <summary>
        /// Initializes a new instance of the AddGenreWF class.
        /// </summary>
        public AddGenreWF()
        {
            this.InitializeComponent();
        }

        private void genreTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method handles the  "OK" button click
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ButtonOkClick(object sender, EventArgs e)
        {
            // Add the genre in the textbox
            CDCatalogEF.Genre genre = CDCatalogDA.Genre.AddGenre(this.genreTxtBox.Text.Trim());

            // Save the new genre that was created as the tag object
            this.Tag = genre;

            // Display a debug message box
            // string msg = "GenreID=" + genreId.ToString();
            // MessageBox.Show(msg);

            // Close the genre pop-up form
            this.Close();
        }

        /// <summary>
        /// This method handles the  "Cancel" button click on the AddGenre form.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            // set the tag to zero, an invalid genreID
            this.Tag = 0;

            // Close the genre pop-up form
            this.Close();
        }
    }
}
