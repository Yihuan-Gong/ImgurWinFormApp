using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.Picture.Presenters
{
    internal interface IPicturePresenter
    {
        Task DownPictureAsync(string url);
    }
}