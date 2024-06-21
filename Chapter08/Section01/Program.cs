using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("生年月日を入力");
            Console.Write("年：");
            var year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            var month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            var day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);

            var cul = new CultureInfo("ja-JP");
            cul.DateTimeFormat.Calendar = new JapaneseCalendar();

            Console.WriteLine();
            Console.WriteLine("あなたは、" + birthday.ToString("ggyy年M月d日",cul) +
                cul.DateTimeFormat.GetShortestDayName(birthday.DayOfWeek) + "曜日に生まれました");

            TimeSpan span = DateTime.Today - birthday;   

            Console.WriteLine("あなたは、生まれてから" + span.Days + "日です");
        }
    }
}
