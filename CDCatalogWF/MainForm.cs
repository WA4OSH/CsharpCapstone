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

        }

        private void albumViewButton_CheckedChanged(object sender, EventArgs e)
        {
            // Bring album view panel to front

        }

        private void songViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Bring song view to front

        }

        private void albumPanel_Paint(object sender, PaintEventArgs e)
        {
            // Refresh album view

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
