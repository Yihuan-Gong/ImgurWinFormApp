namespace ImgurWinForm.Forms.UserProfile.Views
{
    abstract partial class AUserProfileView
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userProfileFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.galleryButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.albumButton = new System.Windows.Forms.Button();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userProfileFlowLayoutPanel
            // 
            this.userProfileFlowLayoutPanel.Location = new System.Drawing.Point(23, 102);
            this.userProfileFlowLayoutPanel.Name = "userProfileFlowLayoutPanel";
            this.userProfileFlowLayoutPanel.Size = new System.Drawing.Size(878, 658);
            this.userProfileFlowLayoutPanel.TabIndex = 0;
            // 
            // galleryButton
            // 
            this.galleryButton.Font = new System.Drawing.Font("新細明體", 10F);
            this.galleryButton.Location = new System.Drawing.Point(568, 38);
            this.galleryButton.Name = "galleryButton";
            this.galleryButton.Size = new System.Drawing.Size(96, 40);
            this.galleryButton.TabIndex = 1;
            this.galleryButton.Text = "公開";
            this.galleryButton.UseVisualStyleBackColor = true;
            this.galleryButton.Click += new System.EventHandler(this.GalleryButtonClicked);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("新細明體", 15F);
            this.userNameLabel.Location = new System.Drawing.Point(18, 44);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(117, 25);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User Name";
            // 
            // albumButton
            // 
            this.albumButton.Font = new System.Drawing.Font("新細明體", 10F);
            this.albumButton.Location = new System.Drawing.Point(687, 38);
            this.albumButton.Name = "albumButton";
            this.albumButton.Size = new System.Drawing.Size(96, 40);
            this.albumButton.TabIndex = 3;
            this.albumButton.Text = "非公開";
            this.albumButton.UseVisualStyleBackColor = true;
            this.albumButton.Click += new System.EventHandler(this.AlbumButtonClicked);
            // 
            // favoriteButton
            // 
            this.favoriteButton.Font = new System.Drawing.Font("新細明體", 10F);
            this.favoriteButton.Location = new System.Drawing.Point(805, 38);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(96, 40);
            this.favoriteButton.TabIndex = 4;
            this.favoriteButton.Text = "已收藏";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.FavoriteButtonClicked);
            // 
            // AUserProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 772);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.albumButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.galleryButton);
            this.Controls.Add(this.userProfileFlowLayoutPanel);
            this.Name = "AUserProfileView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel userProfileFlowLayoutPanel;
        private System.Windows.Forms.Button galleryButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button albumButton;
        private System.Windows.Forms.Button favoriteButton;
    }
}
