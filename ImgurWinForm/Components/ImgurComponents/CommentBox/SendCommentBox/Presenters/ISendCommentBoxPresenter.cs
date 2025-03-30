using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Presenters
{
    internal interface ISendCommentBoxPresenter
    {
        Task SendCommentAsync(SendCommentReqModel reqModel);

        Task UploadPictureAsync(string path);
    }
}