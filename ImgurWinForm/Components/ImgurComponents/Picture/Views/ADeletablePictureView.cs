using ImgurAPI.Image.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.Picture.Views
{
    internal abstract class ADeletablePictureView : APictureView
    {
        public EventHandler PictureDeleted { get; set; }
        protected ADeletablePictureView(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            InitializeControl();
        }

        private void InitializeControl()
        {
            extensionFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            extensionFlowLayoutPanel.Controls.Add(InitializeDeleteLabel());
        }

        public Label InitializeDeleteLabel()
        {
            var label = new Label
            {
                Text = "X"
            };
            label.Click += DeleteLabelClicked;
            return label;
        }

        private void DeleteLabelClicked(object sender, EventArgs e)
        {
            PictureDeleted?.Invoke(null, null);
        }
    }
}
