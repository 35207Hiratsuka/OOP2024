using System;

namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBookmark = new System.Windows.Forms.ComboBox();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.btForward = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(588, 28);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(97, 33);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 87);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(687, 172);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 268);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1005, 460);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            // 
            // btSet
            // 
            this.btSet.Font = new System.Drawing.Font("メイリオ", 8F);
            this.btSet.Location = new System.Drawing.Point(908, 217);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(109, 42);
            this.btSet.TabIndex = 5;
            this.btSet.Text = "このページを\r\nお気に入りに登録";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "URLを入力(またはトピックスを選択)：";
            // 
            // cbBookmark
            // 
            this.cbBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBookmark.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbBookmark.FormattingEnabled = true;
            this.cbBookmark.Location = new System.Drawing.Point(717, 32);
            this.cbBookmark.Name = "cbBookmark";
            this.cbBookmark.Size = new System.Drawing.Size(259, 26);
            this.cbBookmark.TabIndex = 7;
            this.cbBookmark.Text = "お気に入り一覧";
            this.cbBookmark.SelectedIndexChanged += new System.EventHandler(this.cbBookmark_SelectedIndexChanged);
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(24, 35);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(558, 20);
            this.cbRssUrl.TabIndex = 8;
            // 
            // btForward
            // 
            this.btForward.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btForward.Location = new System.Drawing.Point(798, 229);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(75, 33);
            this.btForward.TabIndex = 9;
            this.btForward.Text = "進む";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(717, 229);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 33);
            this.btBack.TabIndex = 10;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "ニュースタイトル一覧：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 740);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.cbBookmark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSet);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btBack_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void btForward_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void cbBookmark_SelectedIndexChanged(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBookmark;
        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label2;
    }
}

