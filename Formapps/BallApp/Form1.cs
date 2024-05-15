namespace BallApp {
    public partial class Form1 : Form {
        //Obj ball;
        //PictureBox pb;

        //Listコレクション
        private List<Obj> balls = new List<Obj>(); //ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>(); //表示用

        //Bar用
        private Bar bar;
        private PictureBox pbBar;

        //コンストラクタ
        public Form1() {
            InitializeComponent();

        }

        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            this.Text = "BallApp SoccerBall=" + SoccerBall.count + " TennisBall=" + tennisBall.count;

            bar = new Bar(340, 500);
            pbBar = new PictureBox();

            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;

        }

        private void timer1_Tick(object sender, EventArgs e) {
            //ball.Move();
            //pb.Location = new Point((int)ball.PosX, (int)ball.PosY);

            for(int i = 0; i < balls.Count; i++) {
                balls[i].Move(pbBar, pbs[i]);
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);

            }

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e) {


            PictureBox pb = new PictureBox();   //画像を表示するコントロール
            Obj ball = null;



            if(e.Button == MouseButtons.Left) {
                pb.Size = new Size(50, 50);
                ball = new SoccerBall(e.X - 25, e.Y - 25);


            } else if(e.Button == MouseButtons.Right) {
                pb.Size = new Size(25, 25);
                ball = new tennisBall(e.X - 12, e.Y - 12);
            }

            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();

            balls.Add(ball);
            pbs.Add(pb);

            this.Text = "BallApp SoccerBall=" + SoccerBall.count + " TennisBall=" + tennisBall.count;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyCode);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);


        }
    }
}

