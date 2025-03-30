using DTO;
using ImgurAPI;
using ImgurAPI.Album.Models;
using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Forms.NewPost.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.NewPost.Presenters
{
    internal class NewPostPresenter : INewPostPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ANewPostView _newPostView;

        public NewPostPresenter(IServiceProvider serviceProvider, ANewPostView NewPostView)
        {
            _serviceProvider = serviceProvider;
            _newPostView = NewPostView;
        }

        public async Task CreateNewAlbumAsync(ImageModel[] newPictures)
        {
            var apiService = _serviceProvider.GetService<Imgur>();
            var mapper = new Mapper<AlbumModel, GalleryAlbumModel>();

            List<string> imageIds = newPictures.Select(x => x.Id).ToList();
            var result = await apiService.Album.CreateAlbum(imageIds, null, null);

            AlbumModel newAlbumFromApi = await apiService.Album.GetAlbumByAlbumId(result.Id);
            await _newPostView.PresenterAlbumCreatedAsync(mapper.Map(newAlbumFromApi));
        }
    }
}
