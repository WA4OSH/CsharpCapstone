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
    public partial class AddGenreWF : Form
    {
        private static int _genreId;

        public static int genreID
        {
            get { return _genreId; }
            set { _genreId = 0; }
        }
 
        public AddGenreWF()
        {
            InitializeComponent();
        }

        private void genreTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Text = genreTxtBox.Text;
            _genreId = Genre.AddGenre(this.Text);
            string msg = "GenreID=" + _genreId.ToString();
            MessageBox.Show(msg);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _genreId = 0;
        }




    }
}
