using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.Labels
{
    internal class DownLabel : Label
    {
        public DownLabel()
        {
            //AutoSize = true,
            Font = new System.Drawing.Font("新細明體", 14F);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Location = new System.Drawing.Point(101, 0);
            Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Size = new System.Drawing.Size(20, 24);
            Text = "⬇︎";
        }
    }
}
