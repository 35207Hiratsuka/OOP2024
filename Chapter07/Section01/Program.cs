using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var location = new Dictionary<string, string>();
            Console.WriteLine("県庁所在地の登録");
            for (int i = 0; i < 5; i++) {
                Console.Write("都道府県：");
                string key = Console.ReadLine();
                Console.Write("県庁所在地：");
                string value = Console.ReadLine();

                location.Add(key, value);
            }

            foreach (var PLocation in location) 
                Console.WriteLine(PLocation.Key + "の県庁所在地は" + PLocation.Value + "です。");
            


            #region
            //var employeeDict = new Dictionary<int, Employee> {
            //   { 100, new Employee(100, "清水遼久") },
            //   { 112, new Employee(112, "芹沢洋和") },
            //   { 125, new Employee(125, "岩瀬奈央子") },
            //};

            //employeeDict.Add(126, new Employee(126, "庄野遥花"));

            //foreach(var item in employeeDict.Keys) {
            //Console.WriteLine($"{item}");
            //}
            #endregion
        }
    }
}
