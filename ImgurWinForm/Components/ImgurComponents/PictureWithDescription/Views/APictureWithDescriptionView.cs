using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Presenters;
using IoCContainer;
using Microsoft.Extensions.DependencyInjection;
using MVPExtension;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Views
{
    internal abstract partial class APictureWithDescriptionView : UserControl
    {
        protected readonly IServiceProvider serviceProvider;
        protected readonly IPictureWithDescriptionPresenter pictureWithDescriptionPresenter;
        protected ImageModel refModel;

        public APictureWithDescriptionView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            
            this.serviceProvider = serviceProvider;
            pictureWithDescriptionPresenter = serviceProvider.CreatePresenter<IPictureWithDescriptionPresenter, APictureWithDescriptionView>(this);
        }

        public async Task LoadDataAsync(ImageModel imageModel)
        {
            InitiailizeControl();
            await LoadPictureAsync(imageModel);
            LoadDescription(imageModel.Description);
            refModel = imageModel;
        }

        protected virtual async Task LoadPictureAsync(ImageModel imageModel)
        {
            var picture = serviceProvider.GetService<APictureView>();
            rootPanel.Controls.Add(picture);
            await picture.LoadPictureAsync(imageModel.Link);
        }

        protected virtual void LoadDescription(string description)
        {
            var descriptionLabel = new Label
            {
                AutoSize = true,
                MaximumSize = new Size(Width, int.MaxValue)
            };
            rootPanel.Controls.Add(descriptionLabel);
            descriptionLabel.Text = description;
        }
    }
}
