namespace CDCatalogWF
{
    partial class ChangeArtistWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeArtistWF));
            this.changeArtistPictureBox = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.artistTxtBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.changeArtistPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // changeArtistPictureBox
            // 
            this.changeArtistPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("changeArtistPictureBox.Image")));
            this.changeArtistPictureBox.Location = new System.Drawing.Point(12, 12);
            this.changeArtistPictureBox.Name = "changeArtistPictureBox";
            this.changeArtistPictureBox.Size = new System.Drawing.Size(65, 50);
            this.changeArtistPictureBox.TabIndex = 9;
            this.changeArtistPictureBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(167, 39);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(86, 39);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // artistTxtBox
            // 
            this.artistTxtBox.Location = new System.Drawing.Point(119, 12);
            this.artistTxtBox.Name = "artistTxtBox";
            this.artistTxtBox.Size = new System.Drawing.Size(123, 20);
            this.artistTxtBox.TabIndex = 6;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(83, 12);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 5;
            this.artistLabel.Text = "Artist";
            // 
            // ChangeArtistWF
            // 
            this.AcceptButton = this.okButton;
            this.AccessibleDescription = "Use this form to change an artist";
            this.AccessibleName = "Change Artist";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(257, 75);
            this.Controls.Add(this.changeArtistPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.artistTxtBox);
            this.Controls.Add(this.artistLabel);
            this.Name = "ChangeArtistWF";
            this.Text = "ChangeArtistWF";
            ((System.ComponentModel.ISupportInitialize)(this.changeArtistPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox changeArtistPictureBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox artistTxtBox;
        private System.Windows.Forms.Label artistLabel;
    }
}