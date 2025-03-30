using ImgurAPI.Gallery.Models;
using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.CommentBox.Assembly.Presenters;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Views;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Views;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Models;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBoxList.Views;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.Assembly.Views
{
    internal abstract partial class ACommentBoxAssemblyView : UserControl
    {
        private GalleryAlbumModel _refModel;
        private readonly ASendCommentBoxView _sendCommentBoxView;
        private readonly AIndicateCommentBoxListView _indicateCommentBoxListView;

        public ACommentBoxAssemblyView(IServiceProvider serviceProvider, ASendCommentBoxView sendCommentBoxView, AIndicateCommentBoxListView indicateCommentBoxListView)
        {
            InitializeComponent();

            _sendCommentBoxView = sendCommentBoxView;
            _indicateCommentBoxListView = indicateCommentBoxListView;
        }

        public async Task LoadDataAsync(GalleryAlbumModel galleryModel)
        {
            InitializeControls();

            _refModel = galleryModel;
            _sendCommentBoxView.LoadData(new SendCommentReqModel
            {
                GalleryId = _refModel.Id,
            });
            _sendCommentBoxView.CommentSent += CreateNewComment;

            await _indicateCommentBoxListView.LoadDataAsync(galleryModel);
        }

        public async void CreateNewComment(object sender, long commentId)
        {
            await _indicateCommentBoxListView.AddNewCommentAsync(commentId);
        }

    }
}
