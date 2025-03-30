using ImgurAPI;
using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Presenters
{
    internal class PictureWithDescriptionPresenter : IPictureWithDescriptionPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly APictureWithDescriptionView _PictureWithDescriptionView;

        public PictureWithDescriptionPresenter(IServiceProvider serviceProvider, APictureWithDescriptionView PictureWithDescriptionView)
        {
            _serviceProvider = serviceProvider;
            _PictureWithDescriptionView = PictureWithDescriptionView;
        }

        public async Task UpdateDescriptionAsync(string description)
        {
            var apiService = _serviceProvider.GetService<Imgur>();

            // 目前UpdateImage的這支API有問題
            // POST https://api.imgur.com/3/image/{imageId}
            return;
        }
    }
}
