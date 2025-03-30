using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Presenters
{
    internal interface IGalleryAlbumItemPresenter
    {
        Task SyncGalleryAlbumWithImgurAsync(GalleryAlbumModel model);
    }
}