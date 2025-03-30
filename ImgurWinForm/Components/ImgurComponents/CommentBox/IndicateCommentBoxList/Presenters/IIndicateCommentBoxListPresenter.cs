using ImgurAPI.Gallery.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBoxList.Presenters
{
    internal interface IIndicateCommentBoxListPresenter
    {
        Task DownloadCommentsFromGalleryAsync(GalleryAlbumModel galleryModel);

        Task DownloadNewCommentFromIdAsync(long commentId);
    }
}