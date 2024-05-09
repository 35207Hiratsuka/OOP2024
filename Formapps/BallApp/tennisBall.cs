using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class tennisBall : Obj {

        public static int count { get; set; }

        public tennisBall(double xp, double yp)
            : base(xp, yp, @"Picture\tennis_ball.png") {
            Random rand = new Random();
            MoveX = rand.Next(-25,25); //移動量設定
            MoveY = rand.Next(-25,25);
            
            count++;
        }

        public override bool Move() {
            if(PosX > 750 || PosX < 0) {
                //移動量の符号を反転
                MoveX = -MoveX;
            }

            if(PosY > 500 || PosY < 0) {
                //移動量の符号を反転
                MoveY = -MoveY;
            }

            PosX += MoveX;
            PosY += MoveY;

            return true;
        }
    }
} 