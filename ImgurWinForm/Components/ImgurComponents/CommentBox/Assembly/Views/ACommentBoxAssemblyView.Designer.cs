using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.Assembly.Views
{
    abstract partial class ACommentBoxAssemblyView
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private FlowLayoutPanel rootPanel;
        private FlowLayoutPanel sendCommentFlowLayoutPanel;
        private FlowLayoutPanel indicateCommentFlowLayoutPanel;
        private void InitializeControls()
        {
            int width = Parent.Width;

            // sendCommentFlowLayoutPanel
            sendCommentFlowLayoutPanel = new ImgurFlowLayoutPanel(width, FlowDirection.TopDown);
            sendCommentFlowLayoutPanel.Controls.Add(_sendCommentBoxView);


            // indicateCommentFlowLayoutPanel
            indicateCommentFlowLayoutPanel = new ImgurFlowLayoutPanel(width, FlowDirection.TopDown);
            indicateCommentFlowLayoutPanel.Controls.Add(_indicateCommentBoxListView);

            // rootPanel
            rootPanel = new ImgurFlowLayoutPanel(width, FlowDirection.TopDown);
            rootPanel.Controls.Add(sendCommentFlowLayoutPanel);
            rootPanel.Controls.Add(indicateCommentFlowLayoutPanel);

            // ASendCommentBoxView
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximumSize = new System.Drawing.Size(width, int.MaxValue);
            Controls.Add(rootPanel);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
    }
}
