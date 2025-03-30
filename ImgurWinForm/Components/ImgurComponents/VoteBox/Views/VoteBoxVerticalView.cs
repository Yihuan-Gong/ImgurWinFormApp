using ImgurWinForm.Components.ImgurComponents.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Views
{
    internal class VoteBoxVerticalView : AVoteBoxVerticalView
    {
        public VoteBoxVerticalView(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public override Label InitializeDownLabelLayout()
        {
            return new DownLabel();
        }

        public override Label InitializeScoreLabelLayout()
        {
            return new ScoreLabel();
        }

        public override Label InitializeUpLabelLayout()
        {
            return new UpLabel();
        }
    }
}
