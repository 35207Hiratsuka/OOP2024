namespace BallApp {
    public partial class Form1 : Form {



        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            PictureBox pb = new PictureBox();　　//画像を表示するコントロール
            pb.Size = new Size(50,50);
            SoccerBall soccerBall = new SoccerBall(0,0);

            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX,(int)soccerBall.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
        }
    }
}
