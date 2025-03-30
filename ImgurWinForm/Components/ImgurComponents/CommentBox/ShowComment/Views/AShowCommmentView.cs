using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.CommentBox.ShowComment.Presenters;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using IoCContainer;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.ShowComment.Views
{
    internal abstract partial class AShowCommmentView : UserControl
    {
        protected readonly IShowCommmentPresenter _showCommmentPresenter;
        private IServiceProvider _serviceProvider;
        
        public AShowCommmentView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _showCommmentPresenter = serviceProvider.CreatePresenter<IShowCommmentPresenter, AShowCommmentView>(this);
        }

        public async Task LoadDataAsync(string comment)
        {
            InitializeControl();

            await _showCommmentPresenter.LoadCommentAsync(comment);
        }

        public void PresenterCommentTextLoaded(string text)
        {
            commentTextLabel.Text += text;
        }

        public void PresenterCommentLinkLoaded(string link)
        {
            commentTextLabel.Text += link;
        }

        public async Task PresenterCommentPictureLoadedAsync(string pictureLink)
        {
            var pictureBox = _serviceProvider.GetService<APictureView>();
            await pictureBox.LoadPictureAsync(pictureLink);
            rootPanel.Controls.Add(pictureBox);
        }
    }
}
