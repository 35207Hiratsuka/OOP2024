using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productSample {
    //商品クラス
    public class Product {
        //商品コード
        public int code {
            get; set;   //自動実装プロパティ（P23）
        }
        //商品名
        public String Name {
            get; set;
        }
        //商品価格（税抜き）
        public int Price {
            get; set;
        }

        public Product(int code, string name, int price) {
            this.code = code;
            this.Name = name;
            this.Price = price;
        }

        //消費税額を求める（消費税率は10％）
        public int GetTax() {
            return (int)(Price * 0.10);
        }

        //税込価格を求める
        public int GetPriceInclidingTax() {
            return Price + GetTax();
        }
    }
}
