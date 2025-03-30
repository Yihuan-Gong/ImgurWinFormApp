using ImgurAPI.Gallery.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Forms.GallerySearch.Views
{
    internal interface IGallerySearchView
    {
        void PresenterSearchCompleted(List<GalleryAlbumModel> searchResult);
    }
}
