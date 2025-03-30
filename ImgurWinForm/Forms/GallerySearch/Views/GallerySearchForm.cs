using ImgurWinForm.Forms.GallerySearch.Presenters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPExtension;
using FormComponents.Components.Search.Views;
using Microsoft.Extensions.DependencyInjection;
using ImgurWinForm.Forms.NewPost.Views;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Views;
using ImgurWinForm.Forms.UserProfile.Views;

namespace ImgurWinForm.Forms.GallerySearch.Views
{
    internal partial class GallerySearchForm : Form, IGallerySearchView
    {
        private List<GalleryAlbumModel> _searchResult;
        private readonly IGallerySearchPresenter _gallerySearchPresenter;
        private readonly ASearchView<AGalleryItemView, GalleryAlbumModel> _searchView;
        private readonly IServiceProvider _serviceProvider;

        private readonly string USERNAME = "aring981";
        
        public GallerySearchForm(ASearchView<AGalleryItemView, GalleryAlbumModel> gallerySearchView, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _gallerySearchPresenter = serviceProvider.CreatePresenter<IGallerySearchPresenter, IGallerySearchView>(this);
            _searchView = gallerySearchView;
            _searchView.SearchMethod = SearchMethod;
            gallerySearchFlowLayoutPanel.Controls.Add(_searchView);
        }

        public void PresenterSearchCompleted(List<GalleryAlbumModel> searchResult)
        {
            _searchResult = searchResult;
        }

        private async Task<List<GalleryAlbumModel>> SearchMethod(string searchText)
        {
            await _gallerySearchPresenter.Search(searchText);
            return _searchResult;
        }

        private async void UserProfileButtonClicked(object sender, EventArgs e)
        {
            var userProfileForm = _serviceProvider.GetService<AUserProfileView>();
            userProfileForm.LoadData(USERNAME);
            userProfileForm.Show();
        }

        private void NewPostButtonClicked(object sender, EventArgs e)
        {
            var newPostForm = _serviceProvider.GetService<ANewPostView>();
            newPostForm.Show();
        }
    }
}
