namespace ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Views
{
    abstract partial class ANumberOfWatchBoxView
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
            this.watchNumLabel = new System.Windows.Forms.Label();
            this.watchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // watchNumLabel
            // 
            this.watchNumLabel.AutoSize = true;
            this.watchNumLabel.Location = new System.Drawing.Point(32, 7);
            this.watchNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.watchNumLabel.Name = "watchNumLabel";
            this.watchNumLabel.Size = new System.Drawing.Size(14, 15);
            this.watchNumLabel.TabIndex = 11;
            this.watchNumLabel.Text = "0";
            // 
            // watchLabel
            // 
            this.watchLabel.AutoSize = true;
            this.watchLabel.Font = new System.Drawing.Font("新細明體", 14F);
            this.watchLabel.Location = new System.Drawing.Point(2, 0);
            this.watchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(35, 24);
            this.watchLabel.TabIndex = 10;
            this.watchLabel.Text = "👁️";
            // 
            // ANumberOfViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.watchNumLabel);
            this.Controls.Add(this.watchLabel);
            this.Name = "ANumberOfViewBox";
            this.Size = new System.Drawing.Size(83, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label watchNumLabel;
        protected System.Windows.Forms.Label watchLabel;
    }
}
