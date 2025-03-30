using ImgurAPI;
using ImgurWinForm.Components.ImgurComponents.FavoriteButton.Views;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.FavoriteButton.Presenters
{
    internal class FavoriteButtonPresenter : IFavoriteButtonPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AFavoriteButtonView _FavoriteButtonView;
        private readonly Imgur _imgur;

        public FavoriteButtonPresenter(Imgur imgur, IServiceProvider serviceProvider, AFavoriteButtonView FavoriteButtonView)
        {
            _imgur = imgur;
            _serviceProvider = serviceProvider;
            _FavoriteButtonView = FavoriteButtonView;
        }

        public async void Favorite(string albumId)
        {
            string result = await _imgur.Album.FavoriteAlbum(albumId);

            _FavoriteButtonView.PresenterFavorited(result);
        }
    }
}
