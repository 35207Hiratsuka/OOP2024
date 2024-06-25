namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {

            var today = DateTime.Today;

            TimeSpan diff = today - dtpDate.Value;

            //tbDisp.Text = "ÅZÅZì˙ñ⁄";
            tbDisp.Text = (diff.Days + 1) + "ì˙ñ⁄";
        }

        private void btDayBefore_Click(object sender, EventArgs e) {

            var past = dtpDate.Value.AddDays(-(double)nudDay.Value);
            tbDisp.Text = past.ToString("D");
        }

        private void button1_Click(object sender, EventArgs e) {
            var future = dtpDate.Value.AddDays((double)nudDay.Value);
            tbDisp.Text = future.ToString("D");

        }

        private void btAge_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            var age = today.Year - dtpDate.Value.Year;
            if(today < dtpDate.Value.AddYears(age)) {
                age--;
            }
            tbDisp.Text = age.ToString() + "çŒ";

        }
    }
}
