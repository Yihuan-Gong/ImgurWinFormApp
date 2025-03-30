using ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Views
{
    internal class NumberOfWatchBoxView : ANumberOfWatchBoxView
    {
        public override void LoadWatchNumber(NumberOfWatchBoxReqModel req)
        {
            watchNumLabel.Text = req.Views.ToString();
        }
    }
}
