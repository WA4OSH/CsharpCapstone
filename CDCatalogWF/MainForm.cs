using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CDCatalogDA;

namespace CDCatalogWF
{
    public partial class MainForm : Form
    {
        private static int _gridViewState;  // 0=default(Album) 1=Album 2=Song

        public static int gridViewState
        {
            get { return _gridViewState; }
            set { _gridViewState = 0; }  //default
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDCatalogDataSet1.SongView' table. You can move, or remove it, as needed.
            this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
            // TODO: This line of code loads data into the 'cDCatalogDataSet.AlbumView' table. You can move, or remove it, as needed.
            this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);

            // the albumViewButton radiobutton is selected first
            albumViewButton.Checked = true;
            _gridViewState = 1; //album
            songOrAlbumRatingLabel.Text = "Album";

            // Show albumDataGridView as default
            albumDataGridView.Visible = true;
            songDataGridView.Visible = false;

            // albumGroupBox hides songGroupBox
            albumGroupBox.Visible = true;
            songGroupBox.Visible = false;
        }

        private void albumViewButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set the current state
            _gridViewState = 1; //album
            songOrAlbumRatingLabel.Text = "Album";

            // Show songDataGridView
            albumDataGridView.Visible = true;
            songDataGridView.Visible = false;

            // albumGroupBox hides songGroupBox
            albumGroupBox.Visible = true;
            songGroupBox.Visible = false;
        }

        private void songViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set the current state
            _gridViewState = 2; //song
            songOrAlbumRatingLabel.Text = "Song";

            // Show songDataGridView
            albumDataGridView.Visible = false;
            songDataGridView.Visible = true;

            // AlbumGroupBox reveals songGroupBox
            albumGroupBox.Visible = false;
            songGroupBox.Visible = true;
        }

        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddAlbumWF frm = new AddAlbumWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void changeAlbumButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeAlbumWF frm = new ChangeAlbumWF();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void DeleteAlbumButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteAlbumWF frm = new DeleteAlbumWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddSongWF frm = new AddSongWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void songEditButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeSongWF frm = new ChangeSongWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void songDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteSongWF frm = new DeleteSongWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void artistAddButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddArtistWF frm = new AddArtistWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void artistChangeButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeArtistWF frm = new ChangeArtistWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void artistDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteArtistWF frm = new DeleteArtistWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void GenreAddButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddGenreWF frm = new AddGenreWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void genreChangeButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ChangeGenreWF frm = new ChangeGenreWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void genreDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteGenreWF frm = new DeleteGenreWF();
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void albumDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("User clicked in AlbumDataGridView");
        }

        private void songDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("User clicked in SongDataGridView");
        }

        private void ratingOkButton_Click(object sender, EventArgs e)
        {
            int selectedRating = ratingComboBox.SelectedIndex;
            string msg = "rating =" + selectedRating.ToString();
            MessageBox.Show(msg);
            switch (_gridViewState)
            {
                case 0: //default (album)
                case 1: //album
                    //update album
                    break;
                case 2: //song
                    //update song
                    break;
            }
        }

        private void ratingCancelButton_Click(object sender, EventArgs e)
        {

        }

       




    }
}
