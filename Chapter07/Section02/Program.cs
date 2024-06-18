using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            var we = new WordsExtractor(lines);
            foreach (var word in we.Extract()) {
                Console.WriteLine(word);
            }
        }
    }
}
