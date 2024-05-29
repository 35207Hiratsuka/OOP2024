using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            #region null合体演算子
            //string code = "12345";
            //var message = GetMessage(code) ?? DefaultMessage();
            //Console.WriteLine(message);



            #endregion

            #region null条件演算子

            //Sale sale = new Sale {
            //    Amount = 1000,
            //};

            Sale sale = null;

            //「int?」は
            int? ret = sale?.Amount;
            Console.WriteLine(ret);

            #endregion

            Console.WriteLine("整数を入力");
            string inputNum = Console.ReadLine();

            int height;
            if(int.TryParse(inputNum, out height)) {
                int num = int.Parse(inputNum);
                Console.WriteLine("整数に変換した値：" + num);
            } else {
                Console.WriteLine("変換失敗");
            }

        }

        private static object GetMessage(string code) {
        return null;
        }

        private static object DefaultMessage() {
            return "Default Message";
        }

        public class Sale {
            //店舗名
            public String ShopName {
                get; set;
            }

            //商品カテゴリ
            public String ProductCategory {
                get; set;
            }

            //売上高
            public int Amount {
                get; set;
            }
        }
    }
}
