using ImgurAPI.Album.Models;
using ImgurAPI.Image.Models;
using ImgurAPI;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Views;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using IoCContainer;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Presenters
{
    internal class GalleryAlbumContextPresenter : IGalleryAlbumContextPresenter
    {
        private readonly Imgur _apiService;
        private readonly Mapper<AlbumModel, GalleryAlbumModel> _mapper;
        private readonly AGalleryAlbumContextView _galleryAlbumContextView;

        public GalleryAlbumContextPresenter(IServiceProvider serviceProvider, AGalleryAlbumContextView galleryAlbumContextView)
        {
            _apiService = serviceProvider.GetService<Imgur>();
            _mapper = new Mapper<AlbumModel, GalleryAlbumModel>();
            _galleryAlbumContextView = galleryAlbumContextView;
        }

        public async Task AddPictureAsync(string albumId, List<string> newPicturesId)
        {
            // 將已上傳的相片新增至Album
            await _apiService.Album.AddAlbumImages(newPicturesId, albumId);

            // 重新取得被更新後的Album
            await SendUpdatedAlbumToView(albumId);
        }

        public async Task PublishAlbumToGalleryAsync(string albumId, string title)
        {
            await _apiService.Gallery.ShareAlbumWithGallery(albumId, title);
        }

        public async Task RemovePictureAsync(string albumId, List<string> newPicturesId)
        {
            await _apiService.Album.RemoveAlbumImage(newPicturesId, albumId);
            await SendUpdatedAlbumToView(albumId);
        }

        public async Task UpdateTitleAsync(string albumId, string title)
        {
            await _apiService.Album.UpdateAlbum(albumId, title);
            await SendUpdatedAlbumToView(albumId);
        }

        private async Task SendUpdatedAlbumToView(string albumId)
        {
            AlbumModel updatedAlbum = await _apiService.Album.GetAlbumByAlbumId(albumId);
            _galleryAlbumContextView.PresenterUpdated(_mapper.Map(updatedAlbum));
        }
    }
}
