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

        private void albumAddButton_Click(object sender, EventArgs e)
        {
            AddAlbumWF frm = new AddAlbumWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void albumChangeButton_Click(object sender, EventArgs e)
        {
            ChangeAlbumWF frm = new ChangeAlbumWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void albumDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteAlbumWF frm = new DeleteAlbumWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void songAddButton_Click(object sender, EventArgs e)
        {
            AddSongWF frm = new AddSongWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void songChangeButton_Click(object sender, EventArgs e)
        {
            ChangeSongWF frm = new ChangeSongWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void songDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteSongWF frm = new DeleteSongWF();
            DialogResult dr = new DialogResult();
            
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
            ChangeArtistWF frm = new ChangeArtistWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void artistDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteArtistWF frm = new DeleteArtistWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void GenreAddButton_Click(object sender, EventArgs e)
        {
            AddGenreWF frm = new AddGenreWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
    
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void genreChangeButton_Click(object sender, EventArgs e)
        {
            ChangeGenreWF frm = new ChangeGenreWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("User clicked OK button");
            else if (dr == DialogResult.Cancel)
                MessageBox.Show("User clicked Cancel button");
        }

        private void genreDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteGenreWF frm = new DeleteGenreWF();
            DialogResult dr = new DialogResult();
            
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

            switch (_gridViewState)
            {
                case 0: // default
                case 1: // album
                    // update album
                    string msg = "update album rating =" + selectedRating.ToString();
                    MessageBox.Show(msg);
                    break;
                case 2: // song
                    // update song
                    msg = "update song rating =" + selectedRating.ToString();
                    MessageBox.Show(msg);
                    break;
            }
        }

        private void ratingCancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
