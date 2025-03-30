using ImgurWinForm.Components.ImgurComponents.CommentBox.ShowComment.Views;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Views;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Views
{
    internal class IndicateCommentBoxView : AIndicateCommentBoxView
    {
        public IndicateCommentBoxView(IServiceProvider serviceProvider, AVoteBoxHorizontalView voteBoxView, AShowCommmentView showCommmentView) : 
            base(serviceProvider, voteBoxView, showCommmentView)
        {
        }
    }
}
