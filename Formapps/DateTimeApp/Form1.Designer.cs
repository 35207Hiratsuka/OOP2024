namespace DateTimeApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            btDateCount = new Button();
            tbDisp = new TextBox();
            nudDay = new NumericUpDown();
            btDayBefore = new Button();
            button1 = new Button();
            btAge = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(45, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(137, 44);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(198, 39);
            dtpDate.TabIndex = 1;
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(201, 89);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(139, 54);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(45, 261);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(423, 43);
            tbDisp.TabIndex = 3;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(63, 176);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(132, 30);
            nudDay.TabIndex = 4;
            // 
            // btDayBefore
            // 
            btDayBefore.Font = new Font("Yu Gothic UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayBefore.Location = new Point(201, 149);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(75, 33);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefore_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(201, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 6;
            button1.Text = "日後";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btAge
            // 
            btAge.Font = new Font("Yu Gothic UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAge.Location = new Point(363, 112);
            btAge.Name = "btAge";
            btAge.Size = new Size(84, 53);
            btAge.TabIndex = 7;
            btAge.Text = "年齢";
            btAge.UseVisualStyleBackColor = true;
            btAge.Click += btAge_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 306);
            Controls.Add(btAge);
            Controls.Add(button1);
            Controls.Add(btDayBefore);
            Controls.Add(nudDay);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Button btDateCount;
        private TextBox tbDisp;
        private NumericUpDown nudDay;
        private Button btDayBefore;
        private Button button1;
        private Button btAge;
    }
}
