using ImgurAPI.Vote.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Models;

namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Presenters
{
    internal interface IVoteBoxPresenter
    {
        Task VoteAsync(VoteReqModel currentVoteState);
    }
}
