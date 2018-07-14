namespace OpenTween
{
    partial class ImageDetailBrowser
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
            this.twitterFullImage1 = new OpenTween.TwitterFullImage();
            this.SuspendLayout();
            // 
            // twitterFullImage1
            // 
            this.twitterFullImage1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.twitterFullImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twitterFullImage1.Location = new System.Drawing.Point(0, 0);
            this.twitterFullImage1.Margin = new System.Windows.Forms.Padding(2);
            this.twitterFullImage1.Name = "twitterFullImage1";
            this.twitterFullImage1.Size = new System.Drawing.Size(120, 50);
            this.twitterFullImage1.TabIndex = 1;
            this.twitterFullImage1.TabStop = false;
            // 
            // ImageDetailBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 50);
            this.Controls.Add(this.twitterFullImage1);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "ImageDetailBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "画像詳細(矢印以外のキーを押すと閉じます)";
            this.Load += new System.EventHandler(this.ImageDetailBrowser_Load);
            this.Shown += new System.EventHandler(this.ImageDetailBrowser_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageDetailBrowser_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal TwitterFullImage twitterFullImage1;
    }
}