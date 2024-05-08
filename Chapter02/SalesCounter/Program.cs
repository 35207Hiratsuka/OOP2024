using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace SalesCounter {
    public class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            var amountPerStore = sales.GetPerStoreSales();
            foreach(var obj in amountPerStore) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
