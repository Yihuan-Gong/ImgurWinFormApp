using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImgurWinForm.Components.ImgurComponents.Labels
{
    internal class ImgurLabel : Label
    {
        public ImgurLabel(LabelSize labelSize, Point location, string text)
        {
            SetBasicProperties(labelSize, location, text);
        }

        public ImgurLabel(LabelSize labelSize, Point location, string text, Color textColor)
        {
            SetBasicProperties(labelSize, location, text);
            ForeColor = textColor;
        }

        public ImgurLabel(LabelSize labelSize, Point location, string text, Color textColor, EventHandler clickedEvent)
        {
            SetBasicProperties(labelSize, location, text);
            ForeColor = textColor;
            Click += clickedEvent;
        }

        private void SetBasicProperties(LabelSize labelSize, Point location, string text)
        {
            Font = new Font("新細明體", GetFontSize(labelSize));
            ForeColor = SystemColors.ControlText;
            Location = location;
            Margin = new Padding(2, 0, 2, 0);
            Size = new Size(20, 24);
            Text = text;
        }

        private float GetFontSize(LabelSize labelSize)
        {
            switch (labelSize)
            {
                case LabelSize.Large:
                    return 20F;
                case LabelSize.Small:
                    return 12F;
                case LabelSize.Medium:
                    return 15F;
                default:
                    return 15F;

            }
        }
    }
}
