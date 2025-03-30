namespace ImgurWinForm.Forms.GallerySearch.Views
{
    partial class GallerySearchForm
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
            this.gallerySearchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userProfileButton = new System.Windows.Forms.Button();
            this.newPostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gallerySearchFlowLayoutPanel
            // 
            this.gallerySearchFlowLayoutPanel.Location = new System.Drawing.Point(34, 103);
            this.gallerySearchFlowLayoutPanel.Name = "gallerySearchFlowLayoutPanel";
            this.gallerySearchFlowLayoutPanel.Size = new System.Drawing.Size(870, 820);
            this.gallerySearchFlowLayoutPanel.TabIndex = 0;
            // 
            // userProfileButton
            // 
            this.userProfileButton.Location = new System.Drawing.Point(613, 35);
            this.userProfileButton.Name = "userProfileButton";
            this.userProfileButton.Size = new System.Drawing.Size(128, 48);
            this.userProfileButton.TabIndex = 1;
            this.userProfileButton.Text = "User Profile";
            this.userProfileButton.UseVisualStyleBackColor = true;
            this.userProfileButton.Click += new System.EventHandler(this.UserProfileButtonClicked);
            // 
            // newPostButton
            // 
            this.newPostButton.Location = new System.Drawing.Point(775, 35);
            this.newPostButton.Name = "newPostButton";
            this.newPostButton.Size = new System.Drawing.Size(129, 47);
            this.newPostButton.TabIndex = 2;
            this.newPostButton.Text = "+ New Post";
            this.newPostButton.UseVisualStyleBackColor = true;
            this.newPostButton.Click += new System.EventHandler(this.NewPostButtonClicked);
            // 
            // GallerySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 935);
            this.Controls.Add(this.newPostButton);
            this.Controls.Add(this.userProfileButton);
            this.Controls.Add(this.gallerySearchFlowLayoutPanel);
            this.Name = "GallerySearchForm";
            this.Text = "GallerySearchForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel gallerySearchFlowLayoutPanel;
        private System.Windows.Forms.Button userProfileButton;
        private System.Windows.Forms.Button newPostButton;
    }
}