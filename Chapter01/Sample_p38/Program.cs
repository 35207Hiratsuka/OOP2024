﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_p38 {
    internal class Program {
        private static Student person;
        private static Student obj;

        static void Main(string[] args) {
            Employee employee = new Employee {
                Id = 100,
                Name = "山田太郎",
                Birthday = new DateTime(1992, 4, 5),
                DivisionName = "第一営業部",
            };
            Console.WriteLine("{0}({1})は、{2}に所属しています。",
                employee.Name, employee.GetAge(), employee.DivisionName);


            Student student = new Student {
                Grade = 5,
                Name = "神田　理",
                Birthday = new DateTime(2006, 11, 6),
                ClassNumber = 5,
            };
            Console.WriteLine("{0} - {1}年{2}組 {3:yyyy/m/d}生まれ",
                student.Name, student.Grade, student.ClassNumber, student.Birthday);
            if(person is Student) {
                Console.WriteLine("Person is Student");
                if(obj is Student) {
                    Console.WriteLine("obj is Student");




                }


            }
        }
    }
}
