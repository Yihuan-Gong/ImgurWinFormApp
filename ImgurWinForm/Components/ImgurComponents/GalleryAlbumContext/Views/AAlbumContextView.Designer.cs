using ImgurWinForm.Components.ImgurComponents.UploadPictures.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Views
{
    partial class AAlbumContextView
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

        private void InitializeControl()
        {
            var uploadPicturesView = serviceProvider.GetService<AUploadPicturesView>();
            extensionFlowLayoutPanel.Controls.Add(uploadPicturesView);
            uploadPicturesView.PicturesUploaded += PicturesUploaded;

            extensionFlowLayoutPanel.Controls.Add(InitializePublishButton());
        }

        protected override Control InitializeTitleControl()
        {
            var titleControl = new TextBox
            {
                AutoSize = true,
                MaximumSize = new Size(Width, int.MaxValue)
            };
            titleControl.Leave += TitleTextBoxLeave;
            titleControl.KeyDown += TitleTextBoxEnterPressed;
            return titleControl;
        }

        protected virtual Button InitializePublishButton()
        {
            var btn = new Button
            {
                Text = "公開發表"
            };
            btn.Click += PublishButtonClicked;
            return btn;
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
    }
}
