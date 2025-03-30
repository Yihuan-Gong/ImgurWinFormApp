using DTO;
using ImgurAPI;
using ImgurAPI.Album.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Forms.UserProfile.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.UserProfile.Presenters
{
    internal class UserProfilePresenter : IUserProfilePresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AUserProfileView _userProfileView;
        private readonly Imgur _apiService;
        private readonly Mapper<AlbumModel, GalleryAlbumModel> _mapper;

        public UserProfilePresenter(IServiceProvider serviceProvider, AUserProfileView UserProfileView)
        {
            _serviceProvider = serviceProvider;
            _userProfileView = UserProfileView;
            _apiService = serviceProvider.GetService<Imgur>();
            _mapper = new Mapper<AlbumModel, GalleryAlbumModel>();
        }

        public async Task<List<GalleryAlbumModel>> GetUserAlbumsAsync(string userName)
        {
            return await GetUserPostedAlbumDataAsync(userName, x => !x.InGallery);
        }

        public async Task<List<GalleryAlbumModel>> GetUserFavoritesAsync(string userName)
        {
            var resultsFromApi = await _apiService.Album.GetAlbumsByUserFavorite(userName);
            return ApiResponseToGalleryAlbumList(resultsFromApi);
        }

        public async Task<List<GalleryAlbumModel>> GetUserGalleriesAsync(string userName)
        {
            return await GetUserPostedAlbumDataAsync(userName, x => x.InGallery);
        }

        private async Task<List<GalleryAlbumModel>> GetUserPostedAlbumDataAsync
            (string userName, Func<GalleryAlbumModel, bool> selector)
        {
            // 這個API發完後可以得到User的所有Album，但每筆Album的資料不齊全(不包含相片)
            var allResultsFromApi = await _apiService.Album.GetAlbumsByUserName(userName);
            var allResults = ApiResponseToGalleryAlbumList(allResultsFromApi);

            // 篩選出需要被呈現的Album
            var requiredAlbums = allResults.Where(selector);

            // 再發一次API，把原本不完整的Album資料補齊全
            return await GetCompletedAlbumDetailsAsync(requiredAlbums);
        }

        private async Task<List<GalleryAlbumModel>> GetCompletedAlbumDetailsAsync(IEnumerable<GalleryAlbumModel> imcompletedAlbums)
        {
            var resultsFromApi = await Task.WhenAll(imcompletedAlbums
                .Select(async x => await _apiService.Album.GetAlbumByAlbumId(x.Id))
                .ToList());

            return ApiResponseToGalleryAlbumList(resultsFromApi);
        }

        private List<GalleryAlbumModel> ApiResponseToGalleryAlbumList(IEnumerable<AlbumModel> apiResponse)
        {
            return apiResponse.Select(x => _mapper.Map(x)).ToList();
        }
    }
}
