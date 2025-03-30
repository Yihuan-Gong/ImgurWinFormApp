using ImgurAPI;
using ImgurAPI.Gallery.Models;
using ImgurWinForm.Forms.GallerySearch.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using IoCContainer;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using DTO;

namespace ImgurWinForm.Forms.GallerySearch.Presenters
{
    internal class GallerySearchPresenter : IGallerySearchPresenter
    {
        private readonly Imgur _imgur;
        private readonly IServiceProvider _serviceProvider;
        private readonly IGallerySearchView _gallerySearchView;

        public GallerySearchPresenter(IGallerySearchView gallerySearchView, IServiceProvider serviceProvider)
        {
            _gallerySearchView = gallerySearchView;
            _serviceProvider = serviceProvider;

            _imgur = _serviceProvider.GetService<Imgur>();
        }

        public async Task Search(string searchText)
        {
            var mapper = new Mapper<GalleryModel, GalleryAlbumModel>();
            List<GalleryModel> galleriesFromApi = await _imgur.Gallery.GallerySearch(searchText);
            List<GalleryAlbumModel> galleries = galleriesFromApi.Select(x => mapper.Map(x)).ToList();
            _gallerySearchView.PresenterSearchCompleted(galleries);
        }
    }
}
