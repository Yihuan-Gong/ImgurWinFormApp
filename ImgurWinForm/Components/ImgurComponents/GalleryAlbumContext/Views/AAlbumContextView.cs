using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Views;
using ImgurWinForm.Components.ImgurComponents.UploadPictures.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Views
{
    internal abstract partial class AAlbumContextView : AGalleryAlbumContextView
    {
        private string _originalTitle;

        public AAlbumContextView(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public override async Task LoadDataAsync(GalleryAlbumModel model)
        {
            await base.LoadDataAsync(model);
            InitializeControl();
            _originalTitle = model.Title;
        }

        protected override async Task RenderNewPictureAsync(ImageModel model)
        {
            var pictureWithDescription = serviceProvider.GetService<AEditablePictureWithDescriptionView>();
            picturesFlowLayoutPanel.Controls.Add(pictureWithDescription);
            await pictureWithDescription.LoadDataAsync(model);
            pictureWithDescription.PictureDeleted += PictureDeleted;
        }

        private async void PicturesUploaded(object sender, ImageModel[] images)
        {
            await _galleryAlbumContextPresenter
                .AddPictureAsync(refModel.Id, images.Select(x => x.Id).ToList());

            foreach (ImageModel image in images)
            {
                await RenderNewPictureAsync(image);
            }
        }

        private async void PictureDeleted(object sender, string pictureId)
        {
            await _galleryAlbumContextPresenter
                .RemovePictureAsync(refModel.Id, new List<string> { pictureId });
        }

        private async void TitleTextBoxLeave(object sender, EventArgs e)
        {
            await UpdateTitle();
        }

        private async void TitleTextBoxEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            await UpdateTitle();
        }

        private async Task UpdateTitle()
        {
            if (titleControl.Text == _originalTitle)
                return;
            await _galleryAlbumContextPresenter.UpdateTitleAsync(refModel.Id, titleControl.Text);
        }

        private async void PublishButtonClicked(object sender, EventArgs e)
        {
            await _galleryAlbumContextPresenter.PublishAlbumToGalleryAsync(refModel.Id, titleControl.Text);
        }
    }
}
