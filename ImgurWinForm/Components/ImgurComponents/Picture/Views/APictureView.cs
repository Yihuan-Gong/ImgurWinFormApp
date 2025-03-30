using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.Picture.Presenters;
using MVPExtension;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.Picture.Views
{
    internal abstract partial class APictureView : UserControl
    {
        public int PictureWidth 
        { 
            get => _pictureWidth; 
            set => _pictureWidth = value; 
        }
        public int PictureHeight 
        { 
            get => _pictureHeight; 
            set => _pictureHeight = value; 
        }
        public EventHandler ImageClicked { set; private get; }
        protected readonly IPicturePresenter _picturePresenter;
        private int _pictureWidth = 200;
        private int _pictureHeight = 200;

        public APictureView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            InitializeControl();

            _picturePresenter = serviceProvider.CreatePresenter<IPicturePresenter, APictureView>(this);
        }

        

        public virtual PictureBox InitializePictureBox()
        {
            var pictureBox = new System.Windows.Forms.PictureBox
            {
                Width = _pictureWidth,
                Height = _pictureHeight,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pictureBox.Click += (s, e) => ImageClicked?.Invoke(s,e);
            return pictureBox;
        }

        public async Task LoadPictureAsync(string url)
        {
            await _picturePresenter.DownPictureAsync(url);
        }

        public void PresenterDownloaded(Image downloadedPicture)
        {
            pictureBox.Image = downloadedPicture;
        }
    }
}
