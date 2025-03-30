using ImgurWinForm.Components.PictureBox.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinForm.Components.Test
{
    internal partial class TestComponent : UserControl, IItem<Data>
    {
        public TestComponent()
        {
            InitializeComponent();
        }

        public Task LoadItemAsync(Data itemModel)
        {
            label1.Text = itemModel.Data1;
            label2.Text = itemModel.Data2;

            return Task.CompletedTask;
        }
    }
}
