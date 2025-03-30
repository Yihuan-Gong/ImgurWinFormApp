using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBoxList.Views;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Views;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.Assembly.Views
{
    internal class CommentBoxAssemblyView : ACommentBoxAssemblyView
    {
        public CommentBoxAssemblyView(IServiceProvider serviceProvider, ASendCommentBoxView sendCommentBoxView, AIndicateCommentBoxListView indicateCommentBoxListView) : 
            base(serviceProvider, sendCommentBoxView, indicateCommentBoxListView)
        {
        }
    }
}
