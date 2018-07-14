using OpenTween.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTween
{
    public partial class ImageDetailBrowser : Form
    {
        private PostClass Post { get; }
        private CancellationToken CancelToken { get; }

        public ImageDetailBrowser(PostClass post, CancellationToken token)
        {
            InitializeComponent();
            this.Post = post;
            this.CancelToken = token;
        }

        public async Task InitThumbnailAsync()
        {
            try
            {
                await this.twitterFullImage1.ShowThumbnailAsync(this.Post, this.CancelToken);
                List<Size> imageSizeList = new List<Size>();
                // イメージのサイズを取得
                foreach (var picbox in this.twitterFullImage1.pictureBox)
                {
                    if (picbox.Image != null)
                    {
                        imageSizeList.Add(picbox.Image.Image.Size);
                    }
                }
                FormUtil.SetupWindow(this, imageSizeList);
            }
            catch (OperationCanceledException)
            {
                Console.Write("Load: OperationCanceledException.");
                if (!this.Disposing) this.Dispose();
            }
            catch (ObjectDisposedException)
            {
                Console.Write("Load: OperationCanceledException.");
                if (!this.Disposing) this.Dispose();
            }
        }

        private void ImageDetailBrowser_Load(object sender, EventArgs e)
        {
        }

        private void ImageDetailBrowser_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.Disposing && this != null)
            {
                if ((e.KeyCode != Keys.Up) &&
                    (e.KeyCode != Keys.Down) &&
                    (e.KeyCode != Keys.Right) &&
                    (e.KeyCode != Keys.Left) &&
                    (e.KeyCode != Keys.RWin) &&
                    (e.KeyCode != Keys.LWin))
                {
                    this.Dispose();
                }
            }
        }

        private async void ImageDetailBrowser_Shown(object sender, EventArgs e)
        {
            await InitThumbnailAsync();

            // 当たり前だが、別に非同期実行ではないので、普通にコントロールを操作する
            if(this.twitterFullImage1.pictureBox.Count > 1)
            {
                this.twitterFullImage1.scrollBar.Enabled = true;
                this.twitterFullImage1.scrollBar.Visible = true;
                this.twitterFullImage1.scrollBar.Select();
            }
        }
    }
}
