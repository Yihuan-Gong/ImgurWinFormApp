using DTO;
using HttpRequestModule;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.Picture.Presenters
{
    internal class PicturePresenter : IPicturePresenter
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly APictureView _pictureView;

        public PicturePresenter(IServiceProvider serviceProvider, APictureView PictureView)
        {
            _serviceProvider = serviceProvider;
            _pictureView = PictureView;
        }

        public async Task DownPictureAsync(string url)
        {
            var httpRequest = new HttpRequest();

            if (url.EndsWith(".mp4"))
            {
                //await ExtractAndDisplayFirstFrame(galleryViewModel, link);
            }
            else
            {
                byte[] imageByte = await httpRequest.GetAsyn(url);
                var downloadedImage = Image.FromStream(new MemoryStream(imageByte));
                _pictureView.PresenterDownloaded(downloadedImage);
            }
            
        }

        //private async Task ExtractAndDisplayFirstFrame(GalleryViewModel galleryViewModel, string link)
        //{
        //    await Task.Run(() =>
        //    {
        //        string ffmpegPath = @"ffmpeg.exe";
        //        string outputImagePath = $"C:\\Users\\User\\test\\{galleryViewModel.Id}.jpg";
        //        //string outputImagePath = Path.Combine(Path.GetTempPath(), $"{image.Id}.jpg");

        //        Process ffmpeg = new Process();
        //        ffmpeg.StartInfo.FileName = ffmpegPath;
        //        ffmpeg.StartInfo.Arguments = $"-i {link} -vf \"select=eq(n\\,0)\" -q:v 3 {outputImagePath}";
        //        ffmpeg.StartInfo.UseShellExecute = false;
        //        ffmpeg.StartInfo.CreateNoWindow = true;
        //        ffmpeg.Start();
        //        ffmpeg.WaitForExit();

        //        galleryViewModel.Image = Image.FromFile(outputImagePath);
        //    });
        //}
    }
}
