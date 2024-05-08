using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal abstract class Obj {
        public Image? Image {get; set;}
        public double PosX {get; set;}
        public double PosY {get; set;}
        public double moveX {get; set;}
        public double moveY {get; set;}

        //コンストラクター
        public Obj(double posX,double posY,string path)
        {
            PosX = posX;
            PosY = posY;
            Image = Image.FromFile(path);
        }

        //移動用メソッド(抽象メソッド)
        public abstract bool Move();

    }
}
