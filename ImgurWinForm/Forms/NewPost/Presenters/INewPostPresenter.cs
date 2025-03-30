using ImgurAPI.Image.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.NewPost.Presenters
{
    internal interface INewPostPresenter
    {
        Task CreateNewAlbumAsync(ImageModel[] newPictures);
    }
}