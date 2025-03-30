using ImgurWinForm.Components.ImgurComponents.Basic.FlowLayoutPanels;
using ImgurWinForm.Components.ImgurComponents.CommentBox.PictureComment.Views;
using System.Drawing;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.SendCommentBox.Views
{
    abstract partial class ASendCommentBoxView
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
        private FlowLayoutPanel writeCommentFlowLayoutPanel;
        private FlowLayoutPanel pictureCommentFlowLayoutPanel;
        private FlowLayoutPanel sendCommentFlowLayoutPanel;
        private APictureCommentView pictureCommentView;
        private TextBox writeCommentTextBox;
        private Button sendCommentButton;
        private Label pictureLabel;

        protected void InitializeControl()
        {
            int width = Parent.Width;
            //int width = 500;

            // writeCommentFlowLayoutPanel
            writeCommentFlowLayoutPanel = new ImgurFlowLayoutPanel(width);
            writeCommentTextBox = InitializeWriteCommentTextBox(width);
            writeCommentFlowLayoutPanel.Controls.Add(writeCommentTextBox);

            // pictureCommentFlowLayoutPanel
            pictureCommentFlowLayoutPanel = new ImgurFlowLayoutPanel(width);

            // sendCommentFlowLayoutPanel
            sendCommentFlowLayoutPanel = new ImgurFlowLayoutPanel(width, FlowDirection.RightToLeft);
            sendCommentButton = InitializeSendCommentButton();
            pictureLabel = InitializeUploadPictureLabel();
            sendCommentFlowLayoutPanel.Controls.Add(sendCommentButton);
            sendCommentFlowLayoutPanel.Controls.Add(pictureLabel);

            // rootPanel
            rootPanel = new ImgurFlowLayoutPanel(width, FlowDirection.TopDown);
            rootPanel.Controls.Add(writeCommentFlowLayoutPanel);
            rootPanel.Controls.Add(pictureCommentFlowLayoutPanel);
            rootPanel.Controls.Add(sendCommentFlowLayoutPanel);

            // ASendCommentBoxView
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximumSize = new Size(width, int.MaxValue);
            Controls.Add(rootPanel);
        }

        protected virtual TextBox InitializeWriteCommentTextBox(int width)
        {
            return new TextBox
            {
                Multiline = true,
                Size = new Size(width, 50),
            };
        }

        protected virtual Button InitializeSendCommentButton()
        {
            var button = new Button
            {
                Size = new Size(75, 23),
                Text = "Send",
                UseVisualStyleBackColor = true,
            };
            button.Click += SendCommentButtonClicked;
            return button;
        }

        protected virtual Label InitializeUploadPictureLabel()
        {
            var label = new Label
            {
                Text = "Upload picture"
            };
            label.Click += PictureLabelClicked;
            return label;
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
            // ASendCommentBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ASendCommentBoxView";
            this.Size = new System.Drawing.Size(272, 174);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
