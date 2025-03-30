namespace ImgurWinForm.Components.ImgurComponents.CommentBox.PictureComment.Views
{
    abstract partial class APictureCommentView
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
            this.commentPictureBox = new System.Windows.Forms.PictureBox();
            this.closeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // commentPictureBox
            // 
            this.commentPictureBox.Location = new System.Drawing.Point(12, 41);
            this.commentPictureBox.Name = "commentPictureBox";
            this.commentPictureBox.Size = new System.Drawing.Size(277, 219);
            this.commentPictureBox.TabIndex = 0;
            this.commentPictureBox.TabStop = false;
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLabel.AutoSize = true;
            this.closeLabel.Location = new System.Drawing.Point(272, 12);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(17, 15);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.CloseLabelClicked);
            // 
            // APictureCommentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.commentPictureBox);
            this.Name = "APictureCommentView";
            this.Size = new System.Drawing.Size(300, 276);
            ((System.ComponentModel.ISupportInitialize)(this.commentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox commentPictureBox;
        private System.Windows.Forms.Label closeLabel;
    }
}
