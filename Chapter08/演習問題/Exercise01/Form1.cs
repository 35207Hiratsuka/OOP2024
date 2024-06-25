using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            tbDisp.Text = now.ToString("yyyy/M/dd HH:mm") + "\r\n";

            tbDisp.Text += now.ToString("yyyy年MM月dd日 HH時mm分ss秒") + "\r\n";

            var cul = new CultureInfo("ja-JP");
            cul.DateTimeFormat.Calendar = new JapaneseCalendar();

            
            tbDisp.Text += now.ToString("ggyy年 M月dd日(" + cul.DateTimeFormat.GetDayName(now.DayOfWeek) + ")");
        }
    }
}
