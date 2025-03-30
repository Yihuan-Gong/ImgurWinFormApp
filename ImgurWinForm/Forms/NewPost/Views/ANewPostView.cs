using ImgurAPI.Album.API;
using ImgurAPI.Album.Models;
using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.UploadPictures.Views;
using ImgurWinForm.Forms.EditPost.Views;
using ImgurWinForm.Forms.NewPost.Presenters;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.NewPost.Views
{
    internal abstract partial class ANewPostView : Form
    {
        protected readonly INewPostPresenter _newPostPresenter;

        private readonly IServiceProvider _serviceProvider;

        public ANewPostView(IServiceProvider serviceProvider, AUploadPicturesView newPicturesView)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _newPostPresenter = serviceProvider.CreatePresenter<INewPostPresenter, ANewPostView>(this);

            uploadPictureFlowLayoutPanel.Controls.Add(newPicturesView);
            newPicturesView.PicturesUploaded += NewPictureUploaded;
        }

        public async Task PresenterAlbumCreatedAsync(GalleryAlbumModel newAlbum)
        {
            var editAlbumForm = _serviceProvider.GetService<AEditPostView>();
            await editAlbumForm.LoadDataAsync(newAlbum);
            editAlbumForm.Show();
        }

        private async void NewPictureUploaded(object sender, ImageModel[] newPictureModel)
        {
            await _newPostPresenter.CreateNewAlbumAsync(newPictureModel);
        }
    }
}
