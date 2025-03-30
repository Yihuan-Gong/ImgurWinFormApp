using DTO;
using ImgurAPI.Album.Models;
using ImgurAPI.Gallery.Models;
using ImgurAPI;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Presenters;
using ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Models;
using ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Views;
using ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Models;
using ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Views;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Models;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Views;
using ImgurWinForm.Forms.Image.Views;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using FormComponents.Utilities.Interfaces;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Views
{
    internal abstract partial class AGalleryAlbumItemView : UserControl, IItemUpdatable<GalleryAlbumModel>
    {
        protected readonly IGalleryAlbumItemPresenter _galleryAlbumItemPresenter;
        protected readonly IServiceProvider serviceProvider;
        protected GalleryAlbumModel referenceModel;
        private readonly ABasicPictureView _pictureView;
        private readonly AVoteBoxView _voteBoxView;
        private readonly ANumberOfCommentBoxView _numberOfCommentBoxView;
        private readonly ANumberOfWatchBoxView _numberOfWatchBoxView;
        

        public GalleryAlbumModel ReferenceModel { get => referenceModel; set => referenceModel = value; }

        public AGalleryAlbumItemView(IServiceProvider serviceProvider, ABasicPictureView pictureView,
            AVoteBoxHorizontalView voteBoxView, ANumberOfWatchBoxView numberOfWatchBoxView,
            ANumberOfCommentBoxView numberOfCommentBoxView)
        {
            InitializeComponent();

            _galleryAlbumItemPresenter = serviceProvider.CreatePresenter<IGalleryAlbumItemPresenter, AGalleryAlbumItemView>(this);

            this.serviceProvider = serviceProvider;

            _pictureView = pictureView;
            _pictureView.ImageClicked = OnImageClicked;

            _voteBoxView = voteBoxView;
            _numberOfCommentBoxView = numberOfCommentBoxView;
            _numberOfWatchBoxView = numberOfWatchBoxView;

            pictureFlowLayoutPanel.Controls.Add(_pictureView);
            voteBoxFlowLayoutPanel.Controls.Add(_voteBoxView);
            numberOfWatchFlowLayoutPanel.Controls.Add(_numberOfWatchBoxView);
            numberOfCommentFlowLayoutPanel.Controls.Add(_numberOfCommentBoxView);
        }

        public async Task LoadItemAsync(GalleryAlbumModel itemModel)
        {
            referenceModel = itemModel;

            // 這邊需要處理itemModel.Images == null的情況，也就是imageLink = itemModel.Link
            if (itemModel.Images == null && itemModel.Link.Contains("i.imgur.com"))
            {
                itemModel.Images = new ImgurAPI.Image.Models.ImageModel[]
                {
                    new ImgurAPI.Image.Models.ImageModel
                    {
                        Link = itemModel.Link,
                    }
                };
            }
            
            if (itemModel.Images != null)
                await _pictureView.LoadPictureAsync(itemModel.Images[0].Link);

            RenderGalleryExceptPictureOnUiThread();
        }

        public async Task LoadItemAsync(GalleryAlbumModel itemModel, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
                return;

            await LoadItemAsync(itemModel);
        }

        public async Task UpdateItemAsync()
        {
            await _galleryAlbumItemPresenter.SyncGalleryAlbumWithImgurAsync(referenceModel);
        }

        public async Task UpdateItemAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
                return;

            await UpdateItemAsync();
        }

        public void PresenterSyncWithImgurFinished(GalleryAlbumModel itemModel)
        {
            referenceModel = itemModel;
            RenderGalleryExceptPictureOnUiThread();
        }

        protected abstract void OnImageClicked(object sender, EventArgs e);
        

        private void RenderGalleryExceptPictureOnUiThread()
        {
            if (this.InvokeRequired)
            {
                // 用 BeginInvoke 非同步調用，不會阻塞目前的背景執行緒
                this.BeginInvoke(new Action(RenderGalleryExceptPictureOnUiThread));
            }
            else
            {
                titleLabel.Text = referenceModel.Title;
                _voteBoxView.LoadVote(new Mapper<GalleryAlbumModel, VoteReqModel>().Map(referenceModel));
                _numberOfWatchBoxView.LoadWatchNumber(new Mapper<GalleryAlbumModel, NumberOfWatchBoxReqModel>().Map(referenceModel));
                _numberOfCommentBoxView.LoadCommentNumber(new Mapper<GalleryAlbumModel, NumberOfCommentBoxReqModel>().Map(referenceModel));
            }
        }
    }
}
