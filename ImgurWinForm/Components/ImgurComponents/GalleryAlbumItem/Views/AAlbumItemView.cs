using ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Views;
using ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Views;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Views;
using ImgurWinForm.Forms.EditPost.Views;
using ImgurWinForm.Forms.Image.Views;
using IoCContainer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Views
{
    internal abstract class AAlbumItemView : AGalleryAlbumItemView
    {
        public AAlbumItemView(IServiceProvider serviceProvider, ABasicPictureView pictureView, AVoteBoxHorizontalView voteBoxView, ANumberOfWatchBoxView numberOfWatchBoxView, ANumberOfCommentBoxView numberOfCommentBoxView) : 
            base(serviceProvider, pictureView, voteBoxView, numberOfWatchBoxView, numberOfCommentBoxView)
        {
        }

        protected override async void OnImageClicked(object sender, EventArgs e)
        {
            var albumForm = serviceProvider.GetService<AEditPostView>();
            await albumForm.LoadDataAsync(referenceModel);
            albumForm.Show();
        }
    }
}
