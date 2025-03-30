using MVPExtension;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgurWinForm.Components.ImgurComponents.CommentBox.PictureComment.Views
{
    internal abstract partial class APictureCommentView : UserControl
    {
        public EventHandler PictureCommentClosing { get; set; }

        public APictureCommentView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
        }

        public void LoadData(string path)
        {
            commentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            commentPictureBox.Image = Image.FromFile(path);
        }

        public void Close()
        {
            PictureCommentClosing?.Invoke(null, null);
            
            // 先釋放圖片資源
            DisposeImage();

            // 從父容器移除
            this.Parent?.Controls.Remove(this);

            // 釋放控制項資源
            this.Dispose();

            // 強制垃圾回收
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void CloseLabelClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void DisposeImage()
        {
            if (commentPictureBox.Image != null)
            {
                commentPictureBox.Image.Dispose();
                commentPictureBox.Image = null;
            }
        }
    }
}
