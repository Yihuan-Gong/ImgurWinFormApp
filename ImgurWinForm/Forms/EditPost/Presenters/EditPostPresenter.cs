using ImgurAPI;
using ImgurAPI.Album.Models;
using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Forms.EditPost.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.EditPost.Presenters
{
    internal class EditPostPresenter : IEditPostPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AEditPostView _editPostView;

        public EditPostPresenter(IServiceProvider serviceProvider, AEditPostView editPostView)
        {
            _serviceProvider = serviceProvider;
            _editPostView = editPostView;
        }
    }
}
