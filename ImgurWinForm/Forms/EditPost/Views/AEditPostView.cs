using ImgurAPI.Album.Models;
using ImgurAPI.Image.Models;
using ImgurWinForm.Components;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Views;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.UploadPictures.Views;
using ImgurWinForm.Forms.EditPost.Presenters;
using ImgurWinForm.Forms.Image.Views;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.EditPost.Views
{
    internal abstract partial class AEditPostView : Form
    {
        private GalleryAlbumModel _refModel;
        private readonly AAlbumContextView _albumContextView;
        private readonly IEditPostPresenter _editPostPresenter;
        private readonly IServiceProvider _serviceProvider;

        public AEditPostView(IServiceProvider serviceProvider, AAlbumContextView albumContextView)
        {
            InitializeComponent();
            albumContextFlowLayoutPanel.Controls.Add(albumContextView);
            _albumContextView = albumContextView;
            _serviceProvider = serviceProvider;
            _editPostPresenter = serviceProvider.CreatePresenter<IEditPostPresenter, AEditPostView>(this);
        }

        public async Task LoadDataAsync(GalleryAlbumModel model)
        {
            _refModel = model;
            await _albumContextView.LoadDataAsync(model);
        }

        public async Task PresenterGalleryPublished(GalleryAlbumModel newGallery)
        {
            var galleryForm = _serviceProvider.GetService<ImageForm>();
            await galleryForm.LoadAsync(newGallery);
            galleryForm.Show();
            this.Close();
        }
    }
}
