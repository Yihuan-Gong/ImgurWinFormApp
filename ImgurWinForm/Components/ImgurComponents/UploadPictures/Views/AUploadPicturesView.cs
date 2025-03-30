using ImgurAPI;
using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.UploadPictures.Presenters;
using IoCContainer;
using MVPExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ImgurWinForm.Components.ImgurComponents.UploadPictures.Views
{
    internal abstract partial class AUploadPicturesView : UserControl
    {
        public EventHandler<ImageModel[]> PicturesUploaded { get; set; }

        protected readonly IUploadPicturesPresenter _uploadPicturesPresenter;

        public AUploadPicturesView(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _uploadPicturesPresenter = serviceProvider.CreatePresenter<IUploadPicturesPresenter, AUploadPicturesView>(this);
        }

        public void PresenterPictureUploaded(ImageModel[] uploadedPictures)
        {
            PicturesUploaded.Invoke(null, uploadedPictures);
        }

        private async void NewPictureButtonClicked(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "選擇圖片";
                openFileDialog.Filter = "圖片檔案 (*.jpg; *.jpeg; *.png; *.bmp; *.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有檔案 (*.*)|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await _uploadPicturesPresenter.UploadPicturesAsync(openFileDialog.FileNames);
                }
            }
        }

        
    }
}
