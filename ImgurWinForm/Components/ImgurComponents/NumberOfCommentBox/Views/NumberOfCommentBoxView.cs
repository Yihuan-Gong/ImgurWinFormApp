using ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Views
{
    internal class NumberOfCommentBoxView : ANumberOfCommentBoxView
    {
        public override void LoadCommentNumber(NumberOfCommentBoxReqModel req)
        {
            commentNumLabel.Text = req.CommentCount.ToString();
        }
    }
}
