using ImgurAPI;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ImgurAPI.Comment;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Models;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Presenters
{
    internal class IndicateCommentBoxPresenter : IIndicateCommentBoxPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AIndicateCommentBoxView _IndicateCommentBoxView;

        public IndicateCommentBoxPresenter(IServiceProvider serviceProvider, AIndicateCommentBoxView IndicateCommentBoxView)
        {
            _serviceProvider = serviceProvider;
            _IndicateCommentBoxView = IndicateCommentBoxView;
        }
    }
}
