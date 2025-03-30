using ImgurAPI.Album.Models;
using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.FavoriteButton.Presenters;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.Labels;
using MVPExtension;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.FavoriteButton.Views
{
    internal abstract partial class AFavoriteButtonView : UserControl
    {
        protected readonly IFavoriteButtonPresenter _favoriteButtonPresenter;

        private GalleryAlbumModel _referenceModel;

        public AFavoriteButtonView(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _favoriteButtonPresenter = serviceProvider.CreatePresenter<IFavoriteButtonPresenter, AFavoriteButtonView>(this);
        }

        public void LoadFavorite(GalleryAlbumModel albumModel)
        {
            _referenceModel = albumModel;

            if (_referenceModel.Favorite)
                favoriteLabel = FavoriteIconProperty();
            else
                favoriteLabel = UnFavoriteIconProperty();

            Controls.Clear();
            Controls.Add(favoriteLabel);
        }

        protected void FavoriteButtonClicked(object sender, EventArgs e)
        {
            _favoriteButtonPresenter.Favorite(_referenceModel.Id);
        }

        public void PresenterFavorited(string result)
        {
            if (result == "favorited")
                favoriteLabel = FavoriteIconProperty();
            else if (result == "unfavorited")
                favoriteLabel = UnFavoriteIconProperty();

            Controls.Clear();
            Controls.Add(favoriteLabel);

            //StringBuilder builder = new StringBuilder();
            //builder.AppendLine("ABC"); // [A,B,C]
            //builder.AppendLine("EFG"); // [E,F,G]
            //string str = builder.ToString(); //  [A,B,C,E,F,G]
        }
    }
}
