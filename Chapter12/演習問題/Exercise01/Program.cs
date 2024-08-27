using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var employee = new Employee {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001, 5, 10)
            };
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            //シリアル化
            using(var writer = XmlWriter.Create("employee.xml", settings)) {
                var serializer = new DataContractSerializer(employee.GetType());
                serializer.WriteObject(writer, employee);
            }

            //逆シリアル化
            using(var reader = XmlReader.Create("employee.xml")) {
                var serializer = new DataContractSerializer(typeof(Employee));
                var emp = serializer.ReadObject(reader) as Employee;
                Console.WriteLine(employee);
            }
        }

        private static void Exercise1_2(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 123,
                    Name  = "出井　秀行",
                    HireDate = new DateTime(2001,5,10)
                },
                new Employee {
                    Id = 139,
                    Name  = "大橋　考仁",
                    HireDate = new DateTime(2004,12,1)
                },
            };

            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            //シリアル化
            using(var writer = XmlWriter.Create("employees.xml", settings)) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }
        }

        private static void Exercise1_3(string v) {

            using(var reader = XmlReader.Create("employees.xml")) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach(var emp in emps)
                Console.WriteLine("Id:{0}  Name:{1}  HireDate:{2}",
                                   emp.Id,emp.Name,emp.HireDate);
            }
        }

        private static void Exercise1_4(string v) {
        }
    }
}
