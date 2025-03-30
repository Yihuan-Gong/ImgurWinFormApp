using ImgurAPI.Album.Models;
using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Presenters
{
    internal interface IGalleryAlbumContextPresenter
    {
        Task UpdateTitleAsync(string albumId, string title);
        Task PublishAlbumToGalleryAsync(string albumId, string title);

        Task AddPictureAsync(string albumId, List<string> newPicturesId);
        Task RemovePictureAsync(string albumId, List<string> newPicturesId);
    }
}