using ImgurAPI.Gallery.Models;
using ImgurWinForm.Forms.GallerySearch.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Presenters;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Models;
using MVPExtension;
using DTO;

namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Views
{
    internal abstract partial class AVoteBoxView : UserControl
    {
        protected readonly IVoteBoxPresenter _voteBoxPresenter;

        private readonly Label _upLabel;
        private readonly Label _downLabel;
        private readonly Label _scoreLabel;
        private VoteResModel _currentVoteState;

        protected Label UpLabel { get => _upLabel; }
        protected Label DownLabel { get => _downLabel; }
        protected Label ScoreLabel { get => _scoreLabel; }

        public AVoteBoxView(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _upLabel = InitializeUpLabelLayout();
            _downLabel = InitializeDownLabelLayout();
            _scoreLabel = InitializeScoreLabelLayout();
            _upLabel.Click += new EventHandler(UpLabel_Click);
            _downLabel.Click += new EventHandler(DownLabel_Click);


            _voteBoxPresenter = serviceProvider.CreatePresenter<IVoteBoxPresenter, AVoteBoxView>(this);
        }

        public abstract Label InitializeUpLabelLayout();
        public abstract Label InitializeDownLabelLayout();
        public abstract Label InitializeScoreLabelLayout();

        public void LoadVote(VoteReqModel voteReqModel)
        {
            _currentVoteState = new Mapper<VoteReqModel, VoteResModel>().Map(voteReqModel);
            PresenterVoted(_currentVoteState);
        }

        public void PresenterVoted(VoteResModel vote)
        {
            ScoreLabel.Text = vote.Points.ToString();
            UpLabel.ForeColor = vote.UpLabelColor;
            DownLabel.ForeColor = vote.DownLabelColor;
        }

        private async void UpLabel_Click(object sender, EventArgs e)
        {
            await _voteBoxPresenter.VoteAsync(NewVote(VoteMode.up));
        }

        private async void DownLabel_Click(object sender, EventArgs e)
        {
            await _voteBoxPresenter.VoteAsync(NewVote(VoteMode.down));
        }

        private VoteReqModel NewVote(VoteMode mode)
        {
            var voteReq = new Mapper<VoteResModel, VoteReqModel>().Map(_currentVoteState);
            voteReq.VoteAction = mode;
            return voteReq;
        }
    }
}
