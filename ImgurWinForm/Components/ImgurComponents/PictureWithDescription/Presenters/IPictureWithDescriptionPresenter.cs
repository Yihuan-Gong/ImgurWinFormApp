using ImgurAPI.Image.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Presenters
{
    internal interface IPictureWithDescriptionPresenter
    {
        Task UpdateDescriptionAsync(string description);
    }
}