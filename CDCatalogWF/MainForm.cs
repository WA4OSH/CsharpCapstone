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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDCatalogDataSet1.SongView' table. You can move, or remove it, as needed.
            this.songViewTableAdapter.Fill(this.cDCatalogDataSet1.SongView);
            // TODO: This line of code loads data into the 'cDCatalogDataSet.AlbumView' table. You can move, or remove it, as needed.
            this.albumViewTableAdapter.Fill(this.cDCatalogDataSet.AlbumView);
            // Bring album view panel to front
            albumPanel.BringToFront();
            songPanel.SendToBack();
        }

        private void albumViewButton_CheckedChanged(object sender, EventArgs e)
        {
            // Bring album view panel to front
            albumPanel.BringToFront();
            songPanel.SendToBack();
        }

        private void songViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Bring song view to front
            songPanel.BringToFront();
            albumPanel.SendToBack();
        }

        private void albumPanel_Paint(object sender, PaintEventArgs e)
        {
            // Refresh album view
            

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        }

        private void DeleteAlbumButton_Click(object sender, EventArgs e)
        {

        }


    }
}
