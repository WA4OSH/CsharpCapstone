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
    public partial class AddArtistWF : Form
    {
        private static int _artistId;

        public static int ArtistID
        {
            get { return _artistId; }
            set { _artistId = 0; }
        }

        private static string _artistName;

        public static string ArtistName
        {
            get { return _artistName; }
            set { _artistName = String.Empty; }
        }
   
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
            _artistId = Artist.AddArtist(this.Text);
            _artistName = this.Text;
            string msg = "ArtistID=" + _artistId.ToString();
            MessageBox.Show(msg);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _artistId = 0;
        }

    }
}
