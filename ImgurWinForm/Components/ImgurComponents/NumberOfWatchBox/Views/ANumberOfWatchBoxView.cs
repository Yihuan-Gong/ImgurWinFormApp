using ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.NumberOfWatchBox.Views
{
    internal abstract partial class ANumberOfWatchBoxView : UserControl
    {
        public ANumberOfWatchBoxView()
        {
            InitializeComponent();
        }

        public abstract void LoadWatchNumber(NumberOfWatchBoxReqModel req);
    }
}
