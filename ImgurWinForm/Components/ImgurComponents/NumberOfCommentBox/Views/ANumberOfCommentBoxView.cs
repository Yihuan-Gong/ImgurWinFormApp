using ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.NumberOfCommentBox.Views
{
    internal abstract partial class ANumberOfCommentBoxView : UserControl
    {
        public ANumberOfCommentBoxView()
        {
            InitializeComponent();
        }

        public abstract void LoadCommentNumber(NumberOfCommentBoxReqModel req);
    }
}
