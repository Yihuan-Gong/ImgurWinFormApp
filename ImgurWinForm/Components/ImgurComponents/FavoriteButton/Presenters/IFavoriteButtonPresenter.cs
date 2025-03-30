using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.FavoriteButton.Presenters
{
    internal interface IFavoriteButtonPresenter
    {
        void Favorite(string albumId);
    }
}