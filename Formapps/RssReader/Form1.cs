using Microsoft.VisualBasic;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {

    public partial class Form1 : Form {

        List<Itemdata> Items;
        List<Itemdata> bookItems = new List<Itemdata>();

        public Form1() {
            InitializeComponent();

            foreach(var category in categoryUrls.Keys) {
                cbRssUrl.Items.Add(category);
            }
        }

        public class Itemdata {
            public string Title { get; set; }
            public string Link { get; set; }
        }

        //カテゴリ一覧
        Dictionary<string, string> categoryUrls = new Dictionary<string, string> {
            { "主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
            { "国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
            { "国際", "https://news.yahoo.co.jp/rss/topics/world.xml" },
            { "経済", "https://news.yahoo.co.jp/rss/topics/business.xml" },
            { "エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
            { "スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml" },
            { "IT", "https://news.yahoo.co.jp/rss/topics/it.xml" },
            { "科学", "https://news.yahoo.co.jp/rss/topics/science.xml" },
            { "地域", "https://news.yahoo.co.jp/rss/topics/local.xml" }
        };

        //取得ボタン
        private void btGet_Click(object sender, EventArgs e) {
            if(lbRssTitle.Items != null)
                lbRssTitle.Items.Clear();
            try {
            
                string url = categoryUrls[cbRssUrl.SelectedItem.ToString()];

            
                using(var wc = new WebClient()) {
                    var stream = wc.OpenRead(url);
                    var xdoc = XDocument.Load(stream);

                    Items = xdoc.Root.Descendants("item")
                                    .Select(item => new Itemdata {
                                        Title = item.Element("title").Value,
                                        Link = item.Element("link").Value,
                                    }).ToList();
                }
            } catch(Exception ex) {
                MessageBox.Show("URLの読み込みに失敗しました: " + ex.Message);
                return;
            }

            foreach(var item in Items) {
                lbRssTitle.Items.Add(item.Title);
            }
        }

        // ニュースタイトル一覧
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            webView21.Source = new Uri(Items[lbRssTitle.SelectedIndex].Link);
        }

        //ブックマーク処理
        private void btSet_Click(object sender, EventArgs e) {
            string inputT = Interaction.InputBox(
                "登録する名称を入力してください", "お気に入り登録", "ここに入力");

            if(inputT.Equals("")) {
                MessageBox.Show("お気に入り名称を入力してください");
                return;
            } else if(cbBookmark.Items.Contains(inputT)) {
                MessageBox.Show("別のお気に入り名称を入力してください");
                return;
            }

            string bookmarkLink = webView21.CoreWebView2.Source.ToString();

            if(string.IsNullOrEmpty(bookmarkLink)) {
                MessageBox.Show("ブックマークのURLが無効です");
                return;
            }

            try {
                bookItems.Add(new Itemdata { Title = inputT, Link = bookmarkLink });
                cbBookmark.Items.Add(inputT);
            } catch(Exception ex) {
                MessageBox.Show("ブックマークの追加中にエラーが発生しました: " + ex.Message);
            }
        }

        //ブックマーク一覧
        private void cbBookmark_SelectedIndexChanged(object sender, EventArgs e) {
            webView21.Source = new Uri(bookItems[cbBookmark.SelectedIndex].Link);
        }

        //進む
        private void btForward_Click(object sender, EventArgs e) {
            if(webView21.CanGoForward) {
                webView21.GoForward();
            } else {
                return;
            }
        }

        //戻る
        private void btBack_Click(object sender, EventArgs e) {
            if(webView21.CanGoBack) {
                webView21.GoBack();
            } else {
                return;
            }

        }
    }
}
