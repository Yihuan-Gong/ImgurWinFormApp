using ImgurAPI;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Presenters
{
    internal class SendCommentBoxPresenter : ISendCommentBoxPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ASendCommentBoxView _sendCommentBoxView;

        public SendCommentBoxPresenter(IServiceProvider serviceProvider, ASendCommentBoxView SendCommentBoxView)
        {
            _serviceProvider = serviceProvider;
            _sendCommentBoxView = SendCommentBoxView;
        }

        public async Task SendCommentAsync(SendCommentReqModel reqModel)
        {
            if (reqModel.PictirePath == null && 
                (reqModel.CommentText == null || reqModel.CommentText == string.Empty))
            {
                return;
            }
            
            if (reqModel.PictirePath != null)
            {
                await UploadPictureAsync(reqModel.PictirePath);
            }
                
            var commentText = (reqModel.PictureLink == null) ?
                reqModel.CommentText : $"{reqModel.CommentText} {reqModel.PictureLink}";
            
            var apiService = _serviceProvider.GetService<Imgur>();

            long newCommentId;
            if (reqModel.CommentId == null)
                newCommentId = await apiService.Commemt.CreateGalleryComment(reqModel.GalleryId, commentText);
            else
                newCommentId = await apiService.Commemt.CreateSubComment(reqModel.GalleryId, (long)reqModel.CommentId, commentText);
            
            _sendCommentBoxView.PresenterCommentSent(newCommentId);
        }

        public async Task UploadPictureAsync(string path)
        {
            var apiService = _serviceProvider.GetService<Imgur>();

            var result = await apiService.Image.UploadImage(string.Empty, string.Empty, path);

            _sendCommentBoxView.PresenterPictureUploaded(result.Link);
        }
    }
}
