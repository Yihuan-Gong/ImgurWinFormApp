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
            
            // ������Ϥ��귽
            DisposeImage();

            // �q���e������
            this.Parent?.Controls.Remove(this);

            // ���񱱨�귽
            this.Dispose();

            // �j��U���^��
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
