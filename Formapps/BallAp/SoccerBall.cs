using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class SoccerBall : Obj {
        public SoccerBall(double xp, double yp) 
            : base(xp,yp,@"Picture\soccer_Ball.png"){

            moveX = 10;//移動量設定
            moveY = 10;
        }

        public override bool Move() {
            PosX += moveX;
            PosY += moveY;

            return true;
        }
    }
}
