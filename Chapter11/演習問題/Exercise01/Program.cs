using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file) {

            var xdoc = XDocument.Load(file);
            foreach(var xsports in xdoc.Root.Elements()) {
                var xname = xsports.Element("name");
                var xteam = xsports.Element("teammembers");
                Console.WriteLine("{0}：{1}メンバー",xname.Value,xteam.Value);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var firstsports = xdoc.Root.Elements()
                                  .OrderBy(x => x.Element("firstplayed").Value);
            foreach(var xsports in firstsports) {
                var xkanji = xsports.Element("name").Attribute("kanji");
                var xplayed = xsports.Element("firstplayed");

                Console.WriteLine("{0}({1})" ,xkanji.Value,xplayed.Value);
            }

        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var many = xdoc.Root.Elements().Max(x => x.Element("teammembers").Value);
            Console.WriteLine(many);

        }

        private static void Exercise1_4(string file, string newfile) {
        }
    }
}
