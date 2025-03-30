using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.VoteBox.Views
{
    partial class AVoteBoxVerticalView
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

        private FlowLayoutPanel downLabelFlowLayoutPanel;
        private FlowLayoutPanel scoreLabelFlowLayoutPanel;
        private FlowLayoutPanel upLabelFlowLayoutPanel;

        private void InitializeControls()
        {
            this.downLabelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.scoreLabelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upLabelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // downLabelFlowLayoutPanel
            // 
            this.downLabelFlowLayoutPanel.Location = new System.Drawing.Point(3, 63);
            this.downLabelFlowLayoutPanel.Name = "downLabelFlowLayoutPanel";
            this.downLabelFlowLayoutPanel.Size = new System.Drawing.Size(25, 24);
            this.downLabelFlowLayoutPanel.TabIndex = 4;
            // 
            // scoreLabelFlowLayoutPanel
            // 
            this.scoreLabelFlowLayoutPanel.Location = new System.Drawing.Point(3, 33);
            this.scoreLabelFlowLayoutPanel.Name = "scoreLabelFlowLayoutPanel";
            this.scoreLabelFlowLayoutPanel.Size = new System.Drawing.Size(38, 24);
            this.scoreLabelFlowLayoutPanel.TabIndex = 3;
            // 
            // upLabelFlowLayoutPanel
            // 
            this.upLabelFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.upLabelFlowLayoutPanel.Name = "upLabelFlowLayoutPanel";
            this.upLabelFlowLayoutPanel.Size = new System.Drawing.Size(25, 24);
            this.upLabelFlowLayoutPanel.TabIndex = 2;
            // 
            // AVoteBoxVerticalView
            // 
            this.Controls.Add(this.downLabelFlowLayoutPanel);
            this.Controls.Add(this.scoreLabelFlowLayoutPanel);
            this.Controls.Add(this.upLabelFlowLayoutPanel);
            this.Name = "AVoteBoxVerticalView";
            this.Size = new System.Drawing.Size(45, 91);
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
        }

        #endregion
    }
}
