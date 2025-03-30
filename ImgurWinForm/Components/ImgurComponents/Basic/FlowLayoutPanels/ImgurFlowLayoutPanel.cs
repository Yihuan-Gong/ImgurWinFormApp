using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels
{
    internal class ImgurFlowLayoutPanel : FlowLayoutPanel
    {
        public ImgurFlowLayoutPanel(FlowDirection flowDirection)
        {
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DoubleBuffered = true; // 啟用雙緩衝
            FlowDirection = flowDirection;

            // 優化繪圖設定
            SetStyle(ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.UserPaint
                   | ControlStyles.OptimizedDoubleBuffer, true);
        }

        public ImgurFlowLayoutPanel(int width)
        {
            BasicSettings(width);
        }

        public ImgurFlowLayoutPanel(int width, FlowDirection flowDirection)
        {
            BasicSettings(width);
            FlowDirection = flowDirection;
        }

        private void BasicSettings(int width)
        {
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximumSize = new System.Drawing.Size(width, int.MaxValue);
            MinimumSize = new System.Drawing.Size(width, 1);
            DoubleBuffered = true; // 啟用雙緩衝

            // 優化繪圖設定
            SetStyle(ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.UserPaint
                   | ControlStyles.OptimizedDoubleBuffer, true);

            //BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
