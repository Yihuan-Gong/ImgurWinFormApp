using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.Labels
{
    internal class UpLabel : Label
    {
        public UpLabel()
        {
            //AutoSize = true;
            Font = new System.Drawing.Font("新細明體", 14F);
            Location = new System.Drawing.Point(2, 0);
            Margin = new Padding(2, 0, 2, 0);
            Size = new System.Drawing.Size(20, 24);
            Text = "⬆︎";
        }
    }
}
