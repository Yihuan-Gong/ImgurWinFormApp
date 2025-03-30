using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.ShowComment.Presenters
{
    internal interface IShowCommmentPresenter
    {
        Task LoadCommentAsync(string comment);
    }
}