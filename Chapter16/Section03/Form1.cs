using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void bt16_6_Click(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
            await Task.Run(() => DoSomething());
            toolStripStatusLabel1.Text = "終了";

        }

        private void DoSomething() {
            Thread.Sleep(1000);
        }

        private async void bt_16_7_Click(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
            var elapeed = await Task.Run(() => DoSomething2());
            toolStripStatusLabel1.Text = $"{elapeed}ミリ秒";

        }
        
        private long DoSomething2() {
            var sw = Stopwatch.StartNew();
            Thread.Sleep(5000);
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        private async void bt_16_8_Click(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
            await DoSomethingAsync();
            //DoSomething();
            toolStripStatusLabel1.Text = "終了";

        }

        private async Task DoSomethingAsync() {
            await Task.Run(() => {
                Thread.Sleep(5000);
            });
        }

        private async void bt_16_9_Click(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
            var elapeed = await DoSomethingAsync2();
            toolStripStatusLabel1.Text = $"{elapeed}ミリ秒";

        }

        private async Task<long> DoSomethingAsync2() {
            var sw = Stopwatch.StartNew();
            await Task.Run(() => {
                Thread.Sleep(5000);
            });
            
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
