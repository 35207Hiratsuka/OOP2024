namespace BallApp {
    public partial class Form1 : Form {
        private double posX; //X���W
        private double posY; //Y���W
        private double moveX; //�ړ��ʁiX�����j
        private double moveY; //�ړ��ʁiY�����j
        
        
        
        
        
        
        public Form1() {
            InitializeComponent();

            moveX = moveY = 5;

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }
        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            //posX >= 0 && posY >= 0 && posX <= 720 && posY <=500
            int collide;

            while (true) {
                
                
                if(posX == 720) {collide = 2;}//x-y+
                else if(posY == 500) {collide = 3;}//x-y-
                else if(posX != 0 && posY == 0) {collide = 4;}//x+y-
                else {collide = 1;}//x+y+

                if(collide == 1) {
                posX += moveX;
                posY += moveY;
            }else if(collide == 2) {
                posX -= moveX;
                posY += moveY;
            }else if(collide == 3) {
                posX -= moveX;
                posY -= moveY;
            }else if(collide == 4) {
                posX += moveX;
                posY -= moveY;
            }
}


            pbBall.Location = new Point((int)posX, (int)posY);
        }
    }
}
