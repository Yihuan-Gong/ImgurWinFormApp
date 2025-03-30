using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Views;
using IoCContainer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Views
{
    internal abstract class AGalleryContextView : AGalleryAlbumContextView
    {
        public AGalleryContextView(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override async Task RenderNewPictureAsync(ImageModel model)
        {
            var pictureWithDescription = serviceProvider.GetService<ABasicPictureWithDescriptionView>();
            picturesFlowLayoutPanel.Controls.Add(pictureWithDescription);
            await pictureWithDescription.LoadDataAsync(model);
        }
    }
}
