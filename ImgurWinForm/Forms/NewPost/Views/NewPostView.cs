using ImgurWinForm.Components.ImgurComponents.UploadPictures.Views;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.NewPost.Views
{
    internal class NewPostView : ANewPostView
    {
        public NewPostView(IServiceProvider serviceProvider, AUploadPicturesView newPicturesView) : 
            base(serviceProvider, newPicturesView)
        {
        }
    }
}
