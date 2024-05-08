﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//P75の２．２．９の上の三つ　要復習


namespace SalesCounter {
    public class SalesCounter {
        private IEnumerable<Sale> _sales;





        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }







        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(String filePath) {
            var sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);
            foreach(var line in lines) {
                var items = line.Split(',');
                var sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }


        //店舗別売上を求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new SortedDictionary<string, int>();
            foreach(var sale in _sales) {
                if(dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}
