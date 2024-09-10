using Microsoft.VisualBasic;
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

    public partial class Form1 : Form {

        List<Itemdata> Items;

        public Form1() {
            InitializeComponent();
            
        }
        
        public class Itemdata {
        public string Title { get; set; }
        public string Link { get; set; }
    }

        private void btGet_Click(object sender, EventArgs e) {
            //if(tbRssUrl.Text == "" || tbRssUrl) {
            //    MessageBox.Show("正しいURLまたはお気に入り名称を入力してください");
            //    return;
           // }
            
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

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            webView21.Source = new Uri(Items[lbRssTitle.SelectedIndex].Link);
                //.Navigate(Items[lbRssTitle.SelectedIndex].Link);

        }

        private void btSet_Click(object sender, EventArgs e) {
            string inputT;

            inputT = Interaction.InputBox(
                "登録する名称を入力してください", "お気に入り登録", "ここに入力");

            if(!cbBookmark.Items.Contains(inputT) && !cbBookmark.Items.Contains(""))
                cbBookmark.Items.Add(inputT);

        }

        private void cbBookmark_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btForward_Click(object sender, EventArgs e) {
            if(webView21.CanGoForward) {
                webView21.GoForward();
            } else {
                return;
            }
        }

        private void btBack_Click(object sender, EventArgs e) {
            if(webView21.CanGoBack) {
                webView21.GoBack();
            } else {
                return;
            }
        }
    }

    
}
