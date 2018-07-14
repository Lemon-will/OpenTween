using OpenTween.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTween
{
    public partial class TwitterFullImage : TweetThumbnail
    {
        public TwitterFullImage()
        {
            InitializeComponent();
        }

        public async new Task ShowThumbnailAsync(PostClass post, CancellationToken cancelToken)
        {
            var loadTasks = new List<Task>();

            Invoke((MethodInvoker)(() => {
                this.scrollBar.Enabled = false;
                this.scrollBar.Visible = false;
            }));

            if (post.ExpandedUrls.Length == 0 && post.Media.Count == 0 && post.PostGeo == null)
            {
                this.SetThumbnailCount(0);
                return;
            }

            var thumbnails = (await this.GetThumbailInfoAsync(post, cancelToken))
                .ToArray();

            cancelToken.ThrowIfCancellationRequested();

            this.SetThumbnailCount(thumbnails.Length);
            if (thumbnails.Length == 0)
                return;

            for (int i = 0; i < thumbnails.Length; i++)
            {
                var thumb = thumbnails[i];
                var picbox = this.pictureBox[i];

                picbox.Tag = thumb;
                picbox.Dock = DockStyle.Fill;
                //picbox.ContextMenuStrip = this.ContextMenuStrip;

                //FullSizeImageUrlが使える場合は，ThumbnailUrlを置き換える
                if(thumb.FullSizeImageUrl != null)
                {
                    thumb.ThumbnailImageUrl = thumb.FullSizeImageUrl;
                }

                var loadTask = picbox.SetImageFromTask(() => thumb.LoadThumbnailImageAsync(cancelToken));
                loadTasks.Add(loadTask);

                var tooltipText = thumb.TooltipText;
                if (!string.IsNullOrEmpty(tooltipText))
                {
                    this.toolTip.SetToolTip(picbox, tooltipText);
                    picbox.AccessibleDescription = tooltipText;
                }

                cancelToken.ThrowIfCancellationRequested();
            }

            await Task.WhenAll(loadTasks);
        }

        /// <summary>
        /// 表示するサムネイルの数を設定する
        /// </summary>
        /// <param name="count">表示するサムネイルの数</param>
        public new void SetThumbnailCount(int count)
        {
            if (count == 0 && this.pictureBox.Count == 0)
                return;

            using (ControlTransaction.Layout(this.panelPictureBox, false))
            {
                this.panelPictureBox.Controls.Clear();
                foreach (var picbox in this.pictureBox)
                {
                    var memoryImage = picbox.Image;

                    picbox.MouseWheel -= this.pictureBox_MouseWheel;
                    picbox.DoubleClick -= this.pictureBox_DoubleClick;
                    picbox.Dispose();

                    memoryImage?.Dispose();

                    // メモリリーク対策 (http://stackoverflow.com/questions/2792427#2793714)
                    picbox.ContextMenuStrip = null;
                }
                this.pictureBox.Clear();

                this.scrollBar.Maximum = (count > 0) ? count - 1 : 0;
                this.scrollBar.Value = 0;

                for (int i = 0; i < count; i++)
                {
                    var picbox = CreatePictureBox("pictureBox" + i);
                    picbox.Visible = (i == 0);
                    picbox.MouseWheel += this.pictureBox_MouseWheel;
                    picbox.DoubleClick += this.pictureBox_DoubleClick;

                    picbox.Dock = DockStyle.Fill;
                    picbox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                    this.panelPictureBox.Controls.Add(picbox);
                    this.pictureBox.Add(picbox);
                }
            }
        }
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);
            OTBaseForm.ScaleChildControl(this.scrollBar, factor);
        }
    }
}
