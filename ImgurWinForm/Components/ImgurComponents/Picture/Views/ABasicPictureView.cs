using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.Picture.Views
{
    internal abstract class ABasicPictureView : APictureView
    {
        public ABasicPictureView(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
