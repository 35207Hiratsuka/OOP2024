using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Book {
        public string Title {
            get; set;
        }
        public int Price {
            get; set;
        }
        public int Pages {
            get; set;
        }
    }


    internal class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };



            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);
            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);
            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var wonderful = books.Where(b => b.Title == "ワンダフル・C#ライフ");
            foreach(var wond in wonderful) {
                Console.WriteLine("価格：" + wond.Price + "　　ページ数：" + wond.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            var count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<Book> books) {
            var average = books.Where(b => b.Title.Contains("C#"))
                               .Average(b => b.Pages);
            Console.WriteLine(average);
        }

        private static void Exercise2_4(List<Book> books) {
            var book = books.FirstOrDefault(b => b.Price >= 4000);
            if(book != null) {
                Console.WriteLine(book.Title);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            var pages = books.Where(b => b.Price < 4000)
                             .Max(b => b.Pages);
            Console.WriteLine(pages);
        }

        private static void Exercise2_6(List<Book> books) {
            var book = books.Where(b => b.Pages >= 400)
                            .OrderByDescending(b => b.Price);
            foreach(var fbook in book) {
                Console.WriteLine(fbook.Title + "," + fbook.Price + "円");
            }
        }

        private static void Exercise2_7(List<Book> books) {
            var book = books.Where(b => b.Title.Contains("C#"))
                            .Where(b => b.Pages <= 500); 
            foreach(var cbook in book) {
                Console.WriteLine(cbook.Title);
            }
        }
    }
}
