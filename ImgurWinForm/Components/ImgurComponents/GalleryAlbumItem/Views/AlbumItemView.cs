using ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Views;
using ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Views;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Views
{
    internal class AlbumItemView : AAlbumItemView
    {
        public AlbumItemView(IServiceProvider serviceProvider, ABasicPictureView pictureView, AVoteBoxHorizontalView voteBoxView, ANumberOfWatchBoxView numberOfWatchBoxView, ANumberOfCommentBoxView numberOfCommentBoxView) : 
            base(serviceProvider, pictureView, voteBoxView, numberOfWatchBoxView, numberOfCommentBoxView)
        {
        }
    }
}
