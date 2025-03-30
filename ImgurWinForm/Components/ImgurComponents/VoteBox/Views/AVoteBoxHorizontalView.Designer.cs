using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Views
{
    partial class AVoteBoxHorizontalView
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


        private FlowLayoutPanel scoreLabelFlowLayoutPanel;
        private FlowLayoutPanel downLabelFlowLayoutPanel;
        private FlowLayoutPanel upLabelFlowLayoutPanel;

        private void InitializeControls()
        {
            this.upLabelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.scoreLabelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.downLabelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // upLabelFlowLayoutPanel
            // 
            this.upLabelFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.upLabelFlowLayoutPanel.Name = "upLabelFlowLayoutPanel";
            this.upLabelFlowLayoutPanel.Size = new System.Drawing.Size(25, 24);
            this.upLabelFlowLayoutPanel.TabIndex = 0;
            // 
            // scoreLabelFlowLayoutPanel
            // 
            this.scoreLabelFlowLayoutPanel.Location = new System.Drawing.Point(34, 3);
            this.scoreLabelFlowLayoutPanel.Name = "scoreLabelFlowLayoutPanel";
            this.scoreLabelFlowLayoutPanel.Size = new System.Drawing.Size(38, 24);
            this.scoreLabelFlowLayoutPanel.TabIndex = 1;
            // 
            // downLabelFlowLayoutPanel
            // 
            this.downLabelFlowLayoutPanel.Location = new System.Drawing.Point(78, 3);
            this.downLabelFlowLayoutPanel.Name = "downLabelFlowLayoutPanel";
            this.downLabelFlowLayoutPanel.Size = new System.Drawing.Size(25, 24);
            this.downLabelFlowLayoutPanel.TabIndex = 1;
            // 
            // AVoteBoxHorizontalView
            // 
            this.Controls.Add(this.downLabelFlowLayoutPanel);
            this.Controls.Add(this.scoreLabelFlowLayoutPanel);
            this.Controls.Add(this.upLabelFlowLayoutPanel);
            this.Name = "AVoteBoxHorizontalView";
            this.Size = new System.Drawing.Size(110, 31);
            this.ResumeLayout(false);


            scoreLabelFlowLayoutPanel.Controls.Add(ScoreLabel);
            upLabelFlowLayoutPanel.Controls.Add(UpLabel);
            downLabelFlowLayoutPanel.Controls.Add(DownLabel);
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
