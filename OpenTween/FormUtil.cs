using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTween
{
    /// <summary>
    /// Windows Forms関連Utilクラス
    /// </summary>
    public sealed class FormUtil
    {
        // singleton
        private FormUtil() { }

        /// <summary>
        /// ウィンドウ外側(枠とタイトルバー)のサイズ
        /// </summary>
        public static readonly Size OUTER_FRAME_SIZE =
            new Size(SystemInformation.BorderSize.Width * 2,
                SystemInformation.BorderSize.Height + System.Windows.Forms.SystemInformation.CaptionHeight);


        /// <summary>
        /// formで渡されたフォームのサイズをimageSizeListの最大値の幅と高さに変更し、中央寄せします。
        /// ただし，現在表示しているディスプレイサイズをはみ出すようなウィンドウになる場合は，その分縮小します。
        /// </summary>
        /// <param name="form">フォームオブジェクト</param>
        /// <param name="imageSizeList">表示させたい画像やビデオのサイズのリスト</param>
        public static void SetupWindow(Form form, List<Size> imageSizeList)
        {
            Size rawMaxSize = form.ClientSize;   // イメージをもとに愚直にMaxサイズを計算したウィンドウサイズ
            Size realMaxSize = form.Size;   // 外枠も含めたMaxサイズ(ディスプレイサイズ超過判定に必要)
            Size defaultSize = form.Size;   // 初期状態のウィンドウサイズ(位置調整に必要)

            Size outputClientSize = rawMaxSize;
            Size outputSize = defaultSize;

            // 縦と横の最大値をそれぞれ保存
            foreach (Size imageSize in imageSizeList)
            {
                if (imageSize != null)
                {
                    if (rawMaxSize.Width < imageSize.Width) rawMaxSize.Width = imageSize.Width;
                    if (rawMaxSize.Height < imageSize.Height) rawMaxSize.Height = imageSize.Height;
                }
            }

            realMaxSize = rawMaxSize + FormUtil.OUTER_FRAME_SIZE;

            // 画像の大きさがディスプレイサイズを超えるときは縮小する
            double minimizeRate = 1.0;
            if (realMaxSize.Width > Screen.GetWorkingArea(form).Width)
            {
                minimizeRate = (double)(Screen.GetWorkingArea(form).Width - FormUtil.OUTER_FRAME_SIZE.Width) / rawMaxSize.Width;
            }
            if (realMaxSize.Height > Screen.GetWorkingArea(form).Height)
            {
                double heightMinimizeRate = (double)(Screen.GetWorkingArea(form).Height - FormUtil.OUTER_FRAME_SIZE.Height) / (rawMaxSize.Height);
                if (heightMinimizeRate < minimizeRate) minimizeRate = heightMinimizeRate;
            }
            outputClientSize = new Size((int)(rawMaxSize.Width * minimizeRate), (int)(rawMaxSize.Height * minimizeRate));
            outputSize = outputClientSize + FormUtil.OUTER_FRAME_SIZE;
            form.ClientSize = outputClientSize;

            //フォームを画面の中央に配置
            form.Left -= ((outputSize.Width - defaultSize.Width) / 2);
            form.Top -= ((outputSize.Height - defaultSize.Height) / 2);
        }
    }
}
