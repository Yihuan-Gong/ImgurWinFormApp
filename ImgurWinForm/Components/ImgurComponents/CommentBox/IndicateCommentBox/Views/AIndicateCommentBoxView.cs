using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Models;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Presenters;
using ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Views;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Views;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Models;
using System.Threading.Tasks;
using ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBoxList.Views;
using ImgurWinForm.Components.ImgurComponents.CommentBox.ShowComment.Views;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Views
{
    internal abstract partial class AIndicateCommentBoxView : UserControl
    {
        private IndicateCommentReqModel _reqModel;
        private readonly IServiceProvider _serviceProvider;
        private AIndicateCommentBoxListView _subCommentsView;
        private readonly AVoteBoxView _voteBoxView;
        private readonly AShowCommmentView _showCommmentView;

        public AIndicateCommentBoxView(IServiceProvider serviceProvider, AVoteBoxHorizontalView voteBoxView, AShowCommmentView showCommmentView)
        {
            InitializeComponent();
            
            _serviceProvider = serviceProvider;

            _voteBoxView = voteBoxView;
            _showCommmentView = showCommmentView;
        }


        protected void ReplyButtonClicked(object sender, EventArgs e)
        {
            var sendCommentBoxView = _serviceProvider.GetService<ASendCommentBoxView>();
            sendCommentFlowLayoutPanel.Controls.Add(sendCommentBoxView);

            sendCommentBoxView.LoadData(new SendCommentBox.Models.SendCommentReqModel
            {
                GalleryId = _reqModel.ImageId,
                CommentId = _reqModel.Id
            });
            sendCommentBoxView.CommentSent += RenderNewCommentAsync;
        }

        protected async void ExtendLabelClicked(object sender, EventArgs e)
        {
            extendCollapseCommentLabel.Text = "colapse replies";
            extendCollapseCommentLabel.Click -= ExtendLabelClicked;
            extendCollapseCommentLabel.Click += CollapseLabelClicked;

            _subCommentsView = _serviceProvider.GetService<AIndicateCommentBoxListView>();
            nextLayerFlowLayoutPanel.Controls.Add(_subCommentsView);
            Console.WriteLine(_reqModel.Children.ToList().Count);

            rootPanel.SuspendLayout(); // 暫停 UI 佈局，避免重繪影響效能
            await _subCommentsView.LoadDataAsync(_reqModel.Children.ToList());
            rootPanel.ResumeLayout(true); // 重新啟用佈局

        }

        protected void CollapseLabelClicked(object sender, EventArgs e)
        {
            nextLayerFlowLayoutPanel.Controls.Clear();

            extendCollapseCommentLabel.Text = $"+ {_reqModel.Children.Count()} replies";
            extendCollapseCommentLabel.Click -= CollapseLabelClicked;
            extendCollapseCommentLabel.Click += ExtendLabelClicked;
        }

        protected async void RenderNewCommentAsync(object sender, long newCommentId)
        {
            if (_subCommentsView == null)
            {
                ExtendLabelClicked(null, null);
            }
            
            await _subCommentsView.AddNewCommentAsync(newCommentId);
        }

        public async Task LoadDataAsync(IndicateCommentReqModel commentReq)
        {
            InitializeControls();

            _reqModel = commentReq;

            _voteBoxView.LoadVote(new VoteReqModel
            {
                Id = _reqModel.Id.ToString(),
                Points = _reqModel.Ups - _reqModel.Downs,
                Vote = _reqModel.Vote,
                VotePlace = VotePlace.Comment,
            });

            //commentIndicationLabel.Text = commentReq.Comment;
            await _showCommmentView.LoadDataAsync(commentReq.Comment);

            if (_reqModel.Children.Count() > 0)
            {
                extendCollapseCommentLabel.Text = $"+ {_reqModel.Children.Count()} replies";
                extendCollapseCommentLabel.Click += ExtendLabelClicked;
            }   
        }
    }
}
