namespace WinFormsApp2
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox6 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button3 = new Button();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            button2 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(96, 549);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(372, 35);
            textBox6.TabIndex = 33;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 503);
            label6.Name = "label6";
            label6.Size = new Size(57, 30);
            label6.TabIndex = 32;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 71);
            label5.Name = "label5";
            label5.Size = new Size(251, 30);
            label5.TabIndex = 31;
            label5.Text = "Change the previous data";
            // 
            // button3
            // 
            button3.Location = new Point(90, 406);
            button3.Name = "button3";
            button3.Size = new Size(389, 78);
            button3.TabIndex = 30;
            button3.Text = "Confirm change the previous data";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(636, 454);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(222, 35);
            textBox5.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 454);
            label4.Name = "label4";
            label4.Size = new Size(82, 30);
            label4.TabIndex = 28;
            label4.Text = "Income";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(634, 408);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 35);
            textBox4.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 408);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 26;
            label3.Text = "Expenditure";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(505, 100);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(90, 335);
            button2.Name = "button2";
            button2.Size = new Size(403, 64);
            button2.TabIndex = 24;
            button2.Text = "Confirm income";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(286, 286);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 35);
            textBox3.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 286);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 22;
            label2.Text = "Money income";
            // 
            // button1
            // 
            button1.Location = new Point(90, 190);
            button1.Name = "button1";
            button1.Size = new Size(403, 55);
            button1.TabIndex = 21;
            button1.Text = "Confirm Expenditure";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(286, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 35);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 66);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(411, 35);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 141);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 18;
            label1.Text = "Money expenditure";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button4
            // 
            button4.Location = new Point(505, 503);
            button4.Name = "button4";
            button4.Size = new Size(355, 81);
            button4.TabIndex = 34;
            button4.Text = "Get total money";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(943, 651);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private Label label6;
        private Label label5;
        private Button button3;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Button button2;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
    }
}
