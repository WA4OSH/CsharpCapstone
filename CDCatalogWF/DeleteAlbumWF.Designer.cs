namespace CDCatalogWF
{
    partial class DeleteAlbumWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAlbumWF));
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.deleteAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.deleteAlbumTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(186, 46);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(104, 46);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 28;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // deleteAlbumPictureBox
            // 
            this.deleteAlbumPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deleteAlbumPictureBox.Image")));
            this.deleteAlbumPictureBox.Location = new System.Drawing.Point(12, 12);
            this.deleteAlbumPictureBox.Name = "deleteAlbumPictureBox";
            this.deleteAlbumPictureBox.Size = new System.Drawing.Size(66, 57);
            this.deleteAlbumPictureBox.TabIndex = 30;
            this.deleteAlbumPictureBox.TabStop = false;
            // 
            // deleteAlbumTextBox
            // 
            this.deleteAlbumTextBox.Location = new System.Drawing.Point(104, 12);
            this.deleteAlbumTextBox.Name = "deleteAlbumTextBox";
            this.deleteAlbumTextBox.Size = new System.Drawing.Size(157, 20);
            this.deleteAlbumTextBox.TabIndex = 31;
            // 
            // DeleteAlbumWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 80);
            this.Controls.Add(this.deleteAlbumTextBox);
            this.Controls.Add(this.deleteAlbumPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Name = "DeleteAlbumWF";
            this.Text = "DeleteAlbumWF";
            ((System.ComponentModel.ISupportInitialize)(this.deleteAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox deleteAlbumPictureBox;
        private System.Windows.Forms.TextBox deleteAlbumTextBox;
    }
}