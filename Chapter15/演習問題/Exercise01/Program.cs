using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine("---");
            Exercise1_3();
            Console.WriteLine("---");
            Exercise1_4();
            Console.WriteLine("---");
            Exercise1_5();
            Console.WriteLine("---");
            Exercise1_6();
            Console.WriteLine("---");
            Exercise1_7();
            Console.WriteLine("---");
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);
        }
            

        private static void Exercise1_3() {
            var query = Library.Books.GroupBy(b => b.PublishedYear)
                .Select(g => new { PublishedYear = g.Key, Count = g.Count()})
                .OrderBy(g => g.PublishedYear);

            foreach (var item in query) {
                Console.WriteLine("{0}年 {1}冊",item.PublishedYear,item.Count);
            }
        }

        private static void Exercise1_4() {
            var query = Library.Books.OrderByDescending(b => b.PublishedYear).ThenByDescending(b => b.Price)
                .Join(Library.Categories,book => book.CategoryId,Category => Category.Id,
                (book,Category) => new {
                    Title = book.Title,
                    Price = book.Price,
                    Category = Category.Name,
                PublishedYear = book.PublishedYear});


            foreach(var item in query) {
                Console.WriteLine("{0}年　{1}円　{2}({3})"
                    ,item.PublishedYear,item.Price,item.Title,item.Category);
            }

        }

        private static void Exercise1_5() {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                book => book.CategoryId,
                Category => Category.Id,
                (book,Category) => Category.Name)
                .Distinct();

            foreach (var name in names) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Categories.GroupJoin(Library.Books,
                c => c.Id,b => b.CategoryId,
                (c,books) => new {Category = c.Name,Books = books})
                .OrderBy(o => o.Category);

            foreach (var group in groups) {
                Console.WriteLine($"#" + group.Category);
                foreach(var book in group.Books) {
                    Console.WriteLine(" {0}",book.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Categories.GroupJoin(Library.Books,
                c => c.Id, b => b.CategoryId,
                (c, books) => new { Category = c.Name});

        }

        private static void Exercise1_8() {
        }
    }
}
