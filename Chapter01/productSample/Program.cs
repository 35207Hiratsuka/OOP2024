using System;

namespace productSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(235, "大福もち", 160);
            Product dorayaki = new Product(98, "どら焼き", 210);

            int price = karinto.Price;
            int taxIncluded = karinto.GetPriceInclidingTax();
            int daifukuPrice = daifuku.Price;
            int daifukuTaxIncluded = daifuku.GetPriceInclidingTax();
            int dorayakiPrice = dorayaki.Price;
            int dorayakiTaxIncluded = dorayaki.GetPriceInclidingTax();

            Console.WriteLine(karinto.Name + "の税込価格：" + taxIncluded + "円【税抜き" + price + "円】");
            Console.WriteLine(dorayaki.Name + "の消費税額：" + (dorayakiTaxIncluded - dorayakiPrice) );
            }
        }
    }
