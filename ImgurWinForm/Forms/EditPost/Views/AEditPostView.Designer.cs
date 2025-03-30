namespace ImgurWinForm.Forms.EditPost.Views
{
    abstract partial class AEditPostView
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
            this.albumContextFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // albumContextFlowLayoutPanel
            // 
            this.albumContextFlowLayoutPanel.AutoScroll = true;
            this.albumContextFlowLayoutPanel.Location = new System.Drawing.Point(44, 36);
            this.albumContextFlowLayoutPanel.Name = "albumContextFlowLayoutPanel";
            this.albumContextFlowLayoutPanel.Size = new System.Drawing.Size(454, 642);
            this.albumContextFlowLayoutPanel.TabIndex = 0;
            // 
            // AEditPostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 713);
            this.Controls.Add(this.albumContextFlowLayoutPanel);
            this.Name = "AEditPostView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel albumContextFlowLayoutPanel;
    }
}
