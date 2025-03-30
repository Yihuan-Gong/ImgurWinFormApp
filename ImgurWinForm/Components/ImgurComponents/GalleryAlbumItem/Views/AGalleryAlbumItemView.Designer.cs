namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Views
{
    abstract partial class AGalleryAlbumItemView
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.numberOfCommentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.numberOfWatchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.voteBoxFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 312);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(52, 15);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "無標題";
            // 
            // numberOfCommentFlowLayoutPanel
            // 
            this.numberOfCommentFlowLayoutPanel.Location = new System.Drawing.Point(239, 333);
            this.numberOfCommentFlowLayoutPanel.Name = "numberOfCommentFlowLayoutPanel";
            this.numberOfCommentFlowLayoutPanel.Size = new System.Drawing.Size(47, 23);
            this.numberOfCommentFlowLayoutPanel.TabIndex = 18;
            // 
            // numberOfWatchFlowLayoutPanel
            // 
            this.numberOfWatchFlowLayoutPanel.Location = new System.Drawing.Point(167, 333);
            this.numberOfWatchFlowLayoutPanel.Name = "numberOfWatchFlowLayoutPanel";
            this.numberOfWatchFlowLayoutPanel.Size = new System.Drawing.Size(59, 23);
            this.numberOfWatchFlowLayoutPanel.TabIndex = 17;
            // 
            // voteBoxFlowLayoutPanel
            // 
            this.voteBoxFlowLayoutPanel.Location = new System.Drawing.Point(2, 333);
            this.voteBoxFlowLayoutPanel.Name = "voteBoxFlowLayoutPanel";
            this.voteBoxFlowLayoutPanel.Size = new System.Drawing.Size(142, 24);
            this.voteBoxFlowLayoutPanel.TabIndex = 16;
            // 
            // pictureFlowLayoutPanel
            // 
            this.pictureFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.pictureFlowLayoutPanel.Name = "pictureFlowLayoutPanel";
            this.pictureFlowLayoutPanel.Size = new System.Drawing.Size(283, 306);
            this.pictureFlowLayoutPanel.TabIndex = 15;
            // 
            // AGalleryAlbumItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.numberOfCommentFlowLayoutPanel);
            this.Controls.Add(this.numberOfWatchFlowLayoutPanel);
            this.Controls.Add(this.voteBoxFlowLayoutPanel);
            this.Controls.Add(this.pictureFlowLayoutPanel);
            this.Name = "AGalleryAlbumItemView";
            this.Size = new System.Drawing.Size(292, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel numberOfCommentFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel numberOfWatchFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel voteBoxFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel pictureFlowLayoutPanel;
    }
}
