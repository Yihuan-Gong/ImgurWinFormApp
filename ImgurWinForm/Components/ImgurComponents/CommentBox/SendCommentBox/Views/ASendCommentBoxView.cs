using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.CommentBox.PictureComment.Views;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Presenters;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Views
{
    internal abstract partial class ASendCommentBoxView : UserControl
    {
        private SendCommentReqModel _refModel;
        private IServiceProvider _serviceProvider;
        protected readonly ISendCommentBoxPresenter _sendCommentBoxPresenter;
        public EventHandler<long> CommentSent { get; set; }

        public ASendCommentBoxView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _sendCommentBoxPresenter = serviceProvider.CreatePresenter<ISendCommentBoxPresenter, ASendCommentBoxView>(this);
        }

        protected async void SendCommentButtonClicked(object sender, EventArgs e)
        {
            _refModel.CommentText = writeCommentTextBox.Text;

            await _sendCommentBoxPresenter.SendCommentAsync(_refModel);

            // 留言完成後重設，讓下一次留言時使用到的資料都是新的
            Reset();
        }

        protected void PictureLabelClicked(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "選擇圖片";
                openFileDialog.Filter = "圖片檔案 (*.jpg; *.jpeg; *.png; *.bmp; *.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有檔案 (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _refModel.PictirePath = openFileDialog.FileName;

                    pictureCommentView = _serviceProvider.GetService<APictureCommentView>();
                    pictureCommentFlowLayoutPanel.Controls.Add(pictureCommentView);
                    pictureCommentView.PictureCommentClosing += PictureCommentClosed;
                    pictureCommentView.LoadData(openFileDialog.FileName);
                }
            }
        }

        public void LoadData(SendCommentReqModel reqModel)
        {
            InitializeControl();

            _refModel = reqModel;
        }

        public void PresenterCommentSent(long newCommentId)
        {
            // 這邊要讓IndicateCommentBox把新的Comment渲染上去
            CommentSent.Invoke(null, newCommentId);

            writeCommentTextBox.Text = string.Empty;
        }

        public void PresenterPictureUploaded(string pictureUrl)
        {
            _refModel.PictureLink = pictureUrl;
        }

        protected void Reset()
        {
            // 留言完成，刪除暫存紀錄
            _refModel = new SendCommentReqModel
            {
                GalleryId = _refModel.GalleryId,
                CommentId = _refModel.CommentId,
            };

            pictureCommentView?.Close();
            pictureCommentView = null;
        }

        private void PictureCommentClosed(object sender, EventArgs e)
        {
            _refModel.PictureLink = null;
            _refModel.PictirePath = null;
        }
    }
}
