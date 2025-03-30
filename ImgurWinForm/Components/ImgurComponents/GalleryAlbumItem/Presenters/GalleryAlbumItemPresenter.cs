using DTO;
using ImgurAPI.Album.Models;
using ImgurAPI.Gallery.Models;
using ImgurAPI;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Presenters
{
    internal class GalleryAlbumItemPresenter : IGalleryAlbumItemPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AGalleryAlbumItemView _galleryAlbumItemView;

        public GalleryAlbumItemPresenter(IServiceProvider serviceProvider, AGalleryAlbumItemView GalleryAlbumItemView)
        {
            _serviceProvider = serviceProvider;
            _galleryAlbumItemView = GalleryAlbumItemView;
        }



        public async Task SyncGalleryAlbumWithImgurAsync(GalleryAlbumModel model)
        {
            AlbumModel album;
            var apiService = _serviceProvider.GetService<Imgur>();

            if (model.InGallery)
            {
                album = await apiService.Gallery.GetAlbumFromGallery(model.Id);
            }
            else
            {
                album = await apiService.Album.GetAlbumByAlbumId(model.Id);
            }

            var result = new Mapper<AlbumModel, GalleryAlbumModel>().Map(album);
            _galleryAlbumItemView.PresenterSyncWithImgurFinished(result);
        }
    }
}
