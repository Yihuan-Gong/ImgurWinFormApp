using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Models
{
    internal class VoteResModel
    {
        private readonly Color _defaultLabelColor = Color.Black;
        private readonly Color _upVoteLabelColor = Color.Green;
        private readonly Color _downVoteLabelColor = Color.Red;

        public string Id { get; set; }
        public int Points { get; set; }
        public VotePlace VotePlace { get; set; }
        public VoteMode? Vote { get; set; }
        public Color UpLabelColor
        {
            get { return Vote == VoteMode.up ? _upVoteLabelColor : _defaultLabelColor; }
        }
        public Color DownLabelColor
        {
            get { return Vote == VoteMode.down ? _downVoteLabelColor : _defaultLabelColor; }
        }
    }
}
