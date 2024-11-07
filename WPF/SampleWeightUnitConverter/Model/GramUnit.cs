using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //メートル単位を表すクラス
    public class GramUnit : WeightUnit {
        private static List<GramUnit> units = new List<GramUnit> {
            new GramUnit{ Name = "mm",Coefficient = 1,},
            new GramUnit{ Name = "cm",Coefficient = 10,},
            new GramUnit{ Name = "m",Coefficient = 10 * 100,},
            new GramUnit{ Name = "km",Coefficient = 10 * 100 * 1000,},
        };
        public static ICollection<GramUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromImperialUnit(PoundUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }
    }

}
