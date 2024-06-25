namespace Exercise01 {
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
            btEx8_1 = new Button();
            tbDisp = new TextBox();
            SuspendLayout();
            // 
            // btEx8_1
            // 
            btEx8_1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btEx8_1.Location = new Point(36, 25);
            btEx8_1.Name = "btEx8_1";
            btEx8_1.Size = new Size(139, 50);
            btEx8_1.TabIndex = 0;
            btEx8_1.Text = "問題8.1";
            btEx8_1.UseVisualStyleBackColor = true;
            btEx8_1.Click += btEx8_1_Click;
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(36, 92);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(329, 110);
            tbDisp.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 385);
            Controls.Add(tbDisp);
            Controls.Add(btEx8_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEx8_1;
        private TextBox tbDisp;
    }
}
