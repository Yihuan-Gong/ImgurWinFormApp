using ImgurAPI.Gallery.Models;
using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Views;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBoxList.Presenters;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using IoCContainer;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBoxList.Views
{
    internal abstract partial class AIndicateCommentBoxListView : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        
        private FlowLayoutPanel rootPanel;

        protected readonly IIndicateCommentBoxListPresenter _indicateCommentBoxListPresenter;

        public AIndicateCommentBoxListView(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;

            _indicateCommentBoxListPresenter = serviceProvider.CreatePresenter<IIndicateCommentBoxListPresenter, AIndicateCommentBoxListView>(this);
        }

        public async Task LoadDataAsync(GalleryAlbumModel galleryModel)
        {
            InitializeControls();

            await _indicateCommentBoxListPresenter.DownloadCommentsFromGalleryAsync(galleryModel);
        }

        public async Task LoadDataAsync(List<IndicateCommentReqModel> commentList)
        {
            InitializeControls();

            await PresenterCommentsFromGalleryDownloadedAsync(commentList);
        }

        public async Task AddNewCommentAsync(long commentId)
        {
            await _indicateCommentBoxListPresenter.DownloadNewCommentFromIdAsync(commentId);
        }

        public async Task PresenterCommentsFromGalleryDownloadedAsync(List<IndicateCommentReqModel> commentList)
        {
            foreach (var comment in commentList)
            {
                await AddNewCommentAsync(comment);
            }
        }

        public async Task PresenterNewCommentDownloadedAsync(IndicateCommentReqModel newComment)
        {
            await AddNewCommentAsync(newComment);
        }

        private async Task AddNewCommentAsync(IndicateCommentReqModel comment)
        {
            var oneCommentIndication = _serviceProvider.GetService<AIndicateCommentBoxView>();
            rootPanel.Controls.Add(oneCommentIndication);
            await oneCommentIndication.LoadDataAsync(comment);
        }
    }
}
