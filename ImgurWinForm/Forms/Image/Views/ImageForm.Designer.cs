namespace ImgurWinForm.Forms.Image.Views
{
    partial class ImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.voteBoxFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.favoriteButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.commentBoxFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // voteBoxFlowLayoutPanel
            // 
            this.voteBoxFlowLayoutPanel.Location = new System.Drawing.Point(24, 37);
            this.voteBoxFlowLayoutPanel.Name = "voteBoxFlowLayoutPanel";
            this.voteBoxFlowLayoutPanel.Size = new System.Drawing.Size(75, 179);
            this.voteBoxFlowLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 250);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(75, 66);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBoxFlowLayoutPanel
            // 
            this.pictureBoxFlowLayoutPanel.AutoScroll = true;
            this.pictureBoxFlowLayoutPanel.Location = new System.Drawing.Point(123, 37);
            this.pictureBoxFlowLayoutPanel.Name = "pictureBoxFlowLayoutPanel";
            this.pictureBoxFlowLayoutPanel.Size = new System.Drawing.Size(371, 664);
            this.pictureBoxFlowLayoutPanel.TabIndex = 2;
            // 
            // favoriteButtonFlowLayoutPanel
            // 
            this.favoriteButtonFlowLayoutPanel.Location = new System.Drawing.Point(27, 354);
            this.favoriteButtonFlowLayoutPanel.Name = "favoriteButtonFlowLayoutPanel";
            this.favoriteButtonFlowLayoutPanel.Size = new System.Drawing.Size(71, 61);
            this.favoriteButtonFlowLayoutPanel.TabIndex = 3;
            // 
            // commentBoxFlowLayoutPanel
            // 
            this.commentBoxFlowLayoutPanel.AutoScroll = true;
            this.commentBoxFlowLayoutPanel.Location = new System.Drawing.Point(522, 37);
            this.commentBoxFlowLayoutPanel.Name = "commentBoxFlowLayoutPanel";
            this.commentBoxFlowLayoutPanel.Size = new System.Drawing.Size(404, 664);
            this.commentBoxFlowLayoutPanel.TabIndex = 5;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 731);
            this.Controls.Add(this.commentBoxFlowLayoutPanel);
            this.Controls.Add(this.favoriteButtonFlowLayoutPanel);
            this.Controls.Add(this.pictureBoxFlowLayoutPanel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.voteBoxFlowLayoutPanel);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel voteBoxFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel pictureBoxFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel favoriteButtonFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel commentBoxFlowLayoutPanel;
    }
}