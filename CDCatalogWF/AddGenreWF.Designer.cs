namespace CDCatalogWF
{
    partial class AddGenreWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGenreWF));
            this.buttonOK = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTxtBox = new System.Windows.Forms.TextBox();
            this.genrePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.genrePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(92, 45);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(173, 45);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(89, 13);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Genre";
            // 
            // genreTxtBox
            // 
            this.genreTxtBox.Location = new System.Drawing.Point(131, 13);
            this.genreTxtBox.Name = "genreTxtBox";
            this.genreTxtBox.Size = new System.Drawing.Size(117, 20);
            this.genreTxtBox.TabIndex = 3;
            this.genreTxtBox.TextChanged += new System.EventHandler(this.genreTxtBox_TextChanged);
            // 
            // genrePictureBox
            // 
            this.genrePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("genrePictureBox.Image")));
            this.genrePictureBox.Location = new System.Drawing.Point(18, 13);
            this.genrePictureBox.Name = "genrePictureBox";
            this.genrePictureBox.Size = new System.Drawing.Size(65, 55);
            this.genrePictureBox.TabIndex = 4;
            this.genrePictureBox.TabStop = false;
            // 
            // AddGenreWF
            // 
            this.AcceptButton = this.buttonOK;
            this.AccessibleDescription = "Use this form to add a genre";
            this.AccessibleName = "Add Genre";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(269, 82);
            this.Controls.Add(this.genrePictureBox);
            this.Controls.Add(this.genreTxtBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buttonOK);
            this.Name = "AddGenreWF";
            this.Text = "AddGenre";
            ((System.ComponentModel.ISupportInitialize)(this.genrePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreTxtBox;
        private System.Windows.Forms.PictureBox genrePictureBox;
    }
}