using ImgurWinForm.Components.ImgurComponents.CommentBox.ShowComment.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.ShowComment.Views;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.ShowComment.Presenters
{
    internal class ShowCommmentPresenter : IShowCommmentPresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AShowCommmentView _showCommmentView;

        public ShowCommmentPresenter(IServiceProvider serviceProvider, AShowCommmentView ShowCommmentView)
        {
            _serviceProvider = serviceProvider;
            _showCommmentView = ShowCommmentView;
        }

        public async Task LoadCommentAsync(string comment)
        {
            // "vejipejqifpeqpi "https://feefwef" wiofiewhigfiwe"
            // => List<Model>: ["vejipejqifpeqpi", "https://feefwef", "wiofiewhigfiwe"]
            // Model: string, type(str, picture, link)
            List<CommentTextModel> parsedComment = ParseComment(comment);

            // foreach
            //  if (str or link) then return to view (view直接放到flowLayoutPanel)
            //  if picture then load picture; return to view
            foreach (CommentTextModel commentElement in parsedComment)
            {
                if (commentElement.Type == CommentType.Picture)
                {
                    await _showCommmentView.PresenterCommentPictureLoadedAsync(commentElement.Text);
                }
                else if (commentElement.Type == CommentType.Link)
                {
                    _showCommmentView.PresenterCommentLinkLoaded(commentElement.Text);
                }
                else if (commentElement.Type == CommentType.Text)
                {
                    _showCommmentView.PresenterCommentTextLoaded(commentElement.Text);
                }
            }
        }

        private List<CommentTextModel> ParseComment(string input)
        {
            List<CommentTextModel> result = new List<CommentTextModel>();
            string urlPattern = @"https?://\S+";
            MatchCollection matches = Regex.Matches(input, urlPattern);

            int lastIndex = 0;
            foreach (Match match in matches)
            {
                // 取得 URL 之前的純文字部分
                if (match.Index > lastIndex)
                {
                    string textPart = input.Substring(lastIndex, match.Index - lastIndex).Trim();
                    if (!string.IsNullOrEmpty(textPart))
                    {
                        result.Add(new CommentTextModel { Text = textPart, Type = CommentType.Text });
                    }
                }

                // 取得 URL 並分類
                string url = match.Value;
                CommentType type = url.Contains("i.imgur.com") ? CommentType.Picture : CommentType.Link;
                result.Add(new CommentTextModel { Text = url, Type = type });

                lastIndex = match.Index + match.Length;
            }

            // 取得最後一段純文字
            if (lastIndex < input.Length)
            {
                string remainingText = input.Substring(lastIndex).Trim();
                if (!string.IsNullOrEmpty(remainingText))
                {
                    result.Add(new CommentTextModel { Text = remainingText, Type = CommentType.Text });
                }
            }

            return result;
        }
    }
}
