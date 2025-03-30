namespace ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Views
{
    abstract partial class ANumberOfCommentBoxView
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
            this.commentNumLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // commentNumLabel
            // 
            this.commentNumLabel.AutoSize = true;
            this.commentNumLabel.Location = new System.Drawing.Point(33, 5);
            this.commentNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.commentNumLabel.Name = "commentNumLabel";
            this.commentNumLabel.Size = new System.Drawing.Size(14, 15);
            this.commentNumLabel.TabIndex = 10;
            this.commentNumLabel.Text = "0";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("新細明體", 14F);
            this.commentLabel.Location = new System.Drawing.Point(2, 0);
            this.commentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(35, 24);
            this.commentLabel.TabIndex = 9;
            this.commentLabel.Text = "💬";
            // 
            // ANumberOfCommentBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commentNumLabel);
            this.Controls.Add(this.commentLabel);
            this.Name = "ANumberOfCommentBoxView";
            this.Size = new System.Drawing.Size(77, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label commentNumLabel;
        protected System.Windows.Forms.Label commentLabel;
    }
}
