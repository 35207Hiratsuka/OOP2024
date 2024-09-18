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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RssReader {

    //調べても分からなかったコードをコメントアウトしてあります（３箇所）

    public partial class Form1 : Form {

        List<Itemdata> Items;
        List<Itemdata> bookItems;

        public Form1() {
            InitializeComponent();

            //1.URLを入力するコンボボックスのリストに、カテゴリ一覧をあらかじめ用意する方法
            //（↑このそれぞれにURLを埋め込む方法）

            //lbRssTitle.Items.Add("主要");
            //lbRssTitle.Items.Add("国内");
            //lbRssTitle.Items.Add("国際");
            //lbRssTitle.Items.Add("経済");
            //lbRssTitle.Items.Add("エンタメ");
            //lbRssTitle.Items.Add("スポーツ");
            //lbRssTitle.Items.Add("IT"); 
            //lbRssTitle.Items.Add("科学");
            //lbRssTitle.Items.Add("地域");



        }

        public class Itemdata {
            public string Title { get; set; }
            public string Link { get; set; }
        }


        //取得ボタン
        private void btGet_Click(object sender, EventArgs e) {



            //2.読み込めないURLを入力した際、それを検出するコード

            //if(cbRssUrl.Text == "" || cbRssUrl.Items.) {　　←ここの2つめ
            //    MessageBox.Show("正しいURLまたはお気に入り名称を入力してください");
            //    return;
            //}


            if(lbRssTitle.Items != null)
                lbRssTitle.Items.Clear();



            using(var wc = new WebClient()) {
                var url = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                Items = xdoc.Root.Descendants("item")
                                    .Select(item => new Itemdata {
                                        Title = item.Element("title").Value,
                                        Link = item.Element("link").Value,
                                    }).ToList();

                foreach(var item in Items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }
        
        
        


        //ニュースタイトル一覧
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            webView21.Source = new Uri(Items[lbRssTitle.SelectedIndex].Link);
            //.Navigate(Items[lbRssTitle.SelectedIndex].Link);

        }





        //ブックマーク

        private void btSet_Click(object sender, EventArgs e) {
            string inputT;

            inputT = Interaction.InputBox(
                "登録する名称を入力してください", "お気に入り登録", "ここに入力");

            if(inputT.Equals("")) {
                MessageBox.Show("お気に入り名称を入力してください");
                return;
            } else if(cbBookmark.Items.Contains(inputT)) {
                MessageBox.Show("別のお気に入り名称を入力してください");
                return;
            }

            //3.各ブックマークへのURLの埋め込み方
            //リストにしようとすると「暗黙的に変換できない」とエラーになる

            //string bookmarkLink = webView21.CoreWebView2.Source;

            //bookItems = new Itemdata { Title = inputT, Link = bookmarkLink };

            cbBookmark.Items.Add(inputT);

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

        //ブックマークコンボボックス
        private void cbBookmark_SelectedIndexChanged(object sender, EventArgs e) {
            webView21.Source = new Uri(bookItems[cbBookmark.SelectedIndex].Link);
        }



        

        
    }
}