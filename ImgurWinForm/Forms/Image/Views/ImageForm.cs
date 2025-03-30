using DTO;
using ImgurAPI.Album.Models;
using ImgurAPI.Gallery.Models;
using ImgurWinForm.Components.ImgurComponents.FavoriteButton.Views;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Models;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurAPI;
using ImgurWinForm.Components.ImgurComponents.CommentBox.Assembly.Views;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Views;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;

namespace ImgurWinForm.Forms.Image.Views
{
    internal partial class ImageForm : Form
    {
        private readonly AVoteBoxVerticalView _voteBoxView;
        private readonly AGalleryContextView _contextView;
        private readonly AFavoriteButtonView _favoriteButtonView;
        private readonly ACommentBoxAssemblyView _commentBoxView;

        public ImageForm(AVoteBoxVerticalView voteBoxView, AGalleryContextView contextView, 
            AFavoriteButtonView favoriteButtonView, ACommentBoxAssemblyView commentBoxView)
        {
            InitializeComponent();

            _voteBoxView = voteBoxView;
            _contextView = contextView;
            _favoriteButtonView = favoriteButtonView;
            _commentBoxView = commentBoxView;

            voteBoxFlowLayoutPanel.Controls.Add(_voteBoxView);
            pictureBoxFlowLayoutPanel.Controls.Add(_contextView);
            favoriteButtonFlowLayoutPanel.Controls.Add(_favoriteButtonView);
            commentBoxFlowLayoutPanel.Controls.Add(_commentBoxView);
        }

        public async Task LoadAsync(GalleryAlbumModel galleryModel)
        {
            await _contextView.LoadDataAsync(galleryModel);
            _voteBoxView.LoadVote(new Mapper<GalleryAlbumModel, VoteReqModel>().Map(galleryModel));
            _favoriteButtonView.LoadFavorite(galleryModel);
            await _commentBoxView.LoadDataAsync(galleryModel);
        }
    }
}
