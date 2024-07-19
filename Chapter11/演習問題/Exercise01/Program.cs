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
            var many = xdoc.Root.Elements().OrderByDescending(x => x.Element("teammembers").Value)
                                           .First();
            Console.WriteLine("{0}：{1}メンバー",many.Element("name").Value,many.Element("teammembers").Value);

        }

        private static void Exercise1_4(string file, string newfile) {
             var fin = true;
            while(fin) {
                fin = false;

                Console.WriteLine("＊スポーツ追加");
                Console.Write("競技名(カタカナ)：");
                var cName = Console.ReadLine();
                Console.Write("競技名(漢字)：");
                var cKanji = Console.ReadLine();
                Console.Write("１チームの人数：");
                var cTeam = Console.ReadLine();
                Console.Write("起源：");
                var cFirst = Console.ReadLine();
            
            
                var element = new XElement("ballsport",
                    new XElement("name", cName, 
                                 new XAttribute("kanji", cKanji)
                                 ),
                    new XElement("teammember", cTeam),
                    new XElement("firstplayed", cFirst)
                  );
                var xdoc = XDocument.Load(file);
                
                xdoc.Root.Add(element);

                Console.WriteLine("追加：1 / 保存：2");
                Console.Write("＞");
                var choice = Console.ReadLine();

                switch(choice) {
                    case "1":
                    fin = true;    
                        break;


                    case "2":
                    xdoc.Save(newfile);
                    
                        break;
                }

            }
            



            //var element = new XElement("ballsport",
            //    new XElement("name", "サッカーボール", 
            //                 new XAttribute("kanji", "蹴球")
            //                 ),
            //    new XElement("teammember", "11"),
            //    new XElement("firstplayed", "1863")
            //  );
            //var xdoc = XDocument.Load(file);
            //xdoc.Root.Add(element);

            //xdoc.Save(newfile);
        }
    }
}
