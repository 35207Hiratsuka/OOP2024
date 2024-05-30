using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        

        private static void Exercise3_1(string text) {
            var count = text.Count(c => c == ' ');
            Console.WriteLine("文字数：" + count);
        }

        private static void Exercise3_2(string text) {
            var replace = text.Replace("big","small");
            Console.WriteLine(replace);
        }

        private static void Exercise3_3(string text) {
            String[] words = text.Split();
            Console.WriteLine("単語数：" + words.Length);
        }

        private static void Exercise3_4(string text) {

        }

        private static void Exercise3_5(string text) {

        }
    }
}
