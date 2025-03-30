using ImgurAPI.Gallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Forms.GallerySearch.Presenters
{
    internal interface IGallerySearchPresenter
    {
        Task Search(string searchText);
    }
}
