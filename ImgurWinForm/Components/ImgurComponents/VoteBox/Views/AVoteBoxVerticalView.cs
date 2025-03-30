using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Views
{
    internal abstract partial class AVoteBoxVerticalView : AVoteBoxView
    {
        protected AVoteBoxVerticalView(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            InitializeComponent();
            InitializeControls();
        }
    }
}
