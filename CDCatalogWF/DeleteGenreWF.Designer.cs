namespace CDCatalogWF
{
    partial class DeleteGenreWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteGenreWF));
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.deleteGenrePictureBox = new System.Windows.Forms.PictureBox();
            this.deleteGenreTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deleteGenrePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(186, 48);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(104, 48);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 24;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // deleteGenrePictureBox
            // 
            this.deleteGenrePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deleteGenrePictureBox.Image")));
            this.deleteGenrePictureBox.Location = new System.Drawing.Point(13, 13);
            this.deleteGenrePictureBox.Name = "deleteGenrePictureBox";
            this.deleteGenrePictureBox.Size = new System.Drawing.Size(66, 58);
            this.deleteGenrePictureBox.TabIndex = 26;
            this.deleteGenrePictureBox.TabStop = false;
            // 
            // deleteGenreTextBox
            // 
            this.deleteGenreTextBox.Location = new System.Drawing.Point(104, 12);
            this.deleteGenreTextBox.Name = "deleteGenreTextBox";
            this.deleteGenreTextBox.Size = new System.Drawing.Size(157, 20);
            this.deleteGenreTextBox.TabIndex = 27;
            // 
            // DeleteGenreWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.deleteGenreTextBox);
            this.Controls.Add(this.deleteGenrePictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Name = "DeleteGenreWF";
            this.Text = "DeleteGenreWF";
            ((System.ComponentModel.ISupportInitialize)(this.deleteGenrePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox deleteGenrePictureBox;
        private System.Windows.Forms.TextBox deleteGenreTextBox;
    }
}