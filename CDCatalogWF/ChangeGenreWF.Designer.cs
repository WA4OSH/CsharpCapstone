namespace CDCatalogWF
{
    partial class ChangeGenreWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeGenreWF));
            this.changeGenrePictureBox = new System.Windows.Forms.PictureBox();
            this.deleteGenreTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.changeGenrePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // changeGenrePictureBox
            // 
            this.changeGenrePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("changeGenrePictureBox.Image")));
            this.changeGenrePictureBox.Location = new System.Drawing.Point(12, 12);
            this.changeGenrePictureBox.Name = "changeGenrePictureBox";
            this.changeGenrePictureBox.Size = new System.Drawing.Size(65, 55);
            this.changeGenrePictureBox.TabIndex = 9;
            this.changeGenrePictureBox.TabStop = false;
            // 
            // deleteGenreTextBox
            // 
            this.deleteGenreTextBox.Location = new System.Drawing.Point(125, 12);
            this.deleteGenreTextBox.Name = "deleteGenreTextBox";
            this.deleteGenreTextBox.Size = new System.Drawing.Size(117, 20);
            this.deleteGenreTextBox.TabIndex = 8;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(83, 12);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(167, 44);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(86, 44);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // ChangeGenreWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 82);
            this.Controls.Add(this.changeGenrePictureBox);
            this.Controls.Add(this.deleteGenreTextBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buttonOK);
            this.Name = "ChangeGenreWF";
            this.Text = "ChangeGenreWF";
            ((System.ComponentModel.ISupportInitialize)(this.changeGenrePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox changeGenrePictureBox;
        private System.Windows.Forms.TextBox deleteGenreTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonOK;
    }
}