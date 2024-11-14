using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerApp {
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application {
        static String databaseName = "Shop.db";
        static String folderPass = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static String databasePass = System.IO.Path.Combine(folderPass, databaseName);
    }
}
