using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("数値を入力");
            var Snum = Console.ReadLine();
            int num = int.Parse(Snum);
            var Knum = num.ToString("#,0");
            Console.WriteLine(Knum);
        }
    }
}
