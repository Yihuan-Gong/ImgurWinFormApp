namespace ImgurWinForm.Components.ImgurComponents.UploadPictures.Views
{
    abstract partial class AUploadPicturesView
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
            this.newPictureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPictureButton
            // 
            this.newPictureButton.Font = new System.Drawing.Font("新細明體", 9F);
            this.newPictureButton.Location = new System.Drawing.Point(3, 3);
            this.newPictureButton.Name = "newPictureButton";
            this.newPictureButton.Size = new System.Drawing.Size(112, 39);
            this.newPictureButton.TabIndex = 0;
            this.newPictureButton.Text = "+ 新增相片";
            this.newPictureButton.UseVisualStyleBackColor = true;
            this.newPictureButton.Click += new System.EventHandler(this.NewPictureButtonClicked);
            // 
            // ANewPicturesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newPictureButton);
            this.Name = "ANewPicturesView";
            this.Size = new System.Drawing.Size(121, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newPictureButton;
    }
}
