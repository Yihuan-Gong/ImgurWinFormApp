using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using System.Drawing;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.IndicateCommentBox.Views
{
    abstract partial class AIndicateCommentBoxView
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

        private FlowLayoutPanel authorFlowLayoutPanel;
        private FlowLayoutPanel commentIndicationFlowLayoutPanel;
        private FlowLayoutPanel sendCommentFlowLayoutPanel;
        private FlowLayoutPanel nextLayerFlowLayoutPanel;
        private FlowLayoutPanel buttonsFlowLayoutPanel;
        private FlowLayoutPanel rootPanel;
        private Label authorLabel;
        private Label commentIndicationLabel;
        private Label extendCollapseCommentLabel;
        private Button replyButton;

        private void InitializeControls()
        {
            int width = Parent?.Width ?? 500;
            //int width = 500;

            // authorFlowLayoutPanel
            authorFlowLayoutPanel = new ImgurFlowLayoutPanel(width, FlowDirection.LeftToRight);
            authorLabel = InitializeAuthorLabel();
            authorFlowLayoutPanel.Controls.Add(authorLabel);

            // commentIndicationFlowLayoutPanel
            commentIndicationFlowLayoutPanel = new ImgurFlowLayoutPanel(width);
            //commentIndicationLabel = InitializeCommentIndicationLabel();
            //commentIndicationFlowLayoutPanel.Controls.Add(commentIndicationLabel);
            commentIndicationFlowLayoutPanel.Controls.Add(_showCommmentView);


            // buttonsFlowLayoutPanel
            buttonsFlowLayoutPanel = new ImgurFlowLayoutPanel(width, FlowDirection.LeftToRight);
            extendCollapseCommentLabel = InitializeExtendCommentLabel();
            replyButton = InitializeReplyButton();
            replyButton.Click += ReplyButtonClicked;
            buttonsFlowLayoutPanel.Controls.Add(_voteBoxView);
            buttonsFlowLayoutPanel.Controls.Add(extendCollapseCommentLabel);
            buttonsFlowLayoutPanel.Controls.Add(replyButton);

            // sendCommentFlowLayoutPanel
            sendCommentFlowLayoutPanel = new ImgurFlowLayoutPanel(width);

            // nextLayerFlowLayoutPanel
            nextLayerFlowLayoutPanel = new ImgurFlowLayoutPanel(width);

            // rootPanel
            rootPanel = new ImgurFlowLayoutPanel(width, FlowDirection.TopDown);
            rootPanel.Controls.Add(commentIndicationFlowLayoutPanel);
            rootPanel.Controls.Add(buttonsFlowLayoutPanel);
            rootPanel.Controls.Add(sendCommentFlowLayoutPanel);
            rootPanel.Controls.Add(nextLayerFlowLayoutPanel);

            // AIndicateCommentBoxView
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximumSize = new System.Drawing.Size(width, int.MaxValue);
            Controls.Add(rootPanel);
        }

        protected virtual Label InitializeAuthorLabel()
        {
            return new Label();
        }

        protected virtual Label InitializeCommentIndicationLabel()
        {
            return new Label();
        }

        protected virtual Label InitializeExtendCommentLabel()
        {
            return new Label();
        }

        protected virtual Button InitializeReplyButton()
        {
            return new Button
            {
                Text = "Reply",
            };
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AIndicateCommentBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AIndicateCommentBoxView";
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}
