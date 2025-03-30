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

        // To do: �ϥ�"in_gallery"�ӰϤ��L�OAlbum�٬OGallery
        Task<List<GalleryAlbumModel>> GetUserAlbumsAsync(string userName);
        Task<List<GalleryAlbumModel>> GetUserGalleriesAsync(string userName);
    }
}