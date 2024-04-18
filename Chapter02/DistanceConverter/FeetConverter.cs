using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class FeetConverter {
        //private const double ratio = 0.3848; //定数
        public static readonly double ratio = 0.3848;

        //メートルからフィードを求める
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //フィードからメートルを求める
        public static double ToMeter(double feet) {
            return feet * ratio;
        }
    }
}
