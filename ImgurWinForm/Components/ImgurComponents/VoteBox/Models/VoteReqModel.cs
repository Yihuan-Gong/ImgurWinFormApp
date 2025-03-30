using ImgurAPI.Vote.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Models
{
    internal class VoteReqModel
    {
        public string Id { get; set; }  // Comment和Gallery的Id的型別不一樣
        public int Points { get; set; }
        public VotePlace VotePlace { get; set; }
        public VoteMode? Vote { get; set; }
        public VoteMode VoteAction { get; set; }
    }
}
