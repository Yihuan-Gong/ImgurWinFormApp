using ImgurAPI;
using ImgurWinForm.Components.ImgurComponents.UploadPictures.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.UploadPictures.Presenters
{
    internal class UploadPicturesPresenter : IUploadPicturesPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AUploadPicturesView _uploadPicturesView;

        public UploadPicturesPresenter(IServiceProvider serviceProvider, AUploadPicturesView NewPicturesView)
        {
            _serviceProvider = serviceProvider;
            _uploadPicturesView = NewPicturesView;
        }

        public async Task UploadPicturesAsync(string[] picturePaths)
        {
            var apiService = _serviceProvider.GetService<Imgur>();

            var newImages = await Task.WhenAll(
                picturePaths.Select(
                    async x => await apiService.Image.UploadImage(string.Empty, string.Empty, x)
                )
            );

            _uploadPicturesView.PresenterPictureUploaded(newImages);
        }
    }
}
