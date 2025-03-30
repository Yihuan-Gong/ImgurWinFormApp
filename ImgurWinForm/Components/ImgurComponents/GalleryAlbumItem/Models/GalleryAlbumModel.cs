using ImgurAPI.Gallery.Models;
using ImgurAPI.Image.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.GalleryAlbumItem.Models
{
    internal class GalleryAlbumModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Datetime { get; set; }
        public string Cover { get; set; }
        public int CoverWidth { get; set; }
        public int CoverHeight { get; set; }
        public string AccountUrl { get; set; }
        public int AccountId { get; set; }
        public string Privacy { get; set; }
        public int Views { get; set; }
        public string Link { get; set; }
        public int Ups { get; set; }
        public int Downs { get; set; }
        public int Points { get; set; }
        //public int Score { get; set; }
        public bool IsAlbum { get; set; }
        public string Vote { get; set; }
        public bool Favorite { get; set; }
        public int CommentCount { get; set; }
        public int FavoriteCount { get; set; }
        public int ImagesCount { get; set; }
        public bool InGallery { get; set; }
        public ImageModel[] Images { get; set; }
    }
}
