using ImgurAPI.Comment;
using ImgurWinForm.Components.ImgurComponents.VoteBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Models
{
    internal class IndicateCommentReqModel
    {
        public long Id { get; set; } // 這個Id和gallery的Id的data type不一樣
        public string ImageId { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public long AuthorId { get; set; }
        public bool OnAlbum { get; set; }
        public string AlbumCover { get; set; }
        public int Ups { get; set; }
        public int Downs { get; set; }
        public int Points { get; set; }
        public int Datetime { get; set; }
        public long ParentId { get; set; }
        public bool Deleted { get; set; }
        public VoteMode? Vote { get; set; }
        public string Platform { get; set; }
        public bool HasAdminBadge { get; set; }
        public IndicateCommentReqModel[] Children { get; set; }
    }
}
