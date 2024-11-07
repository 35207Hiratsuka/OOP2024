using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //ヤード単位を表すクラス
    public class PoundUnit : WeightUnit {
        private static List<PoundUnit> units = new List<PoundUnit> {
            new PoundUnit{ Name = "in",Coefficient = 1,},
            new PoundUnit{ Name = "ft",Coefficient = 12,},
            new PoundUnit{ Name = "yd",Coefficient = 12 * 3,},
            new PoundUnit{ Name = "ml",Coefficient = 12 * 3 * 1760,},
        };
        public static ICollection<PoundUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromMetricUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) / 25.4 / this.Coefficient;
        }
    }

}
