using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class SalesCounter {
        private List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(String filePath) {
            List<Sale> sales = new List<Sale>();
            String[] lines = File.ReadAllLines(filePath);
            foreach(String line in lines) {
                String[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }


        //店舗別売上を求める
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales) {
                if(dict.ContainsKey(sale.ProductCategory))
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }
    }
}
