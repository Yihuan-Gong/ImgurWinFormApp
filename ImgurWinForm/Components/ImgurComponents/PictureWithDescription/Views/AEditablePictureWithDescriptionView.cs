using ImgurAPI.Image.Models;
using ImgurWinForm.Components.ImgurComponents.Picture.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.PictureWithDescription.Views
{
    internal abstract class AEditablePictureWithDescriptionView : APictureWithDescriptionView
    {
        public EventHandler<string> PictureDeleted { get; set; }
        private TextBox _descriptionTextBox;
        private string _originalDescription;

        public AEditablePictureWithDescriptionView(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override async Task LoadPictureAsync(ImageModel imageModel)
        {
            var picture = serviceProvider.GetService<ADeletablePictureView>();
            rootPanel.Controls.Add(picture);
            await picture.LoadPictureAsync(imageModel.Link);
            picture.PictureDeleted += OnPictureDeleted;
        }

        protected override void LoadDescription(string description)
        {
            _descriptionTextBox = new TextBox
            {
                AutoSize = true,
                MaximumSize = new Size(Width, int.MaxValue)
            };
            rootPanel.Controls.Add(_descriptionTextBox);
            _descriptionTextBox.Leave += DescriptionTextBoxLeave;
            _descriptionTextBox.KeyDown += DescriptionTextBoxEnterPressed;
            _descriptionTextBox.Text = description;
            _originalDescription = description;
        }

        private void OnPictureDeleted(object sender, EventArgs e)
        {
            PictureDeleted?.Invoke(sender, refModel.Id);
            this.Dispose();
        }

        private async void DescriptionTextBoxLeave(object sender, EventArgs e)
        {
            await UpdateDescription();
        }

        private async void DescriptionTextBoxEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            await UpdateDescription();
        }

        private async Task UpdateDescription()
        {
            if (_descriptionTextBox.Text == _originalDescription)
                return;

            await pictureWithDescriptionPresenter.UpdateDescriptionAsync(_descriptionTextBox.Text);
        }
    }
}
