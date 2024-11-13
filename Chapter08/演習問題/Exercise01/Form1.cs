using Microsoft.VisualBasic;
using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            tbDisp.Text = now.ToString("yyyy/M/dd HH:mm") + "\r\n";

            tbDisp.Text += now.ToString("yyyyîNMMåéddì˙ HHéûmmï™ssïb") + "\r\n";

            var cul = new CultureInfo("ja-JP");
            cul.DateTimeFormat.Calendar = new JapaneseCalendar();


            tbDisp.Text += now.ToString("ggyyîN Måéddì˙(" + cul.DateTimeFormat.GetDayName(now.DayOfWeek) + ")");
        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            foreach(var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                NextWeek(today, (DayOfWeek)dayofweek);
                tbDisp.Text += today.ToString("yy/MM/dd") + "ÇÃéüèTÇÃ" + (DayOfWeek)dayofweek
                    + ": " + NextWeek(today, (DayOfWeek)dayofweek).ToString("yy/MM/dd") + "\r\n";
            }
        }

        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var nextweek = date.AddDays(7);
            var day = (int)dayOfWeek - (int)date.DayOfWeek;
            return nextweek.AddDays(day);
        }

        private void btEx8_3_Click(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            //TimeSpan duration = tw.Stop();
            //tbDisp.Text = "èàóùéûä‘ÇÕ" + duration.TotalMicroseconds + "É~ÉäïbÇ≈ÇµÇΩÅB";
        }
    }

    class TimeWatch() {
        private DateTime _time;

        public void Start() {
            var start = DateTime.Now;
        }

        //public TimeSpan Stop() {
            //var stop = DateTime.Now;
            //var milli = stop;
            //return milli;
        //}
    }
}
