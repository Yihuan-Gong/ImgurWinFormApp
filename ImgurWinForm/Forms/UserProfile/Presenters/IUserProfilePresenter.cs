using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.UserProfile.Presenters
{
    internal interface IUserProfilePresenter
    {
        Task<List<GalleryAlbumModel>> GetUserFavoritesAsync(string userName);

        // To do: 使用"in_gallery"來區分他是Album還是Gallery
        Task<List<GalleryAlbumModel>> GetUserAlbumsAsync(string userName);
        Task<List<GalleryAlbumModel>> GetUserGalleriesAsync(string userName);
    }
}