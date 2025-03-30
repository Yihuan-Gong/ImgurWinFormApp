using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.Labels
{
    internal class ScoreLabel : Label
    {
        public ScoreLabel()
        {
            //AutoSize = true,
            Location = new System.Drawing.Point(44, 6);
            Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Size = new System.Drawing.Size(14, 15);
            Text = "0";
        }
    }
}
