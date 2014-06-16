namespace CDCatalogWF
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CDCatalogPictureBox = new System.Windows.Forms.PictureBox();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.songRadioButton = new System.Windows.Forms.RadioButton();
            this.albumRadioButton = new System.Windows.Forms.RadioButton();
            this.AlbumPanel = new System.Windows.Forms.Panel();
            this.songPanel = new System.Windows.Forms.Panel();
            this.playlistPanel = new System.Windows.Forms.Panel();
            this.albumGroupBox = new System.Windows.Forms.GroupBox();
            this.albumDeleteButton = new System.Windows.Forms.Button();
            this.albumUpdateButton = new System.Windows.Forms.Button();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.songGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteSongButton = new System.Windows.Forms.Button();
            this.addSongButton = new System.Windows.Forms.Button();
            this.updateSongButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchContinueButton1 = new System.Windows.Forms.Button();
            this.searchOKButton = new System.Windows.Forms.Button();
            this.playListGroupBox = new System.Windows.Forms.GroupBox();
            this.playListGenreListBox = new System.Windows.Forms.ListBox();
            this.playListTimeTextBox = new System.Windows.Forms.TextBox();
            this.playListCancelButton = new System.Windows.Forms.Button();
            this.playListOKButton = new System.Windows.Forms.Button();
            this.playListPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CDCatalogPictureBox)).BeginInit();
            this.viewGroupBox.SuspendLayout();
            this.AlbumPanel.SuspendLayout();
            this.songPanel.SuspendLayout();
            this.albumGroupBox.SuspendLayout();
            this.songGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.playListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CDCatalogPictureBox
            // 
            this.CDCatalogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CDCatalogPictureBox.Image")));
            this.CDCatalogPictureBox.Location = new System.Drawing.Point(13, 13);
            this.CDCatalogPictureBox.Name = "CDCatalogPictureBox";
            this.CDCatalogPictureBox.Size = new System.Drawing.Size(222, 90);
            this.CDCatalogPictureBox.TabIndex = 0;
            this.CDCatalogPictureBox.TabStop = false;
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Controls.Add(this.songRadioButton);
            this.viewGroupBox.Controls.Add(this.albumRadioButton);
            this.viewGroupBox.Location = new System.Drawing.Point(241, 15);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(174, 88);
            this.viewGroupBox.TabIndex = 1;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View";
            // 
            // songRadioButton
            // 
            this.songRadioButton.AutoSize = true;
            this.songRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("songRadioButton.Image")));
            this.songRadioButton.Location = new System.Drawing.Point(89, 19);
            this.songRadioButton.Name = "songRadioButton";
            this.songRadioButton.Size = new System.Drawing.Size(77, 55);
            this.songRadioButton.TabIndex = 1;
            this.songRadioButton.TabStop = true;
            this.songRadioButton.Text = "Song";
            this.songRadioButton.UseVisualStyleBackColor = true;
            // 
            // albumRadioButton
            // 
            this.albumRadioButton.AutoSize = true;
            this.albumRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("albumRadioButton.Image")));
            this.albumRadioButton.Location = new System.Drawing.Point(6, 19);
            this.albumRadioButton.Name = "albumRadioButton";
            this.albumRadioButton.Size = new System.Drawing.Size(77, 55);
            this.albumRadioButton.TabIndex = 0;
            this.albumRadioButton.TabStop = true;
            this.albumRadioButton.Text = "Album";
            this.albumRadioButton.UseVisualStyleBackColor = true;
            // 
            // AlbumPanel
            // 
            this.AlbumPanel.Controls.Add(this.songPanel);
            this.AlbumPanel.Location = new System.Drawing.Point(13, 110);
            this.AlbumPanel.Name = "AlbumPanel";
            this.AlbumPanel.Size = new System.Drawing.Size(880, 361);
            this.AlbumPanel.TabIndex = 2;
            // 
            // songPanel
            // 
            this.songPanel.Controls.Add(this.playlistPanel);
            this.songPanel.Controls.Add(this.albumGroupBox);
            this.songPanel.Controls.Add(this.songGroupBox);
            this.songPanel.Location = new System.Drawing.Point(-1, -1);
            this.songPanel.Name = "songPanel";
            this.songPanel.Size = new System.Drawing.Size(881, 362);
            this.songPanel.TabIndex = 0;
            // 
            // playlistPanel
            // 
            this.playlistPanel.Location = new System.Drawing.Point(0, 1);
            this.playlistPanel.Name = "playlistPanel";
            this.playlistPanel.Size = new System.Drawing.Size(881, 360);
            this.playlistPanel.TabIndex = 5;
            this.playlistPanel.Visible = false;
            // 
            // albumGroupBox
            // 
            this.albumGroupBox.Controls.Add(this.albumDeleteButton);
            this.albumGroupBox.Controls.Add(this.albumUpdateButton);
            this.albumGroupBox.Controls.Add(this.addAlbumButton);
            this.albumGroupBox.Location = new System.Drawing.Point(5, 5);
            this.albumGroupBox.Name = "albumGroupBox";
            this.albumGroupBox.Size = new System.Drawing.Size(251, 100);
            this.albumGroupBox.TabIndex = 4;
            this.albumGroupBox.TabStop = false;
            this.albumGroupBox.Text = "Album";
            // 
            // albumDeleteButton
            // 
            this.albumDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("albumDeleteButton.Image")));
            this.albumDeleteButton.Location = new System.Drawing.Point(169, 20);
            this.albumDeleteButton.Name = "albumDeleteButton";
            this.albumDeleteButton.Size = new System.Drawing.Size(75, 63);
            this.albumDeleteButton.TabIndex = 2;
            this.albumDeleteButton.Text = "Delete";
            this.albumDeleteButton.UseVisualStyleBackColor = true;
            // 
            // albumUpdateButton
            // 
            this.albumUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("albumUpdateButton.Image")));
            this.albumUpdateButton.Location = new System.Drawing.Point(88, 19);
            this.albumUpdateButton.Name = "albumUpdateButton";
            this.albumUpdateButton.Size = new System.Drawing.Size(75, 64);
            this.albumUpdateButton.TabIndex = 1;
            this.albumUpdateButton.Text = "Update";
            this.albumUpdateButton.UseVisualStyleBackColor = true;
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Image = ((System.Drawing.Image)(resources.GetObject("addAlbumButton.Image")));
            this.addAlbumButton.Location = new System.Drawing.Point(6, 19);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(75, 64);
            this.addAlbumButton.TabIndex = 0;
            this.addAlbumButton.Text = "Add";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            // 
            // songGroupBox
            // 
            this.songGroupBox.Controls.Add(this.deleteSongButton);
            this.songGroupBox.Controls.Add(this.addSongButton);
            this.songGroupBox.Controls.Add(this.updateSongButton);
            this.songGroupBox.Location = new System.Drawing.Point(262, 5);
            this.songGroupBox.Name = "songGroupBox";
            this.songGroupBox.Size = new System.Drawing.Size(254, 100);
            this.songGroupBox.TabIndex = 3;
            this.songGroupBox.TabStop = false;
            this.songGroupBox.Text = "Song";
            // 
            // deleteSongButton
            // 
            this.deleteSongButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteSongButton.Image")));
            this.deleteSongButton.Location = new System.Drawing.Point(169, 19);
            this.deleteSongButton.Name = "deleteSongButton";
            this.deleteSongButton.Size = new System.Drawing.Size(75, 64);
            this.deleteSongButton.TabIndex = 2;
            this.deleteSongButton.Text = "Delete";
            this.deleteSongButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.deleteSongButton.UseVisualStyleBackColor = true;
            // 
            // addSongButton
            // 
            this.addSongButton.Image = ((System.Drawing.Image)(resources.GetObject("addSongButton.Image")));
            this.addSongButton.Location = new System.Drawing.Point(7, 19);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(75, 65);
            this.addSongButton.TabIndex = 0;
            this.addSongButton.Text = "Add";
            this.addSongButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addSongButton.UseVisualStyleBackColor = true;
            // 
            // updateSongButton
            // 
            this.updateSongButton.Image = ((System.Drawing.Image)(resources.GetObject("updateSongButton.Image")));
            this.updateSongButton.Location = new System.Drawing.Point(88, 19);
            this.updateSongButton.Name = "updateSongButton";
            this.updateSongButton.Size = new System.Drawing.Size(75, 64);
            this.updateSongButton.TabIndex = 1;
            this.updateSongButton.Text = "Update";
            this.updateSongButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.updateSongButton.UseVisualStyleBackColor = true;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchPictureBox);
            this.searchGroupBox.Controls.Add(this.textBox1);
            this.searchGroupBox.Controls.Add(this.searchContinueButton1);
            this.searchGroupBox.Controls.Add(this.searchOKButton);
            this.searchGroupBox.Location = new System.Drawing.Point(421, 15);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(232, 89);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.Image")));
            this.searchPictureBox.Location = new System.Drawing.Point(6, 20);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(55, 55);
            this.searchPictureBox.TabIndex = 3;
            this.searchPictureBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 2;
            // 
            // searchContinueButton1
            // 
            this.searchContinueButton1.Location = new System.Drawing.Point(148, 51);
            this.searchContinueButton1.Name = "searchContinueButton1";
            this.searchContinueButton1.Size = new System.Drawing.Size(75, 23);
            this.searchContinueButton1.TabIndex = 1;
            this.searchContinueButton1.Text = "Cancel";
            this.searchContinueButton1.UseVisualStyleBackColor = true;
            // 
            // searchOKButton
            // 
            this.searchOKButton.Location = new System.Drawing.Point(67, 51);
            this.searchOKButton.Name = "searchOKButton";
            this.searchOKButton.Size = new System.Drawing.Size(75, 23);
            this.searchOKButton.TabIndex = 0;
            this.searchOKButton.Text = "OK";
            this.searchOKButton.UseVisualStyleBackColor = true;
            // 
            // playListGroupBox
            // 
            this.playListGroupBox.Controls.Add(this.playListGenreListBox);
            this.playListGroupBox.Controls.Add(this.playListTimeTextBox);
            this.playListGroupBox.Controls.Add(this.playListCancelButton);
            this.playListGroupBox.Controls.Add(this.playListOKButton);
            this.playListGroupBox.Controls.Add(this.playListPictureBox);
            this.playListGroupBox.Location = new System.Drawing.Point(659, 15);
            this.playListGroupBox.Name = "playListGroupBox";
            this.playListGroupBox.Size = new System.Drawing.Size(234, 89);
            this.playListGroupBox.TabIndex = 3;
            this.playListGroupBox.TabStop = false;
            this.playListGroupBox.Text = "Play List";
            // 
            // playListGenreListBox
            // 
            this.playListGenreListBox.FormattingEnabled = true;
            this.playListGenreListBox.Location = new System.Drawing.Point(122, 21);
            this.playListGenreListBox.Name = "playListGenreListBox";
            this.playListGenreListBox.Size = new System.Drawing.Size(102, 17);
            this.playListGenreListBox.TabIndex = 4;
            // 
            // playListTimeTextBox
            // 
            this.playListTimeTextBox.Location = new System.Drawing.Point(68, 20);
            this.playListTimeTextBox.Name = "playListTimeTextBox";
            this.playListTimeTextBox.Size = new System.Drawing.Size(48, 20);
            this.playListTimeTextBox.TabIndex = 3;
            // 
            // playListCancelButton
            // 
            this.playListCancelButton.Location = new System.Drawing.Point(149, 51);
            this.playListCancelButton.Name = "playListCancelButton";
            this.playListCancelButton.Size = new System.Drawing.Size(75, 23);
            this.playListCancelButton.TabIndex = 2;
            this.playListCancelButton.Text = "Cancel";
            this.playListCancelButton.UseVisualStyleBackColor = true;
            // 
            // playListOKButton
            // 
            this.playListOKButton.Location = new System.Drawing.Point(68, 52);
            this.playListOKButton.Name = "playListOKButton";
            this.playListOKButton.Size = new System.Drawing.Size(75, 23);
            this.playListOKButton.TabIndex = 1;
            this.playListOKButton.Text = "OK";
            this.playListOKButton.UseVisualStyleBackColor = true;
            // 
            // playListPictureBox
            // 
            this.playListPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playListPictureBox.Image")));
            this.playListPictureBox.Location = new System.Drawing.Point(7, 20);
            this.playListPictureBox.Name = "playListPictureBox";
            this.playListPictureBox.Size = new System.Drawing.Size(55, 55);
            this.playListPictureBox.TabIndex = 0;
            this.playListPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 549);
            this.Controls.Add(this.playListGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.AlbumPanel);
            this.Controls.Add(this.viewGroupBox);
            this.Controls.Add(this.CDCatalogPictureBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CDCatalogPictureBox)).EndInit();
            this.viewGroupBox.ResumeLayout(false);
            this.viewGroupBox.PerformLayout();
            this.AlbumPanel.ResumeLayout(false);
            this.songPanel.ResumeLayout(false);
            this.albumGroupBox.ResumeLayout(false);
            this.songGroupBox.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            this.playListGroupBox.ResumeLayout(false);
            this.playListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CDCatalogPictureBox;
        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.RadioButton songRadioButton;
        private System.Windows.Forms.RadioButton albumRadioButton;
        private System.Windows.Forms.Panel AlbumPanel;
        private System.Windows.Forms.Panel songPanel;
        private System.Windows.Forms.Panel playlistPanel;
        private System.Windows.Forms.GroupBox albumGroupBox;
        private System.Windows.Forms.Button albumDeleteButton;
        private System.Windows.Forms.Button albumUpdateButton;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.GroupBox songGroupBox;
        private System.Windows.Forms.Button deleteSongButton;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button updateSongButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchContinueButton1;
        private System.Windows.Forms.Button searchOKButton;
        private System.Windows.Forms.GroupBox playListGroupBox;
        private System.Windows.Forms.TextBox playListTimeTextBox;
        private System.Windows.Forms.Button playListCancelButton;
        private System.Windows.Forms.Button playListOKButton;
        private System.Windows.Forms.PictureBox playListPictureBox;
        private System.Windows.Forms.ListBox playListGenreListBox;
    }
}