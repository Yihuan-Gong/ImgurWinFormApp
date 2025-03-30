using ImgurWinForm.Components.ImgurComponents.GalleryAlbumContext.Views;
using ImgurWinForm.Components.ImgurComponents.UploadPictures.Views;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.EditPost.Views
{
    internal class EditPostView : AEditPostView
    {
        public EditPostView(IServiceProvider serviceProvider, AAlbumContextView albumContextView) : 
            base(serviceProvider, albumContextView)
        {
        }
    }
}
