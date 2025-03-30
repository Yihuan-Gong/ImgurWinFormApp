using FormComponents.Components.ItemBoxWithPagination.Views;
using ImgurAPI.AccountSetting.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Views;
using ImgurWinForm.Forms.UserProfile.Presenters;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.UserProfile.Views
{
    internal abstract partial class AUserProfileView : Form
    {
        protected readonly IUserProfilePresenter _userProfilePresenter;
        private readonly IServiceProvider _serviceProvider;
        private string _userName;

        public AUserProfileView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userProfilePresenter = serviceProvider.CreatePresenter<IUserProfilePresenter, AUserProfileView>(this);
        }

        public void LoadData(string userName)
        {
            _userName = userName;
            userNameLabel.Text = _userName;
        }

        private async void GalleryButtonClicked(object sender, EventArgs e)
        {
            var results = await _userProfilePresenter.GetUserGalleriesAsync(_userName);
            RenderGalleries(results);
        }

        private async void AlbumButtonClicked(object sender, EventArgs e)
        {
            var results = await _userProfilePresenter.GetUserAlbumsAsync(_userName);
            var itemBoxWithPaginationView = _serviceProvider.GetService
                <AItemBoxWithPaginationView<AAlbumItemView, GalleryAlbumModel>>();
            ResetUserProfileFlowLayoutPanel();
            userProfileFlowLayoutPanel.Controls.Add(itemBoxWithPaginationView);
            itemBoxWithPaginationView.LoadData(results);
        }

        private async void FavoriteButtonClicked(object sender, EventArgs e)
        {
            var results = await _userProfilePresenter.GetUserFavoritesAsync(_userName);
            RenderGalleries(results);
        }

        private void RenderGalleries(List<GalleryAlbumModel> galleries)
        {
            var itemBoxWithPaginationView = _serviceProvider.GetService
                <AItemBoxWithPaginationView<AGalleryItemView, GalleryAlbumModel>>();
            ResetUserProfileFlowLayoutPanel();
            userProfileFlowLayoutPanel.Controls.Add(itemBoxWithPaginationView);
            itemBoxWithPaginationView.LoadData(galleries);
        }

        private void ResetUserProfileFlowLayoutPanel()
        {
            userProfileFlowLayoutPanel.Controls.Clear();
            GC.Collect();
        }
    }
}
