using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Models
{
    internal class SendCommentReqModel
    {
        public string GalleryId { get; set; }
        public long? CommentId { get; set; }
        public string CommentText { get; set; }
        public string PictirePath { get; set; }
        public string PictureLink { get; set; }
    }
}
