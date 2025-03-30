using DTO;
using ImgurAPI.Comment;
using ImgurAPI;
using ImgurAPI.Gallery.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBoxList.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBoxList.Presenters
{
    internal class IndicateCommentBoxListPresenter : IIndicateCommentBoxListPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AIndicateCommentBoxListView _indicateCommentBoxListView;

        public IndicateCommentBoxListPresenter(IServiceProvider serviceProvider, AIndicateCommentBoxListView IndicateCommentBoxListView)
        {
            _serviceProvider = serviceProvider;
            _indicateCommentBoxListView = IndicateCommentBoxListView;
        }

        public async Task DownloadNewCommentFromIdAsync(long commentId)
        {
            var apiService = _serviceProvider.GetService<Imgur>();
            var mapper = new Mapper<CommentModel, IndicateCommentReqModel>();

            CommentModel newComment = await apiService.Commemt.GetSigleComment(commentId);
            await _indicateCommentBoxListView.PresenterNewCommentDownloadedAsync(mapper.Map(newComment));
        }

        public async Task DownloadCommentsFromGalleryAsync(GalleryAlbumModel galleryModel)
        {
            var apiService = _serviceProvider.GetService<Imgur>();
            var mapper = new Mapper<CommentModel, IndicateCommentReqModel>();

            List<CommentModel> results = await apiService.Commemt.GetAllCommentsByGalleryId(galleryModel.Id);
            List<IndicateCommentReqModel> resultsForView = results.Select(x => mapper.Map(x)).ToList();

            await _indicateCommentBoxListView.PresenterCommentsFromGalleryDownloadedAsync(resultsForView);
        }
    }
}
