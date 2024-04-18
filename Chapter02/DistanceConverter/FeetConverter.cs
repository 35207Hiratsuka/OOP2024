using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class FeetConverter {

        //メートルからフィードを求める
        static double FromMeter(double meter) {
            return meter / 0.3048;
        }

        //フィードからメートルを求める
        static double ToMeter(double feet) {
            return feet * 0.3048;
        }
    }
}
