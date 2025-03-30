using FormComponents.Components.ItemBoxWithPagination.Views;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models;
using ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Views;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Forms.UserProfile.Views
{
    internal class UserProfileView : AUserProfileView
    {
        public UserProfileView(IServiceProvider serviceProvider) : 
            base(serviceProvider)
        {
        }
    }
}
