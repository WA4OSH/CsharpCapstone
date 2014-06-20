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
    public partial class ChangeSongWF : Form
    {
        public ChangeSongWF()
        {
            InitializeComponent();
        }

        private void changeArtistButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeArtistWF frm = new ChangeArtistWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void changeGenreButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeGenreWF frm = new ChangeGenreWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }
    }
}
