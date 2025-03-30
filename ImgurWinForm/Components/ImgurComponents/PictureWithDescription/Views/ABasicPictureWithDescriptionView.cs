using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Views
{
    internal abstract partial class ABasicPictureWithDescriptionView : APictureWithDescriptionView
    {
        public ABasicPictureWithDescriptionView(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
