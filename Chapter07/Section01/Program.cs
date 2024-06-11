using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
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
            var location = new Dictionary<string, string>();
            Console.WriteLine("県庁所在地の登録");
            for(int i = 0; i < 5; i++) {
                Console.Write("都道府県：");
                string key = Console.ReadLine();
                if(key == null) { break; }
                Console.Write("県庁所在地：");
                string value = Console.ReadLine();
                if(value == null) { break; }

                if(location.ContainsKey(key)) {
                    Console.WriteLine(key + "は既に存在します。上書きしますか？");
                    Console.WriteLine("Y or N  >");
                    if(Console.ReadLine() == "Y") {
                        location[key] = value;
                    } else {
                        break;
                    }
                } else {
                    location.Add(key, value);
                }
            }
        

            do {

                Console.WriteLine("＊メニュー＊");
                Console.WriteLine("１：一覧表示");
                Console.WriteLine("２：検索");
                Console.WriteLine("３：終了");

                int choice = int.Parse(Console.ReadLine());
                //1
                if(choice == 1) {
                    foreach(var PLocation in location)
                        Console.WriteLine(PLocation.Key + "の県庁所在地は" + PLocation.Value + "です。");
                //2
                } else if(choice == 2) {
                    int ch = location.Count;
                    Console.Write("都道府県：");
                    var todo = Console.ReadLine();
                    foreach(var PLocation in location) {
                        if(PLocation.Key == todo) {
                            Console.WriteLine("県庁所在地：" + PLocation.Value);
                            break;
                        } else { ch--; }

                        if(ch == 0){
                            Console.WriteLine("該当する都道府県が見つかりません");
                        }
                    }
                //3
                } else { break; }

            } while(true);
        }
    }
}
