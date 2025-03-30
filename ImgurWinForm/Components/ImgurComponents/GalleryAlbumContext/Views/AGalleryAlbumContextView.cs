using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Presenters;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Views;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Views
{
    internal abstract partial class AGalleryAlbumContextView : UserControl
    {
        protected GalleryAlbumModel refModel;
        protected readonly IServiceProvider serviceProvider;
        protected readonly IGalleryAlbumContextPresenter _galleryAlbumContextPresenter;

        public AGalleryAlbumContextView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
            _galleryAlbumContextPresenter = serviceProvider.CreatePresenter<IGalleryAlbumContextPresenter, AGalleryAlbumContextView>(this);
        }

        public virtual async Task LoadDataAsync(GalleryAlbumModel model)
        {
            InitiailizeControl();
            refModel = model;
            titleControl.Text = model.Title;
            foreach (ImageModel imageModel in refModel.Images)
            {
                // 在imageLink = itemModel.Link的時候會掛掉
                await RenderNewPictureAsync(imageModel);
            }
        }

        // 這裡，我的IPresenter根據AView子類別需求功能來擴充，那我的最父類別的AView
        // 也要根據它的子類別需求功能來擴充function給presenter使用嗎？
        public void PresenterUpdated(GalleryAlbumModel updatedModel)
        {
            refModel = updatedModel;
        }

        protected abstract Task RenderNewPictureAsync(ImageModel model);
    }
}
