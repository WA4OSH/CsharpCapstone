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
            // Initialize both datagrids -- SongView and AlbumView
            this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
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

        private void AddAlbumButton_Click(object sender, EventArgs e)
        {
            // In the main form, the user clicked the AddAlbum button
            // this causes an AddAlbum form to pop-up
            DialogResult dr = new DialogResult();
            AddAlbumWF frm = new AddAlbumWF();
            
            // After the AddAlbum form has been closed, determine why
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // The user clicked the OK button
                MessageBox.Show("User clicked OK button");
                // Refresh the datagrid
                this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                // The user clicked the Cancel button
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void ChangeAlbumButton_Click(object sender, EventArgs e)
        {
            ChangeAlbumWF frm = new ChangeAlbumWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                // Refresh the datagrid
                this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);
                this.Close();
            }
            else
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void DeleteAlbumButton_Click(object sender, EventArgs e)
        {
            DeleteAlbumWF frm = new DeleteAlbumWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                // Refresh the datagrid
                this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);
                this.Close();
            }
            else
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
                
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            AddSongWF frm = new AddSongWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
                this.Close();
            }
                
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
            
        }

        private void ChangeSongButton_Click(object sender, EventArgs e)
        {
            ChangeSongWF frm = new ChangeSongWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            DeleteSongWF frm = new DeleteSongWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void AddArtistButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddArtistWF frm = new AddArtistWF();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void ChangeArtistButton_Click(object sender, EventArgs e)
        {
            ChangeArtistWF frm = new ChangeArtistWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void DeleteArtistButton_Click(object sender, EventArgs e)
        {
            DeleteArtistWF frm = new DeleteArtistWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreWF frm = new AddGenreWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void ChangeGenreButton_Click(object sender, EventArgs e)
        {
            ChangeGenreWF frm = new ChangeGenreWF();
            DialogResult dr = new DialogResult();

            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
        }

        private void DeleteGenreButton_Click(object sender, EventArgs e)
        {
            DeleteGenreWF frm = new DeleteGenreWF();
            DialogResult dr = new DialogResult();
            
            dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("User clicked OK button");
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("User clicked Cancel button");
                this.Close();
            }
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
