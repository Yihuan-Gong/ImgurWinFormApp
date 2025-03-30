using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.UploadPictures.Presenters
{
    internal interface IUploadPicturesPresenter
    {
        Task UploadPicturesAsync(string[] picturePaths);
    }
}