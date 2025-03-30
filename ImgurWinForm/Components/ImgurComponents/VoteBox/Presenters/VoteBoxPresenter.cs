using ImgurWinForm.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImgurAPI;
using DTO;
using ImgurAPI.Gallery.Models;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Views;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Models;
using Microsoft.Extensions.DependencyInjection;


namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Presenters
{
    internal class VoteBoxPresenter : IVoteBoxPresenter
    {
        private readonly AVoteBoxView _galleryVoteView;

        private readonly IServiceProvider _serviceProvider;

        private readonly Dictionary<VoteMode, int> _voteToScore = new Dictionary<VoteMode, int>()
        {
            { VoteMode.up, 1 },
            { VoteMode.down, -1 },
        };

        public VoteBoxPresenter(AVoteBoxView galleryVoteView, IServiceProvider serviceProvider)
        {
            _galleryVoteView = galleryVoteView;
            _serviceProvider = serviceProvider;
        }

        public async Task VoteAsync(VoteReqModel voteReq)
        {
            _galleryVoteView.PresenterVoted(ApplyVote(voteReq));

            var voteModeForApi = new Mapper<VoteMode?, ImgurAPI.Vote.Enums.VoteMode>().Map(voteReq.VoteAction);
            var apiService = _serviceProvider.GetService<Imgur>();

            if (voteReq.VotePlace == VotePlace.Gallery)
                await apiService.Vote.VoteGallary(voteReq.Id, voteModeForApi);
            else if (voteReq.VotePlace == VotePlace.Comment)
                await apiService.Vote.VoteComment(long.Parse(voteReq.Id), voteModeForApi);
        }

        private VoteResModel ApplyVote(VoteReqModel voteReq)
        {
            VoteResModel voteRes = new VoteResModel();
           

            if (voteReq.Vote == null || voteReq.Vote == VoteMode.veto)
            {
                voteRes.Vote = voteReq.VoteAction;
                voteRes.Points = voteReq.Points + _voteToScore[voteReq.VoteAction];
                return voteRes;
            }

            if (voteReq.Vote == voteReq.VoteAction)
            {
                voteRes.Vote = VoteMode.veto;
                voteRes.Points = voteReq.Points - _voteToScore[voteReq.VoteAction];
                voteReq.VoteAction = VoteMode.veto;
            }
            else
            {
                voteRes.Vote = voteReq.VoteAction;
                voteRes.Points = voteReq.Points + 2 * _voteToScore[voteReq.VoteAction];
            }
            return voteRes;
        }
    }
}
