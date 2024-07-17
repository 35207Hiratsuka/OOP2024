using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    internal class Settings {


        private static Settings? instance; //   自分自身のインスタンス
        
        public int MainFromColor{ get; set; }

        //コンストラクタ
        private　Settings() { }

        public static Settings getInstance() {
            if(instance == null) {
                instance = new Settings();
            }
            return instance;
        }
    }
}
