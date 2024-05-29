using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("文字列を入力(1)");
            var str1 = Console.ReadLine();
            Console.WriteLine("文字列を入力(2)");
            var str2 = Console.ReadLine();
            if(String.Compare(str1, str2, true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
        }
    }
}
