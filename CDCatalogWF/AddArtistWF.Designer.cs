namespace CDCatalogWF
{
    partial class AddArtistWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArtistWF));
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistTxtBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.artistPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.artistPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(83, 10);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 0;
            this.artistLabel.Text = "Artist";
            // 
            // artistTxtBox
            // 
            this.artistTxtBox.Location = new System.Drawing.Point(119, 10);
            this.artistTxtBox.Name = "artistTxtBox";
            this.artistTxtBox.Size = new System.Drawing.Size(123, 20);
            this.artistTxtBox.TabIndex = 1;
            this.artistTxtBox.TextChanged += new System.EventHandler(this.artistTxtBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(86, 37);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(167, 37);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // artistPictureBox
            // 
            this.artistPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("artistPictureBox.Image")));
            this.artistPictureBox.Location = new System.Drawing.Point(12, 10);
            this.artistPictureBox.Name = "artistPictureBox";
            this.artistPictureBox.Size = new System.Drawing.Size(65, 50);
            this.artistPictureBox.TabIndex = 4;
            this.artistPictureBox.TabStop = false;
            // 
            // AddArtistWF
            // 
            this.AcceptButton = this.okButton;
            this.AccessibleDescription = "Use this form to add an artist";
            this.AccessibleName = "Add Artist";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(255, 84);
            this.Controls.Add(this.artistPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.artistTxtBox);
            this.Controls.Add(this.artistLabel);
            this.Name = "AddArtistWF";
            this.Text = "AddArtist";
            this.Load += new System.EventHandler(this.AddArtist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artistPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox artistTxtBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox artistPictureBox;
    }
}