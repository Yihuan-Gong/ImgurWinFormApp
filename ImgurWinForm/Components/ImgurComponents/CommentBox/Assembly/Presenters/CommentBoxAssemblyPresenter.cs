using ImgurAPI;
using ImgurAPI.Comment;
using ImgurAPI.Gallery.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.Assembly.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Models;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.Assembly.Presenters
{
    internal class CommentBoxAssemblyPresenter : ICommentBoxAssemblyPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ACommentBoxAssemblyView _commentBoxAssemblyView;

        public CommentBoxAssemblyPresenter(IServiceProvider serviceProvider, ACommentBoxAssemblyView CommentBoxAssemblyView)
        {
            _serviceProvider = serviceProvider;
            _commentBoxAssemblyView = CommentBoxAssemblyView;
        }
    }
}
